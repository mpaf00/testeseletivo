namespace ApiDois.ApiUmClient
{
    public class ApiUmConcreteCreator : ApiUmCreator
    {
        public override IApiUm FactoryMethod()
        {
            return new ApiUmConcrete();
        }
    }
}
