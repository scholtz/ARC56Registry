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

namespace Arc56.Generated.algorandfoundation.TEALScript.FunctionsTest_a76a9d76
{


    public class FunctionsTestProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public FunctionsTestProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        /// <param name="b"> </param>
        public async Task<ulong> CallNonClassFunction(ulong a, ulong b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 143, 210, 59, 72 };
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

        public async Task<List<Transaction>> CallNonClassFunction_Transactions(ulong a, ulong b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 143, 210, 59, 72 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bAbi.From(b);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi, bAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        /// <param name="b"> </param>
        public async Task<ulong> CallExternalFunction(ulong a, ulong b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 245, 219, 59, 65 };
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

        public async Task<List<Transaction>> CallExternalFunction_Transactions(ulong a, ulong b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 245, 219, 59, 65 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bAbi.From(b);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi, bAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        /// <param name="b"> </param>
        public async Task<ulong> CallPackageFunction(ulong a, ulong b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 139, 120, 145, 150 };
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

        public async Task<List<Transaction>> CallPackageFunction_Transactions(ulong a, ulong b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 139, 120, 145, 150 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bAbi.From(b);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi, bAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task CreateApplication(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 68, 123, 54 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateApplication_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 68, 123, 54 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbNCw1Nl0sIm5hbWUiOiJGdW5jdGlvbnNUZXN0IiwiZGVzYyI6IiIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJjYWxsTm9uQ2xhc3NGdW5jdGlvbiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJiIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpudWxsLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9LHsibmFtZSI6ImNhbGxFeHRlcm5hbEZ1bmN0aW9uIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH0seyJuYW1lIjoiY2FsbFBhY2thZ2VGdW5jdGlvbiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJiIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpudWxsLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9LHsibmFtZSI6ImNyZWF0ZUFwcGxpY2F0aW9uIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOm51bGwsImV2ZW50cyI6bnVsbCwicmVjb21tZW5kYXRpb25zIjpudWxsfV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzBdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9mdW5jdGlvbnMuYWxnby50czoxMCJ9LHsicGMiOlsxLDIsM10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6Miwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2Z1bmN0aW9ucy5hbGdvLnRzOjEwIn0seyJwYyI6WzQsNSw2LDcsOCw5LDEwXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvZnVuY3Rpb25zLmFsZ28udHM6MTAifSx7InBjIjpbMTEsMTJdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE1LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvZnVuY3Rpb25zLmFsZ28udHM6MTAifSx7InBjIjpbMTNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE2LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvZnVuY3Rpb25zLmFsZ28udHM6MTAifSx7InBjIjpbMTQsMTVdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE3LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvZnVuY3Rpb25zLmFsZ28udHM6MTAifSx7InBjIjpbMTZdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE4LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvZnVuY3Rpb25zLmFsZ28udHM6MTAifSx7InBjIjpbMTcsMThdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE5LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvZnVuY3Rpb25zLmFsZ28udHM6MTAifSx7InBjIjpbMTldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjIwLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvZnVuY3Rpb25zLmFsZ28udHM6MTAifSx7InBjIjpbMjAsMjEsMjIsMjMsMjQsMjUsMjYsMjcsMjgsMjksMzAsMzEsMzIsMzMsMzQsMzUsMzYsMzcsMzgsMzksNDAsNDEsNDIsNDMsNDQsNDVdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjIxLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvZnVuY3Rpb25zLmFsZ28udHM6MTAifSx7InBjIjpbNDZdLCJlcnJvck1lc3NhZ2UiOiJUaGUgcmVxdWVzdGVkIGFjdGlvbiBpcyBub3QgaW1wbGVtZW50ZWQgaW4gdGhpcyBjb250cmFjdC4gQXJlIHlvdSB1c2luZyB0aGUgY29ycmVjdCBPbkNvbXBsZXRlPyBEaWQgeW91IHNldCB5b3VyIGFwcCBJRD8iLCJ0ZWFsIjoyNSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2Z1bmN0aW9ucy5hbGdvLnRzOjEwIn0seyJwYyI6WzQ3XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozMCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2Z1bmN0aW9ucy5hbGdvLnRzOjExIn0seyJwYyI6WzQ4LDQ5LDUwXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozMywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2Z1bmN0aW9ucy5hbGdvLnRzOjExIn0seyJwYyI6WzUxXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozNCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2Z1bmN0aW9ucy5hbGdvLnRzOjExIn0seyJwYyI6WzUyLDUzLDU0XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozNywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2Z1bmN0aW9ucy5hbGdvLnRzOjExIn0seyJwYyI6WzU1XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozOCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2Z1bmN0aW9ucy5hbGdvLnRzOjExIn0seyJwYyI6WzU2LDU3LDU4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo0MSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2Z1bmN0aW9ucy5hbGdvLnRzOjExIn0seyJwYyI6WzU5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo0Miwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2Z1bmN0aW9ucy5hbGdvLnRzOjExIn0seyJwYyI6WzYwXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo0Mywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2Z1bmN0aW9ucy5hbGdvLnRzOjExIn0seyJwYyI6WzYxXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo0NCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2Z1bmN0aW9ucy5hbGdvLnRzOjExIn0seyJwYyI6WzYyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo0NSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2Z1bmN0aW9ucy5hbGdvLnRzOjExIn0seyJwYyI6WzYzXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo0Niwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2Z1bmN0aW9ucy5hbGdvLnRzOjExIn0seyJwYyI6WzY0LDY1LDY2XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1MCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2Z1bmN0aW9ucy5hbGdvLnRzOjExIn0seyJwYyI6WzY3LDY4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1NCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2Z1bmN0aW9ucy5hbGdvLnRzOjEyIn0seyJwYyI6WzY5LDcwXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1NSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2Z1bmN0aW9ucy5hbGdvLnRzOjEyIn0seyJwYyI6WzcxLDcyLDczXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1Niwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2Z1bmN0aW9ucy5hbGdvLnRzOjEyIn0seyJwYyI6Wzc0XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1Nywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2Z1bmN0aW9ucy5hbGdvLnRzOjExIn0seyJwYyI6Wzc1XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo2Miwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2Z1bmN0aW9ucy5hbGdvLnRzOjE1In0seyJwYyI6Wzc2LDc3LDc4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo2NSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2Z1bmN0aW9ucy5hbGdvLnRzOjE1In0seyJwYyI6Wzc5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo2Niwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2Z1bmN0aW9ucy5hbGdvLnRzOjE1In0seyJwYyI6WzgwLDgxLDgyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo2OSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2Z1bmN0aW9ucy5hbGdvLnRzOjE1In0seyJwYyI6WzgzXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo3MCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2Z1bmN0aW9ucy5hbGdvLnRzOjE1In0seyJwYyI6Wzg0LDg1LDg2XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo3Mywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2Z1bmN0aW9ucy5hbGdvLnRzOjE1In0seyJwYyI6Wzg3XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo3NCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2Z1bmN0aW9ucy5hbGdvLnRzOjE1In0seyJwYyI6Wzg4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo3NSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2Z1bmN0aW9ucy5hbGdvLnRzOjE1In0seyJwYyI6Wzg5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo3Niwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2Z1bmN0aW9ucy5hbGdvLnRzOjE1In0seyJwYyI6WzkwXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo3Nywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2Z1bmN0aW9ucy5hbGdvLnRzOjE1In0seyJwYyI6WzkxXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo3OCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2Z1bmN0aW9ucy5hbGdvLnRzOjE1In0seyJwYyI6WzkyLDkzLDk0XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo4Miwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2Z1bmN0aW9ucy5hbGdvLnRzOjE1In0seyJwYyI6Wzk1LDk2XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo4Niwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2Z1bmN0aW9ucy5hbGdvLnRzOjE2In0seyJwYyI6Wzk3LDk4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo4Nywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2Z1bmN0aW9ucy5hbGdvLnRzOjE2In0seyJwYyI6Wzk5LDEwMCwxMDFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjg4LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvZnVuY3Rpb25zLmFsZ28udHM6MTYifSx7InBjIjpbMTAyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo4OSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2Z1bmN0aW9ucy5hbGdvLnRzOjE1In0seyJwYyI6WzEwM10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6OTQsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9mdW5jdGlvbnMuYWxnby50czoxOSJ9LHsicGMiOlsxMDQsMTA1LDEwNl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6OTcsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9mdW5jdGlvbnMuYWxnby50czoxOSJ9LHsicGMiOlsxMDddLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjk4LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvZnVuY3Rpb25zLmFsZ28udHM6MTkifSx7InBjIjpbMTA4LDEwOSwxMTBdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEwMSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2Z1bmN0aW9ucy5hbGdvLnRzOjE5In0seyJwYyI6WzExMV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTAyLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvZnVuY3Rpb25zLmFsZ28udHM6MTkifSx7InBjIjpbMTEyLDExMywxMTRdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEwNSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2Z1bmN0aW9ucy5hbGdvLnRzOjE5In0seyJwYyI6WzExNV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTA2LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvZnVuY3Rpb25zLmFsZ28udHM6MTkifSx7InBjIjpbMTE2XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMDcsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9mdW5jdGlvbnMuYWxnby50czoxOSJ9LHsicGMiOlsxMTddLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEwOCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2Z1bmN0aW9ucy5hbGdvLnRzOjE5In0seyJwYyI6WzExOF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTA5LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvZnVuY3Rpb25zLmFsZ28udHM6MTkifSx7InBjIjpbMTE5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMTAsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9mdW5jdGlvbnMuYWxnby50czoxOSJ9LHsicGMiOlsxMjAsMTIxLDEyMl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTE0LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvZnVuY3Rpb25zLmFsZ28udHM6MTkifSx7InBjIjpbMTIzLDEyNF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTE4LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvZnVuY3Rpb25zLmFsZ28udHM6MjAifSx7InBjIjpbMTI1LDEyNl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTE5LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvZnVuY3Rpb25zLmFsZ28udHM6MjAifSx7InBjIjpbMTI3LDEyOCwxMjldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEyMCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2Z1bmN0aW9ucy5hbGdvLnRzOjIwIn0seyJwYyI6WzEzMF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTIxLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvZnVuY3Rpb25zLmFsZ28udHM6MTkifSx7InBjIjpbMTMxXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMjQsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9mdW5jdGlvbnMuYWxnby50czoxMCJ9LHsicGMiOlsxMzJdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEyNSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2Z1bmN0aW9ucy5hbGdvLnRzOjEwIn0seyJwYyI6WzEzMywxMzQsMTM1LDEzNiwxMzcsMTM4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMjgsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9mdW5jdGlvbnMuYWxnby50czoxMCJ9LHsicGMiOlsxMzksMTQwLDE0MV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTI5LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvZnVuY3Rpb25zLmFsZ28udHM6MTAifSx7InBjIjpbMTQyLDE0MywxNDQsMTQ1XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMzAsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9mdW5jdGlvbnMuYWxnby50czoxMCJ9LHsicGMiOlsxNDZdLCJlcnJvck1lc3NhZ2UiOiJ0aGlzIGNvbnRyYWN0IGRvZXMgbm90IGltcGxlbWVudCB0aGUgZ2l2ZW4gQUJJIG1ldGhvZCBmb3IgY3JlYXRlIE5vT3AiLCJ0ZWFsIjoxMzMsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9mdW5jdGlvbnMuYWxnby50czoxMCJ9LHsicGMiOlsxNDcsMTQ4LDE0OSwxNTAsMTUxLDE1Ml0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTM2LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvZnVuY3Rpb25zLmFsZ28udHM6MTAifSx7InBjIjpbMTUzLDE1NCwxNTUsMTU2LDE1NywxNThdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEzNywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2Z1bmN0aW9ucy5hbGdvLnRzOjEwIn0seyJwYyI6WzE1OSwxNjAsMTYxLDE2MiwxNjMsMTY0XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMzgsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9mdW5jdGlvbnMuYWxnby50czoxMCJ9LHsicGMiOlsxNjUsMTY2LDE2N10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTM5LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvZnVuY3Rpb25zLmFsZ28udHM6MTAifSx7InBjIjpbMTY4LDE2OSwxNzAsMTcxLDE3MiwxNzMsMTc0LDE3NV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTQwLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvZnVuY3Rpb25zLmFsZ28udHM6MTAifSx7InBjIjpbMTc2XSwiZXJyb3JNZXNzYWdlIjoidGhpcyBjb250cmFjdCBkb2VzIG5vdCBpbXBsZW1lbnQgdGhlIGdpdmVuIEFCSSBtZXRob2QgZm9yIGNhbGwgTm9PcCIsInRlYWwiOjE0Mywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2Z1bmN0aW9ucy5hbGdvLnRzOjEwIn0seyJwYyI6WzE3NywxNzgsMTc5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxNDcsInNvdXJjZSI6Im5vZGVfbW9kdWxlcy90ZWFsc2NyaXB0X3Rlc3RfcGFja2FnZS9pbmRleC50czozIn0seyJwYyI6WzE4MCwxODFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE1MSwic291cmNlIjoibm9kZV9tb2R1bGVzL3RlYWxzY3JpcHRfdGVzdF9wYWNrYWdlL2luZGV4LnRzOjQifSx7InBjIjpbMTgyLDE4M10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTUyLCJzb3VyY2UiOiJub2RlX21vZHVsZXMvdGVhbHNjcmlwdF90ZXN0X3BhY2thZ2UvaW5kZXgudHM6NCJ9LHsicGMiOlsxODRdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE1Mywic291cmNlIjoibm9kZV9tb2R1bGVzL3RlYWxzY3JpcHRfdGVzdF9wYWNrYWdlL2luZGV4LnRzOjQifSx7InBjIjpbMTg1XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxNTQsInNvdXJjZSI6Im5vZGVfbW9kdWxlcy90ZWFsc2NyaXB0X3Rlc3RfcGFja2FnZS9pbmRleC50czozIn0seyJwYyI6WzE4NiwxODcsMTg4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxNTgsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9mdW5jdGlvbnMtZXh0ZXJuYWwuYWxnby50czoxIn0seyJwYyI6WzE4OSwxOTBdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE2Miwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2Z1bmN0aW9ucy1leHRlcm5hbC5hbGdvLnRzOjIifSx7InBjIjpbMTkxLDE5Ml0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTYzLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvZnVuY3Rpb25zLWV4dGVybmFsLmFsZ28udHM6MiJ9LHsicGMiOlsxOTNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE2NCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2Z1bmN0aW9ucy1leHRlcm5hbC5hbGdvLnRzOjIifSx7InBjIjpbMTk0XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxNjUsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9mdW5jdGlvbnMtZXh0ZXJuYWwuYWxnby50czoxIn0seyJwYyI6WzE5NSwxOTYsMTk3XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxNjksInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9mdW5jdGlvbnMuYWxnby50czo2In0seyJwYyI6WzE5OCwxOTldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE3Mywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2Z1bmN0aW9ucy5hbGdvLnRzOjcifSx7InBjIjpbMjAwLDIwMV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTc0LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvZnVuY3Rpb25zLmFsZ28udHM6NyJ9LHsicGMiOlsyMDJdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE3NSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2Z1bmN0aW9ucy5hbGdvLnRzOjcifSx7InBjIjpbMjAzXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxNzYsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9mdW5jdGlvbnMuYWxnby50czo2In1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q21sdWRHTmliRzlqYXlBeENtSjVkR1ZqWW14dlkyc2dNSGd4TlRGbU4yTTNOUW9LTHk4Z1ZHaHBjeUJVUlVGTUlIZGhjeUJuWlc1bGNtRjBaV1FnWW5rZ1ZFVkJURk5qY21sd2RDQjJNQzR4TURjdU1nb3ZMeUJvZEhSd2N6b3ZMMmRwZEdoMVlpNWpiMjB2WVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDFSRlFVeFRZM0pwY0hRS0NpOHZJRlJvYVhNZ1kyOXVkSEpoWTNRZ2FYTWdZMjl0Y0d4cFlXNTBJSGRwZEdnZ1lXNWtMMjl5SUdsdGNHeGxiV1Z1ZEhNZ2RHaGxJR1p2Ykd4dmQybHVaeUJCVWtOek9pQmJJRUZTUXpRZ1hRb0tMeThnVkdobElHWnZiR3h2ZDJsdVp5QjBaVzRnYkdsdVpYTWdiMllnVkVWQlRDQm9ZVzVrYkdVZ2FXNXBkR2xoYkNCd2NtOW5jbUZ0SUdac2IzY0tMeThnVkdocGN5QndZWFIwWlhKdUlHbHpJSFZ6WldRZ2RHOGdiV0ZyWlNCcGRDQmxZWE41SUdadmNpQmhibmx2Ym1VZ2RHOGdjR0Z5YzJVZ2RHaGxJSE4wWVhKMElHOW1JSFJvWlNCd2NtOW5jbUZ0SUdGdVpDQmtaWFJsY20xcGJtVWdhV1lnWVNCemNHVmphV1pwWXlCaFkzUnBiMjRnYVhNZ1lXeHNiM2RsWkFvdkx5QklaWEpsTENCaFkzUnBiMjRnY21WbVpYSnpJSFJ2SUhSb1pTQlBia052YlhCc1pYUmxJR2x1SUdOdmJXSnBibUYwYVc5dUlIZHBkR2dnZDJobGRHaGxjaUIwYUdVZ1lYQndJR2x6SUdKbGFXNW5JR055WldGMFpXUWdiM0lnWTJGc2JHVmtDaTh2SUVWMlpYSjVJSEJ2YzNOcFlteGxJR0ZqZEdsdmJpQm1iM0lnZEdocGN5QmpiMjUwY21GamRDQnBjeUJ5WlhCeVpYTmxiblJsWkNCcGJpQjBhR1VnYzNkcGRHTm9JSE4wWVhSbGJXVnVkQW92THlCSlppQjBhR1VnWVdOMGFXOXVJR2x6SUc1dmRDQnBiWEJzWlcxbGJuUmxaQ0JwYmlCMGFHVWdZMjl1ZEhKaFkzUXNJR2wwY3lCeVpYTndaV04wYVhabElHSnlZVzVqYUNCM2FXeHNJR0psSUNJcVRrOVVYMGxOVUV4RlRVVk9WRVZFSWlCM2FHbGphQ0JxZFhOMElHTnZiblJoYVc1eklDSmxjbklpQ25SNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lFS2NIVnphR2x1ZENBMkNpb0tkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb3JDbk4zYVhSamFDQXFZMkZzYkY5T2IwOXdJQ3BPVDFSZlNVMVFURVZOUlU1VVJVUWdLazVQVkY5SlRWQk1SVTFGVGxSRlJDQXFUazlVWDBsTlVFeEZUVVZPVkVWRUlDcE9UMVJmU1UxUVRFVk5SVTVVUlVRZ0trNVBWRjlKVFZCTVJVMUZUbFJGUkNBcVkzSmxZWFJsWDA1dlQzQWdLazVQVkY5SlRWQk1SVTFGVGxSRlJDQXFUazlVWDBsTlVFeEZUVVZPVkVWRUlDcE9UMVJmU1UxUVRFVk5SVTVVUlVRZ0trNVBWRjlKVFZCTVJVMUZUbFJGUkNBcVRrOVVYMGxOVUV4RlRVVk9WRVZFQ2dvcVRrOVVYMGxOVUV4RlRVVk9WRVZFT2dvSkx5OGdWR2hsSUhKbGNYVmxjM1JsWkNCaFkzUnBiMjRnYVhNZ2JtOTBJR2x0Y0d4bGJXVnVkR1ZrSUdsdUlIUm9hWE1nWTI5dWRISmhZM1F1SUVGeVpTQjViM1VnZFhOcGJtY2dkR2hsSUdOdmNuSmxZM1FnVDI1RGIyMXdiR1YwWlQ4Z1JHbGtJSGx2ZFNCelpYUWdlVzkxY2lCaGNIQWdTVVEvQ2dsbGNuSUtDaTh2SUdOaGJHeE9iMjVEYkdGemMwWjFibU4wYVc5dUtIVnBiblEyTkN4MWFXNTBOalFwZFdsdWREWTBDaXBoWW1sZmNtOTFkR1ZmWTJGc2JFNXZia05zWVhOelJuVnVZM1JwYjI0NkNna3ZMeUJVYUdVZ1FVSkpJSEpsZEhWeWJpQndjbVZtYVhnS0NXSjVkR1ZqSURBZ0x5OGdNSGd4TlRGbU4yTTNOUW9LQ1M4dklHSTZJSFZwYm5RMk5Bb0pkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvSlluUnZhUW9LQ1M4dklHRTZJSFZwYm5RMk5Bb0pkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvSlluUnZhUW9LQ1M4dklHVjRaV04xZEdVZ1kyRnNiRTV2YmtOc1lYTnpSblZ1WTNScGIyNG9kV2x1ZERZMExIVnBiblEyTkNsMWFXNTBOalFLQ1dOaGJHeHpkV0lnWTJGc2JFNXZia05zWVhOelJuVnVZM1JwYjI0S0NXbDBiMklLQ1dOdmJtTmhkQW9KYkc5bkNnbHBiblJqSURBZ0x5OGdNUW9KY21WMGRYSnVDZ292THlCallXeHNUbTl1UTJ4aGMzTkdkVzVqZEdsdmJpaGhPaUIxYVc1ME5qUXNJR0k2SUhWcGJuUTJOQ2s2SUhWcGJuUTJOQXBqWVd4c1RtOXVRMnhoYzNOR2RXNWpkR2x2YmpvS0NYQnliM1J2SURJZ01Rb0tDUzh2SUhSbGMzUnpMMk52Ym5SeVlXTjBjeTltZFc1amRHbHZibk11WVd4bmJ5NTBjem94TWdvSkx5OGdjbVYwZFhKdUlHNXZia05zWVhOelJuVnVZM1JwYjI0b1lTd2dZaWs3Q2dsbWNtRnRaVjlrYVdjZ0xUSWdMeThnWWpvZ2RXbHVkRFkwQ2dsbWNtRnRaVjlrYVdjZ0xURWdMeThnWVRvZ2RXbHVkRFkwQ2dsallXeHNjM1ZpSUc1dmJrTnNZWE56Um5WdVkzUnBiMjRLQ1hKbGRITjFZZ29LTHk4Z1kyRnNiRVY0ZEdWeWJtRnNSblZ1WTNScGIyNG9kV2x1ZERZMExIVnBiblEyTkNsMWFXNTBOalFLS21GaWFWOXliM1YwWlY5allXeHNSWGgwWlhKdVlXeEdkVzVqZEdsdmJqb0tDUzh2SUZSb1pTQkJRa2tnY21WMGRYSnVJSEJ5WldacGVBb0pZbmwwWldNZ01DQXZMeUF3ZURFMU1XWTNZemMxQ2dvSkx5OGdZam9nZFdsdWREWTBDZ2wwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNnbGlkRzlwQ2dvSkx5OGdZVG9nZFdsdWREWTBDZ2wwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENnbGlkRzlwQ2dvSkx5OGdaWGhsWTNWMFpTQmpZV3hzUlhoMFpYSnVZV3hHZFc1amRHbHZiaWgxYVc1ME5qUXNkV2x1ZERZMEtYVnBiblEyTkFvSlkyRnNiSE4xWWlCallXeHNSWGgwWlhKdVlXeEdkVzVqZEdsdmJnb0phWFJ2WWdvSlkyOXVZMkYwQ2dsc2IyY0tDV2x1ZEdNZ01DQXZMeUF4Q2dseVpYUjFjbTRLQ2k4dklHTmhiR3hGZUhSbGNtNWhiRVoxYm1OMGFXOXVLR0U2SUhWcGJuUTJOQ3dnWWpvZ2RXbHVkRFkwS1RvZ2RXbHVkRFkwQ21OaGJHeEZlSFJsY201aGJFWjFibU4wYVc5dU9nb0pjSEp2ZEc4Z01pQXhDZ29KTHk4Z2RHVnpkSE12WTI5dWRISmhZM1J6TDJaMWJtTjBhVzl1Y3k1aGJHZHZMblJ6T2pFMkNna3ZMeUJ5WlhSMWNtNGdaWGgwWlhKdVlXeEdkVzVqZEdsdmJpaGhMQ0JpS1RzS0NXWnlZVzFsWDJScFp5QXRNaUF2THlCaU9pQjFhVzUwTmpRS0NXWnlZVzFsWDJScFp5QXRNU0F2THlCaE9pQjFhVzUwTmpRS0NXTmhiR3h6ZFdJZ1pYaDBaWEp1WVd4R2RXNWpkR2x2YmdvSmNtVjBjM1ZpQ2dvdkx5QmpZV3hzVUdGamEyRm5aVVoxYm1OMGFXOXVLSFZwYm5RMk5DeDFhVzUwTmpRcGRXbHVkRFkwQ2lwaFltbGZjbTkxZEdWZlkyRnNiRkJoWTJ0aFoyVkdkVzVqZEdsdmJqb0tDUzh2SUZSb1pTQkJRa2tnY21WMGRYSnVJSEJ5WldacGVBb0pZbmwwWldNZ01DQXZMeUF3ZURFMU1XWTNZemMxQ2dvSkx5OGdZam9nZFdsdWREWTBDZ2wwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNnbGlkRzlwQ2dvSkx5OGdZVG9nZFdsdWREWTBDZ2wwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENnbGlkRzlwQ2dvSkx5OGdaWGhsWTNWMFpTQmpZV3hzVUdGamEyRm5aVVoxYm1OMGFXOXVLSFZwYm5RMk5DeDFhVzUwTmpRcGRXbHVkRFkwQ2dsallXeHNjM1ZpSUdOaGJHeFFZV05yWVdkbFJuVnVZM1JwYjI0S0NXbDBiMklLQ1dOdmJtTmhkQW9KYkc5bkNnbHBiblJqSURBZ0x5OGdNUW9KY21WMGRYSnVDZ292THlCallXeHNVR0ZqYTJGblpVWjFibU4wYVc5dUtHRTZJSFZwYm5RMk5Dd2dZam9nZFdsdWREWTBLVG9nZFdsdWREWTBDbU5oYkd4UVlXTnJZV2RsUm5WdVkzUnBiMjQ2Q2dsd2NtOTBieUF5SURFS0Nna3ZMeUIwWlhOMGN5OWpiMjUwY21GamRITXZablZ1WTNScGIyNXpMbUZzWjI4dWRITTZNakFLQ1M4dklISmxkSFZ5YmlCd1lXTnJZV2RsUm5WdVkzUnBiMjRvWVN3Z1lpazdDZ2xtY21GdFpWOWthV2NnTFRJZ0x5OGdZam9nZFdsdWREWTBDZ2xtY21GdFpWOWthV2NnTFRFZ0x5OGdZVG9nZFdsdWREWTBDZ2xqWVd4c2MzVmlJSEJoWTJ0aFoyVkdkVzVqZEdsdmJnb0pjbVYwYzNWaUNnb3FZV0pwWDNKdmRYUmxYMk55WldGMFpVRndjR3hwWTJGMGFXOXVPZ29KYVc1MFl5QXdJQzh2SURFS0NYSmxkSFZ5YmdvS0ttTnlaV0YwWlY5T2IwOXdPZ29KY0hWemFHSjVkR1Z6SURCNFlqZzBORGRpTXpZZ0x5OGdiV1YwYUc5a0lDSmpjbVZoZEdWQmNIQnNhV05oZEdsdmJpZ3BkbTlwWkNJS0NYUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLQ1cxaGRHTm9JQ3BoWW1sZmNtOTFkR1ZmWTNKbFlYUmxRWEJ3YkdsallYUnBiMjRLQ2drdkx5QjBhR2x6SUdOdmJuUnlZV04wSUdSdlpYTWdibTkwSUdsdGNHeGxiV1Z1ZENCMGFHVWdaMmwyWlc0Z1FVSkpJRzFsZEdodlpDQm1iM0lnWTNKbFlYUmxJRTV2VDNBS0NXVnljZ29LS21OaGJHeGZUbTlQY0RvS0NYQjFjMmhpZVhSbGN5QXdlRGhtWkRJellqUTRJQzh2SUcxbGRHaHZaQ0FpWTJGc2JFNXZia05zWVhOelJuVnVZM1JwYjI0b2RXbHVkRFkwTEhWcGJuUTJOQ2wxYVc1ME5qUWlDZ2x3ZFhOb1lubDBaWE1nTUhobU5XUmlNMkkwTVNBdkx5QnRaWFJvYjJRZ0ltTmhiR3hGZUhSbGNtNWhiRVoxYm1OMGFXOXVLSFZwYm5RMk5DeDFhVzUwTmpRcGRXbHVkRFkwSWdvSmNIVnphR0o1ZEdWeklEQjRPR0kzT0RreE9UWWdMeThnYldWMGFHOWtJQ0pqWVd4c1VHRmphMkZuWlVaMWJtTjBhVzl1S0hWcGJuUTJOQ3gxYVc1ME5qUXBkV2x1ZERZMElnb0pkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvSmJXRjBZMmdnS21GaWFWOXliM1YwWlY5allXeHNUbTl1UTJ4aGMzTkdkVzVqZEdsdmJpQXFZV0pwWDNKdmRYUmxYMk5oYkd4RmVIUmxjbTVoYkVaMWJtTjBhVzl1SUNwaFltbGZjbTkxZEdWZlkyRnNiRkJoWTJ0aFoyVkdkVzVqZEdsdmJnb0tDUzh2SUhSb2FYTWdZMjl1ZEhKaFkzUWdaRzlsY3lCdWIzUWdhVzF3YkdWdFpXNTBJSFJvWlNCbmFYWmxiaUJCUWtrZ2JXVjBhRzlrSUdadmNpQmpZV3hzSUU1dlQzQUtDV1Z5Y2dvS0x5OGdjR0ZqYTJGblpVWjFibU4wYVc5dUtHRTZJSFZwYm5RMk5Dd2dZam9nZFdsdWREWTBLVG9nZFdsdWREWTBDbkJoWTJ0aFoyVkdkVzVqZEdsdmJqb0tDWEJ5YjNSdklESWdNUW9LQ1M4dklHNXZaR1ZmYlc5a2RXeGxjeTkwWldGc2MyTnlhWEIwWDNSbGMzUmZjR0ZqYTJGblpTOXBibVJsZUM1MGN6bzBDZ2t2THlCeVpYUjFjbTRnWVNBcklHSTdDZ2xtY21GdFpWOWthV2NnTFRFZ0x5OGdZVG9nZFdsdWREWTBDZ2xtY21GdFpWOWthV2NnTFRJZ0x5OGdZam9nZFdsdWREWTBDZ2tyQ2dseVpYUnpkV0lLQ2k4dklHVjRkR1Z5Ym1Gc1JuVnVZM1JwYjI0b1lUb2dkV2x1ZERZMExDQmlPaUIxYVc1ME5qUXBPaUIxYVc1ME5qUUtaWGgwWlhKdVlXeEdkVzVqZEdsdmJqb0tDWEJ5YjNSdklESWdNUW9LQ1M4dklIUmxjM1J6TDJOdmJuUnlZV04wY3k5bWRXNWpkR2x2Ym5NdFpYaDBaWEp1WVd3dVlXeG5ieTUwY3pveUNna3ZMeUJ5WlhSMWNtNGdZU0FySUdJN0NnbG1jbUZ0WlY5a2FXY2dMVEVnTHk4Z1lUb2dkV2x1ZERZMENnbG1jbUZ0WlY5a2FXY2dMVElnTHk4Z1lqb2dkV2x1ZERZMENna3JDZ2x5WlhSemRXSUtDaTh2SUc1dmJrTnNZWE56Um5WdVkzUnBiMjRvWVRvZ2RXbHVkRFkwTENCaU9pQjFhVzUwTmpRcE9pQjFhVzUwTmpRS2JtOXVRMnhoYzNOR2RXNWpkR2x2YmpvS0NYQnliM1J2SURJZ01Rb0tDUzh2SUhSbGMzUnpMMk52Ym5SeVlXTjBjeTltZFc1amRHbHZibk11WVd4bmJ5NTBjem8zQ2drdkx5QnlaWFIxY200Z1lTQXJJR0k3Q2dsbWNtRnRaVjlrYVdjZ0xURWdMeThnWVRvZ2RXbHVkRFkwQ2dsbWNtRnRaVjlrYVdjZ0xUSWdMeThnWWpvZ2RXbHVkRFkwQ2drckNnbHlaWFJ6ZFdJPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBQkFTWUJCQlVmZkhVeEdCU0JCZ3N4R1FpTkRBQmxBQUFBQUFBQUFBQUFBQUJYQUFBQUFBQUFBQUFBQUFBb05ob0NGellhQVJlSUFBVVdVTEFpUTRvQ0FZditpLytJQUhtSktEWWFBaGMyR2dFWGlBQUZGbEN3SWtPS0FnR0wvb3YvaUFCVWlTZzJHZ0lYTmhvQkY0Z0FCUlpRc0NKRGlnSUJpLzZMLzRnQUw0a2lRNEFFdUVSN05qWWFBSTRCLy9FQWdBU1AwanRJZ0FUMTJ6dEJnQVNMZUpHV05ob0FqZ1AvZi8rYi83Y0FpZ0lCaS8rTC9naUppZ0lCaS8rTC9naUppZ0lCaS8rTC9naUoiLCJjbGVhciI6IkNnPT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoiYWxnb2QiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjQsIm1pbm9yIjo0LCJwYXRjaCI6MSwiY29tbWl0SGFzaCI6IjdiNjA3Y2U0In19LCJldmVudHMiOm51bGwsInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
