using System.Windows.Forms;

#pragma warning disable 1587
///------------------------------------------------------------------------------
///   Namespace:      <Class CSharp_Programming_COP2360_228883_5>                              
///   Class:          <Class Program>                                   
///   Description:    <Description Assignment 5>                                  
///   Author:         <Author Matias Miranda Noriega> Date: <DateTime 04/17/2017>   
///   Notes:          <Notes>                                        
///   Revision History:                                              
///   Name:Initial  Date:04/17/2017 Description:Last Modification Date                  
///------------------------------------------------------------------------------
#pragma warning restore 1587

namespace CSharp_Programming_COP2360_228883_5
{
    public class ReadingMaterial
    {
        private string _title { get; set; }
        private string _url { get; set; }
        private string _author { get; set; }
        private string _author2 { get; set; }
        private string _publisher { get; set; }
        private string _publicationDate { get; set; }
        private string _callNumber { get; set; }
        private string _article { get; set; }
        private string _availableAt { get; set; }

        internal class Online : ReadingMaterial, IPrintable
        {
            public Online(string title, string url, ref Label label)
            {
                _title = title;
                _url = url;
                label.Text = ToString();
                label.Visible = true;
            }

            public string AvailableFrom()
            {
                return string.Format("Available From: Printable PDF");
            }

            public override string ToString()
            {
                return string.Format("Title: {0}\nURL: {1}", _title, _url);
            }
        }
        internal class Book : ReadingMaterial, IPrintable
        {
            public Book(string title, string author, string publisher, string publicationDate, string callNumber, ref Label label)
            {
                _title = title;
                _author = author;
                _publisher = publisher;
                _publicationDate = publicationDate;
                _callNumber = callNumber;
                label.Text = ToString();
                label.Visible = true;
            }

            public string AvailableFrom()
            {
                return string.Format("Available From: Bookstore");
            }

            public override string ToString()
            {
                return string.Format("Title: {0}\nAuthor: {1}\nPublisher: {2}\nPublication Date: {3}\nCall Number: {4}", _title, _author, _publisher, _publicationDate, _callNumber);
            }
        }
        internal class Magazine : ReadingMaterial, IPrintable
        {
            public Magazine(string title, string author, string publisher, string publicationDate, string article, string author2, string availableAt, ref Label label)
            {
                _title = title;
                _author = author;
                _publisher = publisher;
                _publicationDate = publicationDate;
                _article = article;
                _author2 = author2;
                _availableAt = availableAt;
                label.Text = ToString();
                label.Visible = true;
            }

            public string AvailableFrom()
            {
                return string.Format("Available From: Publisher");
            }

            public override string ToString()
            {
                return string.Format("Title: {0}\nAuthor: {1}\nPublisher: {2}\nPublication Date: {3}\nArticle: {4}\nAuthor: {5}\nAvailable at {6}", _title, _author, _publisher, _publicationDate, _article, _author2, _availableAt);
            }
        }
    }
}
