using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Mime;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RADIOConsole
{
    class Program
    {
        public static void ClientInformation(HttpListenerContext context)
        {
            var queryString = context.Request.QueryString;

            var items = queryString.AllKeys.SelectMany(queryString.GetValues, (k, v) => new { key = k, value = v });
            foreach (var item in items)
                Console.WriteLine("{0} {1}", item.key, item.value);
        }

        public static void Main(string[] args)
        {
            #region RADIO HTTP LISTENERS

            //if (!HttpListener.IsSupported)
            //{
            //    Console.WriteLine("Windows XP SP2 or Server 2003 is required to use the HttpListener class.");
            //    return;
            //}

            //var prefixes = new[] {"http://localhost:8000/", "http://127.0.0.1:8000/"};

            //// URI prefixes are required, 
            //// for example "http://contoso.com:8080/index/".
            //if (prefixes == null || prefixes.Length == 0)
            //    throw new ArgumentException("prefixes");

            //// Set up a listener.
            //var listener = new HttpListener();
            //foreach (string s in prefixes)
            //{
            //    listener.Prefixes.Add(s);
            //}
            //listener.Start();
            //// Specify Negotiate as the authentication scheme.
            //listener.AuthenticationSchemes = AuthenticationSchemes.Anonymous;
            //Console.WriteLine("Listening...");
            //// GetContext blocks while waiting for a request. 
            //var context = listener.GetContext();
            //var request = context.Request;
            //// Obtain a response object.
            //var response = context.Response;

            //if (request.HttpMethod == "OPTIONS")
            //{
            //    response.AddHeader("Access-Control-Allow-Origin", "x-requested-with");
            //}
            //else
            //{
            //    // Get a response stream and write the response to it.
            //    response.ContentType = "application/json";   
            //}

            //// Construct a response. 
            //ClientInformation(context);;
            //System.IO.Stream output = response.OutputStream;
            //const string str = "Some dummy data";
            //var bytes = new byte[str.Length * sizeof(char)];
            //Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            
            //output.Write(bytes, 0, bytes.Length);
            //output.Close();
            //listener.Stop();

            #endregion 
        }
    }
}
