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

namespace Arc56.Generated.aorumbayev.puya.MyContract_cc600081
{


    public class MyContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public MyContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        public async Task Create(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 76, 92, 97, 186 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Create_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 76, 92, 97, 186 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="name"> </param>
        public async Task Register(string name, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 189, 96, 153, 229 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);

            var result = await base.CallApp(new List<object> { abiHandle, nameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Register_Transactions(string name, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 189, 96, 153, 229 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);

            return await base.MakeTransactionList(new List<object> { abiHandle, nameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<string> SayHello(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 93, 92, 132, 199 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> SayHello_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 93, 92, 132, 199 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        /// <param name="b"> </param>
        public async Task<ulong> Calculate(ulong a, ulong b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 253, 7, 38, 78 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bAbi.From(b);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi, bAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Calculate_Transactions(ulong a, ulong b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 253, 7, 38, 78 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bAbi.From(b);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi, bAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task CloseOut(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 22, 88, 170, 47 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CloseOut_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 22, 88, 170, 47 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTXlDb250cmFjdCIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVnaXN0ZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmFtZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiLCJPcHRJbiJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNheV9oZWxsbyIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNhbGN1bGF0ZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJiIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2xvc2Vfb3V0IiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiQ2xvc2VPdXQiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MSwiYnl0ZXMiOjF9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MX19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzExMl0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBpcyBub3QgQ2xvc2VPdXQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjQsMTQ2LDE4MV0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBpcyBub3QgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE2Nl0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBpcyBub3Qgb25lIG9mIE5vT3AsIE9wdEluIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTk1LDIxOSwyNThdLCJlcnJvck1lc3NhZ2UiOiJZb3UgYXJlIGJhbm5lZCwgZ29vZGJ5ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE4NV0sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExNSwxMjcsMTQ5LDE2OV0sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBub3QgY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMzksMzQ5XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5jb3VudGVyIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W3sicGMiOlsxNV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuY291bnRlciBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUIwWlhOMFgyTmhjMlZ6TG1WMlpYSjVkR2hwYm1jdVkyOXVkSEpoWTNRdVJYWmxjbmwwYUdsdVp5NWZYMkZzWjI5d2VWOWxiblJ5ZVhCdmFXNTBYM2RwZEdoZmFXNXBkQ2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXhJREFLSUNBZ0lHSjVkR1ZqWW14dlkyc2dJbU52ZFc1MFpYSWlJR0poYzJVek1paFdRMDFLUzFkUFdUVlFOVkEzVTB0TldrWkdUME5GVWs5UVNrTmFUMVJKU2sxT1NWbE9WVU5MU0RkTVVrODBOVXBOU2xCUktTQWlibUZ0WlNJZ01IZ3hOVEZtTjJNM05Rb2dJQ0FnTHk4Z1pYWmxjbmwwYUdsdVp5OWpiMjUwY21GamRDNXdlVG96TndvZ0lDQWdMeThnWTJ4aGMzTWdSWFpsY25sMGFHbHVaeWhCVWtNMFEyOXVkSEpoWTNRc0lFMTVUV2xrWkd4bFFtRnpaU3dnYm1GdFpUMGlUWGxEYjI1MGNtRmpkQ0lwT2dvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJR0o2SUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeE1Bb2dJQ0FnY0hWemFHSjVkR1Z6Y3lBd2VEUmpOV00yTVdKaElEQjRZbVEyTURrNVpUVWdNSGcxWkRWak9EUmpOeUF3ZUdaa01EY3lOalJsSURCNE1UWTFPR0ZoTW1ZZ0x5OGdiV1YwYUc5a0lDSmpjbVZoZEdVb0tYWnZhV1FpTENCdFpYUm9iMlFnSW5KbFoybHpkR1Z5S0hOMGNtbHVaeWwyYjJsa0lpd2diV1YwYUc5a0lDSnpZWGxmYUdWc2JHOG9LWE4wY21sdVp5SXNJRzFsZEdodlpDQWlZMkZzWTNWc1lYUmxLSFZwYm5RMk5DeDFhVzUwTmpRcGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKamJHOXpaVjl2ZFhRb0tYWnZhV1FpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCdFlXbHVYMk55WldGMFpWOXliM1YwWlVBMUlHMWhhVzVmY21WbmFYTjBaWEpmY205MWRHVkFOaUJ0WVdsdVgzTmhlVjlvWld4c2IxOXliM1YwWlVBM0lHMWhhVzVmWTJGc1kzVnNZWFJsWDNKdmRYUmxRRGdnYldGcGJsOWpiRzl6WlY5dmRYUmZjbTkxZEdWQU9Rb0tiV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRREV3T2dvZ0lDQWdMeThnWlhabGNubDBhR2x1Wnk5amIyNTBjbUZqZEM1d2VUb3pOd29nSUNBZ0x5OGdZMnhoYzNNZ1JYWmxjbmwwYUdsdVp5aEJVa00wUTI5dWRISmhZM1FzSUUxNVRXbGtaR3hsUW1GelpTd2dibUZ0WlQwaVRYbERiMjUwY21GamRDSXBPZ29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWpiRzl6WlY5dmRYUmZjbTkxZEdWQU9Ub0tJQ0FnSUM4dklHVjJaWEo1ZEdocGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TmprS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb1lXeHNiM2RmWVdOMGFXOXVjejFiSWtOc2IzTmxUM1YwSWwwcENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCd2RYTm9hVzUwSURJZ0x5OGdRMnh2YzJWUGRYUUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCRGJHOXpaVTkxZEFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNCallXeHNjM1ZpSUdOc2IzTmxYMjkxZEFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlqWVd4amRXeGhkR1ZmY205MWRHVkFPRG9LSUNBZ0lDOHZJR1YyWlhKNWRHaHBibWN2WTI5dWRISmhZM1F1Y0hrNk5qUUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z1pYWmxjbmwwYUdsdVp5OWpiMjUwY21GamRDNXdlVG96TndvZ0lDQWdMeThnWTJ4aGMzTWdSWFpsY25sMGFHbHVaeWhCVWtNMFEyOXVkSEpoWTNRc0lFMTVUV2xrWkd4bFFtRnpaU3dnYm1GdFpUMGlUWGxEYjI1MGNtRmpkQ0lwT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdMeThnWlhabGNubDBhR2x1Wnk5amIyNTBjbUZqZEM1d2VUbzJOQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQW9nSUNBZ1kyRnNiSE4xWWlCallXeGpkV3hoZEdVS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmYzJGNVgyaGxiR3h2WDNKdmRYUmxRRGM2Q2lBZ0lDQXZMeUJsZG1WeWVYUm9hVzVuTDJOdmJuUnlZV04wTG5CNU9qVTJDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUdOaGJHeHpkV0lnYzJGNVgyaGxiR3h2Q2lBZ0lDQmllWFJsWTE4eklDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYM0psWjJsemRHVnlYM0p2ZFhSbFFEWTZDaUFnSUNBdkx5QmxkbVZ5ZVhSb2FXNW5MMk52Ym5SeVlXTjBMbkI1T2pRM0NpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tHRnNiRzkzWDJGamRHbHZibk05V3lKT2IwOXdJaXdnSWs5d2RFbHVJbDBwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdjMmhzQ2lBZ0lDQndkWE5vYVc1MElETWdMeThnTXdvZ0lDQWdKZ29nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdiMjVsSUc5bUlFNXZUM0FzSUU5d2RFbHVDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUdWMlpYSjVkR2hwYm1jdlkyOXVkSEpoWTNRdWNIazZNemNLSUNBZ0lDOHZJR05zWVhOeklFVjJaWEo1ZEdocGJtY29RVkpETkVOdmJuUnlZV04wTENCTmVVMXBaR1JzWlVKaGMyVXNJRzVoYldVOUlrMTVRMjl1ZEhKaFkzUWlLVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lDOHZJR1YyWlhKNWRHaHBibWN2WTI5dWRISmhZM1F1Y0hrNk5EY0tJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9ZV3hzYjNkZllXTjBhVzl1Y3oxYklrNXZUM0FpTENBaVQzQjBTVzRpWFNrS0lDQWdJR05oYkd4emRXSWdjbVZuYVhOMFpYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZlkzSmxZWFJsWDNKdmRYUmxRRFU2Q2lBZ0lDQXZMeUJsZG1WeWVYUm9hVzVuTDJOdmJuUnlZV04wTG5CNU9qUXhDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLR055WldGMFpUMGljbVZ4ZFdseVpTSXBDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJqY21WaGRHbHVad29nSUNBZ1kyRnNiSE4xWWlCamNtVmhkR1VLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QjBaWE4wWDJOaGMyVnpMbVYyWlhKNWRHaHBibWN1WTI5dWRISmhZM1F1UlhabGNubDBhR2x1Wnk1amNtVmhkR1VvS1NBdFBpQjJiMmxrT2dwamNtVmhkR1U2Q2lBZ0lDQXZMeUJsZG1WeWVYUm9hVzVuTDJOdmJuUnlZV04wTG5CNU9qYzVDaUFnSUNBdkx5QmhjM05sY25RZ2IzQXVWSGh1TG5ObGJtUmxjaUFoUFNCblpYUmZZbUZ1Ym1Wa0tDa3NJQ0paYjNVZ1lYSmxJR0poYm01bFpDd2daMjl2WkdKNVpTSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJQzh2SUdWMlpYSjVkR2hwYm1jdlkyOXVkSEpoWTNRdWNIazZNalVLSUNBZ0lDOHZJR0ZrWkhJZ1BTQkJZMk52ZFc1MEtFSkJUazVGUkNrS0lDQWdJR0o1ZEdWalh6RWdMeThnWVdSa2NpQldRMDFLUzFkUFdUVlFOVkEzVTB0TldrWkdUME5GVWs5UVNrTmFUMVJKU2sxT1NWbE9WVU5MU0RkTVVrODBOVXBOU2xBMlZWbENTVXBCQ2lBZ0lDQXZMeUJsZG1WeWVYUm9hVzVuTDJOdmJuUnlZV04wTG5CNU9qYzVDaUFnSUNBdkx5QmhjM05sY25RZ2IzQXVWSGh1TG5ObGJtUmxjaUFoUFNCblpYUmZZbUZ1Ym1Wa0tDa3NJQ0paYjNVZ1lYSmxJR0poYm01bFpDd2daMjl2WkdKNVpTSUtJQ0FnSUNFOUNpQWdJQ0JoYzNObGNuUWdMeThnV1c5MUlHRnlaU0JpWVc1dVpXUXNJR2R2YjJSaWVXVUtJQ0FnSUM4dklHVjJaWEo1ZEdocGJtY3ZiWGxmWW1GelpTNXdlVG81Q2lBZ0lDQXZMeUJ6Wld4bUxtTnlaV0YwYjNJZ1BTQnZjQzVVZUc0dWMyVnVaR1Z5Q2lBZ0lDQndkWE5vWW5sMFpYTWdJbU55WldGMGIzSWlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z1pYWmxjbmwwYUdsdVp5OWpiMjUwY21GamRDNXdlVG8wTlFvZ0lDQWdMeThnYzJWc1ppNWpiM1Z1ZEdWeUlEMGdWVWx1ZERZMEtGcEZVazhwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0pqYjNWdWRHVnlJZ29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QjBaWE4wWDJOaGMyVnpMbVYyWlhKNWRHaHBibWN1WTI5dWRISmhZM1F1UlhabGNubDBhR2x1Wnk1eVpXZHBjM1JsY2lodVlXMWxPaUJpZVhSbGN5a2dMVDRnZG05cFpEb0tjbVZuYVhOMFpYSTZDaUFnSUNBdkx5QmxkbVZ5ZVhSb2FXNW5MMk52Ym5SeVlXTjBMbkI1T2pRM0xUUTRDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLR0ZzYkc5M1gyRmpkR2x2Ym5NOVd5Sk9iMDl3SWl3Z0lrOXdkRWx1SWwwcENpQWdJQ0F2THlCa1pXWWdjbVZuYVhOMFpYSW9jMlZzWml3Z2JtRnRaVG9nVTNSeWFXNW5LU0F0UGlCT2IyNWxPZ29nSUNBZ2NISnZkRzhnTVNBd0NpQWdJQ0F2THlCbGRtVnllWFJvYVc1bkwyTnZiblJ5WVdOMExuQjVPamM1Q2lBZ0lDQXZMeUJoYzNObGNuUWdiM0F1VkhodUxuTmxibVJsY2lBaFBTQm5aWFJmWW1GdWJtVmtLQ2tzSUNKWmIzVWdZWEpsSUdKaGJtNWxaQ3dnWjI5dlpHSjVaU0lLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUM4dklHVjJaWEo1ZEdocGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TWpVS0lDQWdJQzh2SUdGa1pISWdQU0JCWTJOdmRXNTBLRUpCVGs1RlJDa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z1lXUmtjaUJXUTAxS1MxZFBXVFZRTlZBM1UwdE5Xa1pHVDBORlVrOVFTa05hVDFSSlNrMU9TVmxPVlVOTFNEZE1VazgwTlVwTlNsQTJWVmxDU1VwQkNpQWdJQ0F2THlCbGRtVnllWFJvYVc1bkwyTnZiblJ5WVdOMExuQjVPamM1Q2lBZ0lDQXZMeUJoYzNObGNuUWdiM0F1VkhodUxuTmxibVJsY2lBaFBTQm5aWFJmWW1GdWJtVmtLQ2tzSUNKWmIzVWdZWEpsSUdKaGJtNWxaQ3dnWjI5dlpHSjVaU0lLSUNBZ0lDRTlDaUFnSUNCaGMzTmxjblFnTHk4Z1dXOTFJR0Z5WlNCaVlXNXVaV1FzSUdkdmIyUmllV1VLSUNBZ0lDOHZJR1YyWlhKNWRHaHBibWN2WTI5dWRISmhZM1F1Y0hrNk5UQUtJQ0FnSUM4dklHbG1JRzl3TGxSNGJpNXZibDlqYjIxd2JHVjBhVzl1SUQwOUlFOXVRMjl0Y0d4bGRHVkJZM1JwYjI0dVQzQjBTVzQ2Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0JwYm5Salh6QWdMeThnVDNCMFNXNEtJQ0FnSUQwOUNpQWdJQ0JpZWlCeVpXZHBjM1JsY2w5aFpuUmxjbDlwWmw5bGJITmxRRFFLSUNBZ0lDOHZJR1YyWlhKNWRHaHBibWN2WTI5dWRISmhZM1F1Y0hrNk5URUtJQ0FnSUM4dklITmxibVJsY2w5dVlXMWxMQ0J6Wlc1a1pYSmZibUZ0WlY5bGVHbHpkR1ZrSUQwZ2MyVnNaaTV1WVcxbExtMWhlV0psS0dGalkyOTFiblE5TUNrS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmtkWEFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbTVoYldVaUNpQWdJQ0JoY0hCZmJHOWpZV3hmWjJWMFgyVjRDaUFnSUNCaWRYSjVJREVLSUNBZ0lDOHZJR1YyWlhKNWRHaHBibWN2WTI5dWRISmhZM1F1Y0hrNk5USUtJQ0FnSUM4dklHbG1JRzV2ZENCelpXNWtaWEpmYm1GdFpWOWxlR2x6ZEdWa09nb2dJQ0FnWW01NklISmxaMmx6ZEdWeVgyRm1kR1Z5WDJsbVgyVnNjMlZBTkFvZ0lDQWdMeThnWlhabGNubDBhR2x1Wnk5amIyNTBjbUZqZEM1d2VUbzFNd29nSUNBZ0x5OGdjMlZzWmk1amIzVnVkR1Z5SUNzOUlHMTFiSFJwY0d4cFkyRjBhWFpsWDJsa1pXNTBhWFI1S0NrZ0lDTWdhR0Z6SUdaMWJHd2dSblZ1WTBSbFpnb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1OdmRXNTBaWElpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVkyOTFiblJsY2lCbGVHbHpkSE1LSUNBZ0lDOHZJR1YyWlhKNWRHaHBibWN2YlhsZlltRnpaUzV3ZVRveU1Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUZWSmJuUTJOQ2d4S1FvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDOHZJR1YyWlhKNWRHaHBibWN2WTI5dWRISmhZM1F1Y0hrNk5UTUtJQ0FnSUM4dklITmxiR1l1WTI5MWJuUmxjaUFyUFNCdGRXeDBhWEJzYVdOaGRHbDJaVjlwWkdWdWRHbDBlU2dwSUNBaklHaGhjeUJtZFd4c0lFWjFibU5FWldZS0lDQWdJQ3NLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbU52ZFc1MFpYSWlDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9LY21WbmFYTjBaWEpmWVdaMFpYSmZhV1pmWld4elpVQTBPZ29nSUNBZ0x5OGdaWFpsY25sMGFHbHVaeTlqYjI1MGNtRmpkQzV3ZVRvMU5Bb2dJQ0FnTHk4Z2MyVnNaaTV1WVcxbFd6QmRJRDBnYm1GdFpRb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0o1ZEdWalh6SWdMeThnSW01aGJXVWlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdGd2NGOXNiMk5oYkY5d2RYUUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklIUmxjM1JmWTJGelpYTXVaWFpsY25sMGFHbHVaeTVqYjI1MGNtRmpkQzVGZG1WeWVYUm9hVzVuTG5OaGVWOW9aV3hzYnlncElDMCtJR0o1ZEdWek9ncHpZWGxmYUdWc2JHODZDaUFnSUNBdkx5QmxkbVZ5ZVhSb2FXNW5MMk52Ym5SeVlXTjBMbkI1T2pVMkxUVTNDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtDaUFnSUNBdkx5QmtaV1lnYzJGNVgyaGxiR3h2S0hObGJHWXBJQzArSUZOMGNtbHVaem9LSUNBZ0lIQnliM1J2SURBZ01Rb2dJQ0FnTHk4Z1pYWmxjbmwwYUdsdVp5OWpiMjUwY21GamRDNXdlVG8zT1FvZ0lDQWdMeThnWVhOelpYSjBJRzl3TGxSNGJpNXpaVzVrWlhJZ0lUMGdaMlYwWDJKaGJtNWxaQ2dwTENBaVdXOTFJR0Z5WlNCaVlXNXVaV1FzSUdkdmIyUmllV1VpQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QmxkbVZ5ZVhSb2FXNW5MMk52Ym5SeVlXTjBMbkI1T2pJMUNpQWdJQ0F2THlCaFpHUnlJRDBnUVdOamIzVnVkQ2hDUVU1T1JVUXBDaUFnSUNCaWVYUmxZMTh4SUM4dklHRmtaSElnVmtOTlNrdFhUMWsxVURWUU4xTkxUVnBHUms5RFJWSlBVRXBEV2s5VVNVcE5Ua2xaVGxWRFMwZzNURkpQTkRWS1RVcFFObFZaUWtsS1FRb2dJQ0FnTHk4Z1pYWmxjbmwwYUdsdVp5OWpiMjUwY21GamRDNXdlVG8zT1FvZ0lDQWdMeThnWVhOelpYSjBJRzl3TGxSNGJpNXpaVzVrWlhJZ0lUMGdaMlYwWDJKaGJtNWxaQ2dwTENBaVdXOTFJR0Z5WlNCaVlXNXVaV1FzSUdkdmIyUmllV1VpQ2lBZ0lDQWhQUW9nSUNBZ1lYTnpaWEowSUM4dklGbHZkU0JoY21VZ1ltRnVibVZrTENCbmIyOWtZbmxsQ2lBZ0lDQXZMeUJsZG1WeWVYUm9hVzVuTDJOdmJuUnlZV04wTG5CNU9qVTVDaUFnSUNBdkx5QnVZVzFsTENCbGVHbHpkSE1nUFNCelpXeG1MbTVoYldVdWJXRjVZbVVvWVdOamIzVnVkRDB3S1FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHUjFjQW9nSUNBZ1lubDBaV05mTWlBdkx5QWlibUZ0WlNJS0lDQWdJR0Z3Y0Y5c2IyTmhiRjluWlhSZlpYZ0tJQ0FnSUM4dklHVjJaWEo1ZEdocGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TmpBS0lDQWdJQzh2SUdsbUlHNXZkQ0JsZUdsemRITTZDaUFnSUNCaWJub2djMkY1WDJobGJHeHZYMkZtZEdWeVgybG1YMlZzYzJWQU1nb2dJQ0FnTHk4Z1pYWmxjbmwwYUdsdVp5OWpiMjUwY21GamRDNXdlVG8yTVFvZ0lDQWdMeThnY21WMGRYSnVJRk4wY21sdVp5Z2lTRzkzWkhrZ2MzUnlZVzVuWlhJaElpa0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdNR1kwT0RabU56YzJORGM1TWpBM016YzBOekkyTVRabE5qYzJOVGN5TWpFS0lDQWdJSE4zWVhBS0lDQWdJSEpsZEhOMVlnb0tjMkY1WDJobGJHeHZYMkZtZEdWeVgybG1YMlZzYzJWQU1qb0tJQ0FnSUM4dklHVjJaWEo1ZEdocGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TmpJS0lDQWdJQzh2SUhKbGRIVnliaUFpU0dWc2JHOHNJQ0lnS3lCdVlXMWxJQ3NnSWlFaUNpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRFE0TmpVMll6WmpObVl5WXpJd0NpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TWpFS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhSbGMzUmZZMkZ6WlhNdVpYWmxjbmwwYUdsdVp5NWpiMjUwY21GamRDNUZkbVZ5ZVhSb2FXNW5MbU5oYkdOMWJHRjBaU2hoT2lCaWVYUmxjeXdnWWpvZ1lubDBaWE1wSUMwK0lHSjVkR1Z6T2dwallXeGpkV3hoZEdVNkNpQWdJQ0F2THlCbGRtVnllWFJvYVc1bkwyTnZiblJ5WVdOMExuQjVPalkwTFRZMUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0NpQWdJQ0F2THlCa1pXWWdZMkZzWTNWc1lYUmxLSE5sYkdZc0lHRTZJR0Z5WXpSZlZVbHVkRFkwTENCaU9pQmhjbU0wWDFWSmJuUTJOQ2tnTFQ0Z1lYSmpORjlWU1c1ME5qUTZDaUFnSUNCd2NtOTBieUF5SURFS0lDQWdJQzh2SUdWMlpYSjVkR2hwYm1jdmJYbGZZbUZ6WlM1d2VUb3hOUW9nSUNBZ0x5OGdjbVYwZFhKdUlHRnlZelF1VlVsdWREWTBLR0V1Ym1GMGFYWmxJQ3NnWWk1dVlYUnBkbVVwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHSjBiMmtLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1luUnZhUW9nSUNBZ2MzZGhjQW9nSUNBZ1pHbG5JREVLSUNBZ0lDc0tJQ0FnSUdsMGIySUtJQ0FnSUM4dklHVjJaWEo1ZEdocGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TmpjS0lDQWdJQzh2SUhKbGRIVnliaUJoY21NMFgxVkpiblEyTkNoakxtNWhkR2wyWlNBcUlHSXVibUYwYVhabEtRb2dJQ0FnWW5SdmFRb2dJQ0FnS2dvZ0lDQWdhWFJ2WWdvZ0lDQWdjbVYwYzNWaUNnb0tMeThnZEdWemRGOWpZWE5sY3k1bGRtVnllWFJvYVc1bkxtTnZiblJ5WVdOMExrVjJaWEo1ZEdocGJtY3VZMnh2YzJWZmIzVjBLQ2tnTFQ0Z2RtOXBaRG9LWTJ4dmMyVmZiM1YwT2dvZ0lDQWdMeThnWlhabGNubDBhR2x1Wnk5amIyNTBjbUZqZEM1d2VUbzRNd29nSUNBZ0x5OGdjMlZzWmk1amIzVnVkR1Z5SUMwOUlIQnZjMmwwYVhabFgyOXVaU2dwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZMjkxYm5SbGNpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVqYjNWdWRHVnlJR1Y0YVhOMGN3b2dJQ0FnTHk4Z1pYWmxjbmwwYUdsdVp5OWpiMjUwY21GamRDNXdlVG80T0FvZ0lDQWdMeThnY21WMGRYSnVJRlZKYm5RMk5DZ3hLUW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUM4dklHVjJaWEo1ZEdocGJtY3ZZMjl1ZEhKaFkzUXVjSGs2T0RNS0lDQWdJQzh2SUhObGJHWXVZMjkxYm5SbGNpQXRQU0J3YjNOcGRHbDJaVjl2Ym1Vb0tRb2dJQ0FnTFFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWTI5MWJuUmxjaUlLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQnlaWFJ6ZFdJSyIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCMFpYTjBYMk5oYzJWekxtVjJaWEo1ZEdocGJtY3VZMjl1ZEhKaFkzUXVSWFpsY25sMGFHbHVaeTVqYkdWaGNsOXpkR0YwWlY5d2NtOW5jbUZ0S0NrZ0xUNGdkV2x1ZERZME9ncHRZV2x1T2dvZ0lDQWdZbmwwWldOaWJHOWpheUFpWTI5MWJuUmxjaUlLSUNBZ0lDOHZJR1YyWlhKNWRHaHBibWN2WTI5dWRISmhZM1F1Y0hrNk9ETUtJQ0FnSUM4dklITmxiR1l1WTI5MWJuUmxjaUF0UFNCd2IzTnBkR2wyWlY5dmJtVW9LUW9nSUNBZ2NIVnphR2x1ZENBd0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbU52ZFc1MFpYSWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WTI5MWJuUmxjaUJsZUdsemRITUtJQ0FnSUM4dklHVjJaWEo1ZEdocGJtY3ZZMjl1ZEhKaFkzUXVjSGs2T0RnS0lDQWdJQzh2SUhKbGRIVnliaUJWU1c1ME5qUW9NU2tLSUNBZ0lIQjFjMmhwYm5RZ01TQXZMeUF4Q2lBZ0lDQXZMeUJsZG1WeWVYUm9hVzVuTDJOdmJuUnlZV04wTG5CNU9qZ3pDaUFnSUNBdkx5QnpaV3htTG1OdmRXNTBaWElnTFQwZ2NHOXphWFJwZG1WZmIyNWxLQ2tLSUNBZ0lDMEtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltTnZkVzUwWlhJaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z1pYWmxjbmwwYUdsdVp5OWpiMjUwY21GamRDNXdlVG8zTlFvZ0lDQWdMeThnY21WMGRYSnVJRlJ5ZFdVS0lDQWdJSEIxYzJocGJuUWdNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEsifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFDQVFBbUJBZGpiM1Z1ZEdWeUlLaVlsVm5ZNi9yL3lVekpTdUVTTG5wRmwwMEpZMUdHMEVvLzF4ZHpxV0pmQkc1aGJXVUVGUjk4ZFRFYlFRQXFnZ1VFVEZ4aHVnUzlZSm5sQkYxY2hNY0UvUWNtVGdRV1dLb3ZOaG9BamdVQVNRQTJBQ1lBRUFBQ0kwTXhHWUVDRWtReEdFU0lBT01pUXpFWkZFUXhHRVEyR2dFMkdnS0lBTDhyVEZDd0lrTXhHUlJFTVJoRWlBQmlLMHhRc0NKRElqRVprSUVER2tReEdFUTJHZ0dJQUNRaVF6RVpGRVF4R0JSRWlBQUNJa014QUNrVFJJQUhZM0psWVhSdmNqRUFaeWdqWjRtS0FRQXhBQ2tUUkRFWkloSkJBQklqU1NwalJRRkFBQWtqS0dWRUlnZ29UR2NqS292L1pvbUtBQUV4QUNrVFJDTkpLbU5BQUJXQUVRQVBTRzkzWkhrZ2MzUnlZVzVuWlhJaFRJbUxBRmNDQUlBSFNHVnNiRzhzSUV4UVNSVVdWd1lDVEZCWEFnQ0FBU0ZRU1JVV1Z3WUNURkJNaVlvQ0FZditGNHYvRjB4TEFRZ1dGd3NXaVNNb1pVUWlDU2hNWjRrPSIsImNsZWFyIjoiQ2lZQkIyTnZkVzUwWlhLQkFDaGxSSUVCQ1NoTVo0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjk5LCJtaW5vciI6OTksInBhdGNoIjo5OSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
