using System;


namespace A21_Ex01_Amit_312346901_Obaide_318970290
{
    public class TestURL : IURL
    {
        private readonly string r_RestaurantsTemplateUrl;

        public TestURL()
        {
            r_RestaurantsTemplateUrl = "https://www.google.com/search";
        }

        public Uri GetURL(string i_Location)
        {
            return new Uri(string.Format(r_RestaurantsTemplateUrl, i_Location));
        }
    }
}
