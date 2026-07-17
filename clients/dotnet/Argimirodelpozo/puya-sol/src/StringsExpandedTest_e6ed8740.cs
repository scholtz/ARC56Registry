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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.StringsExpandedTest_e6ed8740
{


    public class StringsExpandedTestProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public StringsExpandedTestProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        public async Task<string> ToString(AVM.ClientGenerator.ABI.ARC4.Types.UInt512 value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 97, 199, 140, 232 };

            var result = await base.SimApp(new List<object> { abiHandle, value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> ToString_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt512 value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 97, 199, 140, 232 };

            return await base.MakeTransactionList(new List<object> { abiHandle, value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        public async Task<string> ToStringSigned(AVM.ClientGenerator.ABI.ARC4.Types.UInt512 value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 251, 110, 214, 156 };

            var result = await base.SimApp(new List<object> { abiHandle, value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> ToStringSigned_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt512 value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 251, 110, 214, 156 };

            return await base.MakeTransactionList(new List<object> { abiHandle, value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        public async Task<string> ToHexString(AVM.ClientGenerator.ABI.ARC4.Types.UInt512 value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 211, 231, 119, 205 };

            var result = await base.SimApp(new List<object> { abiHandle, value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> ToHexString_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt512 value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 211, 231, 119, 205 };

            return await base.MakeTransactionList(new List<object> { abiHandle, value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        /// <param name="length"> </param>
        public async Task<string> ToHexStringFixed(AVM.ClientGenerator.ABI.ARC4.Types.UInt512 value, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 length, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 6, 1, 33, 186 };

            var result = await base.SimApp(new List<object> { abiHandle, value, length }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> ToHexStringFixed_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt512 value, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 length, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 6, 1, 33, 186 };

            return await base.MakeTransactionList(new List<object> { abiHandle, value, length }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="addr"> </param>
        public async Task<string> ToHexStringAddr(Algorand.Address addr, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 67, 211, 251, 45 };
            var addrAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addrAbi.From(addr);

            var result = await base.SimApp(new List<object> { abiHandle, addrAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> ToHexStringAddr_Transactions(Algorand.Address addr, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 67, 211, 251, 45 };
            var addrAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addrAbi.From(addr);

            return await base.MakeTransactionList(new List<object> { abiHandle, addrAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        /// <param name="b"> </param>
        public async Task<bool> Equal(string a, string b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 48, 208, 92, 54 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); bAbi.From(b);

            var result = await base.SimApp(new List<object> { abiHandle, aAbi, bAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Equal_Transactions(string a, string b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 48, 208, 92, 54 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); bAbi.From(b);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi, bAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiU3RyaW5nc0V4cGFuZGVkVGVzdCIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJ0b1N0cmluZyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NTEyIiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRvU3RyaW5nU2lnbmVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ1MTIiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidG9IZXhTdHJpbmciLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDUxMiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbHVlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0b0hleFN0cmluZ0ZpeGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ1MTIiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDUxMiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Imxlbmd0aCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidG9IZXhTdHJpbmdBZGRyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZGRyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJlcXVhbCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJiIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls0MDNdLCJlcnJvck1lc3NhZ2UiOiJTdHJpbmdzSW5zdWZmaWNpZW50SGV4TGVuZ3RoIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjc2LDY5NF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY4NCw3MDJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjUwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQxNiw0NDMsNTA2LDYxNiw2MjRdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NTEyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZiM0JsYm5wbGNIQmxiR2x1TDJOdmJuUnlZV04wY3k5VGRISnBibWR6Ulhod1lXNWtaV1F1YzI5c0xsTjBjbWx1WjNORmVIQmhibVJsWkZSbGMzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBNElERWdNQ0EyTkFvZ0lDQWdZbmwwWldOaWJHOWpheUF3ZURFMU1XWTNZemMxSURCNElEQjRNREVnSWpBaUNpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1ltNTZJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF5Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1qb0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnY0hWemFHSjVkR1Z6Y3lBd2VEWXhZemM0WTJVNElEQjRabUkyWldRMk9XTWdNSGhrTTJVM056ZGpaQ0F3ZURBMk1ERXlNV0poSURCNE5ETmtNMlppTW1RZ01IZ3pNR1F3TldNek5pQXZMeUJ0WlhSb2IyUWdJblJ2VTNSeWFXNW5LSFZwYm5RMU1USXBjM1J5YVc1bklpd2diV1YwYUc5a0lDSjBiMU4wY21sdVoxTnBaMjVsWkNoMWFXNTBOVEV5S1hOMGNtbHVaeUlzSUcxbGRHaHZaQ0FpZEc5SVpYaFRkSEpwYm1jb2RXbHVkRFV4TWlsemRISnBibWNpTENCdFpYUm9iMlFnSW5SdlNHVjRVM1J5YVc1blJtbDRaV1FvZFdsdWREVXhNaXgxYVc1ME5URXlLWE4wY21sdVp5SXNJRzFsZEdodlpDQWlkRzlJWlhoVGRISnBibWRCWkdSeUtHRmtaSEpsYzNNcGMzUnlhVzVuSWl3Z2JXVjBhRzlrSUNKbGNYVmhiQ2h6ZEhKcGJtY3NjM1J5YVc1bktXSnZiMndpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCMGIxTjBjbWx1WnlCMGIxTjBjbWx1WjFOcFoyNWxaQ0IwYjBobGVGTjBjbWx1WnlCMGIwaGxlRk4wY21sdVowWnBlR1ZrSUhSdlNHVjRVM1J5YVc1blFXUmtjaUJsY1hWaGJBb2dJQ0FnWlhKeUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMjl3Wlc1NlpYQndaV3hwYmk5amIyNTBjbUZqZEhNdlUzUnlhVzVuYzBWNGNHRnVaR1ZrTG5OdmJDNVRkSEpwYm1kekxuUnZVM1J5YVc1bktIWmhiSFZsT2lCaWVYUmxjeWtnTFQ0Z1lubDBaWE02Q2xOMGNtbHVaM011ZEc5VGRISnBibWM2Q2lBZ0lDQndjbTkwYnlBeElERUtJQ0FnSUdsdWRHTmZNaUF2THlBd0NpQWdJQ0JrZFhCdUlEUUtJQ0FnSUdsMGIySUtJQ0FnSUdSMWNBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JpUFQwS0lDQWdJR0o2SUZOMGNtbHVaM011ZEc5VGRISnBibWRmWVdaMFpYSmZhV1pmWld4elpVQXlDaUFnSUNCaWVYUmxZMTh6SUM4dklDSXdJZ29nSUNBZ1puSmhiV1ZmWW5WeWVTQXdDaUFnSUNCeVpYUnpkV0lLQ2xOMGNtbHVaM011ZEc5VGRISnBibWRmWVdaMFpYSmZhV1pmWld4elpVQXlPZ29nSUNBZ1lubDBaV05mTVNBdkx5QXdlQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXhDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01nb0tVM1J5YVc1bmN5NTBiMU4wY21sdVoxOTNhR2xzWlY5MGIzQkFNem9LSUNBZ0lHWnlZVzFsWDJScFp5QXlDaUFnSUNCbWNtRnRaVjlrYVdjZ05Bb2dJQ0FnWWlFOUNpQWdJQ0JpZWlCVGRISnBibWR6TG5SdlUzUnlhVzVuWDJGbWRHVnlYM2RvYVd4bFFEVUtJQ0FnSUdaeVlXMWxYMlJwWnlBeENpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1ERUtJQ0FnSUdJckNpQWdJQ0JtY21GdFpWOWlkWEo1SURFS0lDQWdJSEIxYzJocGJuUWdNVEFLSUNBZ0lHbDBiMklLSUNBZ0lHWnlZVzFsWDJScFp5QXlDaUFnSUNCemQyRndDaUFnSUNCaUx3b2dJQ0FnWm5KaGJXVmZZblZ5ZVNBeUNpQWdJQ0JpSUZOMGNtbHVaM011ZEc5VGRISnBibWRmZDJocGJHVmZkRzl3UURNS0NsTjBjbWx1WjNNdWRHOVRkSEpwYm1kZllXWjBaWEpmZDJocGJHVkFOVG9LSUNBZ0lHbHVkR05mTUNBdkx5QTRDaUFnSUNCaWVtVnlid29nSUNBZ1pIVndDaUFnSUNCbWNtRnRaVjlpZFhKNUlETUtJQ0FnSUdaeVlXMWxYMlJwWnlBeENpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdMUW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHSjZaWEp2Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREFLQ2xOMGNtbHVaM011ZEc5VGRISnBibWRmZDJocGJHVmZkRzl3UURZNkNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR1p5WVcxbFgyUnBaeUEwQ2lBZ0lDQmlJVDBLSUNBZ0lHSjZJRk4wY21sdVozTXVkRzlUZEhKcGJtZGZZV1owWlhKZmQyaHBiR1ZBT0FvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lHbDBiMklLSUNBZ0lHWnlZVzFsWDJScFp5QXhDaUFnSUNCemQyRndDaUFnSUNCaUxRb2dJQ0FnWkhWd0NpQWdJQ0JtY21GdFpWOWlkWEo1SURFS0lDQWdJR1p5WVcxbFgyUnBaeUF6Q2lBZ0lDQmtkWEFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJQzBLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQndkWE5vYVc1MElEUTRDaUFnSUNCcGRHOWlDaUFnSUNCd2RYTm9hVzUwSURFd0NpQWdJQ0JwZEc5aUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR1JwWnlBeENpQWdJQ0JpSlFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCaUt3b2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ0xRb2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCbGVIUnlZV04wSURjZ01Rb2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J5WlhCc1lXTmxNd29nSUNBZ1puSmhiV1ZmWW5WeWVTQXdDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUhOM1lYQUtJQ0FnSUdJdkNpQWdJQ0JtY21GdFpWOWlkWEo1SUMweENpQWdJQ0JpSUZOMGNtbHVaM011ZEc5VGRISnBibWRmZDJocGJHVmZkRzl3UURZS0NsTjBjbWx1WjNNdWRHOVRkSEpwYm1kZllXWjBaWEpmZDJocGJHVkFPRG9LSUNBZ0lISmxkSE4xWWdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OXZjR1Z1ZW1Wd2NHVnNhVzR2WTI5dWRISmhZM1J6TDFOMGNtbHVaM05GZUhCaGJtUmxaQzV6YjJ3dVUzUnlhVzVuY3k1MGIwaGxlRk4wY21sdVp5Z3lLU2gyWVd4MVpUb2dZbmwwWlhNc0lHeGxibWQwYURvZ1lubDBaWE1wSUMwK0lHSjVkR1Z6T2dwVGRISnBibWR6TG5SdlNHVjRVM1J5YVc1bk9nb2dJQ0FnY0hKdmRHOGdNaUF4Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0lpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ1lucGxjbThLSUNBZ0lHUjFjQW9nSUNBZ2NIVnphR2x1ZENBeUNpQWdJQ0JwZEc5aUNpQWdJQ0JrZFhBS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZaW9LSUNBZ0lHUjFjQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JpS3dvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnTFFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR0o2WlhKdkNpQWdJQ0JpZVhSbFkxOHpJQzh2SUNJd0lnb2dJQ0FnY21Wd2JHRmpaVElnTUFvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0o0SWdvZ0lDQWdjbVZ3YkdGalpUSWdNUW9nSUNBZ2MzZGhjQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUdsMGIySUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1lpc0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb0tVM1J5YVc1bmN5NTBiMGhsZUZOMGNtbHVaMTkzYUdsc1pWOTBiM0JBTVRvS0lDQWdJR1p5WVcxbFgyUnBaeUEwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNd29nSUNBZ1lqNEtJQ0FnSUdKNklGTjBjbWx1WjNNdWRHOUlaWGhUZEhKcGJtZGZZV1owWlhKZmQyaHBiR1ZBTXdvZ0lDQWdabkpoYldWZlpHbG5JREVLSUNBZ0lHWnlZVzFsWDJScFp5QTBDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnTFFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR1p5WVcxbFgySjFjbmtnTUFvZ0lDQWdjSFZ6YUdsdWRDQXhOUW9nSUNBZ2FYUnZZZ29nSUNBZ1puSmhiV1ZmWkdsbklEVUtJQ0FnSUdJbUNpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUWdNVEFLSUNBZ0lHbDBiMklLSUNBZ0lHSThDaUFnSUNCaWVpQlRkSEpwYm1kekxuUnZTR1Y0VTNSeWFXNW5YMkZtZEdWeVgybG1YMlZzYzJWQU9Bb2dJQ0FnY0hWemFHbHVkQ0EwT0FvZ0lDQWdhWFJ2WWdvZ0lDQWdZaXNLSUNBZ0lHWnlZVzFsWDJScFp5QXhDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnTFFvZ0lDQWdhVzUwWTE4d0lDOHZJRGdLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JsZUhSeVlXTjBJRGNnTVFvS1UzUnlhVzVuY3k1MGIwaGxlRk4wY21sdVoxOWhablJsY2w5cGJteHBibVZrWHk5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTl2Y0dWdWVtVndjR1ZzYVc0dlkyOXVkSEpoWTNSekwxTjBjbWx1WjNORmVIQmhibVJsWkM1emIyd3VVM1J5YVc1bmN5NWZhR1Y0UkdsbmFYUkFPVG9LSUNBZ0lHWnlZVzFsWDJScFp5QXlDaUFnSUNCbWNtRnRaVjlrYVdjZ01Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnlaWEJzWVdObE13b2dJQ0FnWm5KaGJXVmZZblZ5ZVNBeUNpQWdJQ0JtY21GdFpWOWthV2NnTlFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF4TUFvZ0lDQWdZaThLSUNBZ0lHWnlZVzFsWDJKMWNua2dOUW9nSUNBZ1puSmhiV1ZmWkdsbklEUUtJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZ3dNUW9nSUNBZ1lpMEtJQ0FnSUdaeVlXMWxYMkoxY25rZ05Bb2dJQ0FnWWlCVGRISnBibWR6TG5SdlNHVjRVM1J5YVc1blgzZG9hV3hsWDNSdmNFQXhDZ3BUZEhKcGJtZHpMblJ2U0dWNFUzUnlhVzVuWDJGbWRHVnlYMmxtWDJWc2MyVkFPRG9LSUNBZ0lIQjFjMmhwYm5RZ09EY0tJQ0FnSUdsMGIySUtJQ0FnSUdJckNpQWdJQ0JtY21GdFpWOWthV2NnTVFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRGdLSUNBZ0lDMEtJQ0FnSUdsdWRHTmZNQ0F2THlBNENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pYaDBjbUZqZENBM0lERUtJQ0FnSUdJZ1UzUnlhVzVuY3k1MGIwaGxlRk4wY21sdVoxOWhablJsY2w5cGJteHBibVZrWHk5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTl2Y0dWdWVtVndjR1ZzYVc0dlkyOXVkSEpoWTNSekwxTjBjbWx1WjNORmVIQmhibVJsWkM1emIyd3VVM1J5YVc1bmN5NWZhR1Y0UkdsbmFYUkFPUW9LVTNSeWFXNW5jeTUwYjBobGVGTjBjbWx1WjE5aFpuUmxjbDkzYUdsc1pVQXpPZ29nSUNBZ2FXNTBZMTh5SUM4dklEQUtJQ0FnSUdsMGIySUtJQ0FnSUdaeVlXMWxYMlJwWnlBMUNpQWdJQ0JpSVQwS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlRkSEpwYm1kelNXNXpkV1ptYVdOcFpXNTBTR1Y0VEdWdVozUm9DaUFnSUNCbWNtRnRaVjlrYVdjZ01nb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBd0NpQWdJQ0J5WlhSemRXSUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12YjNCbGJucGxjSEJsYkdsdUwyTnZiblJ5WVdOMGN5OVRkSEpwYm1kelJYaHdZVzVrWldRdWMyOXNMbE4wY21sdVozTkZlSEJoYm1SbFpGUmxjM1F1ZEc5VGRISnBibWRiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMGIxTjBjbWx1WnpvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdOalFLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREVXhNZ29nSUNBZ1kyRnNiSE4xWWlCVGRISnBibWR6TG5SdlUzUnlhVzVuQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5dmNHVnVlbVZ3Y0dWc2FXNHZZMjl1ZEhKaFkzUnpMMU4wY21sdVozTkZlSEJoYm1SbFpDNXpiMnd1VTNSeWFXNW5jMFY0Y0dGdVpHVmtWR1Z6ZEM1MGIxTjBjbWx1WjFOcFoyNWxaRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25SdlUzUnlhVzVuVTJsbmJtVmtPZ29nSUNBZ2FXNTBZMTh5SUM4dklEQUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNHNGdNZ29nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z05qUUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERVeE1nb2dJQ0FnYVc1MFkxOHlJQzh2SURBS0lDQWdJR2wwYjJJS0lDQWdJR0k4Q2lBZ0lDQmtkWEFLSUNBZ0lHSjZJSFJ2VTNSeWFXNW5VMmxuYm1Wa1gzUmxjbTVoY25sZlptRnNjMlZBTXdvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0l0SWdvZ0lDQWdZblZ5ZVNBekNncDBiMU4wY21sdVoxTnBaMjVsWkY5MFpYSnVZWEo1WDIxbGNtZGxRRFE2Q2lBZ0lDQmtkWEFLSUNBZ0lHSjZJSFJ2VTNSeWFXNW5VMmxuYm1Wa1gzUmxjbTVoY25sZlptRnNjMlZBTmdvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZUFvZ0lDQWdaR2xuSURJS0lDQWdJR0l0Q2dwMGIxTjBjbWx1WjFOcFoyNWxaRjkwWlhKdVlYSjVYMjFsY21kbFFEYzZDaUFnSUNCallXeHNjM1ZpSUZOMGNtbHVaM011ZEc5VGRISnBibWNLSUNBZ0lHUnBaeUF6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwMGIxTjBjbWx1WjFOcFoyNWxaRjkwWlhKdVlYSjVYMlpoYkhObFFEWTZDaUFnSUNCa2FXY2dNUW9nSUNBZ1lpQjBiMU4wY21sdVoxTnBaMjVsWkY5MFpYSnVZWEo1WDIxbGNtZGxRRGNLQ25SdlUzUnlhVzVuVTJsbmJtVmtYM1JsY201aGNubGZabUZzYzJWQU16b0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0lpSUtJQ0FnSUdKMWNua2dNd29nSUNBZ1lpQjBiMU4wY21sdVoxTnBaMjVsWkY5MFpYSnVZWEo1WDIxbGNtZGxRRFFLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmIzQmxibnBsY0hCbGJHbHVMMk52Ym5SeVlXTjBjeTlUZEhKcGJtZHpSWGh3WVc1a1pXUXVjMjlzTGxOMGNtbHVaM05GZUhCaGJtUmxaRlJsYzNRdWRHOUlaWGhUZEhKcGJtZGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AwYjBobGVGTjBjbWx1WnpvS0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQmtkWEFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjRzRnTWdvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdOalFLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREVXhNZ29nSUNBZ2FXNTBZMTh5SUM4dklEQUtJQ0FnSUdsMGIySUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1lqMDlDaUFnSUNCaWVpQjBiMGhsZUZOMGNtbHVaMTloWm5SbGNsOXBabDlsYkhObFFETUtJQ0FnSUhCMWMyaGllWFJsY3lBaU1IZ3dNQ0lLQ25SdlNHVjRVM1J5YVc1blgyRm1kR1Z5WDJsdWJHbHVaV1JmTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMjl3Wlc1NlpYQndaV3hwYmk5amIyNTBjbUZqZEhNdlUzUnlhVzVuYzBWNGNHRnVaR1ZrTG5OdmJDNVRkSEpwYm1kekxuUnZTR1Y0VTNSeWFXNW5LREVwWHpCQU56b0tJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncDBiMGhsZUZOMGNtbHVaMTloWm5SbGNsOXBabDlsYkhObFFETTZDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRDaUFnSUNCaWRYSjVJRFFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmlkWEo1SURNS0NuUnZTR1Y0VTNSeWFXNW5YM2RvYVd4bFgzUnZjRUEwT2dvZ0lDQWdaR2xuSURJS0lDQWdJR1JwWnlBeENpQWdJQ0JpSVQwS0lDQWdJR0o2SUhSdlNHVjRVM1J5YVc1blgyRm1kR1Z5WDNkb2FXeGxRRFlLSUNBZ0lHUnBaeUF6Q2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TURFS0lDQWdJR0lyQ2lBZ0lDQmlkWEo1SURRS0lDQWdJR1JwWnlBeUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TVRBd0NpQWdJQ0JpTHdvZ0lDQWdZblZ5ZVNBekNpQWdJQ0JpSUhSdlNHVjRVM1J5YVc1blgzZG9hV3hsWDNSdmNFQTBDZ3AwYjBobGVGTjBjbWx1WjE5aFpuUmxjbDkzYUdsc1pVQTJPZ29nSUNBZ1pHbG5JREVLSUNBZ0lHUnBaeUEwQ2lBZ0lDQmpZV3hzYzNWaUlGTjBjbWx1WjNNdWRHOUlaWGhUZEhKcGJtY0tJQ0FnSUdJZ2RHOUlaWGhUZEhKcGJtZGZZV1owWlhKZmFXNXNhVzVsWkY4dmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12YjNCbGJucGxjSEJsYkdsdUwyTnZiblJ5WVdOMGN5OVRkSEpwYm1kelJYaHdZVzVrWldRdWMyOXNMbE4wY21sdVozTXVkRzlJWlhoVGRISnBibWNvTVNsZk1FQTNDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDI5d1pXNTZaWEJ3Wld4cGJpOWpiMjUwY21GamRITXZVM1J5YVc1bmMwVjRjR0Z1WkdWa0xuTnZiQzVUZEhKcGJtZHpSWGh3WVc1a1pXUlVaWE4wTG5SdlNHVjRVM1J5YVc1blJtbDRaV1JiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMGIwaGxlRk4wY21sdVowWnBlR1ZrT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QTJOQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5URXlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURZMENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblExTVRJS0lDQWdJR05oYkd4emRXSWdVM1J5YVc1bmN5NTBiMGhsZUZOMGNtbHVad29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12YjNCbGJucGxjSEJsYkdsdUwyTnZiblJ5WVdOMGN5OVRkSEpwYm1kelJYaHdZVzVrWldRdWMyOXNMbE4wY21sdVozTkZlSEJoYm1SbFpGUmxjM1F1ZEc5SVpYaFRkSEpwYm1kQlpHUnlXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LZEc5SVpYaFRkSEpwYm1kQlpHUnlPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnY0hWemFHbHVkQ0F5TUFvZ0lDQWdhWFJ2WWdvZ0lDQWdZMkZzYkhOMVlpQlRkSEpwYm1kekxuUnZTR1Y0VTNSeWFXNW5DaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTl2Y0dWdWVtVndjR1ZzYVc0dlkyOXVkSEpoWTNSekwxTjBjbWx1WjNORmVIQmhibVJsWkM1emIyd3VVM1J5YVc1bmMwVjRjR0Z1WkdWa1ZHVnpkQzVsY1hWaGJGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbVZ4ZFdGc09nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6SWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2NIVnphR2x1ZENBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCa2RYQUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHlJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lIQjFjMmhwYm5RZ01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ1pIVndDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR3hsYmdvZ0lDQWdjM2RoY0FvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lub2daWEYxWVd4ZlltOXZiRjltWVd4elpVQTBDaUFnSUNCa2FXY2dNUW9nSUNBZ2EyVmpZMkZyTWpVMkNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYTJWalkyRnJNalUyQ2lBZ0lDQTlQUW9nSUNBZ1lub2daWEYxWVd4ZlltOXZiRjltWVd4elpVQTBDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb0taWEYxWVd4ZlltOXZiRjl0WlhKblpVQTFPZ29nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREFLSUNBZ0lHbHVkR05mTWlBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sZEdKcGRBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0taWEYxWVd4ZlltOXZiRjltWVd4elpVQTBPZ29nSUNBZ2FXNTBZMTh5SUM4dklEQUtJQ0FnSUdJZ1pYRjFZV3hmWW05dmJGOXRaWEpuWlVBMUNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmIzQmxibnBsY0hCbGJHbHVMMk52Ym5SeVlXTjBjeTlUZEhKcGJtZHpSWGh3WVc1a1pXUXVjMjlzTGxOMGNtbHVaM05GZUhCaGJtUmxaRlJsYzNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFFQ0FFQVFDWUVCQlVmZkhVQUFRRUJNREVZUUFBQ0kwTXhHUlJFTVJoRWdnWUVZY2VNNkFUN2J0YWNCTlBuZDgwRUJnRWh1Z1JEMC9zdEJERFFYRFkyR2dDT0JnRkhBV0FCbmdJUEFqQUNUUUNLQVFFa1J3UVdTWXYvcUVFQUJDdU1BSWtwakFHTC80d0Npd0tMQktsQkFCS0xBU3FnakFHQkNoYUxBa3lpakFKQy8rWWlyMG1NQTRzQlVFa1ZJZ2xicjR3QWkvK0xCS2xCQUVFakZvc0JUS0ZKakFHTEEwbFBBbEJKRlNJSlc0RXdGb0VLRm92L1N3R3FUd0tnVHdOTVVFa1ZJZ2tpV0ZjSEFZc0FUd05QQWwyTUFJdi9US0tNLzBML3Q0bUtBZ0VwSXE5SmdRSVdTWXYvbzBsUEFxQlBBa3hRU1JVaUNWdXZLMXdBZ0FGNFhBRk1JeFpKVGdLZ2kvNkxCSXNEcFVFQWVJc0Jpd1JRU1JVaUNWdU1BSUVQRm9zRnJFbUJDaGFrUVFCS2dUQVdvSXNCVEZCSkZTSUpJbGhYQndHTEFvc0FUd0pkakFLTEJZQWdBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUJDaWpBV0xCQ3FoakFSQy81U0JWeGFnaXdGTVVFa1ZJZ2tpV0ZjSEFVTC9zeVFXaXdXcEZFU0xBb3dBaVRZYUFVa1ZKUkpFaVA2dlNSVVdWd1lDVEZBb1RGQ3dJME1rTmhvQlJ3SVZKUkpFSkJha1NVRUFKNEFCTFVVRFNVRUFHU2xMQXFHSS9vQkxBMHhRU1JVV1Z3WUNURkFvVEZDd0kwTkxBVUwvNWlsRkEwTC8yQ1JKTmhvQlJ3SVZKUkpFSkJaSlRnS29RUUFVZ0FRd2VEQXdTUlVXVndZQ1RGQW9URkN3STBNcFJRUkxBVVVEU3dKTEFhbEJBREJMQXlxZ1JRUkxBb0FnQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFRQ2lSUU5DLzhoTEFVc0VpUDZDUXYrcE5ob0JTUlVsRWtRMkdnSkpGU1VTUklqK2JFa1ZGbGNHQWt4UUtFeFFzQ05ETmhvQlNSV0JJQkpFZ1JRV2lQNVBTUlVXVndZQ1RGQW9URkN3STBNMkdnRkpKRm1CQWdoTEFSVVNSRmNDQUVrMkdnSkpKRm1CQWdoTEFSVVNSRmNDQUVsUEFoVk1GUkpCQUJoTEFRSkxBUUlTUVFBT0k0QUJBQ1JQQWxRb1RGQ3dJME1rUXYvdiIsImNsZWFyIjoiQ29FQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjcsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
