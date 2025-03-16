namespace System.IO
{
    internal class StreamWrite
    {
        private string v1;
        private bool v2;

        public StreamWrite(string v1, bool v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        internal void WriteLine(object p)
        {
            throw new NotImplementedException();
        }
    }
}