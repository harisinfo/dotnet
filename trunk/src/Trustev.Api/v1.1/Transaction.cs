using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Trustev.Api.v1_1.Services.Transaction;
using Trustev.Api.v1_1.Helpers;

namespace Trustev.Api.v1_1
{
    public class Transaction
    {
        public void AddTransaction(AddTransactionRequest request)
        {
            TransactionServiceClient service = (TransactionServiceClient)ServiceConfigHelper.Instance.GetService(Constants.ServiceType.Transaction);

            service.AddTransaction(request);
        }


        public void UpdateTransaction(UpdateTransactionRequest request, String transactionNumber)
        {

            TransactionServiceClient service = (TransactionServiceClient)ServiceConfigHelper.Instance.GetService(Constants.ServiceType.Transaction);

            service.UpdateTransaction(request, transactionNumber);

        }

        public void AddTransactionBIN(AddTransactionBINRequest request, String transactionNumber)
        {
            TransactionServiceClient service = (TransactionServiceClient)ServiceConfigHelper.Instance.GetService(Constants.ServiceType.Transaction);

            service.AddTransactionBIN(request, transactionNumber);
        }

        public void AddTransactionStatus(AddTransactionStatusRequest request, String transactionNumber)
        {
            TransactionServiceClient service = (TransactionServiceClient)ServiceConfigHelper.Instance.GetService(Constants.ServiceType.Transaction);

            service.AddTransactionStatus(request, transactionNumber);
        }

       


    }

}
