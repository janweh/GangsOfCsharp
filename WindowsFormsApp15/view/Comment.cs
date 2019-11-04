using System;

namespace WindowsFormsApp15.view
{
    class Comment
    {
        private string username;
        private string date;
        private string rating;
        private string text;

        public Comment(string username, DateTime date, string rating,
            string text)
        {
            this.Username = username;
            this.Date = date.Date.ToString("d");
            this.Rating = rating + "/5";
            this.Text = text;
        }

        public string Username { get => username; set => username = value; }
        public string Date { get => date; set => date = value; }
        public string Rating { get => rating; set => rating = value; }
        public string Text { get => text; set => text = value; }
    }
}
