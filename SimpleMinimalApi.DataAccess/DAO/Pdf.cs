namespace SimpleMinimalApi.DataAccess.DAO;

public class Pdf
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Content { get; set; }

    public virtual ICollection<PdfMetaTag>? PdfMetaTags { get; set; }
}
