using System;
using System.Collections.Generic;
using System.Text;

namespace BookShop
{
    public class Book
    {
        private string title;
        private string author;
        private decimal price;

        public Book(string title, string author, decimal price)
        {
            this.Title = title;
            this.Author = author;
            this.Price = price;
        }


        public string Title
        {
            get => this.title;
            protected set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) || value.Length < 3)
                {
                    throw new ArgumentException("Title not valid!");
                }
                this.title = value;
            }

        }
        public string Author
        {
            get => this.author;
            protected set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) || char.IsDigit(value.Split(" ")[0][0]))
                {
                    throw new ArgumentException("Author not valid!");
                }
                this.author = value;
            }
        }

        public virtual decimal Price
        {
            get => this.Price;
            protected set
            {
                if (price <= 0)
                {
                    throw new ArgumentException("Price not valid!");
                }
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("Type: ")
            .AppendLine(this.GetType().Name)
            .Append("Title: ")
            .AppendLine(this.Title)
            .Append("Author: ")
            .AppendLine(this.Author)
            .Append("Price: ")
            .Append($"{this.Price:f1}")
            .AppendLine();

            return sb.ToString();
        }
    }
}
