namespace WinFormsApp_OOP_Lab3.Model
{
    public interface IPersonCloneable
    {
        public object DeepClone();

        public object ShallowCopy();
    }
}
