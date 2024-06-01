using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace Project
{
    class ProjectsGroups
    {
        public static void GeneratePDF(string connectionString, string query)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(@"Select gp.ProjectId, gp.GroupId, g.Created_On, gp.AssignmentDate from GroupProject gp Left Join [Group] g on g.Id = gp.GroupId where gp.AssignmentDate is not null", connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    Document document = new Document();
                    PdfWriter.GetInstance(document, new FileStream("Group Projects.pdf", FileMode.Create));
                    document.Open();
                    PdfPTable table = new PdfPTable(reader.FieldCount);
                    table.WidthPercentage = 100;
                    table.SetWidths(new float[] { 2f, 2f, 2f, 2f });


                    // Add headers to the table
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(reader.GetName(i)));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                        table.AddCell(cell);
                    }

                    // Add rows to the table
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            table.AddCell(reader[i].ToString());
                        }
                    }

                    // Add the table to the document
                    document.Add(table);

                    // Close the document and the reader
                    document.Close();
                    reader.Close();
                }
            }
        }
    }
}
