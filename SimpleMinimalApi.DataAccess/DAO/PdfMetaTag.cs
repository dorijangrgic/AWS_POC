namespace SimpleMinimalApi.DataAccess.DAO;

public class PdfMetaTag
{
    public int Id { get; set; }
    public int PdfId { get; set; }
    public int MetaTagId { get; set; }

    public virtual Pdf? Pdf { get; set; }
    public virtual MetaTag? MetaTag { get; set; }
}
