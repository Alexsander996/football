using GitHub;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace GitHub.Repository
{
    public class ViewerStorage
    {
        private Dictionary<int, Viewer> Viewers { get; } = new Dictionary<int, Viewer>();

        public void Create(Viewer viewer)
        {
            Viewers.Add(viewer.ViewerID, viewer);
        }

        public Viewer Read(int viewerID)
        {
            return Viewers[viewerID];
        }

        public Viewer Update(int viewerID, Viewer newViewer)
        {
            Viewers[viewerID] = newViewer;
            return Viewers[viewerID];
        }

        public bool Delete(int viewerID)
        {
            return Viewers.Remove(viewerID);
        }
    }
}