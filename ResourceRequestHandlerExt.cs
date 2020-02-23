using CefSharp;
using CefSharp.Handler;
using System;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace ViuDownloader
{

    public class ResourceRequestHandlerExt : ResourceRequestHandler
    {
        public static String m3u8Url, subtitleUrl, seriesTitle, episodeTitle;
        public static int episodeNum;

        protected override void OnResourceLoadComplete(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, IRequest request, IResponse response, UrlRequestStatus status, long receivedContentLength)
        {
            if (request.ResourceType == ResourceType.Xhr)
            {
                using(WebClient wc = new WebClient())
                {
                    if (request.Url.Contains("cloudfront.net/distribute_web_hk.php?ccs_product_id="))
                    {
                        using (MemoryStream stream = new MemoryStream(wc.DownloadData(request.Url)))
                        {
                            var data = Encoding.Default.GetString(stream.ToArray());
                            m3u8Url = Regex.Match(data, "\"s1080p\":\"([^\"]+)\"").Groups[1].Value.Replace("\\", "");
                        }
                    }

                    if (request.Url.Contains(@"https://www.viu.com/ott/hk/index.php?r=vod/ajax-detail"))
                    {
                        String data;
                        Regex rx = new Regex(@"\\[uU]([0-9A-Fa-f]{4})"); // replace escaped unicode sequences to unicode characters
                        int begin, end;
                        using (MemoryStream stream = new MemoryStream(wc.DownloadData(request.Url)))
                        {
                            data = Encoding.Default.GetString(stream.ToArray());
                        }
                        begin = data.IndexOf("number") + "number\":\"".Length;
                        end = data.IndexOf('"', begin);
                        episodeNum = Convert.ToInt32(data.Substring(begin, end - begin));
                        begin = data.IndexOf(':', begin) + 2;
                        end = data.IndexOf('"', begin);
                        episodeTitle = data.Substring(begin, end - begin);
                        episodeTitle = rx.Replace(episodeTitle, match => ((char)Int32.Parse(match.Value.Substring(2), NumberStyles.HexNumber)).ToString()); ;
                        begin = data.IndexOf(@"\u7e41\u9ad4\u4e2d\u6587", begin) + @"\u7e41\u9ad4\u4e2d\u6587"",""url"":""".Length;
                        end = data.IndexOf('"', begin);
                        subtitleUrl = data.Substring(begin, end - begin).Replace("\\", "");
                        begin = data.IndexOf("name", data.IndexOf("\"series\":{\"series_id\"", begin) + "\"series\":{\"series_id\"".Length) + "name\":\"".Length;
                        end = data.IndexOf('"', begin);
                        seriesTitle = data.Substring(begin, end - begin);
                        seriesTitle = rx.Replace(seriesTitle, match => ((char)Int32.Parse(match.Value.Substring(2), NumberStyles.HexNumber)).ToString());
                    }
                }
            }
            base.OnResourceLoadComplete(chromiumWebBrowser, browser, frame, request, response, status, receivedContentLength);
        }
    }

    public class MyRequestHandler : RequestHandler
    {
        protected override IResourceRequestHandler GetResourceRequestHandler(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, IRequest request, bool isNavigation, bool isDownload, string requestInitiator, ref bool disableDefaultHandling)
        {
            return new ResourceRequestHandlerExt();
        }
    }
}
