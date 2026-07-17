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

namespace Arc56.Generated.allthetimeintheworld.my_project.FactChecker_09c50348
{


    public class FactCheckerProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public FactCheckerProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///Step 1: Submit text and get submission ID
        ///</summary>
        /// <param name="text"> </param>
        public async Task<ulong> SubmitTextForAnalysis(string text, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 138, 203, 216, 99 };
            var textAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); textAbi.From(text);

            var result = await base.CallApp(new List<object> { abiHandle, textAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> SubmitTextForAnalysis_Transactions(string text, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 138, 203, 216, 99 };
            var textAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); textAbi.From(text);

            return await base.MakeTransactionList(new List<object> { abiHandle, textAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Step 1a: Count potential claims by counting sentences
        ///</summary>
        /// <param name="text"> </param>
        public async Task<ulong> ExtractClaimsCount(string text, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 44, 233, 210, 20 };
            var textAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); textAbi.From(text);

            var result = await base.CallApp(new List<object> { abiHandle, textAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> ExtractClaimsCount_Transactions(string text, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 44, 233, 210, 20 };
            var textAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); textAbi.From(text);

            return await base.MakeTransactionList(new List<object> { abiHandle, textAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Generate SHA256 hash for text verification
        ///</summary>
        /// <param name="text"> </param>
        public async Task<byte[]> GetTextHash(string text, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 8, 214, 108, 50 };
            var textAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); textAbi.From(text);

            var result = await base.CallApp(new List<object> { abiHandle, textAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> GetTextHash_Transactions(string text, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 8, 214, 108, 50 };
            var textAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); textAbi.From(text);

            return await base.MakeTransactionList(new List<object> { abiHandle, textAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get total number of text submissions
        ///</summary>
        public async Task<ulong> GetTotalSubmissions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 251, 23, 133, 143 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetTotalSubmissions_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 251, 23, 133, 143 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get total claims extracted across all submissions
        ///</summary>
        public async Task<ulong> GetTotalClaims(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 67, 120, 98, 11 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetTotalClaims_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 67, 120, 98, 11 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Complete Step 1: Submit text and extract claims
        ///</summary>
        /// <param name="text"> </param>
        public async Task<string> ProcessStep1Complete(string text, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 199, 163, 147, 108 };
            var textAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); textAbi.From(text);

            var result = await base.CallApp(new List<object> { abiHandle, textAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> ProcessStep1Complete_Transactions(string text, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 199, 163, 147, 108 };
            var textAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); textAbi.From(text);

            return await base.MakeTransactionList(new List<object> { abiHandle, textAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Reset all counters for testing
        ///</summary>
        public async Task<string> ResetAllStats(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 44, 49, 28, 206 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> ResetAllStats_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 44, 49, 28, 206 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get basic contract information
        ///</summary>
        public async Task<string> GetContractInfo(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 46, 238, 187, 185 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> GetContractInfo_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 46, 238, 187, 185 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRmFjdENoZWNrZXIiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoic3VibWl0X3RleHRfZm9yX2FuYWx5c2lzIiwiZGVzYyI6IlN0ZXAgMTogU3VibWl0IHRleHQgYW5kIGdldCBzdWJtaXNzaW9uIElEIiwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRleHQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJleHRyYWN0X2NsYWltc19jb3VudCIsImRlc2MiOiJTdGVwIDFhOiBDb3VudCBwb3RlbnRpYWwgY2xhaW1zIGJ5IGNvdW50aW5nIHNlbnRlbmNlcyIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0ZXh0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3RleHRfaGFzaCIsImRlc2MiOiJHZW5lcmF0ZSBTSEEyNTYgaGFzaCBmb3IgdGV4dCB2ZXJpZmljYXRpb24iLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoidGV4dCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF90b3RhbF9zdWJtaXNzaW9ucyIsImRlc2MiOiJHZXQgdG90YWwgbnVtYmVyIG9mIHRleHQgc3VibWlzc2lvbnMiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfdG90YWxfY2xhaW1zIiwiZGVzYyI6IkdldCB0b3RhbCBjbGFpbXMgZXh0cmFjdGVkIGFjcm9zcyBhbGwgc3VibWlzc2lvbnMiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJwcm9jZXNzX3N0ZXAxX2NvbXBsZXRlIiwiZGVzYyI6IkNvbXBsZXRlIFN0ZXAgMTogU3VibWl0IHRleHQgYW5kIGV4dHJhY3QgY2xhaW1zIiwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRleHQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZXNldF9hbGxfc3RhdHMiLCJkZXNjIjoiUmVzZXQgYWxsIGNvdW50ZXJzIGZvciB0ZXN0aW5nIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X2NvbnRyYWN0X2luZm8iLCJkZXNjIjoiR2V0IGJhc2ljIGNvbnRyYWN0IGluZm9ybWF0aW9uIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjIsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsxMzcsMTk4LDIyMiwyNTIsMjY5LDI4NiwzMTYsMzM5XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIGlzIG5vdCBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzY3XSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQwLDIwMSwyMjUsMjU1LDI3MiwyODksMzE5LDM0Ml0sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBub3QgY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MzYsNDY0XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi50b3RhbF9jbGFpbXNfZXh0cmFjdGVkIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM3Niw0NTldLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnRvdGFsX3N1Ym1pc3Npb25zIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11Wm1GamRGOWphR1ZqYTJWeUxtTnZiblJ5WVdOMExrWmhZM1JEYUdWamEyVnlMbDlmWVd4bmIzQjVYMlZ1ZEhKNWNHOXBiblJmZDJsMGFGOXBibWwwS0NrZ0xUNGdkV2x1ZERZME9ncHRZV2x1T2dvZ0lDQWdhVzUwWTJKc2IyTnJJREVnTUFvZ0lDQWdZbmwwWldOaWJHOWpheUF3ZURFMU1XWTNZemMxSUNKMGIzUmhiRjl6ZFdKdGFYTnphVzl1Y3lJZ0luUnZkR0ZzWDJOc1lXbHRjMTlsZUhSeVlXTjBaV1FpQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWW01NklHMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlptRmpkRjlqYUdWamEyVnlMMk52Ym5SeVlXTjBMbkI1T2pnS0lDQWdJQzh2SUhObGJHWXVkRzkwWVd4ZmMzVmliV2x6YzJsdmJuTWdQU0JIYkc5aVlXeFRkR0YwWlNoVlNXNTBOalFvTUNrcENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKMGIzUmhiRjl6ZFdKdGFYTnphVzl1Y3lJS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlpoWTNSZlkyaGxZMnRsY2k5amIyNTBjbUZqZEM1d2VUbzVDaUFnSUNBdkx5QnpaV3htTG5SdmRHRnNYMk5zWVdsdGMxOWxlSFJ5WVdOMFpXUWdQU0JIYkc5aVlXeFRkR0YwWlNoVlNXNTBOalFvTUNrcENpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKMGIzUmhiRjlqYkdGcGJYTmZaWGgwY21GamRHVmtJZ29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDZ3B0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTltWVdOMFgyTm9aV05yWlhJdlkyOXVkSEpoWTNRdWNIazZOUW9nSUNBZ0x5OGdZMnhoYzNNZ1JtRmpkRU5vWldOclpYSW9RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0JpZWlCdFlXbHVYMkpoY21WZmNtOTFkR2x1WjBBeE13b2dJQ0FnY0hWemFHSjVkR1Z6Y3lBd2VEaGhZMkprT0RZeklEQjRNbU5sT1dReU1UUWdNSGd3T0dRMk5tTXpNaUF3ZUdaaU1UYzROVGhtSURCNE5ETTNPRFl5TUdJZ01IaGpOMkV6T1RNMll5QXdlREpqTXpFeFkyTmxJREI0TW1WbFpXSmlZamtnTHk4Z2JXVjBhRzlrSUNKemRXSnRhWFJmZEdWNGRGOW1iM0pmWVc1aGJIbHphWE1vYzNSeWFXNW5LWFZwYm5RMk5DSXNJRzFsZEdodlpDQWlaWGgwY21GamRGOWpiR0ZwYlhOZlkyOTFiblFvYzNSeWFXNW5LWFZwYm5RMk5DSXNJRzFsZEdodlpDQWlaMlYwWDNSbGVIUmZhR0Z6YUNoemRISnBibWNwWW5sMFpWdGRJaXdnYldWMGFHOWtJQ0puWlhSZmRHOTBZV3hmYzNWaWJXbHpjMmx2Ym5Nb0tYVnBiblEyTkNJc0lHMWxkR2h2WkNBaVoyVjBYM1J2ZEdGc1gyTnNZV2x0Y3lncGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKd2NtOWpaWE56WDNOMFpYQXhYMk52YlhCc1pYUmxLSE4wY21sdVp5bHpkSEpwYm1jaUxDQnRaWFJvYjJRZ0luSmxjMlYwWDJGc2JGOXpkR0YwY3lncGMzUnlhVzVuSWl3Z2JXVjBhRzlrSUNKblpYUmZZMjl1ZEhKaFkzUmZhVzVtYnlncGMzUnlhVzVuSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ2JXRnBibDl6ZFdKdGFYUmZkR1Y0ZEY5bWIzSmZZVzVoYkhsemFYTmZjbTkxZEdWQU5TQnRZV2x1WDJWNGRISmhZM1JmWTJ4aGFXMXpYMk52ZFc1MFgzSnZkWFJsUURZZ2JXRnBibDluWlhSZmRHVjRkRjlvWVhOb1gzSnZkWFJsUURjZ2JXRnBibDluWlhSZmRHOTBZV3hmYzNWaWJXbHpjMmx2Ym5OZmNtOTFkR1ZBT0NCdFlXbHVYMmRsZEY5MGIzUmhiRjlqYkdGcGJYTmZjbTkxZEdWQU9TQnRZV2x1WDNCeWIyTmxjM05mYzNSbGNERmZZMjl0Y0d4bGRHVmZjbTkxZEdWQU1UQWdiV0ZwYmw5eVpYTmxkRjloYkd4ZmMzUmhkSE5mY205MWRHVkFNVEVnYldGcGJsOW5aWFJmWTI5dWRISmhZM1JmYVc1bWIxOXliM1YwWlVBeE1nb0tiV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRREUxT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlpoWTNSZlkyaGxZMnRsY2k5amIyNTBjbUZqZEM1d2VUbzFDaUFnSUNBdkx5QmpiR0Z6Y3lCR1lXTjBRMmhsWTJ0bGNpaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDluWlhSZlkyOXVkSEpoWTNSZmFXNW1iMTl5YjNWMFpVQXhNam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW1ZV04wWDJOb1pXTnJaWEl2WTI5dWRISmhZM1F1Y0hrNk5qUUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3hOVEZtTjJNM05UQXdNbUkwTmpZeE5qTTNORFF6TmpnMk5UWXpObUkyTlRjeU1qQTNOak14TW1Vek1ESXdNbVF5TURVek56UTJOVGN3TWpBek1UTmhNakEwTXpaak5qRTJPVFprTWpBME5UYzROelEzTWpZeE5qTTNORFk1Tm1ZMlpRb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDNKbGMyVjBYMkZzYkY5emRHRjBjMTl5YjNWMFpVQXhNVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW1ZV04wWDJOb1pXTnJaWEl2WTI5dWRISmhZM1F1Y0hrNk5UY0tJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNCallXeHNjM1ZpSUhKbGMyVjBYMkZzYkY5emRHRjBjd29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmNISnZZMlZ6YzE5emRHVndNVjlqYjIxd2JHVjBaVjl5YjNWMFpVQXhNRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW1ZV04wWDJOb1pXTnJaWEl2WTI5dWRISmhZM1F1Y0hrNk5UQUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlptRmpkRjlqYUdWamEyVnlMMk52Ym5SeVlXTjBMbkI1T2pVS0lDQWdJQzh2SUdOc1lYTnpJRVpoWTNSRGFHVmphMlZ5S0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJaaFkzUmZZMmhsWTJ0bGNpOWpiMjUwY21GamRDNXdlVG8xTUFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0JqWVd4c2MzVmlJSEJ5YjJObGMzTmZjM1JsY0RGZlkyOXRjR3hsZEdVS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMmRsZEY5MGIzUmhiRjlqYkdGcGJYTmZjbTkxZEdWQU9Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bVlXTjBYMk5vWldOclpYSXZZMjl1ZEhKaFkzUXVjSGs2TkRVS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0JqWVd4c2MzVmlJR2RsZEY5MGIzUmhiRjlqYkdGcGJYTUtJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZloyVjBYM1J2ZEdGc1gzTjFZbTFwYzNOcGIyNXpYM0p2ZFhSbFFEZzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlptRmpkRjlqYUdWamEyVnlMMk52Ym5SeVlXTjBMbkI1T2pRd0NpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnWTJGc2JITjFZaUJuWlhSZmRHOTBZV3hmYzNWaWJXbHpjMmx2Ym5NS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWjJWMFgzUmxlSFJmYUdGemFGOXliM1YwWlVBM09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJaaFkzUmZZMmhsWTJ0bGNpOWpiMjUwY21GamRDNXdlVG96TlFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTltWVdOMFgyTm9aV05yWlhJdlkyOXVkSEpoWTNRdWNIazZOUW9nSUNBZ0x5OGdZMnhoYzNNZ1JtRmpkRU5vWldOclpYSW9RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZabUZqZEY5amFHVmphMlZ5TDJOdmJuUnlZV04wTG5CNU9qTTFDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHTmhiR3h6ZFdJZ1oyVjBYM1JsZUhSZmFHRnphQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZlpYaDBjbUZqZEY5amJHRnBiWE5mWTI5MWJuUmZjbTkxZEdWQU5qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bVlXTjBYMk5vWldOclpYSXZZMjl1ZEhKaFkzUXVjSGs2TVRjS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Wm1GamRGOWphR1ZqYTJWeUwyTnZiblJ5WVdOMExuQjVPalVLSUNBZ0lDOHZJR05zWVhOeklFWmhZM1JEYUdWamEyVnlLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlpoWTNSZlkyaGxZMnRsY2k5amIyNTBjbUZqZEM1d2VUb3hOd29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQmpZV3hzYzNWaUlHVjRkSEpoWTNSZlkyeGhhVzF6WDJOdmRXNTBDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzTjFZbTFwZEY5MFpYaDBYMlp2Y2w5aGJtRnNlWE5wYzE5eWIzVjBaVUExT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlpoWTNSZlkyaGxZMnRsY2k5amIyNTBjbUZqZEM1d2VUb3hNUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW1ZV04wWDJOb1pXTnJaWEl2WTI5dWRISmhZM1F1Y0hrNk5Rb2dJQ0FnTHk4Z1kyeGhjM01nUm1GamRFTm9aV05yWlhJb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlptRmpkRjlqYUdWamEyVnlMMk52Ym5SeVlXTjBMbkI1T2pFeENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdOaGJHeHpkV0lnYzNWaWJXbDBYM1JsZUhSZlptOXlYMkZ1WVd4NWMybHpDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgySmhjbVZmY205MWRHbHVaMEF4TXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTltWVdOMFgyTm9aV05yWlhJdlkyOXVkSEpoWTNRdWNIazZOUW9nSUNBZ0x5OGdZMnhoYzNNZ1JtRmpkRU5vWldOclpYSW9RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUdKdWVpQnRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNVFVLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJR055WldGMGFXNW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG1aaFkzUmZZMmhsWTJ0bGNpNWpiMjUwY21GamRDNUdZV04wUTJobFkydGxjaTV6ZFdKdGFYUmZkR1Y0ZEY5bWIzSmZZVzVoYkhsemFYTW9kR1Y0ZERvZ1lubDBaWE1wSUMwK0lIVnBiblEyTkRvS2MzVmliV2wwWDNSbGVIUmZabTl5WDJGdVlXeDVjMmx6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlpoWTNSZlkyaGxZMnRsY2k5amIyNTBjbUZqZEM1d2VUb3hNUzB4TWdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0F2THlCa1pXWWdjM1ZpYldsMFgzUmxlSFJmWm05eVgyRnVZV3g1YzJsektITmxiR1lzSUhSbGVIUTZJRk4wY21sdVp5a2dMVDRnVlVsdWREWTBPZ29nSUNBZ2NISnZkRzhnTVNBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Wm1GamRGOWphR1ZqYTJWeUwyTnZiblJ5WVdOMExuQjVPakUwQ2lBZ0lDQXZMeUJ6Wld4bUxuUnZkR0ZzWDNOMVltMXBjM05wYjI1ekxuWmhiSFZsSUNzOUlERUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKMGIzUmhiRjl6ZFdKdGFYTnphVzl1Y3lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNTBiM1JoYkY5emRXSnRhWE56YVc5dWN5QmxlR2x6ZEhNS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCaWVYUmxZMTh4SUM4dklDSjBiM1JoYkY5emRXSnRhWE56YVc5dWN5SUtJQ0FnSUdScFp5QXhDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyWmhZM1JmWTJobFkydGxjaTlqYjI1MGNtRmpkQzV3ZVRveE5Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUhObGJHWXVkRzkwWVd4ZmMzVmliV2x6YzJsdmJuTXVkbUZzZFdVS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTVtWVdOMFgyTm9aV05yWlhJdVkyOXVkSEpoWTNRdVJtRmpkRU5vWldOclpYSXVaWGgwY21GamRGOWpiR0ZwYlhOZlkyOTFiblFvZEdWNGREb2dZbmwwWlhNcElDMCtJSFZwYm5RMk5Eb0taWGgwY21GamRGOWpiR0ZwYlhOZlkyOTFiblE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZabUZqZEY5amFHVmphMlZ5TDJOdmJuUnlZV04wTG5CNU9qRTNMVEU0Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJQzh2SUdSbFppQmxlSFJ5WVdOMFgyTnNZV2x0YzE5amIzVnVkQ2h6Wld4bUxDQjBaWGgwT2lCVGRISnBibWNwSUMwK0lGVkpiblEyTkRvS0lDQWdJSEJ5YjNSdklERWdNUW9nSUNBZ2NIVnphR0o1ZEdWeklDSWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlptRmpkRjlqYUdWamEyVnlMMk52Ym5SeVlXTjBMbkI1T2pJeENpQWdJQ0F2THlCd1pYSnBiMlJmWTI5MWJuUWdQU0JWU1c1ME5qUW9NQ2tLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlptRmpkRjlqYUdWamEyVnlMMk52Ym5SeVlXTjBMbkI1T2pJekxUSTBDaUFnSUNBdkx5QWpJRk5wYlhCc1pTQnNiMjl3SUhkcGRHZ2dabWw0WldRZ2JHbHRhWFFnWm05eUlHUmxiVzhLSUNBZ0lDOHZJR2tnUFNCVlNXNTBOalFvTUNrS0lDQWdJR1IxY0FvS1pYaDBjbUZqZEY5amJHRnBiWE5mWTI5MWJuUmZkMmhwYkdWZmRHOXdRREU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZabUZqZEY5amFHVmphMlZ5TDJOdmJuUnlZV04wTG5CNU9qSTFDaUFnSUNBdkx5QjNhR2xzWlNCcElEd2dWVWx1ZERZMEtERXdNQ2s2SUNBaklGQnliMk5sYzNNZ1ptbHljM1FnTVRBd0lHSjVkR1Z6SUcxaGVBb2dJQ0FnWm5KaGJXVmZaR2xuSURJS0lDQWdJSEIxYzJocGJuUWdNVEF3SUM4dklERXdNQW9nSUNBZ1BBb2dJQ0FnWW5vZ1pYaDBjbUZqZEY5amJHRnBiWE5mWTI5MWJuUmZZV1owWlhKZmQyaHBiR1ZBTlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlpoWTNSZlkyaGxZMnRsY2k5amIyNTBjbUZqZEM1d2VUb3lOZ29nSUNBZ0x5OGdZM1Z5Y21WdWRGOWllWFJsSUQwZ2IzQXVaMlYwWW5sMFpTaDBaWGgwWDJKNWRHVnpMQ0JwS1FvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNZ29nSUNBZ1oyVjBZbmwwWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlpoWTNSZlkyaGxZMnRsY2k5amIyNTBjbUZqZEM1d2VUb3lOd29nSUNBZ0x5OGdhV1lnWTNWeWNtVnVkRjlpZVhSbElEMDlJRFEyT2lBZ0l5QkJVME5KU1NCbWIzSWdKeTRuQ2lBZ0lDQndkWE5vYVc1MElEUTJJQzh2SURRMkNpQWdJQ0E5UFFvZ0lDQWdabkpoYldWZlpHbG5JREVLSUNBZ0lHWnlZVzFsWDJKMWNua2dNQW9nSUNBZ1lub2daWGgwY21GamRGOWpiR0ZwYlhOZlkyOTFiblJmWVdaMFpYSmZhV1pmWld4elpVQTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlptRmpkRjlqYUdWamEyVnlMMk52Ym5SeVlXTjBMbkI1T2pJNENpQWdJQ0F2THlCd1pYSnBiMlJmWTI5MWJuUWdLejBnTVFvZ0lDQWdabkpoYldWZlpHbG5JREVLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBckNpQWdJQ0JtY21GdFpWOWlkWEo1SURBS0NtVjRkSEpoWTNSZlkyeGhhVzF6WDJOdmRXNTBYMkZtZEdWeVgybG1YMlZzYzJWQU5Eb0tJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0JtY21GdFpWOWlkWEo1SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTltWVdOMFgyTm9aV05yWlhJdlkyOXVkSEpoWTNRdWNIazZNamtLSUNBZ0lDOHZJR2tnS3owZ01Rb2dJQ0FnWm5KaGJXVmZaR2xuSURJS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCbWNtRnRaVjlpZFhKNUlESUtJQ0FnSUdJZ1pYaDBjbUZqZEY5amJHRnBiWE5mWTI5MWJuUmZkMmhwYkdWZmRHOXdRREVLQ21WNGRISmhZM1JmWTJ4aGFXMXpYMk52ZFc1MFgyRm1kR1Z5WDNkb2FXeGxRRFU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZabUZqZEY5amFHVmphMlZ5TDJOdmJuUnlZV04wTG5CNU9qTXhMVE15Q2lBZ0lDQXZMeUFqSUZWd1pHRjBaU0JuYkc5aVlXd2dZMjkxYm5SbGNnb2dJQ0FnTHk4Z2MyVnNaaTUwYjNSaGJGOWpiR0ZwYlhOZlpYaDBjbUZqZEdWa0xuWmhiSFZsSUNzOUlIQmxjbWx2WkY5amIzVnVkQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdKNWRHVmpYeklnTHk4Z0luUnZkR0ZzWDJOc1lXbHRjMTlsZUhSeVlXTjBaV1FpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWRHOTBZV3hmWTJ4aGFXMXpYMlY0ZEhKaFkzUmxaQ0JsZUdsemRITUtJQ0FnSUdaeVlXMWxYMlJwWnlBeENpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUNzS0lDQWdJR0o1ZEdWalh6SWdMeThnSW5SdmRHRnNYMk5zWVdsdGMxOWxlSFJ5WVdOMFpXUWlDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyWmhZM1JmWTJobFkydGxjaTlqYjI1MGNtRmpkQzV3ZVRvek13b2dJQ0FnTHk4Z2NtVjBkWEp1SUhCbGNtbHZaRjlqYjNWdWRBb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBd0NpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11Wm1GamRGOWphR1ZqYTJWeUxtTnZiblJ5WVdOMExrWmhZM1JEYUdWamEyVnlMbWRsZEY5MFpYaDBYMmhoYzJnb2RHVjRkRG9nWW5sMFpYTXBJQzArSUdKNWRHVnpPZ3BuWlhSZmRHVjRkRjlvWVhOb09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJaaFkzUmZZMmhsWTJ0bGNpOWpiMjUwY21GamRDNXdlVG96TlMwek5nb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNBdkx5QmtaV1lnWjJWMFgzUmxlSFJmYUdGemFDaHpaV3htTENCMFpYaDBPaUJUZEhKcGJtY3BJQzArSUVKNWRHVnpPZ29nSUNBZ2NISnZkRzhnTVNBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Wm1GamRGOWphR1ZqYTJWeUwyTnZiblJ5WVdOMExuQjVPak00Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdiM0F1YzJoaE1qVTJLSFJsZUhRdVlubDBaWE1wQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lITm9ZVEkxTmdvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbVpoWTNSZlkyaGxZMnRsY2k1amIyNTBjbUZqZEM1R1lXTjBRMmhsWTJ0bGNpNW5aWFJmZEc5MFlXeGZjM1ZpYldsemMybHZibk1vS1NBdFBpQjFhVzUwTmpRNkNtZGxkRjkwYjNSaGJGOXpkV0p0YVhOemFXOXVjem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW1ZV04wWDJOb1pXTnJaWEl2WTI5dWRISmhZM1F1Y0hrNk5ETUtJQ0FnSUM4dklISmxkSFZ5YmlCelpXeG1MblJ2ZEdGc1gzTjFZbTFwYzNOcGIyNXpMblpoYkhWbENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpZEc5MFlXeGZjM1ZpYldsemMybHZibk1pQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWRHOTBZV3hmYzNWaWJXbHpjMmx2Ym5NZ1pYaHBjM1J6Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVabUZqZEY5amFHVmphMlZ5TG1OdmJuUnlZV04wTGtaaFkzUkRhR1ZqYTJWeUxtZGxkRjkwYjNSaGJGOWpiR0ZwYlhNb0tTQXRQaUIxYVc1ME5qUTZDbWRsZEY5MGIzUmhiRjlqYkdGcGJYTTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlptRmpkRjlqYUdWamEyVnlMMk52Ym5SeVlXTjBMbkI1T2pRNENpQWdJQ0F2THlCeVpYUjFjbTRnYzJWc1ppNTBiM1JoYkY5amJHRnBiWE5mWlhoMGNtRmpkR1ZrTG5aaGJIVmxDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNaUF2THlBaWRHOTBZV3hmWTJ4aGFXMXpYMlY0ZEhKaFkzUmxaQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1MGIzUmhiRjlqYkdGcGJYTmZaWGgwY21GamRHVmtJR1Y0YVhOMGN3b2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG1aaFkzUmZZMmhsWTJ0bGNpNWpiMjUwY21GamRDNUdZV04wUTJobFkydGxjaTV3Y205alpYTnpYM04wWlhBeFgyTnZiWEJzWlhSbEtIUmxlSFE2SUdKNWRHVnpLU0F0UGlCaWVYUmxjem9LY0hKdlkyVnpjMTl6ZEdWd01WOWpiMjF3YkdWMFpUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bVlXTjBYMk5vWldOclpYSXZZMjl1ZEhKaFkzUXVjSGs2TlRBdE5URUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ0x5OGdaR1ZtSUhCeWIyTmxjM05mYzNSbGNERmZZMjl0Y0d4bGRHVW9jMlZzWml3Z2RHVjRkRG9nVTNSeWFXNW5LU0F0UGlCVGRISnBibWM2Q2lBZ0lDQndjbTkwYnlBeElERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bVlXTjBYMk5vWldOclpYSXZZMjl1ZEhKaFkzUXVjSGs2TlRNS0lDQWdJQzh2SUhOMVltMXBjM05wYjI1ZmFXUWdQU0J6Wld4bUxuTjFZbTFwZEY5MFpYaDBYMlp2Y2w5aGJtRnNlWE5wY3loMFpYaDBLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCallXeHNjM1ZpSUhOMVltMXBkRjkwWlhoMFgyWnZjbDloYm1Gc2VYTnBjd29nSUNBZ2NHOXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlptRmpkRjlqYUdWamEyVnlMMk52Ym5SeVlXTjBMbkI1T2pVMENpQWdJQ0F2THlCamJHRnBiWE5mWTI5MWJuUWdQU0J6Wld4bUxtVjRkSEpoWTNSZlkyeGhhVzF6WDJOdmRXNTBLSFJsZUhRcENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR05oYkd4emRXSWdaWGgwY21GamRGOWpiR0ZwYlhOZlkyOTFiblFLSUNBZ0lIQnZjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyWmhZM1JmWTJobFkydGxjaTlqYjI1MGNtRmpkQzV3ZVRvMU5Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUZOMGNtbHVaeWdpVTNSbGNDQXhJR052YlhCc1pYUmxJQzBnWTJ4aGFXMXpJR1Y0ZEhKaFkzUmxaQ0lwQ2lBZ0lDQndkWE5vWW5sMFpYTWdJbE4wWlhBZ01TQmpiMjF3YkdWMFpTQXRJR05zWVdsdGN5QmxlSFJ5WVdOMFpXUWlDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVptRmpkRjlqYUdWamEyVnlMbU52Ym5SeVlXTjBMa1poWTNSRGFHVmphMlZ5TG5KbGMyVjBYMkZzYkY5emRHRjBjeWdwSUMwK0lHSjVkR1Z6T2dweVpYTmxkRjloYkd4ZmMzUmhkSE02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZabUZqZEY5amFHVmphMlZ5TDJOdmJuUnlZV04wTG5CNU9qWXdDaUFnSUNBdkx5QnpaV3htTG5SdmRHRnNYM04xWW0xcGMzTnBiMjV6TG5aaGJIVmxJRDBnVlVsdWREWTBLREFwQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0owYjNSaGJGOXpkV0p0YVhOemFXOXVjeUlLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyWmhZM1JmWTJobFkydGxjaTlqYjI1MGNtRmpkQzV3ZVRvMk1Rb2dJQ0FnTHk4Z2MyVnNaaTUwYjNSaGJGOWpiR0ZwYlhOZlpYaDBjbUZqZEdWa0xuWmhiSFZsSUQwZ1ZVbHVkRFkwS0RBcENpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKMGIzUmhiRjlqYkdGcGJYTmZaWGgwY21GamRHVmtJZ29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlptRmpkRjlqYUdWamEyVnlMMk52Ym5SeVlXTjBMbkI1T2pZeUNpQWdJQ0F2THlCeVpYUjFjbTRnVTNSeWFXNW5LQ0pCYkd3Z2MzUmhkSE1nY21WelpYUWdjM1ZqWTJWemMyWjFiR3g1SWlrS0lDQWdJSEIxYzJoaWVYUmxjeUFpUVd4c0lITjBZWFJ6SUhKbGMyVjBJSE4xWTJObGMzTm1kV3hzZVNJS0lDQWdJSEpsZEhOMVlnbz0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIn0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBQ0FRQW1Bd1FWSDN4MUVYUnZkR0ZzWDNOMVltMXBjM05wYjI1ekZuUnZkR0ZzWDJOc1lXbHRjMTlsZUhSeVlXTjBaV1F4R0VBQUJpa2paeW9qWnpFYlFRRWlnZ2dFaXN2WVl3UXM2ZElVQkFqV2JESUUreGVGandSRGVHSUxCTWVqazJ3RUxERWN6Z1F1N3J1NU5ob0FqZ2dBekFDMUFKY0FoZ0IxQUZjQVB3QUNJME14R1JSRU1SaEVnREVWSDN4MUFDdEdZV04wUTJobFkydGxjaUIyTVM0d0lDMGdVM1JsY0NBeE9pQkRiR0ZwYlNCRmVIUnlZV04wYVc5dXNDSkRNUmtVUkRFWVJJZ0JPVWtWRmxjR0FreFFLRXhRc0NKRE1Sa1VSREVZUkRZYUFWY0NBSWdBNTBrVkZsY0dBa3hRS0V4UXNDSkRNUmtVUkRFWVJJZ0F5aFlvVEZDd0lrTXhHUlJFTVJoRWlBQzBGaWhNVUxBaVF6RVpGRVF4R0VRMkdnRlhBZ0NJQUpaSkZSWlhCZ0pNVUNoTVVMQWlRekVaRkVReEdFUTJHZ0ZYQWdDSUFEY1dLRXhRc0NKRE1Sa1VSREVZUkRZYUFWY0NBSWdBRWhZb1RGQ3dJa014R1VEL0dERVlGRVFpUTRvQkFTTXBaVVFpQ0NsTEFXZUppZ0VCZ0FBalNZc0NnV1FNUVFBaWkvK0xBbFdCTGhLTEFZd0FRUUFHaXdFaUNJd0Fpd0NNQVlzQ0lnaU1Ba0wvMWlNcVpVU0xBVWxPQWdncVRHZU1BSW1LQVFHTC93R0pJeWxsUklrakttVkVpWW9CQVl2L2lQK1lTSXYvaVArZ1NJQWlVM1JsY0NBeElHTnZiWEJzWlhSbElDMGdZMnhoYVcxeklHVjRkSEpoWTNSbFpJa3BJMmNxSTJlQUhFRnNiQ0J6ZEdGMGN5QnlaWE5sZENCemRXTmpaWE56Wm5Wc2JIbUoiLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjQsIm1pbm9yIjoxMCwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
