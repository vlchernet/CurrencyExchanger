/*
 * Created by SharpDevelop.
 * User: vche
 * Date: 11/14/2018
 * Time: 3:19 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Net;
using Newtonsoft.Json.Linq;

namespace winapp1
{
	/// <summary>
	/// Description of Utility.
	/// </summary>
	public class Utility
	{
		public Utility()
		{
		}
		public static string ReadResponse(string req) {
			HttpWebRequest  myHttpWebRequest  = (HttpWebRequest)HttpWebRequest.Create(req);
            HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
            StreamReader myStreamReader = new StreamReader(myHttpWebResponse.GetResponseStream());
            return myStreamReader.ReadToEnd();
		}
		public static string JsonParse(string json) {
			JArray content = JArray.Parse(json);
			return (string)content[0]["rate"];
		}
	}
}
