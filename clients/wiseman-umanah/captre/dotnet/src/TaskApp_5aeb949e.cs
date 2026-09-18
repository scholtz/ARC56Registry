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

namespace Arc56.Generated.wiseman_umanah.captre.TaskApp_5aeb949e
{


    //
    // 
    //    On-chain task submission registry.
    //
    //    Stores first-claim task records keyed by a SHA-256 digest of the task
    //    content string. Supports update and deletion so stranded ALGO can always
    //    be recovered.
    //
    //    Attributes
    //    ----------
    //    tasks : BoxMap[Bytes, Bytes]
    //        Maps ``task_hash_key`` (32-byte SHA-256 digest of the task content
    //        string) → serialised JSON metadata blob.
    //        Box key prefix: ``b"t:"``. Box name is always 34 bytes.
    //    
    //
    public class TaskAppProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public TaskAppProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///Write a new task record. Fails if ``task_hash_key`` is already claimed.
        ///</summary>
        /// <param name="task_hash_key">32-byte SHA-256 digest of the task content string. Used as the ``tasks`` box key. Must not already exist — aborts with ``ERR_ALREADY_CLAIMED`` if so. </param>
        /// <param name="task_hash_str">The original task content hash string (UTF-8 encoded). Stored verbatim inside ``metadata_json``; included here for parity with the ``CaptreApp`` ``attest()`` signature. </param>
        /// <param name="task_id">Server-generated UUID for this task record (UTF-8 encoded). </param>
        /// <param name="author">Algorand address of the payer. Stored inside ``metadata_json``; validated non-empty here. </param>
        /// <param name="metadata_json">Full JSON-serialised ``TaskRecord``. Written verbatim to the ``tasks`` box. </param>
        public async Task SubmitTask(byte[] task_hash_key, byte[] task_hash_str, byte[] task_id, string author, byte[] metadata_json, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 106, 210, 252, 167 };
            var task_hash_keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); task_hash_keyAbi.From(task_hash_key);
            var task_hash_strAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); task_hash_strAbi.From(task_hash_str);
            var task_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); task_idAbi.From(task_id);
            var authorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); authorAbi.From(author);
            var metadata_jsonAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); metadata_jsonAbi.From(metadata_json);

            var result = await base.CallApp(new List<object> { abiHandle, task_hash_keyAbi, task_hash_strAbi, task_idAbi, authorAbi, metadata_jsonAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SubmitTask_Transactions(byte[] task_hash_key, byte[] task_hash_str, byte[] task_id, string author, byte[] metadata_json, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 106, 210, 252, 167 };
            var task_hash_keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); task_hash_keyAbi.From(task_hash_key);
            var task_hash_strAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); task_hash_strAbi.From(task_hash_str);
            var task_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); task_idAbi.From(task_id);
            var authorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); authorAbi.From(author);
            var metadata_jsonAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); metadata_jsonAbi.From(metadata_json);

            return await base.MakeTransactionList(new List<object> { abiHandle, task_hash_keyAbi, task_hash_strAbi, task_idAbi, authorAbi, metadata_jsonAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Read a task record by ``task_hash_key``.
        ///</summary>
        /// <param name="task_hash_key">The 32-byte SHA-256 digest key to look up. </param>
        public async Task<byte[]> GetTask(byte[] task_hash_key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 82, 196, 103, 172 };
            var task_hash_keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); task_hash_keyAbi.From(task_hash_key);

            var result = await base.SimApp(new List<object> { abiHandle, task_hash_keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> GetTask_Transactions(byte[] task_hash_key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 82, 196, 103, 172 };
            var task_hash_keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); task_hash_keyAbi.From(task_hash_key);

            return await base.MakeTransactionList(new List<object> { abiHandle, task_hash_keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Check whether a ``task_hash_key`` has already been submitted.
        ///</summary>
        /// <param name="task_hash_key">The 32-byte SHA-256 digest key to check. </param>
        public async Task<bool> TaskExists(byte[] task_hash_key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 176, 19, 52, 209 };
            var task_hash_keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); task_hash_keyAbi.From(task_hash_key);

            var result = await base.SimApp(new List<object> { abiHandle, task_hash_keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> TaskExists_Transactions(byte[] task_hash_key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 176, 19, 52, 209 };
            var task_hash_keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); task_hash_keyAbi.From(task_hash_key);

            return await base.MakeTransactionList(new List<object> { abiHandle, task_hash_keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiVGFza0FwcCIsImRlc2MiOiJcbiAgICBPbi1jaGFpbiB0YXNrIHN1Ym1pc3Npb24gcmVnaXN0cnkuXG5cbiAgICBTdG9yZXMgZmlyc3QtY2xhaW0gdGFzayByZWNvcmRzIGtleWVkIGJ5IGEgU0hBLTI1NiBkaWdlc3Qgb2YgdGhlIHRhc2tcbiAgICBjb250ZW50IHN0cmluZy4gU3VwcG9ydHMgdXBkYXRlIGFuZCBkZWxldGlvbiBzbyBzdHJhbmRlZCBBTEdPIGNhbiBhbHdheXNcbiAgICBiZSByZWNvdmVyZWQuXG5cbiAgICBBdHRyaWJ1dGVzXG4gICAgLS0tLS0tLS0tLVxuICAgIHRhc2tzIDogQm94TWFwW0J5dGVzLCBCeXRlc11cbiAgICAgICAgTWFwcyBgYHRhc2tfaGFzaF9rZXlgYCAoMzItYnl0ZSBTSEEtMjU2IGRpZ2VzdCBvZiB0aGUgdGFzayBjb250ZW50XG4gICAgICAgIHN0cmluZykg4oaSIHNlcmlhbGlzZWQgSlNPTiBtZXRhZGF0YSBibG9iLlxuICAgICAgICBCb3gga2V5IHByZWZpeDogYGBiXCJ0OlwiYGAuIEJveCBuYW1lIGlzIGFsd2F5cyAzNCBieXRlcy5cbiAgICAiLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoic3VibWl0X3Rhc2siLCJkZXNjIjoiV3JpdGUgYSBuZXcgdGFzayByZWNvcmQuIEZhaWxzIGlmIGBgdGFza19oYXNoX2tleWBgIGlzIGFscmVhZHkgY2xhaW1lZC4iLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoidGFza19oYXNoX2tleSIsImRlc2MiOiIzMi1ieXRlIFNIQS0yNTYgZGlnZXN0IG9mIHRoZSB0YXNrIGNvbnRlbnQgc3RyaW5nLiBVc2VkIGFzIHRoZSBgYHRhc2tzYGAgYm94IGtleS4gTXVzdCBub3QgYWxyZWFkeSBleGlzdCDigJQgYWJvcnRzIHdpdGggYGBFUlJfQUxSRUFEWV9DTEFJTUVEYGAgaWYgc28uIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0YXNrX2hhc2hfc3RyIiwiZGVzYyI6IlRoZSBvcmlnaW5hbCB0YXNrIGNvbnRlbnQgaGFzaCBzdHJpbmcgKFVURi04IGVuY29kZWQpLiBTdG9yZWQgdmVyYmF0aW0gaW5zaWRlIGBgbWV0YWRhdGFfanNvbmBgOyBpbmNsdWRlZCBoZXJlIGZvciBwYXJpdHkgd2l0aCB0aGUgYGBDYXB0cmVBcHBgYCBgYGF0dGVzdCgpYGAgc2lnbmF0dXJlLiIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoidGFza19pZCIsImRlc2MiOiJTZXJ2ZXItZ2VuZXJhdGVkIFVVSUQgZm9yIHRoaXMgdGFzayByZWNvcmQgKFVURi04IGVuY29kZWQpLiIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXV0aG9yIiwiZGVzYyI6IkFsZ29yYW5kIGFkZHJlc3Mgb2YgdGhlIHBheWVyLiBTdG9yZWQgaW5zaWRlIGBgbWV0YWRhdGFfanNvbmBgOyB2YWxpZGF0ZWQgbm9uLWVtcHR5IGhlcmUuIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtZXRhZGF0YV9qc29uIiwiZGVzYyI6IkZ1bGwgSlNPTi1zZXJpYWxpc2VkIGBgVGFza1JlY29yZGBgLiBXcml0dGVuIHZlcmJhdGltIHRvIHRoZSBgYHRhc2tzYGAgYm94LiIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfdGFzayIsImRlc2MiOiJSZWFkIGEgdGFzayByZWNvcmQgYnkgYGB0YXNrX2hhc2hfa2V5YGAuIiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRhc2tfaGFzaF9rZXkiLCJkZXNjIjoiVGhlIDMyLWJ5dGUgU0hBLTI1NiBkaWdlc3Qga2V5IHRvIGxvb2sgdXAuIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6IlRoZSByYXcgSlNPTiBtZXRhZGF0YSBibG9iIHN0b3JlZCBpbiB0aGUgYm94LCBvciBgYGJcIlwiYGAgaWYgbm8gYm94IGV4aXN0cyBmb3IgdGhpcyBrZXkuIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0YXNrX2V4aXN0cyIsImRlc2MiOiJDaGVjayB3aGV0aGVyIGEgYGB0YXNrX2hhc2hfa2V5YGAgaGFzIGFscmVhZHkgYmVlbiBzdWJtaXR0ZWQuIiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRhc2tfaGFzaF9rZXkiLCJkZXNjIjoiVGhlIDMyLWJ5dGUgU0hBLTI1NiBkaWdlc3Qga2V5IHRvIGNoZWNrLiIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjoiYGBUcnVlYGAgaWYgYSBib3ggZXhpc3RzIGZvciB0aGlzIGtleSwgYGBGYWxzZWBgIG90aGVyd2lzZS4ifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6WyJEZWxldGVBcHBsaWNhdGlvbiIsIlVwZGF0ZUFwcGxpY2F0aW9uIl19LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMTczXSwiZXJyb3JNZXNzYWdlIjoiRVJSX0FMUkVBRFlfQ0xBSU1FRCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE4OV0sImVycm9yTWVzc2FnZSI6IkVSUl9FTVBUWV9BVVRIT1IiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNzddLCJlcnJvck1lc3NhZ2UiOiJFUlJfRU1QVFlfSEFTSCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE4MV0sImVycm9yTWVzc2FnZSI6IkVSUl9FTVBUWV9IQVNIX1NUUiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE4NV0sImVycm9yTWVzc2FnZSI6IkVSUl9FTVBUWV9JRCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE5M10sImVycm9yTWVzc2FnZSI6IkVSUl9FTVBUWV9NRVRBREFUQSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIyOF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudGFza3MgZW50cnkgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODksMTA1LDEyMSwxMzcsMTUzLDIwNiwyNTRdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5NiwxMTIsMTI4LDE0NCwxNjAsMjEzLDI2MV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF3SURJZ01Rb2dJQ0FnWW5sMFpXTmliRzlqYXlBd2VEYzBNMkVnTUhneE5URm1OMk0zTlFvZ0lDQWdMeThnTDNSdGNDOWpZWEIwY21WZlkyOXRjR2xzWlM5MFlYTnJYMkZ3Y0M1d2VUb3pNd29nSUNBZ0x5OGdZMnhoYzNNZ1ZHRnphMEZ3Y0NoQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lHSjZJRzFoYVc1ZlltRnlaVjl5YjNWMGFXNW5RREV5Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFLSUNBZ0lIQjFjMmhpZVhSbGMzTWdNSGcyWVdReVptTmhOeUF3ZURVeVl6UTJOMkZqSURCNFlqQXhNek0wWkRFZ0x5OGdiV1YwYUc5a0lDSnpkV0p0YVhSZmRHRnpheWhpZVhSbFcxMHNZbmwwWlZ0ZExHSjVkR1ZiWFN4emRISnBibWNzWW5sMFpWdGRLWFp2YVdRaUxDQnRaWFJvYjJRZ0ltZGxkRjkwWVhOcktHSjVkR1ZiWFNsaWVYUmxXMTBpTENCdFpYUm9iMlFnSW5SaGMydGZaWGhwYzNSektHSjVkR1ZiWFNsaWIyOXNJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnYzNWaWJXbDBYM1JoYzJzZ1oyVjBYM1JoYzJzZ2RHRnphMTlsZUdsemRITUtDbTFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF4TnpvS0lDQWdJQzh2SUM5MGJYQXZZMkZ3ZEhKbFgyTnZiWEJwYkdVdmRHRnphMTloY0hBdWNIazZNek1LSUNBZ0lDOHZJR05zWVhOeklGUmhjMnRCY0hBb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lHVnljZ29LYldGcGJsOWlZWEpsWDNKdmRYUnBibWRBTVRJNkNpQWdJQ0F2THlBdmRHMXdMMk5oY0hSeVpWOWpiMjF3YVd4bEwzUmhjMnRmWVhCd0xuQjVPak16Q2lBZ0lDQXZMeUJqYkdGemN5QlVZWE5yUVhCd0tFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0J6ZDJsMFkyZ2diV0ZwYmw5ZlgyRnNaMjl3ZVY5a1pXWmhkV3gwWDJOeVpXRjBaVUF4TXlCdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1UY2diV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRREUzSUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeE55QnRZV2x1WDNWd1pHRjBaVUF4TkNCdFlXbHVYMlJsYkdWMFpVQXhOUW9nSUNBZ1pYSnlDZ3B0WVdsdVgyUmxiR1YwWlVBeE5Ub0tJQ0FnSUM4dklDOTBiWEF2WTJGd2RISmxYMk52YlhCcGJHVXZkR0Z6YTE5aGNIQXVjSGs2TlRZS0lDQWdJQzh2SUVCaGNtTTBMbUpoY21WdFpYUm9iMlFvWVd4c2IzZGZZV04wYVc5dWN6MWJJa1JsYkdWMFpVRndjR3hwWTJGMGFXOXVJbDBwQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzVndaR0YwWlVBeE5Eb0tJQ0FnSUM4dklDOTBiWEF2WTJGd2RISmxYMk52YlhCcGJHVXZkR0Z6YTE5aGNIQXVjSGs2TlRJS0lDQWdJQzh2SUVCaGNtTTBMbUpoY21WdFpYUm9iMlFvWVd4c2IzZGZZV04wYVc5dWN6MWJJbFZ3WkdGMFpVRndjR3hwWTJGMGFXOXVJbDBwQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgxOWZZV3huYjNCNVgyUmxabUYxYkhSZlkzSmxZWFJsUURFek9nb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDRUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmhjMnRmWVhCd0xsUmhjMnRCY0hBdWMzVmliV2wwWDNSaGMydGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B6ZFdKdGFYUmZkR0Z6YXpvS0lDQWdJQzh2SUM5MGJYQXZZMkZ3ZEhKbFgyTnZiWEJwYkdVdmRHRnphMTloY0hBdWNIazZOakFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh4SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk1TQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYekVnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOQW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eElDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURVS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNU0F2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNBdkx5QXZkRzF3TDJOaGNIUnlaVjlqYjIxd2FXeGxMM1JoYzJ0ZllYQndMbkI1T2pFd05nb2dJQ0FnTHk4Z1lYTnpaWEowSUhSaGMydGZhR0Z6YUY5clpYa2dibTkwSUdsdUlITmxiR1l1ZEdGemEzTXNJQ0pGVWxKZlFVeFNSVUZFV1Y5RFRFRkpUVVZFSWdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURjME0yRUtJQ0FnSUdScFp5QTFDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdSVkpTWDBGTVVrVkJSRmxmUTB4QlNVMUZSQW9nSUNBZ0x5OGdMM1J0Y0M5allYQjBjbVZmWTI5dGNHbHNaUzkwWVhOclgyRndjQzV3ZVRveE1EY0tJQ0FnSUM4dklHRnpjMlZ5ZENCMFlYTnJYMmhoYzJoZmEyVjVMbXhsYm1kMGFDQStJRlZKYm5RMk5DZ3dLU3dnSWtWU1VsOUZUVkJVV1Y5SVFWTklJZ29nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0JzWlc0S0lDQWdJR0Z6YzJWeWRDQXZMeUJGVWxKZlJVMVFWRmxmU0VGVFNBb2dJQ0FnTHk4Z0wzUnRjQzlqWVhCMGNtVmZZMjl0Y0dsc1pTOTBZWE5yWDJGd2NDNXdlVG94TURnS0lDQWdJQzh2SUdGemMyVnlkQ0IwWVhOclgyaGhjMmhmYzNSeUxteGxibWQwYUNBK0lGVkpiblEyTkNnd0tTd2dJa1ZTVWw5RlRWQlVXVjlJUVZOSVgxTlVVaUlLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnYkdWdUNpQWdJQ0JoYzNObGNuUWdMeThnUlZKU1gwVk5VRlJaWDBoQlUwaGZVMVJTQ2lBZ0lDQXZMeUF2ZEcxd0wyTmhjSFJ5WlY5amIyMXdhV3hsTDNSaGMydGZZWEJ3TG5CNU9qRXdPUW9nSUNBZ0x5OGdZWE56WlhKMElIUmhjMnRmYVdRdWJHVnVaM1JvSUQ0Z1ZVbHVkRFkwS0RBcExDQWlSVkpTWDBWTlVGUlpYMGxFSWdvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCc1pXNEtJQ0FnSUdGemMyVnlkQ0F2THlCRlVsSmZSVTFRVkZsZlNVUUtJQ0FnSUM4dklDOTBiWEF2WTJGd2RISmxYMk52YlhCcGJHVXZkR0Z6YTE5aGNIQXVjSGs2TVRFd0NpQWdJQ0F2THlCaGMzTmxjblFnWVhWMGFHOXlMbUo1ZEdWekxteGxibWQwYUNBK0lGVkpiblEyTkNnd0tTd2dJa1ZTVWw5RlRWQlVXVjlCVlZSSVQxSWlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR3hsYmdvZ0lDQWdZWE56WlhKMElDOHZJRVZTVWw5RlRWQlVXVjlCVlZSSVQxSUtJQ0FnSUM4dklDOTBiWEF2WTJGd2RISmxYMk52YlhCcGJHVXZkR0Z6YTE5aGNIQXVjSGs2TVRFeENpQWdJQ0F2THlCaGMzTmxjblFnYldWMFlXUmhkR0ZmYW5OdmJpNXNaVzVuZEdnZ1BpQlZTVzUwTmpRb01Da3NJQ0pGVWxKZlJVMVFWRmxmVFVWVVFVUkJWRUVpQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQmhjM05sY25RZ0x5OGdSVkpTWDBWTlVGUlpYMDFGVkVGRVFWUkJDaUFnSUNBdkx5QXZkRzF3TDJOaGNIUnlaVjlqYjIxd2FXeGxMM1JoYzJ0ZllYQndMbkI1T2pFeE1nb2dJQ0FnTHk4Z2MyVnNaaTUwWVhOcmMxdDBZWE5yWDJoaGMyaGZhMlY1WFNBOUlHMWxkR0ZrWVhSaFgycHpiMjRLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlBdmRHMXdMMk5oY0hSeVpWOWpiMjF3YVd4bEwzUmhjMnRmWVhCd0xuQjVPall3Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFlYTnJYMkZ3Y0M1VVlYTnJRWEJ3TG1kbGRGOTBZWE5yVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1oyVjBYM1JoYzJzNkNpQWdJQ0F2THlBdmRHMXdMMk5oY0hSeVpWOWpiMjF3YVd4bEwzUmhjMnRmWVhCd0xuQjVPakV4TkFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYekVnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ0x5OGdMM1J0Y0M5allYQjBjbVZmWTI5dGNHbHNaUzkwWVhOclgyRndjQzV3ZVRveE16QUtJQ0FnSUM4dklHbG1JSFJoYzJ0ZmFHRnphRjlyWlhrZ2FXNGdjMlZzWmk1MFlYTnJjem9LSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGczTkROaENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmllaUJuWlhSZmRHRnphMTloWm5SbGNsOXBabDlsYkhObFFETUtJQ0FnSUM4dklDOTBiWEF2WTJGd2RISmxYMk52YlhCcGJHVXZkR0Z6YTE5aGNIQXVjSGs2TVRNeENpQWdJQ0F2THlCeVpYUjFjbTRnYzJWc1ppNTBZWE5yYzF0MFlYTnJYMmhoYzJoZmEyVjVYUW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1ZEdGemEzTWdaVzUwY25rZ1pYaHBjM1J6Q2dwblpYUmZkR0Z6YTE5aFpuUmxjbDlwYm14cGJtVmtYM1JoYzJ0ZllYQndMbFJoYzJ0QmNIQXVaMlYwWDNSaGMydEFORG9LSUNBZ0lDOHZJQzkwYlhBdlkyRndkSEpsWDJOdmJYQnBiR1V2ZEdGemExOWhjSEF1Y0hrNk1URTBDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3BuWlhSZmRHRnphMTloWm5SbGNsOXBabDlsYkhObFFETTZDaUFnSUNCd2IzQUtJQ0FnSUM4dklDOTBiWEF2WTJGd2RISmxYMk52YlhCcGJHVXZkR0Z6YTE5aGNIQXVjSGs2TVRNeUNpQWdJQ0F2THlCeVpYUjFjbTRnUW5sMFpYTW9ZaUlpS1FvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0Q2lBZ0lDQXZMeUF2ZEcxd0wyTmhjSFJ5WlY5amIyMXdhV3hsTDNSaGMydGZZWEJ3TG5CNU9qRXhOQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQmlJR2RsZEY5MFlYTnJYMkZtZEdWeVgybHViR2x1WldSZmRHRnphMTloY0hBdVZHRnphMEZ3Y0M1blpYUmZkR0Z6YTBBMENnb0tMeThnZEdGemExOWhjSEF1VkdGemEwRndjQzUwWVhOclgyVjRhWE4wYzF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuUmhjMnRmWlhocGMzUnpPZ29nSUNBZ0x5OGdMM1J0Y0M5allYQjBjbVZmWTI5dGNHbHNaUzkwWVhOclgyRndjQzV3ZVRveE16UUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eElDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJQzh2SUM5MGJYQXZZMkZ3ZEhKbFgyTnZiWEJwYkdVdmRHRnphMTloY0hBdWNIazZNVFE1Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdkR0Z6YTE5b1lYTm9YMnRsZVNCcGJpQnpaV3htTG5SaGMydHpDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjROelF6WVFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lDOHZJQzkwYlhBdlkyRndkSEpsWDJOdmJYQnBiR1V2ZEdGemExOWhjSEF1Y0hrNk1UTTBDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6WlhSaWFYUUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFEQUFJQkpnSUNkRG9FRlI5OGRURWJRUUFrTVJrVVJERVlSSUlEQkdyUy9LY0VVc1JuckFTd0V6VFJOaG9BamdNQUhBQ1JBTUVBTVJtTkJnQUgvKy8vNy8vdkFBUUFBUUF4R0VNeEdFTXhHQlJETmhvQlNTSlpJd2hMQVJVU1JGY0NBRFlhQWtraVdTTUlTd0VWRWtSWEFnQTJHZ05KSWxrakNFc0JGUkpFVndJQU5ob0VTU0paSXdoTEFSVVNSRmNDQURZYUJVa2lXU01JU3dFVkVrUlhBZ0FvU3dWUVNiMUZBUlJFVHdVVlJFOEVGVVJQQXhWRVR3SVZSRXNCRlVSSnZFaE12eVJETmhvQlNTSlpJd2hMQVJVU1JGY0NBQ2hNVUVtOVJRRkJBQkMrUkVrVkZsY0dBa3hRS1V4UXNDUkRTSUFBUXYvc05ob0JTU0paSXdoTEFSVVNSRmNDQUNoTVVMMUZBWUFCQUNKUEFsUXBURkN3SkVNPSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjEwLCJwYXRjaCI6MSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
