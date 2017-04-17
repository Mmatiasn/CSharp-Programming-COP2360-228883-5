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
    class Presentation
    {
        public Presentation(ComboBox dropdown, ref Label dataLabel)
        {
            switch (dropdown.SelectedItem.ToString())
            {
                case "Book":
                    var title = "C# Programming";
                    var author = "Barbara Doyle";
                    var publisher = "Course Technology";
                    var publicationDate = "2012";
                    var callNumber = "12387-2349";
                    new ReadingMaterial.Book(title, author, publisher, publicationDate, callNumber, ref dataLabel);
                    break;
                case "Magazine":
                    title = "Data Grids";
                    author = "Julia Little";
                    publisher = "Onom";
                    publicationDate = "2013";
                    var article = "Technology Today";
                    var author2 = "Fredrick";
                    var availableAt = "news stand";
                    new ReadingMaterial.Magazine(title, author, publisher, publicationDate, article, author2, availableAt, ref dataLabel);
                    break;

                case "Online":
                    title = "The Cosmic Computer";
                    var url = "http://www.gutenberg.org/ebooks/20727";
                    new ReadingMaterial.Online(title, url, ref dataLabel);
                    break;
                default:
                    break;
            }
        }
    }
}
