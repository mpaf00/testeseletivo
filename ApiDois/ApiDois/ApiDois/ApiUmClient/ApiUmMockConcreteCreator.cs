namespace ApiDois.ApiUmClient
{
    public class ApiUmMockConcreteCreator : ApiUmCreator
    {
        public override IApiUm FactoryMethod()
        {
            return new ApiUmMockConcrete();
        }
    }
}
