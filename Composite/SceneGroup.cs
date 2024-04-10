namespace Composite
{
    public class SceneGroup : ISceneObject
    {
        private List<ISceneObject> children = new List<ISceneObject>();

        public void Add(ISceneObject obj)
        {
            children.Add(obj);
        }
        public void Remove(ISceneObject obj)
        {
            children.Remove(obj);
        }
        public void draw()
        {
            foreach (var item in children)
            {
                item.draw();
            }
        }
    }
}
