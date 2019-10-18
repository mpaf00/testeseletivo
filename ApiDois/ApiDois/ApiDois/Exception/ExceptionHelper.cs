namespace ApiDois.Exception
{
    using System;

    public static class ExceptionHelper
    {
        public static void DealingException(Exception exception)
        {
            NotificarPorEmail(exception);
        }

        public static void RaiseException(string message) => throw new Exception(message);

        private static void NotificarPorEmail(Exception exception)
        {
            //TODO
        }
    }
}
