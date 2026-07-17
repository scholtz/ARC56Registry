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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.PoolManager__Helper19_e66a9eac
{


    //
    // Helper contract 19 for PoolManager
    //
    public class PoolManager__Helper19Proxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public PoolManager__Helper19Proxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///@notice Returns the index of the least significant bit of the number,
        ///     where the least significant bit is at index 0 and the most significant bit is at index 255
        /// @param x the value for which to compute the least significant bit, must be greater than 0
        /// @return r the index of the least significant bit
        ///</summary>
        /// <param name="x"> </param>
        public async Task<ulong> BitMathLeastSignificantBit(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 x, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 23, 238, 43, 124 };

            var result = await base.SimApp(new List<object> { abiHandle, x }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> BitMathLeastSignificantBit_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 x, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 23, 238, 43, 124 };

            return await base.MakeTransactionList(new List<object> { abiHandle, x }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IExttload
        ///</summary>
        /// <param name="slot"> </param>
        public async Task<byte[]> Exttload(byte[] slot, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 201, 123, 9, 197 };
            var slotAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); slotAbi.From(slot);

            var result = await base.SimApp(new List<object> { abiHandle, slotAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> Exttload_Transactions(byte[] slot, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 201, 123, 9, 197 };
            var slotAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); slotAbi.From(slot);

            return await base.MakeTransactionList(new List<object> { abiHandle, slotAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="o"> </param>
        /// <param name="p"> </param>
        /// <param name="s"> </param>
        public async Task Init(ulong o, ulong p, byte[] s, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 169, 110, 249, 137 };
            var oAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); oAbi.From(o);
            var pAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); pAbi.From(p);
            var sAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); sAbi.From(s);

            var result = await base.CallApp(new List<object> { abiHandle, oAbi, pAbi, sAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Init_Transactions(ulong o, ulong p, byte[] s, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 169, 110, 249, 137 };
            var oAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); oAbi.From(o);
            var pAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); pAbi.From(p);
            var sAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); sAbi.From(s);

            return await base.MakeTransactionList(new List<object> { abiHandle, oAbi, pAbi, sAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUG9vbE1hbmFnZXJfX0hlbHBlcjE5IiwiZGVzYyI6IkhlbHBlciBjb250cmFjdCAxOSBmb3IgUG9vbE1hbmFnZXIiLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoiQml0TWF0aC5sZWFzdFNpZ25pZmljYW50Qml0IiwiZGVzYyI6IkBub3RpY2UgUmV0dXJucyB0aGUgaW5kZXggb2YgdGhlIGxlYXN0IHNpZ25pZmljYW50IGJpdCBvZiB0aGUgbnVtYmVyLFxuICAgICB3aGVyZSB0aGUgbGVhc3Qgc2lnbmlmaWNhbnQgYml0IGlzIGF0IGluZGV4IDAgYW5kIHRoZSBtb3N0IHNpZ25pZmljYW50IGJpdCBpcyBhdCBpbmRleCAyNTVcbiBAcGFyYW0geCB0aGUgdmFsdWUgZm9yIHdoaWNoIHRvIGNvbXB1dGUgdGhlIGxlYXN0IHNpZ25pZmljYW50IGJpdCwgbXVzdCBiZSBncmVhdGVyIHRoYW4gMFxuIEByZXR1cm4gciB0aGUgaW5kZXggb2YgdGhlIGxlYXN0IHNpZ25pZmljYW50IGJpdCIsImFyZ3MiOlt7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoieCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZXh0dGxvYWQiLCJkZXNjIjoiQGluaGVyaXRkb2MgSUV4dHRsb2FkIiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2xvdCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJieXRlWzMyXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJfX2luaXRfXyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjoyLCJieXRlcyI6MX0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbNzE4XSwiZXJyb3JNZXNzYWdlIjoiaGVscGVyOiBhbHJlYWR5IGluaXRpYWxpemVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTkyXSwiZXJyb3JNZXNzYWdlIjoiaGVscGVyOiBtdXN0IGJlIGNhbGxlZCBpbiBncm91cCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYwN10sImVycm9yTWVzc2FnZSI6ImhlbHBlcjogc2VuZGVyIG1pc21hdGNoIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjAwXSwiZXJyb3JNZXNzYWdlIjoiaGVscGVyOiB1bmF1dGhvcml6ZWQgY2FsbGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjI0XSwiZXJyb3JNZXNzYWdlIjoiaGVscGVyOiB3cm9uZyBwcmV2IGNodW5rIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjM3XSwiZXJyb3JNZXNzYWdlIjoiaGVscGVyOiB3cm9uZyBwcmV2IG1ldGhvZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzcwMl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzcxMF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2NTldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMzI+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTgwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDI1NiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY4Niw2OTVdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmRXNXBjM2RoY0MxMk5DOWpiMjUwY21GamRITXZZMjl5WlM5UWIyOXNUV0Z1WVdkbGNpNXpiMnd1VUc5dmJFMWhibUZuWlhKZlgwaGxiSEJsY2pFNUxsOWZjSFY1WVY5aGNtTTBYM0p2ZFhSbGNsOWZLQ2tnTFQ0Z2RXbHVkRFkwT2dwdFlXbHVPZ29nSUNBZ2FXNTBZMkpzYjJOcklERWdPQ0F6TWlBd0NpQWdJQ0JpZVhSbFkySnNiMk5ySURCNE1ERXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdJREI0SURCNFpEYzJORFV6WlRBZ01IZ3haaUFpYnlJZ0luQWlJREI0TURBeFpqQmtNV1V4TURCak1XUXdOekJtTURrd1lqRTVNVE14WXpFM01EWXdNVEJsTVRFd09EQmhNV0V4TkRFNE1ESXhNakZpTVRVd016RTJNRFF3TlNBd2VERTFNV1kzWXpjMUNpQWdJQ0JpSUY5ZmNIVjVZVjloY21NMFgzSnZkWFJsY2w5ZkNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMM1Z1YVhOM1lYQXRkalF2WTI5dWRISmhZM1J6TDJOdmNtVXZVRzl2YkUxaGJtRm5aWEl1YzI5c0xrSnBkRTFoZEdndWJHVmhjM1JUYVdkdWFXWnBZMkZ1ZEVKcGRDaDRPaUJpZVhSbGN5a2dMVDRnZFdsdWREWTBPZ3BDYVhSTllYUm9MbXhsWVhOMFUybG5ibWxtYVdOaGJuUkNhWFE2Q2lBZ0lDQndjbTkwYnlBeElERUtJQ0FnSUdsdWRHTmZNeUF2THlBd0NpQWdJQ0JrZFhCdUlETUtJQ0FnSUdsMGIySUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWWp3S0lDQWdJR0Z6YzJWeWRBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEQXhNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaUxRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEQXhNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lpVUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWWlZS0lDQWdJR1p5WVcxbFgySjFjbmtnTFRFS0lDQWdJR2x1ZEdOZk1TQXZMeUE0Q2lBZ0lDQmllbVZ5YndvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lHSjZaWEp2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlR0kyWkdJMlpHSTJaR1JrWkdSa1pHUmtNelJrTXpSa016UTVNalE1TWpRNU1qRXdPRFF5TVRBNFl6WXpNVGhqTmpNNVkyVTNNemxqWm1abVptWm1abVlLSUNBZ0lHSXFDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNREV3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmlKUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNRFF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lpOEtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EUUtJQ0FnSUdJcUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1ERXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCaUpRb2dJQ0FnWkdsbklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBNENpQWdJQ0F0Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdjSFZ6YUdsdWRDQXlOVFlLSUNBZ0lDVUtJQ0FnSUhCMWMyaHBiblFnTWpVMUNpQWdJQ0J6ZDJGd0NpQWdJQ0F0Q2lBZ0lDQmthV2NnTVFvZ0lDQWdjM2RoY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lITmxkR0pwZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0T0RBME1EUXdOVFUwTXpBd05USTJOalEwTXpJd01EQXdOVEF5TURZeE1EWTNOREExTXpBeU5qQXlNREF3TURFd056VXdOakl3TURFM05qRXhOekEzTndvZ0lDQWdZaW9LSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd3TVRBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR0lsQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd4TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmlMd29nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXlNQW9nSUNBZ1lpb0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3dNVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHSWxDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUE0Q2lBZ0lDQXRDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1pIVndDaUFnSUNCcGRHOWlDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQndkWE5vYVc1MElESTFOZ29nSUNBZ0pRb2dJQ0FnY0hWemFHbHVkQ0F5TlRVS0lDQWdJSE4zWVhBS0lDQWdJQzBLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCelpYUmlhWFFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2MzZGhjQW9nSUNBZ1lpOEtJQ0FnSUdSMWNBb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VBb2dJQ0FnWWlFOUNpQWdJQ0JrZFhBS0lDQWdJR0o2SUVKcGRFMWhkR2d1YkdWaGMzUlRhV2R1YVdacFkyRnVkRUpwZEY5MFpYSnVZWEo1WDJaaGJITmxRRElLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGhrTnpZME5UTmxNQW9nSUNBZ1puSmhiV1ZmWkdsbklEVUtJQ0FnSUdJdkNncENhWFJOWVhSb0xteGxZWE4wVTJsbmJtbG1hV05oYm5SQ2FYUmZkR1Z5Ym1GeWVWOXRaWEpuWlVBek9nb2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VERm1DaUFnSUNCaUpnb2dJQ0FnWm5KaGJXVmZaR2xuSURNS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBd0NpQWdJQ0JtY21GdFpWOWthV2NnTmdvZ0lDQWdZbm9nUW1sMFRXRjBhQzVzWldGemRGTnBaMjVwWm1sallXNTBRbWwwWDNSbGNtNWhjbmxmWm1Gc2MyVkFOUW9nSUNBZ1lubDBaV05mTWlBdkx5QXdlR1EzTmpRMU0yVXdDaUFnSUNCbWNtRnRaVjlrYVdjZ05Rb2dJQ0FnWWk4S0NrSnBkRTFoZEdndWJHVmhjM1JUYVdkdWFXWnBZMkZ1ZEVKcGRGOTBaWEp1WVhKNVgyMWxjbWRsUURZNkNpQWdJQ0JpZVhSbFkxOHpJQzh2SURCNE1XWUtJQ0FnSUdJbUNpQWdJQ0JtY21GdFpWOWthV2NnTXdvZ0lDQWdaSFZ3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z09Bb2dJQ0FnTFFvZ0lDQWdabkpoYldWZlpHbG5JREFLSUNBZ0lITjNZWEFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQmllWFJsWXlBMklDOHZJREI0TURBeFpqQmtNV1V4TURCak1XUXdOekJtTURrd1lqRTVNVE14WXpFM01EWXdNVEJsTVRFd09EQmhNV0V4TkRFNE1ESXhNakZpTVRVd016RTJNRFF3TlFvZ0lDQWdjM2RoY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JtY21GdFpWOWthV2NnTkFvZ0lDQWdZbndLSUNBZ0lHTnZibU5oZEFvZ0lDQWdabkpoYldWZlluVnllU0F4Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dOZ29nSUNBZ1lub2dRbWwwVFdGMGFDNXNaV0Z6ZEZOcFoyNXBabWxqWVc1MFFtbDBYM1JsY201aGNubGZabUZzYzJWQU9Bb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VHUTNOalExTTJVd0NpQWdJQ0JtY21GdFpWOWthV2NnTlFvZ0lDQWdZaThLQ2tKcGRFMWhkR2d1YkdWaGMzUlRhV2R1YVdacFkyRnVkRUpwZEY5MFpYSnVZWEo1WDIxbGNtZGxRRGs2Q2lBZ0lDQmllWFJsWTE4eklDOHZJREI0TVdZS0lDQWdJR0ltQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNd29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm1jbUZ0WlY5aWRYSjVJRElLSUNBZ0lHWnlZVzFsWDJScFp5QTJDaUFnSUNCaWVpQkNhWFJOWVhSb0xteGxZWE4wVTJsbmJtbG1hV05oYm5SQ2FYUmZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeE1Rb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VHUTNOalExTTJVd0NpQWdJQ0JtY21GdFpWOWthV2NnTlFvZ0lDQWdZaThLQ2tKcGRFMWhkR2d1YkdWaGMzUlRhV2R1YVdacFkyRnVkRUpwZEY5MFpYSnVZWEo1WDIxbGNtZGxRREV5T2dvZ0lDQWdZbmwwWldOZk15QXZMeUF3ZURGbUNpQWdJQ0JpSmdvZ0lDQWdabkpoYldWZlpHbG5JRE1LSUNBZ0lHUjFjQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURnS0lDQWdJQzBLSUNBZ0lHWnlZVzFsWDJScFp5QXlDaUFnSUNCemQyRndDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1lubDBaV01nTmlBdkx5QXdlREF3TVdZd1pERmxNVEF3WXpGa01EY3daakE1TUdJeE9URXpNV014TnpBMk1ERXdaVEV4TURnd1lURmhNVFF4T0RBeU1USXhZakUxTURNeE5qQTBNRFVLSUNBZ0lITjNZWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdabkpoYldWZlpHbG5JRFFLSUNBZ0lHSjhDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklEZ0tJQ0FnSUMwS0lDQWdJR1p5WVcxbFgyUnBaeUF4Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdabkpoYldWZlluVnllU0F3Q2lBZ0lDQnlaWFJ6ZFdJS0NrSnBkRTFoZEdndWJHVmhjM1JUYVdkdWFXWnBZMkZ1ZEVKcGRGOTBaWEp1WVhKNVgyWmhiSE5sUURFeE9nb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VBb2dJQ0FnWWlCQ2FYUk5ZWFJvTG14bFlYTjBVMmxuYm1sbWFXTmhiblJDYVhSZmRHVnlibUZ5ZVY5dFpYSm5aVUF4TWdvS1FtbDBUV0YwYUM1c1pXRnpkRk5wWjI1cFptbGpZVzUwUW1sMFgzUmxjbTVoY25sZlptRnNjMlZBT0RvS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnS0lDQWdJR0lnUW1sMFRXRjBhQzVzWldGemRGTnBaMjVwWm1sallXNTBRbWwwWDNSbGNtNWhjbmxmYldWeVoyVkFPUW9LUW1sMFRXRjBhQzVzWldGemRGTnBaMjVwWm1sallXNTBRbWwwWDNSbGNtNWhjbmxmWm1Gc2MyVkFOVG9LSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGdLSUNBZ0lHSWdRbWwwVFdGMGFDNXNaV0Z6ZEZOcFoyNXBabWxqWVc1MFFtbDBYM1JsY201aGNubGZiV1Z5WjJWQU5nb0tRbWwwVFdGMGFDNXNaV0Z6ZEZOcFoyNXBabWxqWVc1MFFtbDBYM1JsY201aGNubGZabUZzYzJWQU1qb0tJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ0tJQ0FnSUdJZ1FtbDBUV0YwYUM1c1pXRnpkRk5wWjI1cFptbGpZVzUwUW1sMFgzUmxjbTVoY25sZmJXVnlaMlZBTXdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OTFibWx6ZDJGd0xYWTBMMk52Ym5SeVlXTjBjeTlqYjNKbEwxQnZiMnhOWVc1aFoyVnlMbk52YkM1UWIyOXNUV0Z1WVdkbGNsOWZTR1ZzY0dWeU1Ua3VYMTl3ZFhsaFgyRnlZelJmY205MWRHVnlYMThvS1NBdFBpQjFhVzUwTmpRNkNsOWZjSFY1WVY5aGNtTTBYM0p2ZFhSbGNsOWZPZ29nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lHSjZJRjlmY0hWNVlWOWhjbU0wWDNKdmRYUmxjbDlmWDE5ZlltRnlaVjlqY21WaGRHVmZYMEE1Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFLSUNBZ0lIQjFjMmhpZVhSbGMzTWdNSGd4TjJWbE1tSTNZeUF3ZUdNNU4ySXdPV00xSURCNFlUazJaV1k1T0RrZ0x5OGdiV1YwYUc5a0lDSkNhWFJOWVhSb0xteGxZWE4wVTJsbmJtbG1hV05oYm5SQ2FYUW9kV2x1ZERJMU5pbDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0ltVjRkSFJzYjJGa0tHSjVkR1ZiTXpKZEtXSjVkR1ZiTXpKZElpd2diV1YwYUc5a0lDSmZYMmx1YVhSZlh5aDFhVzUwTmpRc2RXbHVkRFkwTEdKNWRHVmJYU2wyYjJsa0lnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2dMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzVnVhWE4zWVhBdGRqUXZZMjl1ZEhKaFkzUnpMMk52Y21VdlVHOXZiRTFoYm1GblpYSXVjMjlzTGxCdmIyeE5ZVzVoWjJWeVgxOUlaV3h3WlhJeE9TNUNhWFJOWVhSb0xteGxZWE4wVTJsbmJtbG1hV05oYm5SQ2FYUmJjbTkxZEdsdVoxMGdaWGgwZEd4dllXUW9NU2tnWDE5cGJtbDBYMThLSUNBZ0lHVnljZ29LWDE5d2RYbGhYMkZ5WXpSZmNtOTFkR1Z5WDE5ZlgxOWlZWEpsWDJOeVpXRjBaVjlmUURrNkNpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ0lRb2dJQ0FnSmlZS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTkxYm1semQyRndMWFkwTDJOdmJuUnlZV04wY3k5amIzSmxMMUJ2YjJ4TllXNWhaMlZ5TG5OdmJDNVFiMjlzVFdGdVlXZGxjbDlmU0dWc2NHVnlNVGt1UW1sMFRXRjBhQzVzWldGemRGTnBaMjVwWm1sallXNTBRbWwwVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDNWdWFYTjNZWEF0ZGpRdlkyOXVkSEpoWTNSekwyTnZjbVV2VUc5dmJFMWhibUZuWlhJdWMyOXNMbEJ2YjJ4TllXNWhaMlZ5WDE5SVpXeHdaWEl4T1M1Q2FYUk5ZWFJvTG14bFlYTjBVMmxuYm1sbWFXTmhiblJDYVhSYmNtOTFkR2x1WjEwNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUXlOVFlLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJbThpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEFvZ0lDQWdZbm9nTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMM1Z1YVhOM1lYQXRkalF2WTI5dWRISmhZM1J6TDJOdmNtVXZVRzl2YkUxaGJtRm5aWEl1YzI5c0xsQnZiMnhOWVc1aFoyVnlYMTlJWld4d1pYSXhPUzVDYVhSTllYUm9MbXhsWVhOMFUybG5ibWxtYVdOaGJuUkNhWFJiY205MWRHbHVaMTFmWVdaMFpYSmZhV1pmWld4elpVQTFDaUFnSUNCbmJHOWlZV3dnUjNKdmRYQlRhWHBsQ2lBZ0lDQndkWE5vYVc1MElESUtJQ0FnSUQ0OUNpQWdJQ0JoYzNObGNuUWdMeThnYUdWc2NHVnlPaUJ0ZFhOMElHSmxJR05oYkd4bFpDQnBiaUJuY205MWNBb2dJQ0FnWjNSNGJpQXdJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0o1ZEdWaklEUWdMeThnSW04aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRBb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJvWld4d1pYSTZJSFZ1WVhWMGFHOXlhWHBsWkNCallXeHNaWElLSUNBZ0lHZDBlRzRnTUNCVFpXNWtaWElLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYUdWc2NHVnlPaUJ6Wlc1a1pYSWdiV2x6YldGMFkyZ0tJQ0FnSUdKNWRHVmpJRFVnTHk4Z0luQWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkQW9nSUNBZ1lub2dMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzVnVhWE4zWVhBdGRqUXZZMjl1ZEhKaFkzUnpMMk52Y21VdlVHOXZiRTFoYm1GblpYSXVjMjlzTGxCdmIyeE5ZVzVoWjJWeVgxOUlaV3h3WlhJeE9TNUNhWFJOWVhSb0xteGxZWE4wVTJsbmJtbG1hV05oYm5SQ2FYUmJjbTkxZEdsdVoxMWZZV1owWlhKZmFXWmZaV3h6WlVBMUNpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJQzBLSUNBZ0lHZDBlRzV6SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKNWRHVmpJRFVnTHk4Z0luQWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCb1pXeHdaWEk2SUhkeWIyNW5JSEJ5WlhZZ1kyaDFibXNLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWjNSNGJuTmhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCd2RYTm9ZbmwwWlhNZ0luTWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCb1pXeHdaWEk2SUhkeWIyNW5JSEJ5WlhZZ2JXVjBhRzlrQ2dvdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12ZFc1cGMzZGhjQzEyTkM5amIyNTBjbUZqZEhNdlkyOXlaUzlRYjI5c1RXRnVZV2RsY2k1emIyd3VVRzl2YkUxaGJtRm5aWEpmWDBobGJIQmxjakU1TGtKcGRFMWhkR2d1YkdWaGMzUlRhV2R1YVdacFkyRnVkRUpwZEZ0eWIzVjBhVzVuWFY5aFpuUmxjbDlwWmw5bGJITmxRRFU2Q2lBZ0lDQmtkWEFLSUNBZ0lHTmhiR3h6ZFdJZ1FtbDBUV0YwYUM1c1pXRnpkRk5wWjI1cFptbGpZVzUwUW1sMENpQWdJQ0JwZEc5aUNpQWdJQ0JrZFhBS0lDQWdJSE4wYjNKbElEQUtJQ0FnSUdKNWRHVmpJRGNnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12ZFc1cGMzZGhjQzEyTkM5amIyNTBjbUZqZEhNdlkyOXlaUzlRYjI5c1RXRnVZV2RsY2k1emIyd3VVRzl2YkUxaGJtRm5aWEpmWDBobGJIQmxjakU1TG1WNGRIUnNiMkZrS0RFcFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0taWGgwZEd4dllXUW9NU2s2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGcxWmpWbU56UTFaak0wQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEFvZ0lDQWdhWFJ2WWdvZ0lDQWdaSFZ3Q2lBZ0lDQnpkRzl5WlNBd0NpQWdJQ0JpZVhSbFl5QTNJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMM1Z1YVhOM1lYQXRkalF2WTI5dWRISmhZM1J6TDJOdmNtVXZVRzl2YkUxaGJtRm5aWEl1YzI5c0xsQnZiMnhOWVc1aFoyVnlYMTlJWld4d1pYSXhPUzVmWDJsdWFYUmZYMXR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q2w5ZmFXNXBkRjlmT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYek1nTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdjSFZ6YUdsdWRDQXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQmllWFJsWXlBMElDOHZJQ0p2SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhRS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5Qm9aV3h3WlhJNklHRnNjbVZoWkhrZ2FXNXBkR2xoYkdsNlpXUUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z0ltOGlDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKd0lnb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0p6SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200SyIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12ZFc1cGMzZGhjQzEyTkM5amIyNTBjbUZqZEhNdlkyOXlaUzlRYjI5c1RXRnVZV2RsY2k1emIyd3VVRzl2YkUxaGJtRm5aWEpmWDBobGJIQmxjakU1TG1Oc1pXRnlYM04wWVhSbFgzQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVLSUNBZ0lISmxkSFZ5YmdvPSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQUVBUWdnQUNZSUlRRUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBRTEyUlQ0QUVmQVc4QmNDQUFIdzBlRUF3ZEJ3OEpDeGtUSEJjR0FRNFJDQW9hRkJnQ0Voc1ZBeFlFQlFRVkgzeDFRZ0dzaWdFQkpVY0RGb3YvcEVRb2kvK2hLS3FMLzZ5TS95T3ZTU1N2aS8rQUlMYmJiYmJkM2QzZDAwMDAwMGtra2traENFSVFqR01ZeGpuT2M1ei8vLy8vb3lpcWdDQUVBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUtLQUlBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFFb3lpcVN3Sk1VRWtWSXdsYmdZQUNHSUgvQVV3SlN3Rk1JbFNBSUlCQVFGVkRBRkptUkRJQUFGQWdZUVowQlRBbUFnQUFFSFVHSUFGMkVYQjNveWlxZ0NBUUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBS0tBSUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQWdveWlxVHdKTVVFa1ZJd2xiU1JaT0FvR0FBaGlCL3dGTUNTSlVpLzlNb2trcHFVbEJBSGNxaXdXaUs2eUxBMHhRakFDTEJrRUFZaXFMQmFJcnJJc0RTVThDVUJVakNZc0FURnNuQmt3aVdJc0VxMUNNQVlzR1FRQTdLb3NGb2l1c2l3Tk1VSXdDaXdaQkFDWXFpd1dpSzZ5TEEwbFBBbEFWSXdtTEFreGJKd1pNSWxpTEJLdFFGU01KaXdGTVc0d0FpU2xDLzlvcFF2L0ZLVUwvbmlsQy80a3hHMEVBSkRFWkZFUXhHRVNDQXdRWDdpdDhCTWw3Q2NVRXFXNzVpVFlhQUk0REFBa0FXUUJ6QURFWkZERVlGQkJETmhvQlNSVWtFa1FuQkdSQkFETXlCSUVDRDBRekFCZ25CR1FTUkRNQUFERUFFa1FuQldSQkFCZ3hGaUlKT0JnbkJXUVNSREVXSWdrNUdnQ0FBWE5rRWtSSmlQM2VGa2sxQUNjSFRGQ3dJa00yR2dFVkpCSkVnQVZmWDNSZk5HUVdTVFVBSndkTVVMQWlRellhQVVrVkl4SkVGellhQWtrVkl4SkVGellhQTBrbFdZRUNDRXNCRlJKRVZ3SUFKd1JrRkVRbkJFOERaeWNGVHdKbmdBRnpUR2NpUXc9PSIsImNsZWFyIjoiQ29FQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjcsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
