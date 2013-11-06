using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Trustev.Api.v1_1.Behaviours;
using Trustev.Api.v1_1.Services.Transaction;
using Trustev.Api.v1_1.Helpers;

namespace Trustev.Api.v1_1
{
    public class Transaction
    {
        private TransactionServiceClient service;

        public Transaction()
        {
            XAuthBehaviour behaviour = new XAuthBehaviour();
            service = (TransactionServiceClient)ServiceConfigHelper.Instance.GetService(Constants.ServiceType.Transaction);
            service.Endpoint.Behaviors.Add(behaviour);
        }

        public void AddTransaction(AddTransactionRequest request)
        {
            service.AddTransaction(request);
        }

        public void UpdateTransaction(UpdateTransactionRequest request, String transactionNumber)
        {
            service.UpdateTransaction(request, transactionNumber);
        }

        public void AddTransactionBIN(AddTransactionBINRequest request, String transactionNumber)
        {
            service.AddTransactionBIN(request, transactionNumber);
        }

        public void AddTransactionStatus(AddTransactionStatusRequest request, String transactionNumber)
        {
            service.AddTransactionStatus(request, transactionNumber);
        }

       


    }

}
