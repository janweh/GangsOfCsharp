using System;

namespace WindowsFormsApp15.view
{
    struct Comment
    {
        private string username;
        private string date;
        private string rating;
        private string text;

        public Comment(string name, DateTime dateTime, string overall,
            string comment)
        {
            username = name;
            date = dateTime.Date.ToString("d");
            rating = overall + "/5";
            text = comment;
        }

        public string Username { get => username; set => username = value; }
        public string Date { get => date; set => date = value; }
        public string Rating { get => rating; set => rating = value; }
        public string Text { get => text; set => text = value; }
    }
}
