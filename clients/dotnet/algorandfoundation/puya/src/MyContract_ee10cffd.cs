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

namespace Arc56.Generated.algorandfoundation.puya.MyContract_ee10cffd
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTXlDb250cmFjdCIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVnaXN0ZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmFtZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiLCJPcHRJbiJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNheV9oZWxsbyIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNhbGN1bGF0ZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJiIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2xvc2Vfb3V0IiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiQ2xvc2VPdXQiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MSwiYnl0ZXMiOjF9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MX19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzE1NSwxOTAsMjI3XSwiZXJyb3JNZXNzYWdlIjoiWW91IGFyZSBiYW5uZWQsIGdvb2RieWUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMTAsMzQ0XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5jb3VudGVyIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE3OSwyNjddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxODVdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzE2LDMyNF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W3sicGMiOlsxNV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuY291bnRlciBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBeElEQWdNaUE0Q2lBZ0lDQmllWFJsWTJKc2IyTnJJQ0pqYjNWdWRHVnlJaUJpWVhObE16SW9Wa05OU2t0WFQxazFVRFZRTjFOTFRWcEdSazlEUlZKUFVFcERXazlVU1VwTlRrbFpUbFZEUzBnM1RGSlBORFZLVFVwUVVTa2dJbTVoYldVaUlEQjRNVFV4Wmpkak56VUtJQ0FnSUM4dklHVjJaWEo1ZEdocGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TXpjS0lDQWdJQzh2SUdOc1lYTnpJRVYyWlhKNWRHaHBibWNvUVZKRE5FTnZiblJ5WVdOMExDQk5lVTFwWkdSc1pVSmhjMlVzSUc1aGJXVTlJazE1UTI5dWRISmhZM1FpS1RvS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhoaVpEWXdPVGxsTlNBd2VERTJOVGhoWVRKbUlDOHZJRzFsZEdodlpDQWljbVZuYVhOMFpYSW9jM1J5YVc1bktYWnZhV1FpTENCdFpYUm9iMlFnSW1Oc2IzTmxYMjkxZENncGRtOXBaQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUcxaGFXNWZjbVZuYVhOMFpYSmZjbTkxZEdWQU5DQnRZV2x1WDJOc2IzTmxYMjkxZEY5eWIzVjBaVUExQ2dwdFlXbHVYM04zYVhSamFGOWpZWE5sWDI1bGVIUkFOam9LSUNBZ0lDOHZJR1YyWlhKNWRHaHBibWN2WTI5dWRISmhZM1F1Y0hrNk16Y0tJQ0FnSUM4dklHTnNZWE56SUVWMlpYSjVkR2hwYm1jb1FWSkRORU52Ym5SeVlXTjBMQ0JOZVUxcFpHUnNaVUpoYzJVc0lHNWhiV1U5SWsxNVEyOXVkSEpoWTNRaUtUb0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0o2SUcxaGFXNWZZM0psWVhSbFgwNXZUM0JBTVRFS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhnMVpEVmpPRFJqTnlBd2VHWmtNRGN5TmpSbElDOHZJRzFsZEdodlpDQWljMkY1WDJobGJHeHZLQ2x6ZEhKcGJtY2lMQ0J0WlhSb2IyUWdJbU5oYkdOMWJHRjBaU2gxYVc1ME5qUXNkV2x1ZERZMEtYVnBiblEyTkNJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lITmhlVjlvWld4c2J5QmpZV3hqZFd4aGRHVUtJQ0FnSUdWeWNnb0tiV0ZwYmw5amNtVmhkR1ZmVG05UGNFQXhNVG9LSUNBZ0lDOHZJR1YyWlhKNWRHaHBibWN2WTI5dWRISmhZM1F1Y0hrNk16Y0tJQ0FnSUM4dklHTnNZWE56SUVWMlpYSjVkR2hwYm1jb1FWSkRORU52Ym5SeVlXTjBMQ0JOZVUxcFpHUnNaVUpoYzJVc0lHNWhiV1U5SWsxNVEyOXVkSEpoWTNRaUtUb0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEUmpOV00yTVdKaElDOHZJRzFsZEdodlpDQWlZM0psWVhSbEtDbDJiMmxrSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ1kzSmxZWFJsQ2lBZ0lDQmxjbklLQ20xaGFXNWZZMnh2YzJWZmIzVjBYM0p2ZFhSbFFEVTZDaUFnSUNBdkx5QmxkbVZ5ZVhSb2FXNW5MMk52Ym5SeVlXTjBMbkI1T2pZNUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tHRnNiRzkzWDJGamRHbHZibk05V3lKRGJHOXpaVTkxZENKZEtRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ2FXNTBZMTh5SUM4dklFTnNiM05sVDNWMENpQWdJQ0E5UFFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUNZbUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUdJZ1kyeHZjMlZmYjNWMENncHRZV2x1WDNKbFoybHpkR1Z5WDNKdmRYUmxRRFE2Q2lBZ0lDQXZMeUJsZG1WeWVYUm9hVzVuTDJOdmJuUnlZV04wTG5CNU9qUTNDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLR0ZzYkc5M1gyRmpkR2x2Ym5NOVd5Sk9iMDl3SWl3Z0lrOXdkRWx1SWwwcENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnYzJoc0NpQWdJQ0J3ZFhOb2FXNTBJRE1LSUNBZ0lDWUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQW1KZ29nSUNBZ1lYTnpaWEowQ2lBZ0lDQmlJSEpsWjJsemRHVnlDZ29LTHk4Z2RHVnpkRjlqWVhObGN5NWxkbVZ5ZVhSb2FXNW5MbU52Ym5SeVlXTjBMa1YyWlhKNWRHaHBibWN1WTNKbFlYUmxXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWTNKbFlYUmxPZ29nSUNBZ0x5OGdaWFpsY25sMGFHbHVaeTlqYjI1MGNtRmpkQzV3ZVRvM09Rb2dJQ0FnTHk4Z1lYTnpaWEowSUc5d0xsUjRiaTV6Wlc1a1pYSWdJVDBnWjJWMFgySmhibTVsWkNncExDQWlXVzkxSUdGeVpTQmlZVzV1WldRc0lHZHZiMlJpZVdVaUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQXZMeUJsZG1WeWVYUm9hVzVuTDJOdmJuUnlZV04wTG5CNU9qSTFDaUFnSUNBdkx5QmhaR1J5SUQwZ1FXTmpiM1Z1ZENoQ1FVNU9SVVFwQ2lBZ0lDQmllWFJsWTE4eElDOHZJR0ZrWkhJZ1ZrTk5Ta3RYVDFrMVVEVlFOMU5MVFZwR1JrOURSVkpQVUVwRFdrOVVTVXBOVGtsWlRsVkRTMGczVEZKUE5EVktUVXBRTmxWWlFrbEtRUW9nSUNBZ0x5OGdaWFpsY25sMGFHbHVaeTlqYjI1MGNtRmpkQzV3ZVRvM09Rb2dJQ0FnTHk4Z1lYTnpaWEowSUc5d0xsUjRiaTV6Wlc1a1pYSWdJVDBnWjJWMFgySmhibTVsWkNncExDQWlXVzkxSUdGeVpTQmlZVzV1WldRc0lHZHZiMlJpZVdVaUNpQWdJQ0FoUFFvZ0lDQWdZWE56WlhKMElDOHZJRmx2ZFNCaGNtVWdZbUZ1Ym1Wa0xDQm5iMjlrWW5sbENpQWdJQ0F2THlCbGRtVnllWFJvYVc1bkwyMTVYMkpoYzJVdWNIazZPUW9nSUNBZ0x5OGdjMlZzWmk1amNtVmhkRzl5SUQwZ2IzQXVWSGh1TG5ObGJtUmxjZ29nSUNBZ2NIVnphR0o1ZEdWeklDSmpjbVZoZEc5eUlnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUdWMlpYSjVkR2hwYm1jdlkyOXVkSEpoWTNRdWNIazZORFVLSUNBZ0lDOHZJSE5sYkdZdVkyOTFiblJsY2lBOUlGVkpiblEyTkNoYVJWSlBLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZMjkxYm5SbGNpSUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z1pYWmxjbmwwYUdsdVp5OWpiMjUwY21GamRDNXdlVG8wTVFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoamNtVmhkR1U5SW5KbGNYVnBjbVVpS1FvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSZlkyRnpaWE11WlhabGNubDBhR2x1Wnk1amIyNTBjbUZqZEM1RmRtVnllWFJvYVc1bkxuSmxaMmx6ZEdWeVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjbVZuYVhOMFpYSTZDaUFnSUNBdkx5QmxkbVZ5ZVhSb2FXNW5MMk52Ym5SeVlXTjBMbkI1T2pRM0NpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tHRnNiRzkzWDJGamRHbHZibk05V3lKT2IwOXdJaXdnSWs5d2RFbHVJbDBwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEJ1SURJS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdjM2RoY0FvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lDOHZJR1YyWlhKNWRHaHBibWN2WTI5dWRISmhZM1F1Y0hrNk56a0tJQ0FnSUM4dklHRnpjMlZ5ZENCdmNDNVVlRzR1YzJWdVpHVnlJQ0U5SUdkbGRGOWlZVzV1WldRb0tTd2dJbGx2ZFNCaGNtVWdZbUZ1Ym1Wa0xDQm5iMjlrWW5sbElnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnWlhabGNubDBhR2x1Wnk5amIyNTBjbUZqZEM1d2VUb3lOUW9nSUNBZ0x5OGdZV1JrY2lBOUlFRmpZMjkxYm5Rb1FrRk9Ua1ZFS1FvZ0lDQWdZbmwwWldOZk1TQXZMeUJoWkdSeUlGWkRUVXBMVjA5Wk5WQTFVRGRUUzAxYVJrWlBRMFZTVDFCS1ExcFBWRWxLVFU1SldVNVZRMHRJTjB4U1R6UTFTazFLVURaVldVSkpTa0VLSUNBZ0lDOHZJR1YyWlhKNWRHaHBibWN2WTI5dWRISmhZM1F1Y0hrNk56a0tJQ0FnSUM4dklHRnpjMlZ5ZENCdmNDNVVlRzR1YzJWdVpHVnlJQ0U5SUdkbGRGOWlZVzV1WldRb0tTd2dJbGx2ZFNCaGNtVWdZbUZ1Ym1Wa0xDQm5iMjlrWW5sbElnb2dJQ0FnSVQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJaYjNVZ1lYSmxJR0poYm01bFpDd2daMjl2WkdKNVpRb2dJQ0FnTHk4Z1pYWmxjbmwwYUdsdVp5OWpiMjUwY21GamRDNXdlVG8xTUFvZ0lDQWdMeThnYVdZZ2IzQXVWSGh1TG05dVgyTnZiWEJzWlhScGIyNGdQVDBnVDI1RGIyMXdiR1YwWlVGamRHbHZiaTVQY0hSSmJqb0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lHbHVkR05mTUNBdkx5QlBjSFJKYmdvZ0lDQWdQVDBLSUNBZ0lHSjZJSEpsWjJsemRHVnlYMkZtZEdWeVgybG1YMlZzYzJWQU5Rb2dJQ0FnTHk4Z1pYWmxjbmwwYUdsdVp5OWpiMjUwY21GamRDNXdlVG8xTVFvZ0lDQWdMeThnYzJWdVpHVnlYMjVoYldVc0lITmxibVJsY2w5dVlXMWxYMlY0YVhOMFpXUWdQU0J6Wld4bUxtNWhiV1V1YldGNVltVW9ZV05qYjNWdWREMHdLUW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdSMWNBb2dJQ0FnWW5sMFpXTmZNaUF2THlBaWJtRnRaU0lLSUNBZ0lHRndjRjlzYjJOaGJGOW5aWFJmWlhnS0lDQWdJR0oxY25rZ01Rb2dJQ0FnTHk4Z1pYWmxjbmwwYUdsdVp5OWpiMjUwY21GamRDNXdlVG8xTWdvZ0lDQWdMeThnYVdZZ2JtOTBJSE5sYm1SbGNsOXVZVzFsWDJWNGFYTjBaV1E2Q2lBZ0lDQmlibm9nY21WbmFYTjBaWEpmWVdaMFpYSmZhV1pmWld4elpVQTFDaUFnSUNBdkx5QmxkbVZ5ZVhSb2FXNW5MMk52Ym5SeVlXTjBMbkI1T2pVekNpQWdJQ0F2THlCelpXeG1MbU52ZFc1MFpYSWdLejBnYlhWc2RHbHdiR2xqWVhScGRtVmZhV1JsYm5ScGRIa29LU0FnSXlCb1lYTWdablZzYkNCR2RXNWpSR1ZtQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZMjkxYm5SbGNpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVqYjNWdWRHVnlJR1Y0YVhOMGN3b2dJQ0FnTHk4Z1pYWmxjbmwwYUdsdVp5OXRlVjlpWVhObExuQjVPakl3Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdWVWx1ZERZMEtERXBDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnTHk4Z1pYWmxjbmwwYUdsdVp5OWpiMjUwY21GamRDNXdlVG8xTXdvZ0lDQWdMeThnYzJWc1ppNWpiM1Z1ZEdWeUlDczlJRzExYkhScGNHeHBZMkYwYVhabFgybGtaVzUwYVhSNUtDa2dJQ01nYUdGeklHWjFiR3dnUm5WdVkwUmxaZ29nSUNBZ0t3b2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVkyOTFiblJsY2lJS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENncHlaV2RwYzNSbGNsOWhablJsY2w5cFpsOWxiSE5sUURVNkNpQWdJQ0F2THlCbGRtVnllWFJvYVc1bkwyTnZiblJ5WVdOMExuQjVPalUwQ2lBZ0lDQXZMeUJ6Wld4bUxtNWhiV1ZiTUYwZ1BTQnVZVzFsQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1lubDBaV05mTWlBdkx5QWlibUZ0WlNJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1lYQndYMnh2WTJGc1gzQjFkQW9nSUNBZ0x5OGdaWFpsY25sMGFHbHVaeTlqYjI1MGNtRmpkQzV3ZVRvME53b2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaGhiR3h2ZDE5aFkzUnBiMjV6UFZzaVRtOVBjQ0lzSUNKUGNIUkpiaUpkS1FvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSZlkyRnpaWE11WlhabGNubDBhR2x1Wnk1amIyNTBjbUZqZEM1RmRtVnllWFJvYVc1bkxuTmhlVjlvWld4c2IxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbk5oZVY5b1pXeHNiem9LSUNBZ0lDOHZJR1YyWlhKNWRHaHBibWN2WTI5dWRISmhZM1F1Y0hrNk56a0tJQ0FnSUM4dklHRnpjMlZ5ZENCdmNDNVVlRzR1YzJWdVpHVnlJQ0U5SUdkbGRGOWlZVzV1WldRb0tTd2dJbGx2ZFNCaGNtVWdZbUZ1Ym1Wa0xDQm5iMjlrWW5sbElnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnWlhabGNubDBhR2x1Wnk5amIyNTBjbUZqZEM1d2VUb3lOUW9nSUNBZ0x5OGdZV1JrY2lBOUlFRmpZMjkxYm5Rb1FrRk9Ua1ZFS1FvZ0lDQWdZbmwwWldOZk1TQXZMeUJoWkdSeUlGWkRUVXBMVjA5Wk5WQTFVRGRUUzAxYVJrWlBRMFZTVDFCS1ExcFBWRWxLVFU1SldVNVZRMHRJTjB4U1R6UTFTazFLVURaVldVSkpTa0VLSUNBZ0lDOHZJR1YyWlhKNWRHaHBibWN2WTI5dWRISmhZM1F1Y0hrNk56a0tJQ0FnSUM4dklHRnpjMlZ5ZENCdmNDNVVlRzR1YzJWdVpHVnlJQ0U5SUdkbGRGOWlZVzV1WldRb0tTd2dJbGx2ZFNCaGNtVWdZbUZ1Ym1Wa0xDQm5iMjlrWW5sbElnb2dJQ0FnSVQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJaYjNVZ1lYSmxJR0poYm01bFpDd2daMjl2WkdKNVpRb2dJQ0FnTHk4Z1pYWmxjbmwwYUdsdVp5OWpiMjUwY21GamRDNXdlVG8xT1FvZ0lDQWdMeThnYm1GdFpTd2daWGhwYzNSeklEMGdjMlZzWmk1dVlXMWxMbTFoZVdKbEtHRmpZMjkxYm5ROU1Da0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JrZFhBS0lDQWdJR0o1ZEdWalh6SWdMeThnSW01aGJXVWlDaUFnSUNCaGNIQmZiRzlqWVd4ZloyVjBYMlY0Q2lBZ0lDQXZMeUJsZG1WeWVYUm9hVzVuTDJOdmJuUnlZV04wTG5CNU9qWXdDaUFnSUNBdkx5QnBaaUJ1YjNRZ1pYaHBjM1J6T2dvZ0lDQWdZbTU2SUhOaGVWOW9aV3hzYjE5aFpuUmxjbDlwWmw5bGJITmxRRE1LSUNBZ0lIQnZjQW9nSUNBZ0x5OGdaWFpsY25sMGFHbHVaeTlqYjI1MGNtRmpkQzV3ZVRvMk1Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUZOMGNtbHVaeWdpU0c5M1pIa2djM1J5WVc1blpYSWhJaWtLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3TUdZME9EWm1OemMyTkRjNU1qQTNNemMwTnpJMk1UWmxOamMyTlRjeU1qRUtDbk5oZVY5b1pXeHNiMTloWm5SbGNsOXBibXhwYm1Wa1gzUmxjM1JmWTJGelpYTXVaWFpsY25sMGFHbHVaeTVqYjI1MGNtRmpkQzVGZG1WeWVYUm9hVzVuTG5OaGVWOW9aV3hzYjBBME9nb2dJQ0FnTHk4Z1pYWmxjbmwwYUdsdVp5OWpiMjUwY21GamRDNXdlVG8xTmdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkFvZ0lDQWdZbmwwWldOZk15QXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2MyRjVYMmhsYkd4dlgyRm1kR1Z5WDJsbVgyVnNjMlZBTXpvS0lDQWdJQzh2SUdWMlpYSjVkR2hwYm1jdlkyOXVkSEpoWTNRdWNIazZOaklLSUNBZ0lDOHZJSEpsZEhWeWJpQWlTR1ZzYkc4c0lDSWdLeUJ1WVcxbElDc2dJaUVpQ2lBZ0lDQmtkWEFLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCemQyRndDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdjSFZ6YUdsdWRDQTNDaUFnSUNBckNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTUFvZ0lDQWdMeThnWlhabGNubDBhR2x1Wnk5amIyNTBjbUZqZEM1d2VUbzJNZ29nSUNBZ0x5OGdjbVYwZFhKdUlDSklaV3hzYnl3Z0lpQXJJRzVoYldVZ0t5QWlJU0lLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3TURjME9EWTFObU0yWXpabU1tTXlNQW9nSUNBZ2MzZGhjQW9nSUNBZ2NtVndiR0ZqWlRJZ01Bb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnTHk4Z1pYWmxjbmwwYUdsdVp5OWpiMjUwY21GamRDNXdlVG8yTWdvZ0lDQWdMeThnY21WMGRYSnVJQ0pJWld4c2J5d2dJaUFySUc1aGJXVWdLeUFpSVNJS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01Bb2dJQ0FnY21Wd2JHRmpaVElnTUFvZ0lDQWdMeThnWlhabGNubDBhR2x1Wnk5amIyNTBjbUZqZEM1d2VUbzJNZ29nSUNBZ0x5OGdjbVYwZFhKdUlDSklaV3hzYnl3Z0lpQXJJRzVoYldVZ0t5QWlJU0lLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREl4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUdWMlpYSjVkR2hwYm1jdlkyOXVkSEpoWTNRdWNIazZOVFlLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFLSUNBZ0lHSWdjMkY1WDJobGJHeHZYMkZtZEdWeVgybHViR2x1WldSZmRHVnpkRjlqWVhObGN5NWxkbVZ5ZVhSb2FXNW5MbU52Ym5SeVlXTjBMa1YyWlhKNWRHaHBibWN1YzJGNVgyaGxiR3h2UURRS0Nnb3ZMeUIwWlhOMFgyTmhjMlZ6TG1WMlpYSjVkR2hwYm1jdVkyOXVkSEpoWTNRdVJYWmxjbmwwYUdsdVp5NWpZV3hqZFd4aGRHVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BqWVd4amRXeGhkR1U2Q2lBZ0lDQXZMeUJsZG1WeWVYUm9hVzVuTDJOdmJuUnlZV04wTG5CNU9qWTBDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0F2THlCbGRtVnllWFJvYVc1bkwyMTVYMkpoYzJVdWNIazZNVFVLSUNBZ0lDOHZJSEpsZEhWeWJpQmhjbU0wTGxWSmJuUTJOQ2hoTG1GelgzVnBiblEyTkNncElDc2dZaTVoYzE5MWFXNTBOalFvS1NrS0lDQWdJSE4zWVhBS0lDQWdJR0owYjJrS0lDQWdJSE4zWVhBS0lDQWdJR0owYjJrS0lDQWdJSE4zWVhBS0lDQWdJR1JwWnlBeENpQWdJQ0FyQ2lBZ0lDQXZMeUJsZG1WeWVYUm9hVzVuTDJOdmJuUnlZV04wTG5CNU9qWTNDaUFnSUNBdkx5QnlaWFIxY200Z1lYSmpORjlWU1c1ME5qUW9ZeTVoYzE5MWFXNTBOalFvS1NBcUlHSXVZWE5mZFdsdWREWTBLQ2twQ2lBZ0lDQXFDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QmxkbVZ5ZVhSb2FXNW5MMk52Ym5SeVlXTjBMbkI1T2pZMENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0NpQWdJQ0JpZVhSbFkxOHpJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRGOWpZWE5sY3k1bGRtVnllWFJvYVc1bkxtTnZiblJ5WVdOMExrVjJaWEo1ZEdocGJtY3VZMnh2YzJWZmIzVjBXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWTJ4dmMyVmZiM1YwT2dvZ0lDQWdMeThnWlhabGNubDBhR2x1Wnk5amIyNTBjbUZqZEM1d2VUbzRNd29nSUNBZ0x5OGdjMlZzWmk1amIzVnVkR1Z5SUMwOUlIQnZjMmwwYVhabFgyOXVaU2dwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZMjkxYm5SbGNpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVqYjNWdWRHVnlJR1Y0YVhOMGN3b2dJQ0FnTHk4Z1pYWmxjbmwwYUdsdVp5OWpiMjUwY21GamRDNXdlVG80T0FvZ0lDQWdMeThnY21WMGRYSnVJRlZKYm5RMk5DZ3hLUW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUM4dklHVjJaWEo1ZEdocGJtY3ZZMjl1ZEhKaFkzUXVjSGs2T0RNS0lDQWdJQzh2SUhObGJHWXVZMjkxYm5SbGNpQXRQU0J3YjNOcGRHbDJaVjl2Ym1Vb0tRb2dJQ0FnTFFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWTI5MWJuUmxjaUlLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJsZG1WeWVYUm9hVzVuTDJOdmJuUnlZV04wTG5CNU9qWTVDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLR0ZzYkc5M1gyRmpkR2x2Ym5NOVd5SkRiRzl6WlU5MWRDSmRLUW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ289IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUIwWlhOMFgyTmhjMlZ6TG1WMlpYSjVkR2hwYm1jdVkyOXVkSEpoWTNRdVJYWmxjbmwwYUdsdVp5NWpiR1ZoY2w5emRHRjBaVjl3Y205bmNtRnRLQ2tnTFQ0Z2RXbHVkRFkwT2dwdFlXbHVPZ29nSUNBZ1lubDBaV05pYkc5amF5QWlZMjkxYm5SbGNpSUtJQ0FnSUM4dklHVjJaWEo1ZEdocGJtY3ZZMjl1ZEhKaFkzUXVjSGs2T0RNS0lDQWdJQzh2SUhObGJHWXVZMjkxYm5SbGNpQXRQU0J3YjNOcGRHbDJaVjl2Ym1Vb0tRb2dJQ0FnY0hWemFHbHVkQ0F3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0pqYjNWdWRHVnlJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1OdmRXNTBaWElnWlhocGMzUnpDaUFnSUNBdkx5QmxkbVZ5ZVhSb2FXNW5MMk52Ym5SeVlXTjBMbkI1T2pnNENpQWdJQ0F2THlCeVpYUjFjbTRnVlVsdWREWTBLREVwQ2lBZ0lDQndkWE5vYVc1MElERUtJQ0FnSUM4dklHVjJaWEo1ZEdocGJtY3ZZMjl1ZEhKaFkzUXVjSGs2T0RNS0lDQWdJQzh2SUhObGJHWXVZMjkxYm5SbGNpQXRQU0J3YjNOcGRHbDJaVjl2Ym1Vb0tRb2dJQ0FnTFFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWTI5MWJuUmxjaUlLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJsZG1WeWVYUm9hVzVuTDJOdmJuUnlZV04wTG5CNU9qYzFDaUFnSUNBdkx5QnlaWFIxY200Z1ZISjFaUW9nSUNBZ2NIVnphR2x1ZENBeENpQWdJQ0J5WlhSMWNtNEsifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFQVFBQ0NDWUVCMk52ZFc1MFpYSWdxSmlWV2Rqcit2L0pUTWxLNFJJdWVrV1hUUWxqVVliUVNqL1hGM09wWWw4RWJtRnRaUVFWSDN4MWdnSUV2V0NaNVFRV1dLb3ZOaG9BamdJQU9BQXRNUmtVUkRFWVFRQVdnZ0lFWFZ5RXh3VDlCeVpPTmhvQWpnSUFjQURHQUlBRVRGeGh1allhQUk0QkFCb0FNUmtrRWpFWUVFUkNBTXdpTVJtUWdRTWFNUmdRUkVJQUZqRUFLUk5FZ0FkamNtVmhkRzl5TVFCbktDTm5Ja00yR2dGSEFpTlpKQWhNRlJKRU1RQXBFMFF4R1NJU1FRQVNJMGtxWTBVQlFBQUpJeWhsUkNJSUtFeG5JeXBQQW1ZaVF6RUFLUk5FSTBrcVkwQUFHa2lBRVFBUFNHOTNaSGtnYzNSeVlXNW5aWEloSzB4UXNDSkRTVmNDQUV3aldZRUhDQlpYQmdDQUNRQUhTR1ZzYkc4c0lFeGNBRXhRU1NOWklnZ1dWd1lBWEFDQUFTRlFRdi9LTmhvQlNSVWxFa1EyR2dKSkZTVVNSRXdYVEJkTVN3RUlDeFlyVEZDd0lrTWpLR1ZFSWdrb1RHY2lRdz09IiwiY2xlYXIiOiJDeVlCQjJOdmRXNTBaWEtCQUNobFJJRUJDU2hNWjRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6OTksIm1pbm9yIjo5OSwicGF0Y2giOjk5LCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
