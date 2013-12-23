using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Trustev.Api.v1_1.Behaviours;
using Trustev.Api.v1_1.Services.Transaction;
using Trustev.Api.v1_1.Helpers;
using Trustev.Api.v1_1.Models;

namespace Trustev.Api.v1_1
{
    public class Transaction
    {
        private TransactionServiceClient service;

        /// <summary>
        /// Create a new instance of the Profile class
        /// </summary>
        public Transaction()
        {
            XAuthBehaviour behaviour = new XAuthBehaviour();
            service = (TransactionServiceClient)ServiceConfigHelper.Instance.GetService(Constants.ServiceType.Transaction);
            service.Endpoint.Behaviors.Add(behaviour);
        }

        /// <summary>
        /// Add a new transaction
        /// </summary>
        public void AddTransaction(AddTransactionRequest request)
        {
            service.AddTransaction(request);
        }

        /// <summary>
        /// Update an existing transaction
        /// </summary>
        public void UpdateTransaction(UpdateTransactionRequest request, String transactionNumber)
        {
            service.UpdateTransaction(request, transactionNumber);
        }

        /// <summary>
        /// Add a BIN Number to an existing transaction
        /// </summary>
        public void AddTransactionBIN(AddTransactionBINRequest request, String transactionNumber)
        {
            service.AddTransactionBIN(request, transactionNumber);
        }

        /// <summary>
        /// Update the status of an existing transaction
        /// </summary>
        public void AddTransactionStatus(AddTransactionStatusRequest request, String transactionNumber)
        {
            service.AddTransactionStatus(request, transactionNumber);
        }

       


    }

}
