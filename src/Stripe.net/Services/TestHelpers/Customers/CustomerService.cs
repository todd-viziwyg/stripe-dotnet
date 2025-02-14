// File generated from our OpenAPI spec
namespace Stripe.TestHelpers
{
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe;

    public class CustomerService : Service<Customer>
    {
        public CustomerService()
            : base(null)
        {
        }

        public CustomerService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/test_helpers/customers";

        public virtual CustomerBalanceTransaction FundCashBalance(string id, CustomerFundCashBalanceOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<CustomerBalanceTransaction>(HttpMethod.Post, $"{this.InstanceUrl(id)}/fund_cash_balance", options, requestOptions);
        }

        public virtual Task<CustomerBalanceTransaction> FundCashBalanceAsync(string id, CustomerFundCashBalanceOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<CustomerBalanceTransaction>(HttpMethod.Post, $"{this.InstanceUrl(id)}/fund_cash_balance", options, requestOptions, cancellationToken);
        }
    }
}
