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

namespace Arc56.Generated.algorandfoundation.devportal_code_examples.ScratchStorage_57d9ca58
{


    //
    // ScratchStorage Contract
    //
    //This contract demonstrates how to use scratch storage in Algorand smart contracts.
    //Scratch storage persists for the lifetime of a group transaction and can be used to pass
    //values between multiple calls and/or applications in the same group.
    //
    //Key features demonstrated:
    //- Reserving scratch slots using the contract decorator
    //- Storing and loading values from scratch space
    //- Using scratch space to pass values between transactions in a group
    //- Different data types in scratch space (uint64 and bytes)
    //
    public class ScratchStorageProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ScratchStorageProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///Demonstrates basic scratch storage operations
        ///</summary>
        public async Task<bool> DemonstrateScratchStorage(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 1, 22, 140, 92 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> DemonstrateScratchStorage_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 1, 22, 140, 92 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Demonstrates reading values from another transaction in the same group
        ///</summary>
        /// <param name="groupIndex">The index of the transaction in the group to read from </param>
        /// <param name="scratchSlot">The scratch slot to read from </param>
        public async Task<ulong> ReadFromGroupTransaction(ulong groupIndex, ulong scratchSlot, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 14, 236, 11, 217 };
            var groupIndexAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); groupIndexAbi.From(groupIndex);
            var scratchSlotAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); scratchSlotAbi.From(scratchSlot);

            var result = await base.SimApp(new List<object> { abiHandle, groupIndexAbi, scratchSlotAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> ReadFromGroupTransaction_Transactions(ulong groupIndex, ulong scratchSlot, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 14, 236, 11, 217 };
            var groupIndexAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); groupIndexAbi.From(groupIndex);
            var scratchSlotAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); scratchSlotAbi.From(scratchSlot);

            return await base.MakeTransactionList(new List<object> { abiHandle, groupIndexAbi, scratchSlotAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Demonstrates reading bytes values from another transaction in the same group
        ///</summary>
        /// <param name="groupIndex">The index of the transaction in the group to read from </param>
        /// <param name="scratchSlot">The scratch slot to read from </param>
        public async Task<byte[]> ReadBytesFromGroupTransaction(ulong groupIndex, ulong scratchSlot, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 16, 251, 74, 102 };
            var groupIndexAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); groupIndexAbi.From(groupIndex);
            var scratchSlotAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); scratchSlotAbi.From(scratchSlot);

            var result = await base.SimApp(new List<object> { abiHandle, groupIndexAbi, scratchSlotAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> ReadBytesFromGroupTransaction_Transactions(ulong groupIndex, ulong scratchSlot, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 16, 251, 74, 102 };
            var groupIndexAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); groupIndexAbi.From(groupIndex);
            var scratchSlotAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); scratchSlotAbi.From(scratchSlot);

            return await base.MakeTransactionList(new List<object> { abiHandle, groupIndexAbi, scratchSlotAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiU2NyYXRjaFN0b3JhZ2UiLCJkZXNjIjoiU2NyYXRjaFN0b3JhZ2UgQ29udHJhY3RcblxuVGhpcyBjb250cmFjdCBkZW1vbnN0cmF0ZXMgaG93IHRvIHVzZSBzY3JhdGNoIHN0b3JhZ2UgaW4gQWxnb3JhbmQgc21hcnQgY29udHJhY3RzLlxuU2NyYXRjaCBzdG9yYWdlIHBlcnNpc3RzIGZvciB0aGUgbGlmZXRpbWUgb2YgYSBncm91cCB0cmFuc2FjdGlvbiBhbmQgY2FuIGJlIHVzZWQgdG8gcGFzc1xudmFsdWVzIGJldHdlZW4gbXVsdGlwbGUgY2FsbHMgYW5kL29yIGFwcGxpY2F0aW9ucyBpbiB0aGUgc2FtZSBncm91cC5cblxuS2V5IGZlYXR1cmVzIGRlbW9uc3RyYXRlZDpcbi0gUmVzZXJ2aW5nIHNjcmF0Y2ggc2xvdHMgdXNpbmcgdGhlIGNvbnRyYWN0IGRlY29yYXRvclxuLSBTdG9yaW5nIGFuZCBsb2FkaW5nIHZhbHVlcyBmcm9tIHNjcmF0Y2ggc3BhY2Vcbi0gVXNpbmcgc2NyYXRjaCBzcGFjZSB0byBwYXNzIHZhbHVlcyBiZXR3ZWVuIHRyYW5zYWN0aW9ucyBpbiBhIGdyb3VwXG4tIERpZmZlcmVudCBkYXRhIHR5cGVzIGluIHNjcmF0Y2ggc3BhY2UgKHVpbnQ2NCBhbmQgYnl0ZXMpIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6ImRlbW9uc3RyYXRlU2NyYXRjaFN0b3JhZ2UiLCJkZXNjIjoiRGVtb25zdHJhdGVzIGJhc2ljIHNjcmF0Y2ggc3RvcmFnZSBvcGVyYXRpb25zIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOiJ0cnVlIGlmIGFsbCBvcGVyYXRpb25zIHN1Y2NlZWQifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZWFkRnJvbUdyb3VwVHJhbnNhY3Rpb24iLCJkZXNjIjoiRGVtb25zdHJhdGVzIHJlYWRpbmcgdmFsdWVzIGZyb20gYW5vdGhlciB0cmFuc2FjdGlvbiBpbiB0aGUgc2FtZSBncm91cCIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJncm91cEluZGV4IiwiZGVzYyI6IlRoZSBpbmRleCBvZiB0aGUgdHJhbnNhY3Rpb24gaW4gdGhlIGdyb3VwIHRvIHJlYWQgZnJvbSIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic2NyYXRjaFNsb3QiLCJkZXNjIjoiVGhlIHNjcmF0Y2ggc2xvdCB0byByZWFkIGZyb20iLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjoiVGhlIHVpbnQ2NCB2YWx1ZSByZWFkIGZyb20gdGhlIHNwZWNpZmllZCB0cmFuc2FjdGlvbidzIHNjcmF0Y2ggc2xvdCJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVhZEJ5dGVzRnJvbUdyb3VwVHJhbnNhY3Rpb24iLCJkZXNjIjoiRGVtb25zdHJhdGVzIHJlYWRpbmcgYnl0ZXMgdmFsdWVzIGZyb20gYW5vdGhlciB0cmFuc2FjdGlvbiBpbiB0aGUgc2FtZSBncm91cCIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJncm91cEluZGV4IiwiZGVzYyI6IlRoZSBpbmRleCBvZiB0aGUgdHJhbnNhY3Rpb24gaW4gdGhlIGdyb3VwIHRvIHJlYWQgZnJvbSIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic2NyYXRjaFNsb3QiLCJkZXNjIjoiVGhlIHNjcmF0Y2ggc2xvdCB0byByZWFkIGZyb20iLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJkZXNjIjoiVGhlIGJ5dGVzIHZhbHVlIHJlYWQgZnJvbSB0aGUgc3BlY2lmaWVkIHRyYW5zYWN0aW9uJ3Mgc2NyYXRjaCBzbG90In0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzQwXSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzgwXSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgTm9PcCAmJiBjYW4gb25seSBjYWxsIHdoZW4gY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDNdLCJlcnJvck1lc3NhZ2UiOiJWYWx1ZSBpbiBzbG90IDAgc2hvdWxkIGJlIDQyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTA2XSwiZXJyb3JNZXNzYWdlIjoiVmFsdWUgaW4gc2xvdCAxIHNob3VsZCBiZSBcIkhlbGxvLCBBbGdvcmFuZCFcIiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExM10sImVycm9yTWVzc2FnZSI6IlZhbHVlIGluIHNsb3QgMTUgc2hvdWxkIGJlIDk5OSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExMF0sImVycm9yTWVzc2FnZSI6IlZhbHVlIGluIHNsb3QgMiBzaG91bGQgYmUgMTAwIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNU0EwTWlBeE1EQWdPVGs1Q2lBZ0lDQmllWFJsWTJKc2IyTnJJQ0pJWld4c2J5d2dRV3huYjNKaGJtUWhJaUF3ZURFMU1XWTNZemMxQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12VTJOeVlYUmphRk4wYjNKaFoyVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lOeTB5T0FvZ0lDQWdMeThnUUdOdmJuUnlZV04wS0hzZ2MyTnlZWFJqYUZOc2IzUnpPaUJiTUN3Z01Td2dNaXdnZXlCbWNtOXRPaUF4TUN3Z2RHODZJREl3SUgxZElIMHBJQzh2SUZSb2FYTWdjbVZ6WlhKMlpYTWdjMnh2ZEhNZ01Dd2dNU3dnTWlCaGJtUWdjMnh2ZEhNZ01UQXRNakFLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmtaV1poZFd4MElHTnNZWE56SUZOamNtRjBZMmhUZEc5eVlXZGxJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lHSjZJRzFoYVc1ZlgxOWhiR2R2ZEhOZlh5NWtaV1poZFd4MFEzSmxZWFJsUURFd0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHMTFjM1FnWW1VZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnY0hWemFHSjVkR1Z6Y3lBd2VEQXhNVFk0WXpWaklEQjRNR1ZsWXpCaVpEa2dNSGd4TUdaaU5HRTJOaUF2THlCdFpYUm9iMlFnSW1SbGJXOXVjM1J5WVhSbFUyTnlZWFJqYUZOMGIzSmhaMlVvS1dKdmIyd2lMQ0J0WlhSb2IyUWdJbkpsWVdSR2NtOXRSM0p2ZFhCVWNtRnVjMkZqZEdsdmJpaDFhVzUwTmpRc2RXbHVkRFkwS1hWcGJuUTJOQ0lzSUcxbGRHaHZaQ0FpY21WaFpFSjVkR1Z6Um5KdmJVZHliM1Z3VkhKaGJuTmhZM1JwYjI0b2RXbHVkRFkwTEhWcGJuUTJOQ2xpZVhSbFcxMGlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0JrWlcxdmJuTjBjbUYwWlZOamNtRjBZMmhUZEc5eVlXZGxJSEpsWVdSR2NtOXRSM0p2ZFhCVWNtRnVjMkZqZEdsdmJpQnlaV0ZrUW5sMFpYTkdjbTl0UjNKdmRYQlVjbUZ1YzJGamRHbHZiZ29nSUNBZ1pYSnlDZ3B0WVdsdVgxOWZZV3huYjNSelgxOHVaR1ZtWVhWc2RFTnlaV0YwWlVBeE1Eb0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OVRZM0poZEdOb1UzUnZjbUZuWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJM0xUSTRDaUFnSUNBdkx5QkFZMjl1ZEhKaFkzUW9leUJ6WTNKaGRHTm9VMnh2ZEhNNklGc3dMQ0F4TENBeUxDQjdJR1p5YjIwNklERXdMQ0IwYnpvZ01qQWdmVjBnZlNrZ0x5OGdWR2hwY3lCeVpYTmxjblpsY3lCemJHOTBjeUF3TENBeExDQXlJR0Z1WkNCemJHOTBjeUF4TUMweU1Bb2dJQ0FnTHk4Z1pYaHdiM0owSUdSbFptRjFiSFFnWTJ4aGMzTWdVMk55WVhSamFGTjBiM0poWjJVZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ0lRb2dJQ0FnSmlZS0lDQWdJSEpsZEhWeWJpQXZMeUJ2YmlCbGNuSnZjam9nVDI1RGIyMXdiR1YwYVc5dUlHMTFjM1FnWW1VZ1RtOVBjQ0FtSmlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z1kzSmxZWFJwYm1jS0Nnb3ZMeUJqYjI1MGNtRmpkSE12VTJOeVlYUmphRk4wYjNKaFoyVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZVMk55WVhSamFGTjBiM0poWjJVdVpHVnRiMjV6ZEhKaGRHVlRZM0poZEdOb1UzUnZjbUZuWlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtUmxiVzl1YzNSeVlYUmxVMk55WVhSamFGTjBiM0poWjJVNkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlUyTnlZWFJqYUZOMGIzSmhaMlV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TkFvZ0lDQWdMeThnVTJOeVlYUmphQzV6ZEc5eVpTZ3dMQ0JWYVc1ME5qUW9ORElwS1FvZ0lDQWdhVzUwWTE4eElDOHZJRFF5Q2lBZ0lDQnpkRzl5WlNBd0NpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlUyTnlZWFJqYUZOMGIzSmhaMlV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TlFvZ0lDQWdMeThnVTJOeVlYUmphQzV6ZEc5eVpTZ3hMQ0JDZVhSbGN5Z25TR1ZzYkc4c0lFRnNaMjl5WVc1a0lTY3BLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlTR1ZzYkc4c0lFRnNaMjl5WVc1a0lTSUtJQ0FnSUhOMGIzSmxJREVLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlUWTNKaGRHTm9VM1J2Y21GblpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTTJDaUFnSUNBdkx5QlRZM0poZEdOb0xuTjBiM0psS0RJc0lGVnBiblEyTkNneE1EQXBLUW9nSUNBZ2FXNTBZMTh5SUM4dklERXdNQW9nSUNBZ2MzUnZjbVVnTWdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDFOamNtRjBZMmhUZEc5eVlXZGxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNemNLSUNBZ0lDOHZJRk5qY21GMFkyZ3VjM1J2Y21Vb01UVXNJRlZwYm5RMk5DZzVPVGtwS1FvZ0lDQWdhVzUwWTE4eklDOHZJRGs1T1FvZ0lDQWdjM1J2Y21VZ01UVUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OVRZM0poZEdOb1UzUnZjbUZuWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRM0NpQWdJQ0F2THlCamIyNXpkQ0IyWVd4MVpUSWdQU0JUWTNKaGRHTm9MbXh2WVdSVmFXNTBOalFvTWlrS0lDQWdJR3h2WVdRZ01nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwxTmpjbUYwWTJoVGRHOXlZV2RsTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRnS0lDQWdJQzh2SUdOdmJuTjBJSFpoYkhWbE15QTlJRk5qY21GMFkyZ3ViRzloWkZWcGJuUTJOQ2d4TlNrS0lDQWdJR3h2WVdRZ01UVUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OVRZM0poZEdOb1UzUnZjbUZuWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRNUNpQWdJQ0F2THlCamIyNXpkQ0JpZVhSbGMxWmhiSFZsSUQwZ1UyTnlZWFJqYUM1c2IyRmtRbmwwWlhNb01Ta0tJQ0FnSUd4dllXUWdNUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMU5qY21GMFkyaFRkRzl5WVdkbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5EWUtJQ0FnSUM4dklHTnZibk4wSUhaaGJIVmxNU0E5SUZOamNtRjBZMmd1Ykc5aFpGVnBiblEyTkNnd0tRb2dJQ0FnYkc5aFpDQXdDaUFnSUNBdkx5QmpiMjUwY21GamRITXZVMk55WVhSamFGTjBiM0poWjJVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU1Rb2dJQ0FnTHk4Z1lYTnpaWEowS0haaGJIVmxNU0E5UFQwZ05ESXNJQ2RXWVd4MVpTQnBiaUJ6Ykc5MElEQWdjMmh2ZFd4a0lHSmxJRFF5SnlrS0lDQWdJR2x1ZEdOZk1TQXZMeUEwTWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QldZV3gxWlNCcGJpQnpiRzkwSURBZ2MyaHZkV3hrSUdKbElEUXlDaUFnSUNBdkx5QmpiMjUwY21GamRITXZVMk55WVhSamFGTjBiM0poWjJVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU1nb2dJQ0FnTHk4Z1lYTnpaWEowS0dKNWRHVnpWbUZzZFdVZ1BUMDlJRUo1ZEdWektDZElaV3hzYnl3Z1FXeG5iM0poYm1RaEp5a3NJQ2RXWVd4MVpTQnBiaUJ6Ykc5MElERWdjMmh2ZFd4a0lHSmxJQ0pJWld4c2J5d2dRV3huYjNKaGJtUWhJaWNwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0pJWld4c2J5d2dRV3huYjNKaGJtUWhJZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCV1lXeDFaU0JwYmlCemJHOTBJREVnYzJodmRXeGtJR0psSUNKSVpXeHNieXdnUVd4bmIzSmhibVFoSWdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDFOamNtRjBZMmhUZEc5eVlXZGxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVE1LSUNBZ0lDOHZJR0Z6YzJWeWRDaDJZV3gxWlRJZ1BUMDlJREV3TUN3Z0oxWmhiSFZsSUdsdUlITnNiM1FnTWlCemFHOTFiR1FnWW1VZ01UQXdKeWtLSUNBZ0lITjNZWEFLSUNBZ0lHbHVkR05mTWlBdkx5QXhNREFLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1ZtRnNkV1VnYVc0Z2MyeHZkQ0F5SUhOb2IzVnNaQ0JpWlNBeE1EQUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OVRZM0poZEdOb1UzUnZjbUZuWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVMENpQWdJQ0F2THlCaGMzTmxjblFvZG1Gc2RXVXpJRDA5UFNBNU9Ua3NJQ2RXWVd4MVpTQnBiaUJ6Ykc5MElERTFJSE5vYjNWc1pDQmlaU0E1T1RrbktRb2dJQ0FnYVc1MFkxOHpJQzh2SURrNU9Rb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJXWVd4MVpTQnBiaUJ6Ykc5MElERTFJSE5vYjNWc1pDQmlaU0E1T1RrS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5VFkzSmhkR05vVTNSdmNtRm5aUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPall4Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdaR1Z0YjI1emRISmhkR1ZUWTNKaGRHTm9VM1J2Y21GblpTZ3BPaUJpYjI5c1pXRnVJSHNLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREUxTVdZM1l6YzFPREFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklHTnZiblJ5WVdOMGN5OVRZM0poZEdOb1UzUnZjbUZuWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwVFkzSmhkR05vVTNSdmNtRm5aUzV5WldGa1JuSnZiVWR5YjNWd1ZISmhibk5oWTNScGIyNWJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B5WldGa1JuSnZiVWR5YjNWd1ZISmhibk5oWTNScGIyNDZDaUFnSUNBdkx5QmpiMjUwY21GamRITXZVMk55WVhSamFGTjBiM0poWjJVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvM05DMDNOUW9nSUNBZ0x5OGdRSEpsWVdSdmJteDVDaUFnSUNBdkx5QndkV0pzYVdNZ2NtVmhaRVp5YjIxSGNtOTFjRlJ5WVc1ellXTjBhVzl1S0dkeWIzVndTVzVrWlhnNklIVnBiblEyTkN3Z2MyTnlZWFJqYUZOc2IzUTZJSFZwYm5RMk5DazZJSFZwYm5RMk5DQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZVMk55WVhSamFGTjBiM0poWjJVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvM05nb2dJQ0FnTHk4Z2NtVjBkWEp1SUdkc2IyRmtWV2x1ZERZMEtHZHliM1Z3U1c1a1pYZ3NJSE5qY21GMFkyaFRiRzkwS1FvZ0lDQWdaMnh2WVdSemN3b2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwxTmpjbUYwWTJoVGRHOXlZV2RsTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TnpRdE56VUtJQ0FnSUM4dklFQnlaV0ZrYjI1c2VRb2dJQ0FnTHk4Z2NIVmliR2xqSUhKbFlXUkdjbTl0UjNKdmRYQlVjbUZ1YzJGamRHbHZiaWhuY205MWNFbHVaR1Y0T2lCMWFXNTBOalFzSUhOamNtRjBZMmhUYkc5ME9pQjFhVzUwTmpRcE9pQjFhVzUwTmpRZ2V3b2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUdOdmJuUnlZV04wY3k5VFkzSmhkR05vVTNSdmNtRm5aUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBUWTNKaGRHTm9VM1J2Y21GblpTNXlaV0ZrUW5sMFpYTkdjbTl0UjNKdmRYQlVjbUZ1YzJGamRHbHZibHR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25KbFlXUkNlWFJsYzBaeWIyMUhjbTkxY0ZSeVlXNXpZV04wYVc5dU9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwxTmpjbUYwWTJoVGRHOXlZV2RsTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T0RVdE9EWUtJQ0FnSUM4dklFQnlaV0ZrYjI1c2VRb2dJQ0FnTHk4Z2NIVmliR2xqSUhKbFlXUkNlWFJsYzBaeWIyMUhjbTkxY0ZSeVlXNXpZV04wYVc5dUtHZHliM1Z3U1c1a1pYZzZJSFZwYm5RMk5Dd2djMk55WVhSamFGTnNiM1E2SUhWcGJuUTJOQ2s2SUdKNWRHVnpJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlUWTNKaGRHTm9VM1J2Y21GblpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qZzNDaUFnSUNBdkx5QnlaWFIxY200Z1oyeHZZV1JDZVhSbGN5aG5jbTkxY0VsdVpHVjRMQ0J6WTNKaGRHTm9VMnh2ZENrS0lDQWdJR2RzYjJGa2MzTUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OVRZM0poZEdOb1UzUnZjbUZuWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pnMUxUZzJDaUFnSUNBdkx5QkFjbVZoWkc5dWJIa0tJQ0FnSUM4dklIQjFZbXhwWXlCeVpXRmtRbmwwWlhOR2NtOXRSM0p2ZFhCVWNtRnVjMkZqZEdsdmJpaG5jbTkxY0VsdVpHVjRPaUIxYVc1ME5qUXNJSE5qY21GMFkyaFRiRzkwT2lCMWFXNTBOalFwT2lCaWVYUmxjeUI3Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ289IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFQVNwazV3Y21BaEJJWld4c2J5d2dRV3huYjNKaGJtUWhCQlVmZkhVeEcwRUFKREVaRkVReEdFU0NBd1FCRm94Y0JBN3NDOWtFRVB0S1pqWWFBSTREQUFrQU5BQkVBREVaRkRFWUZCQkRJelVBS0RVQkpEVUNKVFVQTkFJMER6UUJOQUFqRWtRb0VrUk1KQkpFSlJKRWdBVVZIM3gxZ0xBaVF6WWFBUmMyR2dJWHhCWXBURkN3SWtNMkdnRVhOaG9DRjhSSkZSWlhCZ0pNVUNsTVVMQWlRdz09IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6MCwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
