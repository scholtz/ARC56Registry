using System;
using Algorand;
using Algorand.Algod;
using Algorand.Algod.Model;
using Algorand.Algod.Model.Transactions;
using AVM.ClientGenerator;
using AVM.ClientGenerator.Core;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AVM.ClientGenerator.ABI.ARC56;
using Algorand.AVM.ClientGenerator.ABI.ARC56;

namespace Arc56.Generated.AnirudhPratapSinghYadav.Team_Bharat_SIT_Hackathon_SupplyChainAlgorand.AgriSupplyChainEscrow_1abb5092
{


    public class AgriSupplyChainEscrowProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public AgriSupplyChainEscrowProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        public class Events
        {
            public class AlertEvent
            {
                public static readonly byte[] Selector = new byte[4] { 90, 1, 69, 9 };
                public const string Signature = "Alert(string)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public string Field1 { get; set; }

                public static AlertEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new AlertEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    var indexField1 = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField1.Decode(eventData.Skip(indexField1).ToArray());
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is string vField1Value) { ret.Field1 = vField1Value; }
                    return ret;

                }

            }

        }

        ///<summary>
        ///A simple NoOp method to log an alert, as requested.
        ///</summary>
        /// <param name="message"> </param>
        public async Task LogAlert(string message, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 127, 65, 243, 54 };
            var messageAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); messageAbi.From(message);

            var result = await base.CallApp(new List<object> { abiHandle, messageAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> LogAlert_Transactions(string message, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 127, 65, 243, 54 };
            var messageAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); messageAbi.From(message);

            return await base.MakeTransactionList(new List<object> { abiHandle, messageAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Adds a new shipment to the Box Storage mapping.
        ///The default status is initialized to "In_Transit".
        ///</summary>
        /// <param name="shipment_id"> </param>
        public async Task AddShipment(string shipment_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 109, 57, 151, 117 };
            var shipment_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); shipment_idAbi.From(shipment_id);

            var result = await base.CallApp(new List<object> { abiHandle, shipment_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AddShipment_Transactions(string shipment_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 109, 57, 151, 117 };
            var shipment_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); shipment_idAbi.From(shipment_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, shipment_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Returns the current status of a shipment, or an error if not found.
        ///</summary>
        /// <param name="shipment_id"> </param>
        public async Task<string> GetShipmentStatus(string shipment_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 118, 236, 118, 170 };
            var shipment_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); shipment_idAbi.From(shipment_id);

            var result = await base.SimApp(new List<object> { abiHandle, shipment_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> GetShipmentStatus_Transactions(string shipment_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 118, 236, 118, 170 };
            var shipment_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); shipment_idAbi.From(shipment_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, shipment_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Accepts ALGO to fund the escrow for a specific shipment.
        ///</summary>
        /// <param name="shipment_id"> </param>
        /// <param name="payment"> </param>
        public async Task FundEscrow(PaymentTransaction payment, string shipment_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 86, 16, 242, 214 };
            var shipment_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); shipment_idAbi.From(shipment_id);

            var result = await base.CallApp(new List<object> { abiHandle, shipment_idAbi, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> FundEscrow_Transactions(PaymentTransaction payment, string shipment_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 86, 16, 242, 214 };
            var shipment_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); shipment_idAbi.From(shipment_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, shipment_idAbi, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Oracle (creator) reports a disaster delay. Changes status and refunds 10% to the buyer.
        ///</summary>
        /// <param name="shipment_id"> </param>
        public async Task ReportDisasterDelay(string shipment_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 134, 247, 173, 234 };
            var shipment_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); shipment_idAbi.From(shipment_id);

            var result = await base.CallApp(new List<object> { abiHandle, shipment_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ReportDisasterDelay_Transactions(string shipment_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 134, 247, 173, 234 };
            var shipment_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); shipment_idAbi.From(shipment_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, shipment_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Constructor Bare Action
        ///</summary>
        public async Task CreateApplication(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.CreateApplication)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 0, 193, 250, 21 };

            var result = await base.CallApp(new List<object> { }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateApplication_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.CreateApplication)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 0, 193, 250, 21 };

            return await base.MakeTransactionList(new List<object> { }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQWdyaVN1cHBseUNoYWluRXNjcm93IiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6ImxvZ19hbGVydCIsImRlc2MiOiJBIHNpbXBsZSBOb09wIG1ldGhvZCB0byBsb2cgYW4gYWxlcnQsIGFzIHJlcXVlc3RlZC4iLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoibWVzc2FnZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiQWxlcnQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQxIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYWRkX3NoaXBtZW50IiwiZGVzYyI6IkFkZHMgYSBuZXcgc2hpcG1lbnQgdG8gdGhlIEJveCBTdG9yYWdlIG1hcHBpbmcuXG5UaGUgZGVmYXVsdCBzdGF0dXMgaXMgaW5pdGlhbGl6ZWQgdG8gXCJJbl9UcmFuc2l0XCIuIiwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNoaXBtZW50X2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9zaGlwbWVudF9zdGF0dXMiLCJkZXNjIjoiUmV0dXJucyB0aGUgY3VycmVudCBzdGF0dXMgb2YgYSBzaGlwbWVudCwgb3IgYW4gZXJyb3IgaWYgbm90IGZvdW5kLiIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzaGlwbWVudF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZnVuZF9lc2Nyb3ciLCJkZXNjIjoiQWNjZXB0cyBBTEdPIHRvIGZ1bmQgdGhlIGVzY3JvdyBmb3IgYSBzcGVjaWZpYyBzaGlwbWVudC4iLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2hpcG1lbnRfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheW1lbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVwb3J0X2Rpc2FzdGVyX2RlbGF5IiwiZGVzYyI6Ik9yYWNsZSAoY3JlYXRvcikgcmVwb3J0cyBhIGRpc2FzdGVyIGRlbGF5LiBDaGFuZ2VzIHN0YXR1cyBhbmQgcmVmdW5kcyAxMCUgdG8gdGhlIGJ1eWVyLiIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzaGlwbWVudF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzI5OV0sImVycm9yTWVzc2FnZSI6IkRpZmZlcmVudCBidXllciBmdW5kaW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzQzXSwiZXJyb3JNZXNzYWdlIjoiT25seSBvcmFjbGUgY2FuIHJlcG9ydCBkaXNhc3RlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI1OF0sImVycm9yTWVzc2FnZSI6IlBheW1lbnQgbXVzdCBiZSB0byB0aGUgY29udHJhY3QiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNTZdLCJlcnJvck1lc3NhZ2UiOiJTaGlwbWVudCBhbHJlYWR5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE4NywyNDcsMzUyXSwiZXJyb3JNZXNzYWdlIjoiU2hpcG1lbnQgbm90IGZvdW5kIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjUyLDM1OF0sImVycm9yTWVzc2FnZSI6IlNoaXBtZW50IG5vdCBpbiB0cmFuc2l0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjk3LDQyMF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuc2hpcG1lbnRfYnV5ZXJzIGVudHJ5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMwNiw0MDYsNDQyXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5zaGlwbWVudF9mdW5kcyBlbnRyeSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTEsMTM3LDE2OSwyMTQsMzI2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTE4LDE0NCwxNzYsMjIxLDMzM10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMzhdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIHBheSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXhJREFnTWdvZ0lDQWdZbmwwWldOaWJHOWpheUFpYzJocGNHMWxiblJmSWlBaVNXNWZWSEpoYm5OcGRDSWdJbVoxYm1Selh5SWdJbUoxZVdWeVh5SUtJQ0FnSUM4dklHRm5jbWxmWlhOamNtOTNMbkI1T2pNS0lDQWdJQzh2SUdOc1lYTnpJRUZuY21sVGRYQndiSGxEYUdGcGJrVnpZM0p2ZHloQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lHSjZJRzFoYVc1ZlkzSmxZWFJsWDJGd2NFQXhOQW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBDaUFnSUNCd2RYTm9ZbmwwWlhOeklEQjROMlkwTVdZek16WWdNSGcyWkRNNU9UYzNOU0F3ZURjMlpXTTNObUZoSURCNE5UWXhNR1l5WkRZZ01IZzRObVkzWVdSbFlTQXZMeUJ0WlhSb2IyUWdJbXh2WjE5aGJHVnlkQ2h6ZEhKcGJtY3BkbTlwWkNJc0lHMWxkR2h2WkNBaVlXUmtYM05vYVhCdFpXNTBLSE4wY21sdVp5bDJiMmxrSWl3Z2JXVjBhRzlrSUNKblpYUmZjMmhwY0cxbGJuUmZjM1JoZEhWektITjBjbWx1WnlsemRISnBibWNpTENCdFpYUm9iMlFnSW1aMWJtUmZaWE5qY205M0tITjBjbWx1Wnl4d1lYa3BkbTlwWkNJc0lHMWxkR2h2WkNBaWNtVndiM0owWDJScGMyRnpkR1Z5WDJSbGJHRjVLSE4wY21sdVp5bDJiMmxrSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ2JHOW5YMkZzWlhKMElHRmtaRjl6YUdsd2JXVnVkQ0JuWlhSZmMyaHBjRzFsYm5SZmMzUmhkSFZ6SUdaMWJtUmZaWE5qY205M0lISmxjRzl5ZEY5a2FYTmhjM1JsY2w5a1pXeGhlUW9nSUNBZ1pYSnlDZ3B0WVdsdVgyTnlaV0YwWlY5aGNIQkFNVFE2Q2lBZ0lDQXZMeUJoWjNKcFgyVnpZM0p2ZHk1d2VUbzVDaUFnSUNBdkx5QkFZWEpqTkM1aVlYSmxiV1YwYUc5a0tHTnlaV0YwWlQwaWNtVnhkV2x5WlNJcENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ0lRb2dJQ0FnSmlZS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUdGbmNtbGZaWE5qY205M0xrRm5jbWxUZFhCd2JIbERhR0ZwYmtWelkzSnZkeTVzYjJkZllXeGxjblJiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwc2IyZGZZV3hsY25RNkNpQWdJQ0F2THlCaFozSnBYMlZ6WTNKdmR5NXdlVG94TkFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0F2THlCaFozSnBYMlZ6WTNKdmR5NXdlVG94TndvZ0lDQWdMeThnWVhKak5DNWxiV2wwS0NKQmJHVnlkQ0lzSUcxbGMzTmhaMlVwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGcxWVRBeE5EVXdPVEF3TURJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0F2THlCaFozSnBYMlZ6WTNKdmR5NXdlVG94TkFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z1lXZHlhVjlsYzJOeWIzY3VRV2R5YVZOMWNIQnNlVU5vWVdsdVJYTmpjbTkzTG1Ga1pGOXphR2x3YldWdWRGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbUZrWkY5emFHbHdiV1Z1ZERvS0lDQWdJQzh2SUdGbmNtbGZaWE5qY205M0xuQjVPakU1Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTWlBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQXZMeUJoWjNKcFgyVnpZM0p2ZHk1d2VUb3lOUW9nSUNBZ0x5OGdZWE56WlhKMElITm9hWEJ0Wlc1MFgybGtJRzV2ZENCcGJpQnpaV3htTG5Ob2FYQnRaVzUwY3l3Z0lsTm9hWEJ0Wlc1MElHRnNjbVZoWkhrZ1pYaHBjM1J6SWdvZ0lDQWdZbmwwWldOZk1DQXZMeUFpYzJocGNHMWxiblJmSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUZOb2FYQnRaVzUwSUdGc2NtVmhaSGtnWlhocGMzUnpDaUFnSUNBdkx5QmhaM0pwWDJWelkzSnZkeTV3ZVRveU5nb2dJQ0FnTHk4Z2MyVnNaaTV6YUdsd2JXVnVkSE5iYzJocGNHMWxiblJmYVdSZElEMGdVM1J5YVc1bktDSkpibDlVY21GdWMybDBJaWtLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0pKYmw5VWNtRnVjMmwwSWdvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z1lXZHlhVjlsYzJOeWIzY3VjSGs2TVRrS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklHRm5jbWxmWlhOamNtOTNMa0ZuY21sVGRYQndiSGxEYUdGcGJrVnpZM0p2ZHk1blpYUmZjMmhwY0cxbGJuUmZjM1JoZEhWelczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0taMlYwWDNOb2FYQnRaVzUwWDNOMFlYUjFjem9LSUNBZ0lDOHZJR0ZuY21sZlpYTmpjbTkzTG5CNU9qSTRDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0F2THlCaFozSnBYMlZ6WTNKdmR5NXdlVG96TVFvZ0lDQWdMeThnWVhOelpYSjBJSE5vYVhCdFpXNTBYMmxrSUdsdUlITmxiR1l1YzJocGNHMWxiblJ6TENBaVUyaHBjRzFsYm5RZ2JtOTBJR1p2ZFc1a0lnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWMyaHBjRzFsYm5SZklnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZWE56WlhKMElDOHZJRk5vYVhCdFpXNTBJRzV2ZENCbWIzVnVaQW9nSUNBZ0x5OGdZV2R5YVY5bGMyTnliM2N1Y0hrNk16SUtJQ0FnSUM4dklISmxkSFZ5YmlCelpXeG1Mbk5vYVhCdFpXNTBjMXR6YUdsd2JXVnVkRjlwWkYwS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUhCdmNBb2dJQ0FnTHk4Z1lXZHlhVjlsYzJOeWIzY3VjSGs2TWpnS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJR0ZuY21sZlpYTmpjbTkzTGtGbmNtbFRkWEJ3YkhsRGFHRnBia1Z6WTNKdmR5NW1kVzVrWDJWelkzSnZkMXR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21aMWJtUmZaWE5qY205M09nb2dJQ0FnTHk4Z1lXZHlhVjlsYzJOeWIzY3VjSGs2TXpRS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJR1IxY0FvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRE1LSUNBZ0lHUjFjQW9nSUNBZ1ozUjRibk1nVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QndZWGtLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2RISmhibk5oWTNScGIyNGdkSGx3WlNCcGN5QndZWGtLSUNBZ0lDOHZJR0ZuY21sZlpYTmpjbTkzTG5CNU9qTTVDaUFnSUNBdkx5QmhjM05sY25RZ2MyaHBjRzFsYm5SZmFXUWdhVzRnYzJWc1ppNXphR2x3YldWdWRITXNJQ0pUYUdsd2JXVnVkQ0J1YjNRZ1ptOTFibVFpQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0p6YUdsd2JXVnVkRjhpQ2lBZ0lDQmthV2NnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lYTnpaWEowSUM4dklGTm9hWEJ0Wlc1MElHNXZkQ0JtYjNWdVpBb2dJQ0FnTHk4Z1lXZHlhVjlsYzJOeWIzY3VjSGs2TkRBS0lDQWdJQzh2SUdGemMyVnlkQ0J6Wld4bUxuTm9hWEJ0Wlc1MGMxdHphR2x3YldWdWRGOXBaRjBnUFQwZ1UzUnlhVzVuS0NKSmJsOVVjbUZ1YzJsMElpa3NJQ0pUYUdsd2JXVnVkQ0J1YjNRZ2FXNGdkSEpoYm5OcGRDSUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lIQnZjQW9nSUNBZ1lubDBaV05mTVNBdkx5QWlTVzVmVkhKaGJuTnBkQ0lLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1UyaHBjRzFsYm5RZ2JtOTBJR2x1SUhSeVlXNXphWFFLSUNBZ0lDOHZJR0ZuY21sZlpYTmpjbTkzTG5CNU9qUXhDaUFnSUNBdkx5QmhjM05sY25RZ2NHRjViV1Z1ZEM1eVpXTmxhWFpsY2lBOVBTQkhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxDQWlVR0Y1YldWdWRDQnRkWE4wSUdKbElIUnZJSFJvWlNCamIyNTBjbUZqZENJS0lDQWdJR2QwZUc1eklGSmxZMlZwZG1WeUNpQWdJQ0JuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJRWVhsdFpXNTBJRzExYzNRZ1ltVWdkRzhnZEdobElHTnZiblJ5WVdOMENpQWdJQ0F2THlCaFozSnBYMlZ6WTNKdmR5NXdlVG8wTXkwME5Bb2dJQ0FnTHk4Z0l5QlNaV052Y21RZ1luVjVaWElnWVc1a0lHWjFibVJ6SUNobWIzSWdjMmx0Y0d4cFkybDBlU3dnWVhOemRXMXBibWNnYjI1bElHSjFlV1Z5SUhCbGNpQnphR2x3YldWdWRDa0tJQ0FnSUM4dklHbG1JSE5vYVhCdFpXNTBYMmxrSUc1dmRDQnBiaUJ6Wld4bUxuTm9hWEJ0Wlc1MFgySjFlV1Z5Y3pvS0lDQWdJR0o1ZEdWalh6TWdMeThnSW1KMWVXVnlYeUlLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBekNpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lHSnVlaUJtZFc1a1gyVnpZM0p2ZDE5bGJITmxYMkp2WkhsQU13b2dJQ0FnTHk4Z1lXZHlhVjlsYzJOeWIzY3VjSGs2TkRVS0lDQWdJQzh2SUhObGJHWXVjMmhwY0cxbGJuUmZZblY1WlhKelczTm9hWEJ0Wlc1MFgybGtYU0E5SUhCaGVXMWxiblF1YzJWdVpHVnlDaUFnSUNCemQyRndDaUFnSUNCa2RYQUtJQ0FnSUdkMGVHNXpJRk5sYm1SbGNnb2dJQ0FnWkdsbklETUtJQ0FnSUhOM1lYQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJR0ZuY21sZlpYTmpjbTkzTG5CNU9qUTJDaUFnSUNBdkx5QnpaV3htTG5Ob2FYQnRaVzUwWDJaMWJtUnpXM05vYVhCdFpXNTBYMmxrWFNBOUlIQmhlVzFsYm5RdVlXMXZkVzUwQ2lBZ0lDQm5kSGh1Y3lCQmJXOTFiblFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbVoxYm1Selh5SUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEc5aUNpQWdJQ0JpYjNoZmNIVjBDZ3BtZFc1a1gyVnpZM0p2ZDE5aFpuUmxjbDlwWmw5bGJITmxRRFE2Q2lBZ0lDQXZMeUJoWjNKcFgyVnpZM0p2ZHk1d2VUb3pOQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncG1kVzVrWDJWelkzSnZkMTlsYkhObFgySnZaSGxBTXpvS0lDQWdJQzh2SUdGbmNtbGZaWE5qY205M0xuQjVPalE0Q2lBZ0lDQXZMeUJoYzNObGNuUWdjR0Y1YldWdWRDNXpaVzVrWlhJZ1BUMGdjMlZzWmk1emFHbHdiV1Z1ZEY5aWRYbGxjbk5iYzJocGNHMWxiblJmYVdSZExDQWlSR2xtWm1WeVpXNTBJR0oxZVdWeUlHWjFibVJwYm1jaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JrZFhBS0lDQWdJR2QwZUc1eklGTmxibVJsY2dvZ0lDQWdaR2xuSURNS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuTm9hWEJ0Wlc1MFgySjFlV1Z5Y3lCbGJuUnllU0JsZUdsemRITUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnUkdsbVptVnlaVzUwSUdKMWVXVnlJR1oxYm1ScGJtY0tJQ0FnSUM4dklHRm5jbWxmWlhOamNtOTNMbkI1T2pRNUNpQWdJQ0F2THlCelpXeG1Mbk5vYVhCdFpXNTBYMloxYm1SelczTm9hWEJ0Wlc1MFgybGtYU0FyUFNCd1lYbHRaVzUwTG1GdGIzVnVkQW9nSUNBZ1lubDBaV05mTWlBdkx5QWlablZ1WkhOZklnb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWMyaHBjRzFsYm5SZlpuVnVaSE1nWlc1MGNua2daWGhwYzNSekNpQWdJQ0JpZEc5cENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHZDBlRzV6SUVGdGIzVnVkQW9nSUNBZ0t3b2dJQ0FnYVhSdllnb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ1lpQm1kVzVrWDJWelkzSnZkMTloWm5SbGNsOXBabDlsYkhObFFEUUtDZ292THlCaFozSnBYMlZ6WTNKdmR5NUJaM0pwVTNWd2NHeDVRMmhoYVc1RmMyTnliM2N1Y21Wd2IzSjBYMlJwYzJGemRHVnlYMlJsYkdGNVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjbVZ3YjNKMFgyUnBjMkZ6ZEdWeVgyUmxiR0Y1T2dvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lIQjFjMmhpZVhSbGN5QWlJZ29nSUNBZ0x5OGdZV2R5YVY5bGMyTnliM2N1Y0hrNk5URUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUdSMWNBb2dJQ0FnTHk4Z1lXZHlhVjlsYzJOeWIzY3VjSGs2TlRZS0lDQWdJQzh2SUdGemMyVnlkQ0JVZUc0dWMyVnVaR1Z5SUQwOUlFZHNiMkpoYkM1amNtVmhkRzl5WDJGa1pISmxjM01zSUNKUGJteDVJRzl5WVdOc1pTQmpZVzRnY21Wd2IzSjBJR1JwYzJGemRHVnlJZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWjJ4dlltRnNJRU55WldGMGIzSkJaR1J5WlhOekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRTl1YkhrZ2IzSmhZMnhsSUdOaGJpQnlaWEJ2Y25RZ1pHbHpZWE4wWlhJS0lDQWdJQzh2SUdGbmNtbGZaWE5qY205M0xuQjVPalUzQ2lBZ0lDQXZMeUJoYzNObGNuUWdjMmhwY0cxbGJuUmZhV1FnYVc0Z2MyVnNaaTV6YUdsd2JXVnVkSE1zSUNKVGFHbHdiV1Z1ZENCdWIzUWdabTkxYm1RaUNpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKemFHbHdiV1Z1ZEY4aUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZWE56WlhKMElDOHZJRk5vYVhCdFpXNTBJRzV2ZENCbWIzVnVaQW9nSUNBZ0x5OGdZV2R5YVY5bGMyTnliM2N1Y0hrNk5UZ0tJQ0FnSUM4dklHRnpjMlZ5ZENCelpXeG1Mbk5vYVhCdFpXNTBjMXR6YUdsd2JXVnVkRjlwWkYwZ1BUMGdVM1J5YVc1bktDSkpibDlVY21GdWMybDBJaWtzSUNKVGFHbHdiV1Z1ZENCdWIzUWdhVzRnZEhKaGJuTnBkQ0lLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdjRzl3Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0pKYmw5VWNtRnVjMmwwSWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlRhR2x3YldWdWRDQnViM1FnYVc0Z2RISmhibk5wZEFvZ0lDQWdMeThnWVdkeWFWOWxjMk55YjNjdWNIazZOakFLSUNBZ0lDOHZJSE5sYkdZdWMyaHBjRzFsYm5SelczTm9hWEJ0Wlc1MFgybGtYU0E5SUZOMGNtbHVaeWdpUkdWc1lYbGxaRjlFYVhOaGMzUmxjaUlwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0pFWld4aGVXVmtYMFJwYzJGemRHVnlJZ29nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnWVdkeWFWOWxjMk55YjNjdWNIazZOakl0TmpNS0lDQWdJQzh2SUNNZ1VtVm1kVzVrSURFd0pRb2dJQ0FnTHk4Z2FXWWdjMmhwY0cxbGJuUmZhV1FnYVc0Z2MyVnNaaTV6YUdsd2JXVnVkRjltZFc1a2N5QmhibVFnYzJocGNHMWxiblJmYVdRZ2FXNGdjMlZzWmk1emFHbHdiV1Z1ZEY5aWRYbGxjbk02Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0ptZFc1a2MxOGlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JpZWlCeVpYQnZjblJmWkdsellYTjBaWEpmWkdWc1lYbGZZV1owWlhKZmFXWmZaV3h6WlVBM0NpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKaWRYbGxjbDhpQ2lBZ0lDQmthV2NnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ05Rb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmllaUJ5WlhCdmNuUmZaR2x6WVhOMFpYSmZaR1ZzWVhsZllXWjBaWEpmYVdaZlpXeHpaVUEzQ2lBZ0lDQXZMeUJoWjNKcFgyVnpZM0p2ZHk1d2VUbzJOQW9nSUNBZ0x5OGdkRzkwWVd4ZlpuVnVaSE1nUFNCelpXeG1Mbk5vYVhCdFpXNTBYMloxYm1SelczTm9hWEJ0Wlc1MFgybGtYUW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV6YUdsd2JXVnVkRjltZFc1a2N5QmxiblJ5ZVNCbGVHbHpkSE1LSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJR0ZuY21sZlpYTmpjbTkzTG5CNU9qWTFDaUFnSUNBdkx5QnlaV1oxYm1SZllXMXZkVzUwSUQwZ2RHOTBZV3hmWm5WdVpITWdMeThnVlVsdWREWTBLREV3S1NBaklERXdKUW9nSUNBZ2NIVnphR2x1ZENBeE1Bb2dJQ0FnTHdvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURRS0lDQWdJQzh2SUdGbmNtbGZaWE5qY205M0xuQjVPalkzQ2lBZ0lDQXZMeUJwWmlCeVpXWjFibVJmWVcxdmRXNTBJRDRnVlVsdWREWTBLREFwT2dvZ0lDQWdZbm9nY21Wd2IzSjBYMlJwYzJGemRHVnlYMlJsYkdGNVgyRm1kR1Z5WDJsbVgyVnNjMlZBTndvZ0lDQWdMeThnWVdkeWFWOWxjMk55YjNjdWNIazZOamdLSUNBZ0lDOHZJR0oxZVdWeUlEMGdjMlZzWmk1emFHbHdiV1Z1ZEY5aWRYbGxjbk5iYzJocGNHMWxiblJmYVdSZENpQWdJQ0JrYVdjZ013b2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVjMmhwY0cxbGJuUmZZblY1WlhKeklHVnVkSEo1SUdWNGFYTjBjd29nSUNBZ0x5OGdZV2R5YVY5bGMyTnliM2N1Y0hrNk5qa3ROek1LSUNBZ0lDOHZJR2wwZUc0dVVHRjViV1Z1ZENnS0lDQWdJQzh2SUNBZ0lDQnlaV05sYVhabGNqMWlkWGxsY2l3S0lDQWdJQzh2SUNBZ0lDQmhiVzkxYm5ROWNtVm1kVzVrWDJGdGIzVnVkQ3dLSUNBZ0lDOHZJQ0FnSUNCbVpXVTlNQW9nSUNBZ0x5OGdLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnWkdsbklETUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJiVzkxYm5RS0lDQWdJR2wwZUc1ZlptbGxiR1FnVW1WalpXbDJaWElLSUNBZ0lDOHZJR0ZuY21sZlpYTmpjbTkzTG5CNU9qWTVDaUFnSUNBdkx5QnBkSGh1TGxCaGVXMWxiblFvQ2lBZ0lDQnBiblJqWHpBZ0x5OGdjR0Y1Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNBdkx5QmhaM0pwWDJWelkzSnZkeTV3ZVRvM01nb2dJQ0FnTHk4Z1ptVmxQVEFLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ0x5OGdZV2R5YVY5bGMyTnliM2N1Y0hrNk5qa3ROek1LSUNBZ0lDOHZJR2wwZUc0dVVHRjViV1Z1ZENnS0lDQWdJQzh2SUNBZ0lDQnlaV05sYVhabGNqMWlkWGxsY2l3S0lDQWdJQzh2SUNBZ0lDQmhiVzkxYm5ROWNtVm1kVzVrWDJGdGIzVnVkQ3dLSUNBZ0lDOHZJQ0FnSUNCbVpXVTlNQW9nSUNBZ0x5OGdLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUM4dklHRm5jbWxmWlhOamNtOTNMbkI1T2pjMUxUYzJDaUFnSUNBdkx5QWpJRVJsWkhWamRDQjBhR1VnY21WbWRXNWtaV1FnWVcxdmRXNTBDaUFnSUNBdkx5QnpaV3htTG5Ob2FYQnRaVzUwWDJaMWJtUnpXM05vYVhCdFpXNTBYMmxrWFNBdFBTQnlaV1oxYm1SZllXMXZkVzUwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1emFHbHdiV1Z1ZEY5bWRXNWtjeUJsYm5SeWVTQmxlR2x6ZEhNS0lDQWdJR0owYjJrS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ0xRb2dJQ0FnYVhSdllnb2dJQ0FnWW05NFgzQjFkQW9LY21Wd2IzSjBYMlJwYzJGemRHVnlYMlJsYkdGNVgyRm1kR1Z5WDJsbVgyVnNjMlZBTnpvS0lDQWdJQzh2SUdGbmNtbGZaWE5qY205M0xuQjVPalV4Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFEQVFBQ0pnUUpjMmhwY0cxbGJuUmZDa2x1WDFSeVlXNXphWFFHWm5WdVpITmZCbUoxZVdWeVh6RWJRUUF5TVJrVVJERVlSSUlGQkg5Qjh6WUViVG1YZFFSMjdIYXFCRllROHRZRWh2ZXQ2allhQUk0RkFBa0FJd0JEQUhBQTNRQXhHUlF4R0JRUVF6WWFBVWtqV1NRSVN3RVZFa1NBQmxvQlJRa0FBa3hRc0NKRE5ob0JTU05aSkFoTEFSVVNSRmNDQUNoTVVFbTlSUUVVUkVtOFNDbS9Ja00yR2dGSkkxa2tDRXNCRlJKRVZ3SUFLRXhRU2IxRkFVUytTRWtWRmxjR0FreFFnQVFWSDN4MVRGQ3dJa00yR2dGSkkxa2tDRXNCRlJKRVZ3SUFTVEVXSWdsSlRnTkpPQkFpRWtRb1N3SlFTYjFGQVVTK1NDa1NSRGdITWdvU1JDdE1VRWxPQTcxRkFVQUFFMHhKT0FCTEEweS9PQWdxVHdKUVRCYS9Ja05NU1RnQVN3TytSQkpFS2s4Q1VFbStSQmRQQWpnSUNCYS9Rdi9pSTRBQU5ob0JTU05aSkFoTEFSVVNSRmNDQUVreEFESUpFa1FvU3dGUVNiMUZBVVJKdmtncEVrUkp2RWlBRUVSbGJHRjVaV1JmUkdsellYTjBaWEsvS2t4UVNiMUZBVUVBT2l0TEFsQkpSUVc5UlFGQkFDMUp2a1FYZ1FvS1NVVUVRUUFnU3dPK1JMRkxBMGxPQXJJSXNnY2lzaEFqc2dHelN3Rkp2a1FYVHdJSkZyOGlRdz09IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6NywicGF0Y2giOjEsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbeyJuYW1lIjoiQWxlcnQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQxIiwiZGVzYyI6bnVsbH1dfV0sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
