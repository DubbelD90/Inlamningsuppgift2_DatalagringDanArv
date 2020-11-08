using DataAccess.Data;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace DataAccess.Models
{
    public class Issue
    {
        public Issue()
        {

        }
        public Issue(long id, long customerId, string titel, string category, string description, string status, DateTime created)
        {
            Id = id;
            CustomerId = customerId;
            Titel = titel;
            Category = category;
            Description = description;
            Status = status;
            Created = created;
        }

        public long Id { get; set; }
        public long CustomerId { get; set; }
        public string Titel { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public DateTime Created { get; set; }

        public Customer customer { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
    /*
    public class IssueViewModel
    {
        public ObservableCollection<Issue> Cases { get; set; }

        public IssueViewModel()
        {
            using (var db = new SqliteConnection($"Filename={Path.Combine(ApplicationData.Current.LocalFolder.Path, "sqlite.db")}"))
            {
                db.Open();

                var query = "SELECT * FROM Issues";
                var cmd = new SqliteCommand(query, db);

                var result = cmd.ExecuteReader();

                if (result.HasRows)
                {
                    while (result.Read())
                    {
                        Issue issue = new Issue
                        {
                            Id = result.GetInt64(0),
                            CustomerId = result.GetInt64(1),
                            Titel = result.GetString(2),
                            Category = result.GetString(3),
                            Description = result.GetString(4),
                            Status = result.GetString(5),
                            Created = result.GetDateTime(6),
                            customer = SqliteContext.GetCustomerById((int)result.GetInt64(1)).Result,
                            Comments = SqliteContext.GetCommentsByIssueId((int)result.GetInt64(0)).Result
                        };

                        Cases.Add(issue);
                    }
                }
                db.Close();
            }
        }
    }
    */
    
}
