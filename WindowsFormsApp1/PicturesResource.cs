using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class PicturesResource
    {
        class PictureEntry
        {
            public string URL { get; private set; }
            public bool isShown { get; set; }

            public PictureEntry (string url)
            {
                this.URL = url;
            }
        }
        private static List<PictureEntry> entries = new List<PictureEntry>
        {
            new PictureEntry("https://i.pinimg.com/originals/1e/7c/bd/1e7cbdc3b9e6e66ab03e1d8cb01274e9.jpg"),
            new PictureEntry("https://zebraz.ru/uploads/posts/2018-10/1539461818_ty-samaya-luchshaya.gif"),
            new PictureEntry("https://fresh-cards.ru/images/stories/virtuemart/product/avtorskaya-otkrytka-s-dnem-rozhdeniya-zhenschine.jpg"),
            new PictureEntry("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTio-cmnoExGISF7H1SqMNFZyLAe01IfYAVxjfdJqT8okhFJUHkdQ"),
            new PictureEntry("https://cdn.otkritkiok.ru/posts/big/pozdravlenie-malenkoy-devochke-s-dnem-rozhdeniya-46461-7224978.gif"),
            new PictureEntry("https://bestgif.su/_ph/16/2/809357911.gif"),
            new PictureEntry("https://www.youtube.com/watch?v=3pLcXmUJzms"),
            new PictureEntry("https://kartinki-life.ru/articles/2019/02/17/otkrytki-mercaushhie-animacionnye-blestyashhie-gif-s-dnem-rozhdeniya-rebenku-detskie-chast-3-aya-13.gif"),
            new PictureEntry("https://privetpeople.ru/_pu/4/33199145.gif"),
            new PictureEntry("https://cardsmy.com/_ph/7/2/757866501.gif"),
            new PictureEntry("https://i.pinimg.com/originals/b8/6d/bb/b86dbb460bf2c9d55f425d2ed6e715bd.gif"),
            new PictureEntry("https://thumbs.gfycat.com/GoldenCleanCygnet-size_restricted.gif"),
            new PictureEntry("https://www.youtube.com/watch?v=qHtrjuw0hqY"),
            new PictureEntry("https://sp.mycdn.me/image?id=836756679623&t=44&plc=WEB&tkn=*6z2WOnqJzJLn1LoFaw27T0ebhHk"),
            new PictureEntry("https://www.youtube.com/watch?v=3WqrNqX1lsI"),
        };

        public static string NextURL
        {
            get
            {
                var notShown = entries.First(entry => !entry.isShown);
                if (notShown != null)
                {
                    notShown.isShown = true;
                    return notShown.URL;
                }
                return "";
            }
        }
    }
}
