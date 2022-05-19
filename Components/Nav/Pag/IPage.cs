
namespace iSlavici.Controls.Nav.Pag
{
    public interface IPage
    {
        string PageIdName { get; }
        string PageTitle { get; }
        string PageDescription { get; }
        string PageGroup { get; }
        void SetPageInfo();
    }
}
