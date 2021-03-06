﻿using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;
using System.Numerics;

namespace Hope.Ethereum.Unity.Tokens
{
    /// <summary>
    /// Class which mimics the ethereum ERC20 token standard and contains most functions which are active in the token standard.
    /// </summary>
    public partial class ERC20
    {
        /// <summary>
        /// Class which contains the different messages which interact/change the ERC20 token contract values on the blockchain.
        /// </summary>
        public static partial class Messages
        {
            /// <summary>
            /// Class which contains the data needed to execute the ERC20 transferFrom function.
            /// </summary>
            [Function("transferFrom", "bool")]
            public sealed class TransferFrom : FunctionMessage
            {
                /// <summary>
                /// The address transferring the ERC20 token.
                /// </summary>
                [Parameter("address", "_from", 1)]
                public string From { get; set; }

                /// <summary>
                /// The address to transfer the ERC20 token to.
                /// </summary>
                [Parameter("address", "_to", 2)]
                public string To { get; set; }

                /// <summary>
                /// The amount of the ERC20 token to send to the destination address.
                /// </summary>
                [Parameter("uint256", "_value", 3)]
                public BigInteger Value { get; set; }
            }
        }
    }
}