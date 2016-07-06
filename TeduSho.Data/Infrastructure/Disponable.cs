using System;

namespace TeduSho.Data.Infrastructure
{
    public class Disponable : IDisposable
    {
        protected bool isDisposed;

        ~Disponable()
        {
            Dispose(false);
        }

        private void Dispose(bool isDisposing)
        {
            if (isDisposed && isDisposing)
            {
                DisposeCore();
            }
            isDisposed = true;
        }

        protected virtual void DisposeCore()
        {
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}