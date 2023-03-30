namespace SimpleMinimalApi.DataAccess.DAO;

public class MetaTag
{
    public int Id { get; set; }
    public int Value { get; set; }

    public virtual ICollection<PdfMetaTag>? PdfMetaTags { get; set; }
}
