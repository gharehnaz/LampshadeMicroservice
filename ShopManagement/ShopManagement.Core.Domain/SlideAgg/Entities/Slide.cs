namespace ShopManagement.Core.Domain.SlideAgg.Entities
{
    public class Slide
    {
        public string Picture { get;  set; }
        public string PictureAlt { get;  set; }
        public string PictureTitle { get;  set; }
        public string Heading { get;  set; }
        public string Title { get;  set; }
        public string Text { get;  set; }
        public string BtnText { get;  set; }
        public string Link { get;  set; }
        public bool IsRemoved { get;  set; }

        public Slide(string picture, string pictureAlt, string pictureTitle, string heading,
            string title, string text, string link, string btnText)
        {
            Picture = picture;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            Heading = heading;
            Title = title;
            Text = text;
            BtnText = btnText;
            Link = link;
            IsRemoved = false;
        }

        public void Edit(string picture, string pictureAlt, string pictureTitle, string heading,
            string title, string text, string link, string btnText)
        {
            if (!string.IsNullOrWhiteSpace(picture))
                Picture = picture;

            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            Heading = heading;
            Title = title;
            Text = text;
            BtnText = btnText;
            Link = link;
        }

        public void Remove()
        {
            IsRemoved = true;
        }

        public void Restore()
        {
            IsRemoved = false;
        }
    }
}

