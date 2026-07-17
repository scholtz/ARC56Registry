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

namespace Arc56.Generated.krittikabiswas.Durga_Puja_2025.AnjoliDAO_4032bf59
{


    //
    // 
    //    AnjoliDAO ARC-4 contract (Algorand Python / Puya).
    //    - On create: mints the "Anjoli Token" ASA and saves its id to contract state.
    //    - donate(): accepts a direct payment to the app call and sends ANJ tokens back.
    //    
    //
    public class AnjoliDAOProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public AnjoliDAOProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///Runs on creation (when called as the create/constructor). Mints the Anjoli Token ASA
        ///and stores the created asset id into `self.token_id`.
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
        ///Lets a user donate ALGO in the same call (single transaction) and receive ANJ in return.
        ///</summary>
        public async Task Donate(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 188, 15, 249, 247 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Donate_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 188, 15, 249, 247 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Returns the Asset ID of the token minted by this contract (0 if not yet created).
        ///</summary>
        public async Task<ulong> GetAssetId(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 91, 162, 42, 132 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetAssetId_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 91, 162, 42, 132 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQW5qb2xpREFPIiwiZGVzYyI6IlxuICAgIEFuam9saURBTyBBUkMtNCBjb250cmFjdCAoQWxnb3JhbmQgUHl0aG9uIC8gUHV5YSkuXG4gICAgLSBPbiBjcmVhdGU6IG1pbnRzIHRoZSBcIkFuam9saSBUb2tlblwiIEFTQSBhbmQgc2F2ZXMgaXRzIGlkIHRvIGNvbnRyYWN0IHN0YXRlLlxuICAgIC0gZG9uYXRlKCk6IGFjY2VwdHMgYSBkaXJlY3QgcGF5bWVudCB0byB0aGUgYXBwIGNhbGwgYW5kIHNlbmRzIEFOSiB0b2tlbnMgYmFjay5cbiAgICAiLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoiY3JlYXRlIiwiZGVzYyI6IlJ1bnMgb24gY3JlYXRpb24gKHdoZW4gY2FsbGVkIGFzIHRoZSBjcmVhdGUvY29uc3RydWN0b3IpLiBNaW50cyB0aGUgQW5qb2xpIFRva2VuIEFTQVxuYW5kIHN0b3JlcyB0aGUgY3JlYXRlZCBhc3NldCBpZCBpbnRvIGBzZWxmLnRva2VuX2lkYC4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZG9uYXRlIiwiZGVzYyI6IkxldHMgYSB1c2VyIGRvbmF0ZSBBTEdPIGluIHRoZSBzYW1lIGNhbGwgKHNpbmdsZSB0cmFuc2FjdGlvbikgYW5kIHJlY2VpdmUgQU5KIGluIHJldHVybi4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X2Fzc2V0X2lkIiwiZGVzYyI6IlJldHVybnMgdGhlIEFzc2V0IElEIG9mIHRoZSB0b2tlbiBtaW50ZWQgYnkgdGhpcyBjb250cmFjdCAoMCBpZiBub3QgeWV0IGNyZWF0ZWQpLiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjEsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls4NCwxMDYsMTE4XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIGlzIG5vdCBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODcsMTA5XSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIG5vdCBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE4NiwyMjVdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnRva2VuX2lkIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIwNV0sImVycm9yTWVzc2FnZSI6ImRvbmF0aW9uIHRvbyBzbWFsbCBmb3IgYW55IEFOSiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE5OF0sImVycm9yTWVzc2FnZSI6InBheW1lbnQgbXVzdCBiZSB0byBhcHAgYWRkcmVzcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11WVc1cWIyeHBYMlJoYnk1amIyNTBjbUZqZEM1QmJtcHZiR2xFUVU4dVgxOWhiR2R2Y0hsZlpXNTBjbmx3YjJsdWRGOTNhWFJvWDJsdWFYUW9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01DQXhJREV3TURBd01EQXdJRE1LSUNBZ0lHSjVkR1ZqWW14dlkyc2dJblJ2YTJWdVgybGtJaUFpUVU1S0lpQWlRVzVxYjJ4cElGUnZhMlZ1SWdvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKdWVpQnRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnVhbTlzYVY5a1lXOHZZMjl1ZEhKaFkzUXVjSGs2TVRJdE1UTUtJQ0FnSUM4dklDTWdjM1J2Y21Wa0lFRlRRU0JwWkNBb01DQnRaV0Z1Y3lBaWJtOTBJR055WldGMFpXUWdlV1YwSWlrS0lDQWdJQzh2SUhObGJHWXVkRzlyWlc1ZmFXUTZJR0ZzWjI5d2VTNVZTVzUwTmpRZ1BTQmhiR2R2Y0hrdVZVbHVkRFkwS0RBcENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKMGIydGxibDlwWkNJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvS2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFESTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXNXFiMnhwWDJSaGJ5OWpiMjUwY21GamRDNXdlVG8wQ2lBZ0lDQXZMeUJqYkdGemN5QkJibXB2YkdsRVFVOG9ZV3huYjNCNUxrRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzRnVG5WdFFYQndRWEpuY3dvZ0lDQWdZbm9nYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURnS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhnMFl6VmpOakZpWVNBd2VHSmpNR1ptT1dZM0lEQjROV0poTWpKaE9EUWdMeThnYldWMGFHOWtJQ0pqY21WaGRHVW9LWFp2YVdRaUxDQnRaWFJvYjJRZ0ltUnZibUYwWlNncGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWjJWMFgyRnpjMlYwWDJsa0tDbDFhVzUwTmpRaUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQnRZV2x1WDJOeVpXRjBaVjl5YjNWMFpVQTFJRzFoYVc1ZlpHOXVZWFJsWDNKdmRYUmxRRFlnYldGcGJsOW5aWFJmWVhOelpYUmZhV1JmY205MWRHVkFOd29LYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURnNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVc1cWIyeHBYMlJoYnk5amIyNTBjbUZqZEM1d2VUbzBDaUFnSUNBdkx5QmpiR0Z6Y3lCQmJtcHZiR2xFUVU4b1lXeG5iM0I1TGtGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyZGxkRjloYzNObGRGOXBaRjl5YjNWMFpVQTNPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnVhbTlzYVY5a1lXOHZZMjl1ZEhKaFkzUXVjSGs2TnpNS0lDQWdJQzh2SUVCaGJHZHZjSGt1WVhKak5DNWhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdZMkZzYkhOMVlpQm5aWFJmWVhOelpYUmZhV1FLSUNBZ0lHbDBiMklLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWtiMjVoZEdWZmNtOTFkR1ZBTmpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYm1wdmJHbGZaR0Z2TDJOdmJuUnlZV04wTG5CNU9qUTJDaUFnSUNBdkx5QkFZV3huYjNCNUxtRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lHTmhiR3h6ZFdJZ1pHOXVZWFJsQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMk55WldGMFpWOXliM1YwWlVBMU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGdWFtOXNhVjlrWVc4dlkyOXVkSEpoWTNRdWNIazZNVFV0TVRZS0lDQWdJQzh2SUNNZ1FXeHNiM2NnZEdocGN5QnRaWFJvYjJRZ2RHOGdZbVVnZFhObFpDQm1iM0lnWVhCd0lHTnlaV0YwYVc5dUlDaGpjbVZoZEdVOUltRnNiRzkzSWlrS0lDQWdJQzh2SUVCaGJHZHZjSGt1WVhKak5DNWhZbWx0WlhSb2IyUW9ZM0psWVhSbFBTSmhiR3h2ZHlJcENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCallXeHNjM1ZpSUdOeVpXRjBaUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1aGJtcHZiR2xmWkdGdkxtTnZiblJ5WVdOMExrRnVhbTlzYVVSQlR5NWpjbVZoZEdVb0tTQXRQaUIyYjJsa09ncGpjbVZoZEdVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVc1cWIyeHBYMlJoYnk5amIyNTBjbUZqZEM1d2VUb3lNaTB6TVFvZ0lDQWdMeThnSXlCbWFYSnpkQ0J6ZFdKdGFYUUtJQ0FnSUM4dklHRnNaMjl3ZVM1cGRIaHVMa0Z6YzJWMFEyOXVabWxuS0FvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDI1aGJXVTlJa0Z1YW05c2FTQlViMnRsYmlJc0NpQWdJQ0F2THlBZ0lDQWdkVzVwZEY5dVlXMWxQU0pCVGtvaUxBb2dJQ0FnTHk4Z0lDQWdJSFJ2ZEdGc1BXRnNaMjl3ZVM1VlNXNTBOalFvTVRCZk1EQXdYekF3TUNrc0NpQWdJQ0F2THlBZ0lDQWdaR1ZqYVcxaGJITTlZV3huYjNCNUxsVkpiblEyTkNnd0tTd0tJQ0FnSUM4dklDQWdJQ0J0WVc1aFoyVnlQV0ZzWjI5d2VTNUhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQWdJSEpsYzJWeWRtVTlZV3huYjNCNUxrZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lDQWdabVZsUFdGc1oyOXdlUzVWU1c1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXNXFiMnhwWDJSaGJ5OWpiMjUwY21GamRDNXdlVG95T0FvZ0lDQWdMeThnYldGdVlXZGxjajFoYkdkdmNIa3VSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN5d0tJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXNXFiMnhwWDJSaGJ5OWpiMjUwY21GamRDNXdlVG95T1FvZ0lDQWdMeThnY21WelpYSjJaVDFoYkdkdmNIa3VSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN5d0tJQ0FnSUdSMWNBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCRGIyNW1hV2RCYzNObGRGSmxjMlZ5ZG1VS0lDQWdJR2wwZUc1ZlptbGxiR1FnUTI5dVptbG5RWE56WlhSTllXNWhaMlZ5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZVzVxYjJ4cFgyUmhieTlqYjI1MGNtRmpkQzV3ZVRveU53b2dJQ0FnTHk4Z1pHVmphVzFoYkhNOVlXeG5iM0I1TGxWSmJuUTJOQ2d3S1N3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRU52Ym1acFowRnpjMlYwUkdWamFXMWhiSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhibXB2YkdsZlpHRnZMMk52Ym5SeVlXTjBMbkI1T2pJMkNpQWdJQ0F2THlCMGIzUmhiRDFoYkdkdmNIa3VWVWx1ZERZMEtERXdYekF3TUY4d01EQXBMQW9nSUNBZ2FXNTBZMTh5SUM4dklERXdNREF3TURBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVOdmJtWnBaMEZ6YzJWMFZHOTBZV3dLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhibXB2YkdsZlpHRnZMMk52Ym5SeVlXTjBMbkI1T2pJMUNpQWdJQ0F2THlCMWJtbDBYMjVoYldVOUlrRk9TaUlzQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0pCVGtvaUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVOdmJtWnBaMEZ6YzJWMFZXNXBkRTVoYldVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYm1wdmJHbGZaR0Z2TDJOdmJuUnlZV04wTG5CNU9qSTBDaUFnSUNBdkx5QmhjM05sZEY5dVlXMWxQU0pCYm1wdmJHa2dWRzlyWlc0aUxBb2dJQ0FnWW5sMFpXTmZNaUF2THlBaVFXNXFiMnhwSUZSdmEyVnVJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkRiMjVtYVdkQmMzTmxkRTVoYldVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYm1wdmJHbGZaR0Z2TDJOdmJuUnlZV04wTG5CNU9qSXlMVEl6Q2lBZ0lDQXZMeUFqSUdacGNuTjBJSE4xWW0xcGRBb2dJQ0FnTHk4Z1lXeG5iM0I1TG1sMGVHNHVRWE56WlhSRGIyNW1hV2NvQ2lBZ0lDQnBiblJqWHpNZ0x5OGdZV05tWndvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnVhbTlzYVY5a1lXOHZZMjl1ZEhKaFkzUXVjSGs2TXpBS0lDQWdJQzh2SUdabFpUMWhiR2R2Y0hrdVZVbHVkRFkwS0RBcExBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVc1cWIyeHBYMlJoYnk5amIyNTBjbUZqZEM1d2VUb3lNaTB6TVFvZ0lDQWdMeThnSXlCbWFYSnpkQ0J6ZFdKdGFYUUtJQ0FnSUM4dklHRnNaMjl3ZVM1cGRIaHVMa0Z6YzJWMFEyOXVabWxuS0FvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDI1aGJXVTlJa0Z1YW05c2FTQlViMnRsYmlJc0NpQWdJQ0F2THlBZ0lDQWdkVzVwZEY5dVlXMWxQU0pCVGtvaUxBb2dJQ0FnTHk4Z0lDQWdJSFJ2ZEdGc1BXRnNaMjl3ZVM1VlNXNTBOalFvTVRCZk1EQXdYekF3TUNrc0NpQWdJQ0F2THlBZ0lDQWdaR1ZqYVcxaGJITTlZV3huYjNCNUxsVkpiblEyTkNnd0tTd0tJQ0FnSUM4dklDQWdJQ0J0WVc1aFoyVnlQV0ZzWjI5d2VTNUhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQWdJSEpsYzJWeWRtVTlZV3huYjNCNUxrZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lDQWdabVZsUFdGc1oyOXdlUzVWU1c1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnVhbTlzYVY5a1lXOHZZMjl1ZEhKaFkzUXVjSGs2TXpNdE5ESUtJQ0FnSUM4dklDTWdjMlZqYjI1a0lITjFZbTFwZENBb2EyVndkQ0JsZUdGamRHeDVJR0Z6SUhsdmRTQm9ZV1FwQ2lBZ0lDQXZMeUJ5WlhOMWJIUWdQU0JoYkdkdmNIa3VhWFI0Ymk1QmMzTmxkRU52Ym1acFp5Z0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGOXVZVzFsUFNKQmJtcHZiR2tnVkc5clpXNGlMQW9nSUNBZ0x5OGdJQ0FnSUhWdWFYUmZibUZ0WlQwaVFVNUtJaXdLSUNBZ0lDOHZJQ0FnSUNCMGIzUmhiRDFoYkdkdmNIa3VWVWx1ZERZMEtERXdYekF3TUY4d01EQXBMQW9nSUNBZ0x5OGdJQ0FnSUdSbFkybHRZV3h6UFdGc1oyOXdlUzVWU1c1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFnSUNBZ2JXRnVZV2RsY2oxaGJHZHZjSGt1UjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnSUNCeVpYTmxjblpsUFdGc1oyOXdlUzVIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0FnSUdabFpUMWhiR2R2Y0hrdVZVbHVkRFkwS0RBcExBb2dJQ0FnTHk4Z0tTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ1YW05c2FWOWtZVzh2WTI5dWRISmhZM1F1Y0hrNk16a0tJQ0FnSUM4dklHMWhibUZuWlhJOVlXeG5iM0I1TGtkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM01zQ2lBZ0lDQm5iRzlpWVd3Z1EzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ1YW05c2FWOWtZVzh2WTI5dWRISmhZM1F1Y0hrNk5EQUtJQ0FnSUM4dklISmxjMlZ5ZG1VOVlXeG5iM0I1TGtkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM01zQ2lBZ0lDQmtkWEFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRMjl1Wm1sblFYTnpaWFJTWlhObGNuWmxDaUFnSUNCcGRIaHVYMlpwWld4a0lFTnZibVpwWjBGemMyVjBUV0Z1WVdkbGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGdWFtOXNhVjlrWVc4dlkyOXVkSEpoWTNRdWNIazZNemdLSUNBZ0lDOHZJR1JsWTJsdFlXeHpQV0ZzWjI5d2VTNVZTVzUwTmpRb01Da3NDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCRGIyNW1hV2RCYzNObGRFUmxZMmx0WVd4ekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVc1cWIyeHBYMlJoYnk5amIyNTBjbUZqZEM1d2VUb3pOd29nSUNBZ0x5OGdkRzkwWVd3OVlXeG5iM0I1TGxWSmJuUTJOQ2d4TUY4d01EQmZNREF3S1N3S0lDQWdJR2x1ZEdOZk1pQXZMeUF4TURBd01EQXdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkRiMjVtYVdkQmMzTmxkRlJ2ZEdGc0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVc1cWIyeHBYMlJoYnk5amIyNTBjbUZqZEM1d2VUb3pOZ29nSUNBZ0x5OGdkVzVwZEY5dVlXMWxQU0pCVGtvaUxBb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVFVNUtJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkRiMjVtYVdkQmMzTmxkRlZ1YVhST1lXMWxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXNXFiMnhwWDJSaGJ5OWpiMjUwY21GamRDNXdlVG96TlFvZ0lDQWdMeThnWVhOelpYUmZibUZ0WlQwaVFXNXFiMnhwSUZSdmEyVnVJaXdLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJa0Z1YW05c2FTQlViMnRsYmlJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUTI5dVptbG5RWE56WlhST1lXMWxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXNXFiMnhwWDJSaGJ5OWpiMjUwY21GamRDNXdlVG96TXkwek5Bb2dJQ0FnTHk4Z0l5QnpaV052Ym1RZ2MzVmliV2wwSUNoclpYQjBJR1Y0WVdOMGJIa2dZWE1nZVc5MUlHaGhaQ2tLSUNBZ0lDOHZJSEpsYzNWc2RDQTlJR0ZzWjI5d2VTNXBkSGh1TGtGemMyVjBRMjl1Wm1sbktBb2dJQ0FnYVc1MFkxOHpJQzh2SUdGalptY0tJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYm1wdmJHbGZaR0Z2TDJOdmJuUnlZV04wTG5CNU9qUXhDaUFnSUNBdkx5Qm1aV1U5WVd4bmIzQjVMbFZKYm5RMk5DZ3dLU3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnVhbTlzYVY5a1lXOHZZMjl1ZEhKaFkzUXVjSGs2TXpNdE5ESUtJQ0FnSUM4dklDTWdjMlZqYjI1a0lITjFZbTFwZENBb2EyVndkQ0JsZUdGamRHeDVJR0Z6SUhsdmRTQm9ZV1FwQ2lBZ0lDQXZMeUJ5WlhOMWJIUWdQU0JoYkdkdmNIa3VhWFI0Ymk1QmMzTmxkRU52Ym1acFp5Z0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGOXVZVzFsUFNKQmJtcHZiR2tnVkc5clpXNGlMQW9nSUNBZ0x5OGdJQ0FnSUhWdWFYUmZibUZ0WlQwaVFVNUtJaXdLSUNBZ0lDOHZJQ0FnSUNCMGIzUmhiRDFoYkdkdmNIa3VWVWx1ZERZMEtERXdYekF3TUY4d01EQXBMQW9nSUNBZ0x5OGdJQ0FnSUdSbFkybHRZV3h6UFdGc1oyOXdlUzVWU1c1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFnSUNBZ2JXRnVZV2RsY2oxaGJHZHZjSGt1UjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnSUNCeVpYTmxjblpsUFdGc1oyOXdlUzVIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0FnSUdabFpUMWhiR2R2Y0hrdVZVbHVkRFkwS0RBcExBb2dJQ0FnTHk4Z0tTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYm1wdmJHbGZaR0Z2TDJOdmJuUnlZV04wTG5CNU9qUTBDaUFnSUNBdkx5QnpaV3htTG5SdmEyVnVYMmxrSUQwZ2NtVnpkV3gwTG1OeVpXRjBaV1JmWVhOelpYUXVhV1FLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJblJ2YTJWdVgybGtJZ29nSUNBZ2FYUjRiaUJEY21WaGRHVmtRWE56WlhSSlJBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1aGJtcHZiR2xmWkdGdkxtTnZiblJ5WVdOMExrRnVhbTlzYVVSQlR5NWtiMjVoZEdVb0tTQXRQaUIyYjJsa09ncGtiMjVoZEdVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVc1cWIyeHBYMlJoYnk5amIyNTBjbUZqZEM1d2VUbzFNUW9nSUNBZ0x5OGdZWE56WlhKMElITmxiR1l1ZEc5clpXNWZhV1FnSVQwZ1lXeG5iM0I1TGxWSmJuUTJOQ2d3S1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJblJ2YTJWdVgybGtJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5SdmEyVnVYMmxrSUdWNGFYTjBjd29nSUNBZ1pIVndDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhibXB2YkdsZlpHRnZMMk52Ym5SeVlXTjBMbkI1T2pVekxUVTBDaUFnSUNBdkx5QWpJSE5sYm1SbGNpQnBjeUJVZUc0dWMyVnVaR1Z5TENCaGJXOTFiblFnYVhNZ1ZIaHVMbUZ0YjNWdWRBb2dJQ0FnTHk4Z1pHOXViM0lnUFNCaGJHZHZjSGt1VkhodUxuTmxibVJsY2dvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnVhbTlzYVY5a1lXOHZZMjl1ZEhKaFkzUXVjSGs2TlRVS0lDQWdJQzh2SUdGdGIzVnVkQ0E5SUdGc1oyOXdlUzVVZUc0dVlXMXZkVzUwQ2lBZ0lDQjBlRzRnUVcxdmRXNTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXNXFiMnhwWDJSaGJ5OWpiMjUwY21GamRDNXdlVG8xTmdvZ0lDQWdMeThnY21WalpXbDJaWElnUFNCaGJHZHZjSGt1VkhodUxuSmxZMlZwZG1WeUNpQWdJQ0IwZUc0Z1VtVmpaV2wyWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYm1wdmJHbGZaR0Z2TDJOdmJuUnlZV04wTG5CNU9qVTRMVFU1Q2lBZ0lDQXZMeUFqSUcxaGEyVWdjM1Z5WlNCd1lYbHRaVzUwSUdseklIUnZJR0Z3Y0FvZ0lDQWdMeThnWVhOelpYSjBJSEpsWTJWcGRtVnlJRDA5SUdGc1oyOXdlUzVIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMQ0FpY0dGNWJXVnVkQ0J0ZFhOMElHSmxJSFJ2SUdGd2NDQmhaR1J5WlhOeklnb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnY0dGNWJXVnVkQ0J0ZFhOMElHSmxJSFJ2SUdGd2NDQmhaR1J5WlhOekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVc1cWIyeHBYMlJoYnk5amIyNTBjbUZqZEM1d2VUbzJNUzAyTWdvZ0lDQWdMeThnSXlCUWNtbGpaU0J5WVhScGJ6b2dNU0JCVEVkUElDZ3hYekF3TUY4d01EQXBJQzArSURFd0lFRk9TZ29nSUNBZ0x5OGdkRzlyWlc1elgzUnZYM05sYm1RZ1BTQmhiVzkxYm5RZ0x5OGdZV3huYjNCNUxsVkpiblEyTkNneE1EQmZNREF3S1FvZ0lDQWdjSFZ6YUdsdWRDQXhNREF3TURBZ0x5OGdNVEF3TURBd0NpQWdJQ0F2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZVzVxYjJ4cFgyUmhieTlqYjI1MGNtRmpkQzV3ZVRvMk13b2dJQ0FnTHk4Z1lYTnpaWEowSUhSdmEyVnVjMTkwYjE5elpXNWtJQ0U5SUdGc1oyOXdlUzVWU1c1ME5qUW9NQ2tzSUNKa2IyNWhkR2x2YmlCMGIyOGdjMjFoYkd3Z1ptOXlJR0Z1ZVNCQlRrb2lDaUFnSUNCa2RYQUtJQ0FnSUdGemMyVnlkQ0F2THlCa2IyNWhkR2x2YmlCMGIyOGdjMjFoYkd3Z1ptOXlJR0Z1ZVNCQlRrb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJtcHZiR2xmWkdGdkwyTnZiblJ5WVdOMExuQjVPalkxTFRjeENpQWdJQ0F2THlBaklITmxibVFnWW1GamF5QkJUa29LSUNBZ0lDOHZJR0ZzWjI5d2VTNXBkSGh1TGtGemMyVjBWSEpoYm5ObVpYSW9DaUFnSUNBdkx5QWdJQ0FnZUdabGNsOWhjM05sZEQxelpXeG1MblJ2YTJWdVgybGtMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBYM0psWTJWcGRtVnlQV1J2Ym05eUxBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFgyRnRiM1Z1ZEQxMGIydGxibk5mZEc5ZmMyVnVaQ3dLSUNBZ0lDOHZJQ0FnSUNCbVpXVTlZV3huYjNCNUxsVkpiblEyTkNnd0tTd0tJQ0FnSUM4dklDa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhOelpYUkJiVzkxYm5RS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhOelpYUlNaV05sYVhabGNnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCWVptVnlRWE56WlhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYm1wdmJHbGZaR0Z2TDJOdmJuUnlZV04wTG5CNU9qWTFMVFkyQ2lBZ0lDQXZMeUFqSUhObGJtUWdZbUZqYXlCQlRrb0tJQ0FnSUM4dklHRnNaMjl3ZVM1cGRIaHVMa0Z6YzJWMFZISmhibk5tWlhJb0NpQWdJQ0J3ZFhOb2FXNTBJRFFnTHk4Z1lYaG1aWElLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJtcHZiR2xmWkdGdkwyTnZiblJ5WVdOMExuQjVPamN3Q2lBZ0lDQXZMeUJtWldVOVlXeG5iM0I1TGxWSmJuUTJOQ2d3S1N3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ1YW05c2FWOWtZVzh2WTI5dWRISmhZM1F1Y0hrNk5qVXROekVLSUNBZ0lDOHZJQ01nYzJWdVpDQmlZV05ySUVGT1Nnb2dJQ0FnTHk4Z1lXeG5iM0I1TG1sMGVHNHVRWE56WlhSVWNtRnVjMlpsY2lnS0lDQWdJQzh2SUNBZ0lDQjRabVZ5WDJGemMyVjBQWE5sYkdZdWRHOXJaVzVmYVdRc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSZmNtVmpaV2wyWlhJOVpHOXViM0lzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJmWVcxdmRXNTBQWFJ2YTJWdWMxOTBiMTl6Wlc1a0xBb2dJQ0FnTHk4Z0lDQWdJR1psWlQxaGJHZHZjSGt1VlVsdWREWTBLREFwTEFvZ0lDQWdMeThnS1M1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NWhibXB2YkdsZlpHRnZMbU52Ym5SeVlXTjBMa0Z1YW05c2FVUkJUeTVuWlhSZllYTnpaWFJmYVdRb0tTQXRQaUIxYVc1ME5qUTZDbWRsZEY5aGMzTmxkRjlwWkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYm1wdmJHbGZaR0Z2TDJOdmJuUnlZV04wTG5CNU9qYzJDaUFnSUNBdkx5QnlaWFIxY200Z2MyVnNaaTUwYjJ0bGJsOXBaQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0luUnZhMlZ1WDJsa0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MblJ2YTJWdVgybGtJR1Y0YVhOMGN3b2dJQ0FnY21WMGMzVmlDZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01TQXZMeUF4Q2lBZ0lDQnlaWFIxY200SyJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQUVBQUdBcmVJRUF5WURDSFJ2YTJWdVgybGtBMEZPU2d4QmJtcHZiR2tnVkc5clpXNHhHRUFBQXlnaVp6RWJRUUFjZ2dNRVRGeGh1Z1M4RC9uM0JGdWlLb1EyR2dDT0F3QWtBQmdBQWlKRE1Sa1VSREVZUklnQWd4YUFCQlVmZkhWTVVMQWpRekVaRkVReEdFU0lBRVlqUXpFWkZFU0lBQUlqUTdFeUNrbXlLcklwSXJJakpMSWlLYklsS3JJbUpiSVFJcklCczdFeUNrbXlLcklwSXJJakpMSWlLYklsS3JJbUpiSVFJcklCc3lpMFBHZUpJaWhsUkVsRU1RQXhDREVITWdvU1JJR2dqUVlLU1VTeHNoS3lGTElSZ1FTeUVDS3lBYk9KSWlobFJJaz0iLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjQsIm1pbm9yIjoxMCwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
