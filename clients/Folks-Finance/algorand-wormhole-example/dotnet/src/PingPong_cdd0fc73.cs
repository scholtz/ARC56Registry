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

namespace Arc56.Generated.Folks_Finance.algorand_wormhole_example.PingPong_cdd0fc73
{


    public class PingPongProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public PingPongProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="wormhole_core"> </param>
        public async Task Create(ulong wormhole_core, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 13, 47, 103 };
            var wormhole_coreAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); wormhole_coreAbi.From(wormhole_core);

            var result = await base.CallApp(new List<object> { abiHandle, wormhole_coreAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Create_Transactions(ulong wormhole_core, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 13, 47, 103 };
            var wormhole_coreAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); wormhole_coreAbi.From(wormhole_core);

            return await base.MakeTransactionList(new List<object> { abiHandle, wormhole_coreAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="emitter_lsig"> </param>
        public async Task SetEmitterLsig(Algorand.Address emitter_lsig, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 119, 57, 108, 126 };
            var emitter_lsigAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); emitter_lsigAbi.From(emitter_lsig);

            var result = await base.CallApp(new List<object> { abiHandle, emitter_lsigAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetEmitterLsig_Transactions(Algorand.Address emitter_lsig, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 119, 57, 108, 126 };
            var emitter_lsigAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); emitter_lsigAbi.From(emitter_lsig);

            return await base.MakeTransactionList(new List<object> { abiHandle, emitter_lsigAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task Ping(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 24, 139, 143, 180 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Ping_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 24, 139, 143, 180 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="verify_vaa"> </param>
        public async Task ReceiveMessage(ApplicationCallTransaction verify_vaa, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { verify_vaa });
            byte[] abiHandle = { 111, 214, 200, 116 };

            var result = await base.CallApp(new List<object> { abiHandle, verify_vaa }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ReceiveMessage_Transactions(ApplicationCallTransaction verify_vaa, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { verify_vaa });
            byte[] abiHandle = { 111, 214, 200, 116 };

            return await base.MakeTransactionList(new List<object> { abiHandle, verify_vaa }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUGluZ1BvbmciLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoiY3JlYXRlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Indvcm1ob2xlX2NvcmUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0X2VtaXR0ZXJfbHNpZyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZW1pdHRlcl9sc2lnIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InBpbmciLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVjZWl2ZV9tZXNzYWdlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFwcGwiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2ZXJpZnlfdmFhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjoxLCJieXRlcyI6MX0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMzEyXSwiZXJyb3JNZXNzYWdlIjoiQWRkcmVzcyBsZW5ndGggaXMgMzIgYnl0ZXMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMThdLCJlcnJvck1lc3NhZ2UiOiJJbmNvcnJlY3QgYXBwIG9uIGNvbXBsZXRpb24iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMzVdLCJlcnJvck1lc3NhZ2UiOiJJbmNvcnJlY3QgbWV0aG9kIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTEsMjI4LDI0MSwyNTVdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gaXMgbm90IE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMTFdLCJlcnJvck1lc3NhZ2UiOiJVbmtub3duIHBheWxvYWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTNdLCJlcnJvck1lc3NhZ2UiOiJVbmtub3duIHdvcm1ob2xlIGNvcmUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNzhdLCJlcnJvck1lc3NhZ2UiOiJXb3JtaG9sZSBjb3JlIGFkZHJlc3MgdW5rbm93biIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI5Nl0sImVycm9yTWVzc2FnZSI6Ildvcm1ob2xlIG1lc3NhZ2UgZmVlIGlzIHVua25vd24iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNTldLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5NCwyMzEsMjQ0XSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIG5vdCBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMwNl0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuZW1pdHRlcl9sc2lnIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExMSwyNzUsMjgyLDMwMF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYud29ybWhvbGVfY29yZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDRdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIGFwcGwiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmpiMjUwY21GamRITXVVR2x1WjFCdmJtY3VVR2x1WjFCdmJtY3VYMTloYkdkdmNIbGZaVzUwY25sd2IybHVkRjkzYVhSb1gybHVhWFFvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNQ0F4SURZZ05Rb2dJQ0FnWW5sMFpXTmliRzlqYXlBaWQyOXliV2h2YkdWZlkyOXlaU0lnTUhnM01EWTVObVUyTnlBd2VEY3dObVkyWlRZM0lDSmxiV2wwZEdWeVgyeHphV2NpQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12VUdsdVoxQnZibWN1Y0hrNk5Bb2dJQ0FnTHk4Z1kyeGhjM01nVUdsdVoxQnZibWNvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCaWVpQnRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNVE1LSUNBZ0lIQjFjMmhpZVhSbGMzTWdNSGd5TkRCa01tWTJOeUF3ZURjM016azJZemRsSURCNE1UZzRZamhtWWpRZ01IZzJabVEyWXpnM05DQXZMeUJ0WlhSb2IyUWdJbU55WldGMFpTaDFhVzUwTmpRcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpYzJWMFgyVnRhWFIwWlhKZmJITnBaeWhoWkdSeVpYTnpLWFp2YVdRaUxDQnRaWFJvYjJRZ0luQnBibWNvS1hadmFXUWlMQ0J0WlhSb2IyUWdJbkpsWTJWcGRtVmZiV1Z6YzJGblpTaGhjSEJzS1hadmFXUWlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0J0WVdsdVgyTnlaV0YwWlY5eWIzVjBaVUExSUcxaGFXNWZjMlYwWDJWdGFYUjBaWEpmYkhOcFoxOXliM1YwWlVBMklHMWhhVzVmY0dsdVoxOXliM1YwWlVBM0lHMWhhVzVmY21WalpXbDJaVjl0WlhOellXZGxYM0p2ZFhSbFFEZ0tDbTFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF4TXpvS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5UWFXNW5VRzl1Wnk1d2VUbzBDaUFnSUNBdkx5QmpiR0Z6Y3lCUWFXNW5VRzl1WnloQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOXlaV05sYVhabFgyMWxjM05oWjJWZmNtOTFkR1ZBT0RvS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5UWFXNW5VRzl1Wnk1d2VUb3lNUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QmpiMjUwY21GamRITXZVR2x1WjFCdmJtY3VjSGs2TkFvZ0lDQWdMeThnWTJ4aGMzTWdVR2x1WjFCdmJtY29RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1pIVndDaUFnSUNCbmRIaHVjeUJVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh5SUM4dklHRndjR3dLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2RISmhibk5oWTNScGIyNGdkSGx3WlNCcGN5QmhjSEJzQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12VUdsdVoxQnZibWN1Y0hrNk1qTUtJQ0FnSUM4dklHRnpjMlZ5ZENCMlpYSnBabmxmZG1GaExtRndjRjlwWkM1cFpDQTlQU0J6Wld4bUxuZHZjbTFvYjJ4bFgyTnZjbVV1ZG1Gc2RXVXNJQ0pWYm10dWIzZHVJSGR2Y20xb2IyeGxJR052Y21VaUNpQWdJQ0JrZFhBS0lDQWdJR2QwZUc1eklFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSjNiM0p0YUc5c1pWOWpiM0psSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuZHZjbTFvYjJ4bFgyTnZjbVVnWlhocGMzUnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUZWdWEyNXZkMjRnZDI5eWJXaHZiR1VnWTI5eVpRb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwxQnBibWRRYjI1bkxuQjVPakkwQ2lBZ0lDQXZMeUJoYzNObGNuUWdkbVZ5YVdaNVgzWmhZUzV2Ymw5amIyMXdiR1YwYVc5dUlEMDlJRTl1UTI5dGNHeGxkR1ZCWTNScGIyNHVUbTlQY0N3Z0lrbHVZMjl5Y21WamRDQmhjSEFnYjI0Z1kyOXRjR3hsZEdsdmJpSUtJQ0FnSUdSMWNBb2dJQ0FnWjNSNGJuTWdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1NXNWpiM0p5WldOMElHRndjQ0J2YmlCamIyMXdiR1YwYVc5dUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlVHbHVaMUJ2Ym1jdWNIazZNalVLSUNBZ0lDOHZJR0Z6YzJWeWRDQjJaWEpwWm5sZmRtRmhMbUZ3Y0Y5aGNtZHpLREFwSUQwOUlFSjVkR1Z6S0dJaWRtVnlhV1o1VmtGQklpa3NJQ0pKYm1OdmNuSmxZM1FnYldWMGFHOWtJZ29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWjNSNGJuTmhjeUJCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEYzJOalUzTWpZNU5qWTNPVFUyTkRFME1Rb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJKYm1OdmNuSmxZM1FnYldWMGFHOWtDaUFnSUNBdkx5QmpiMjUwY21GamRITXZVR2x1WjFCdmJtY3VjSGs2TWprS0lDQWdJQzh2SUc1MWJWOXphV2R6SUQwZ2IzQXVZblJ2YVNodmNDNWxlSFJ5WVdOMEtIWmxjbWxtZVY5MllXRXVZWEJ3WDJGeVozTW9NU2tzSURVc0lERXBLUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUdkMGVHNXpZWE1nUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNeUF2THlBMUNpQWdJQ0JuWlhSaWVYUmxDaUFnSUNBdkx5QmpiMjUwY21GamRITXZVR2x1WjFCdmJtY3VjSGs2TXpBS0lDQWdJQzh2SUdsdVpHVjRJQ3M5SURFZ0t5QnVkVzFmYzJsbmN5QXFJRFkySUNNZ2MydHBjQ0J6YVdkdVlYUjFjbVZ6Q2lBZ0lDQndkWE5vYVc1MElEWTJJQzh2SURZMkNpQWdJQ0FxQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwxQnBibWRRYjI1bkxuQjVPakkzTFRJNENpQWdJQ0F2THlBaklHaGxZV1JsY2dvZ0lDQWdMeThnYVc1a1pYZ2dQU0JWU1c1ME5qUW9OU2tnSXlCemEybHdJSFpsY25OcGIyNGdZVzVrSUdkMVlYSmthV0Z1WDNObGRGOXBibVJsZUFvZ0lDQWdhVzUwWTE4eklDOHZJRFVLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlRYVc1blVHOXVaeTV3ZVRvek1Bb2dJQ0FnTHk4Z2FXNWtaWGdnS3owZ01TQXJJRzUxYlY5emFXZHpJQ29nTmpZZ0l5QnphMmx3SUhOcFoyNWhkSFZ5WlhNS0lDQWdJQ3NLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlRYVc1blVHOXVaeTV3ZVRvek1pMHpNd29nSUNBZ0x5OGdJeUJpYjJSNUNpQWdJQ0F2THlCa2FXZGxjM1FnUFNCdmNDNXJaV05qWVdzeU5UWW9iM0F1YTJWalkyRnJNalUyS0c5d0xuTjFZbk4wY21sdVp5aDJaWEpwWm5sZmRtRmhMbUZ3Y0Y5aGNtZHpLREVwTENCcGJtUmxlQ3dnZG1WeWFXWjVYM1poWVM1aGNIQmZZWEpuY3lneEtTNXNaVzVuZEdncEtTa0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUdScFp5QXlDaUFnSUNCa2FXY2dNZ29nSUNBZ1pHbG5JRElLSUNBZ0lITjFZbk4wY21sdVp6TUtJQ0FnSUd0bFkyTmhhekkxTmdvZ0lDQWdhMlZqWTJGck1qVTJDaUFnSUNBdkx5QmpiMjUwY21GamRITXZVR2x1WjFCdmJtY3VjSGs2TXpRS0lDQWdJQzh2SUdsdVpHVjRJQ3M5SURnZ0lDTWdjMnRwY0NCMGFXMWxjM1JoYlhBZ1lXNWtJRzV2Ym1ObENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lIQjFjMmhwYm5RZ09DQXZMeUE0Q2lBZ0lDQXJDaUFnSUNBdkx5QmpiMjUwY21GamRITXZVR2x1WjFCdmJtY3VjSGs2TXpVS0lDQWdJQzh2SUdWdGFYUjBaWEpmWTJoaGFXNGdQU0J2Y0M1bGVIUnlZV04wWDNWcGJuUXhOaWgyWlhKcFpubGZkbUZoTG1Gd2NGOWhjbWR6S0RFcExDQnBibVJsZUNrS0lDQWdJR1JwWnlBekNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OVFhVzVuVUc5dVp5NXdlVG96TmdvZ0lDQWdMeThnYVc1a1pYZ2dLejBnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdjSFZ6YUdsdWRDQXlJQzh2SURJS0lDQWdJQ3NLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlRYVc1blVHOXVaeTV3ZVRvek53b2dJQ0FnTHk4Z1pXMXBkSFJsY2w5aFpHUnlaWE56SUQwZ2IzQXVaWGgwY21GamRDaDJaWEpwWm5sZmRtRmhMbUZ3Y0Y5aGNtZHpLREVwTENCcGJtUmxlQ3dnTXpJcENpQWdJQ0JrYVdjZ05Bb2dJQ0FnWkdsbklERUtJQ0FnSUhCMWMyaHBiblFnTXpJZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlVHbHVaMUJ2Ym1jdWNIazZNemdLSUNBZ0lDOHZJR2x1WkdWNElDczlJRFF4SUNBaklITnJhWEFnYzJWeGRXVnVZMlVnWVc1a0lHTnZibk5wYzNSbGJtTjVYMnhsZG1Wc0NpQWdJQ0J6ZDJGd0NpQWdJQ0J3ZFhOb2FXNTBJRFF4SUM4dklEUXhDaUFnSUNBckNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlVHbHVaMUJ2Ym1jdWNIazZNemtLSUNBZ0lDOHZJSEJoZVd4dllXUWdQU0J2Y0M1emRXSnpkSEpwYm1jb2RtVnlhV1o1WDNaaFlTNWhjSEJmWVhKbmN5Z3hLU3dnYVc1a1pYZ3NJSFpsY21sbWVWOTJZV0V1WVhCd1gyRnlaM01vTVNrdWJHVnVaM1JvS1FvZ0lDQWdkVzVqYjNabGNpQTFDaUFnSUNCemQyRndDaUFnSUNCMWJtTnZkbVZ5SURVS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlRYVc1blVHOXVaeTV3ZVRvME1TMDBNZ29nSUNBZ0x5OGdJeUJzYjJjZ2RHaGxJSFZ1YVhGMVpTQnRaWE56WVdkbElHaGhjMmdnWVc1a0lIZG9aWEpsSUcxbGMzTmhaMlVnWTJGdFpTQm1jbTl0Q2lBZ0lDQXZMeUJzYjJjb1pHbG5aWE4wS1FvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCc2IyY0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OVFhVzVuVUc5dVp5NXdlVG8wTXdvZ0lDQWdMeThnYkc5bktHVnRhWFIwWlhKZlkyaGhhVzRwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdsMGIySUtJQ0FnSUd4dlp3b2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwxQnBibWRRYjI1bkxuQjVPalEwQ2lBZ0lDQXZMeUJzYjJjb1pXMXBkSFJsY2w5aFpHUnlaWE56S1FvZ0lDQWdjM2RoY0FvZ0lDQWdiRzluQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12VUdsdVoxQnZibWN1Y0hrNk5EZ0tJQ0FnSUM4dklHTmhjMlVnUW5sMFpYTW9ZaUp3YVc1bklpazZDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjROekEyT1RabE5qY0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OVFhVzVuVUc5dVp5NXdlVG8xTUFvZ0lDQWdMeThnWTJGelpTQkNlWFJsY3loaUluQnZibWNpS1RvS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhnM01EWm1ObVUyTndvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDFCcGJtZFFiMjVuTG5CNU9qUTJMVFV6Q2lBZ0lDQXZMeUFqSUhKbGMzQnZibVFnZDJsMGFDQndhVzVuTDNCdmJtY0tJQ0FnSUM4dklHMWhkR05vSUhCaGVXeHZZV1E2Q2lBZ0lDQXZMeUFnSUNBZ1kyRnpaU0JDZVhSbGN5aGlJbkJwYm1jaUtUb0tJQ0FnSUM4dklDQWdJQ0FnSUNBZ2MyVnNaaTV6Wlc1a1gyMWxjM05oWjJVb1FubDBaWE1vWWlKd2IyNW5JaWtwQ2lBZ0lDQXZMeUFnSUNBZ1kyRnpaU0JDZVhSbGN5aGlJbkJ2Ym1jaUtUb0tJQ0FnSUM4dklDQWdJQ0FnSUNBZ2MyVnNaaTV6Wlc1a1gyMWxjM05oWjJVb1FubDBaWE1vWWlKd2FXNW5JaWtwQ2lBZ0lDQXZMeUFnSUNBZ1kyRnpaU0JmT2dvZ0lDQWdMeThnSUNBZ0lDQWdJQ0JoYzNObGNuUWdSbUZzYzJVc0lDSlZibXR1YjNkdUlIQmhlV3h2WVdRaUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHMWhkR05vSUcxaGFXNWZjM2RwZEdOb1gyTmhjMlZmTUVBNUlHMWhhVzVmYzNkcGRHTm9YMk5oYzJWZk1VQXhNQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMUJwYm1kUWIyNW5MbkI1T2pVekNpQWdJQ0F2THlCaGMzTmxjblFnUm1Gc2MyVXNJQ0pWYm10dWIzZHVJSEJoZVd4dllXUWlDaUFnSUNCbGNuSWdMeThnVlc1cmJtOTNiaUJ3WVhsc2IyRmtDZ3B0WVdsdVgzTjNhWFJqYUY5allYTmxYekZBTVRBNkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlVHbHVaMUJ2Ym1jdWNIazZOVEVLSUNBZ0lDOHZJSE5sYkdZdWMyVnVaRjl0WlhOellXZGxLRUo1ZEdWektHSWljR2x1WnlJcEtRb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VEY3dOamsyWlRZM0NpQWdJQ0JqWVd4c2MzVmlJSE5sYm1SZmJXVnpjMkZuWlFvS2JXRnBibDl6ZDJsMFkyaGZZMkZ6WlY5dVpYaDBRREV5T2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDFCcGJtZFFiMjVuTG5CNU9qSXhDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzTjNhWFJqYUY5allYTmxYekJBT1RvS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5UWFXNW5VRzl1Wnk1d2VUbzBPUW9nSUNBZ0x5OGdjMlZzWmk1elpXNWtYMjFsYzNOaFoyVW9RbmwwWlhNb1lpSndiMjVuSWlrcENpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE56QTJaalpsTmpjS0lDQWdJR05oYkd4emRXSWdjMlZ1WkY5dFpYTnpZV2RsQ2lBZ0lDQmlJRzFoYVc1ZmMzZHBkR05vWDJOaGMyVmZibVY0ZEVBeE1nb0tiV0ZwYmw5d2FXNW5YM0p2ZFhSbFFEYzZDaUFnSUNBdkx5QmpiMjUwY21GamRITXZVR2x1WjFCdmJtY3VjSGs2TVRjS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDFCcGJtZFFiMjVuTG5CNU9qRTVDaUFnSUNBdkx5QnpaV3htTG5ObGJtUmZiV1Z6YzJGblpTaENlWFJsY3loaUluQnBibWNpS1NrS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnM01EWTVObVUyTndvZ0lDQWdZMkZzYkhOMVlpQnpaVzVrWDIxbGMzTmhaMlVLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlRYVc1blVHOXVaeTV3ZVRveE53b2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5elpYUmZaVzFwZEhSbGNsOXNjMmxuWDNKdmRYUmxRRFk2Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12VUdsdVoxQnZibWN1Y0hrNk1UTUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwxQnBibWRRYjI1bkxuQjVPakUxQ2lBZ0lDQXZMeUJ6Wld4bUxtVnRhWFIwWlhKZmJITnBaeTUyWVd4MVpTQTlJR1Z0YVhSMFpYSmZiSE5wWndvZ0lDQWdZbmwwWldOZk15QXZMeUFpWlcxcGRIUmxjbDlzYzJsbklnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwxQnBibWRRYjI1bkxuQjVPalFLSUNBZ0lDOHZJR05zWVhOeklGQnBibWRRYjI1bktFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12VUdsdVoxQnZibWN1Y0hrNk1UVUtJQ0FnSUM4dklITmxiR1l1WlcxcGRIUmxjbDlzYzJsbkxuWmhiSFZsSUQwZ1pXMXBkSFJsY2w5c2MybG5DaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMUJwYm1kUWIyNW5MbkI1T2pFekNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJOeVpXRjBaVjl5YjNWMFpVQTFPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMUJwYm1kUWIyNW5MbkI1T2prS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb1kzSmxZWFJsUFNKeVpYRjFhWEpsSWlrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHTnlaV0YwYVc1bkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlVHbHVaMUJ2Ym1jdWNIazZOQW9nSUNBZ0x5OGdZMnhoYzNNZ1VHbHVaMUJ2Ym1jb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlRYVc1blVHOXVaeTV3ZVRveE1Rb2dJQ0FnTHk4Z2MyVnNaaTUzYjNKdGFHOXNaVjlqYjNKbExuWmhiSFZsSUQwZ2QyOXliV2h2YkdWZlkyOXlaUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlkMjl5YldodmJHVmZZMjl5WlNJS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlVHbHVaMUJ2Ym1jdWNIazZPUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2hqY21WaGRHVTlJbkpsY1hWcGNtVWlLUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklHTnZiblJ5WVdOMGN5NVFhVzVuVUc5dVp5NVFhVzVuVUc5dVp5NXpaVzVrWDIxbGMzTmhaMlVvY0dGNWJHOWhaRG9nWW5sMFpYTXBJQzArSUhadmFXUTZDbk5sYm1SZmJXVnpjMkZuWlRvS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5UWFXNW5VRzl1Wnk1d2VUbzFOUzAxTmdvZ0lDQWdMeThnUUhOMVluSnZkWFJwYm1VS0lDQWdJQzh2SUdSbFppQnpaVzVrWDIxbGMzTmhaMlVvYzJWc1ppd2djR0Y1Ykc5aFpEb2dRbmwwWlhNcElDMCtJRTV2Ym1VNkNpQWdJQ0J3Y205MGJ5QXhJREFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlRYVc1blVHOXVaeTV3ZVRvMU53b2dJQ0FnTHk4Z2QyOXliV2h2YkdWZlkyOXlaVjloWkdSeVpYTnpMQ0JsZUdsemRITWdQU0J2Y0M1QmNIQlFZWEpoYlhOSFpYUXVZWEJ3WDJGa1pISmxjM01vYzJWc1ppNTNiM0p0YUc5c1pWOWpiM0psTG5aaGJIVmxLUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0luZHZjbTFvYjJ4bFgyTnZjbVVpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWQyOXliV2h2YkdWZlkyOXlaU0JsZUdsemRITUtJQ0FnSUdGd2NGOXdZWEpoYlhOZloyVjBJRUZ3Y0VGa1pISmxjM01LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlRYVc1blVHOXVaeTV3ZVRvMU9Bb2dJQ0FnTHk4Z1lYTnpaWEowSUdWNGFYTjBjeXdnSWxkdmNtMW9iMnhsSUdOdmNtVWdZV1JrY21WemN5QjFibXR1YjNkdUlnb2dJQ0FnWVhOelpYSjBJQzh2SUZkdmNtMW9iMnhsSUdOdmNtVWdZV1JrY21WemN5QjFibXR1YjNkdUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlVHbHVaMUJ2Ym1jdWNIazZOakFLSUNBZ0lDOHZJRzFsYzNOaFoyVmZabVZsTENCbGVHbHpkSE1nUFNCdmNDNUJjSEJIYkc5aVlXd3VaMlYwWDJWNFgzVnBiblEyTkNoelpXeG1MbmR2Y20xb2IyeGxYMk52Y21VdWRtRnNkV1VzSUVKNWRHVnpLR0lpVFdWemMyRm5aVVpsWlNJcEtRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5kdmNtMW9iMnhsWDJOdmNtVWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1ZDI5eWJXaHZiR1ZmWTI5eVpTQmxlR2x6ZEhNS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURSa05qVTNNemN6TmpFMk56WTFORFkyTlRZMUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMUJwYm1kUWIyNW5MbkI1T2pZeENpQWdJQ0F2THlCaGMzTmxjblFnWlhocGMzUnpMQ0FpVjI5eWJXaHZiR1VnYldWemMyRm5aU0JtWldVZ2FYTWdkVzVyYm05M2JpSUtJQ0FnSUdGemMyVnlkQ0F2THlCWGIzSnRhRzlzWlNCdFpYTnpZV2RsSUdabFpTQnBjeUIxYm10dWIzZHVDaUFnSUNBdkx5QmpiMjUwY21GamRITXZVR2x1WjFCdmJtY3VjSGs2TnpBS0lDQWdJQzh2SUdGd2NGOXBaRDF6Wld4bUxuZHZjbTFvYjJ4bFgyTnZjbVV1ZG1Gc2RXVXNDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWQyOXliV2h2YkdWZlkyOXlaU0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1M2IzSnRhRzlzWlY5amIzSmxJR1Y0YVhOMGN3b2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwxQnBibWRRYjI1bkxuQjVPamN4Q2lBZ0lDQXZMeUJoY0hCZllYSm5jejBvUW5sMFpYTW9ZaUp3ZFdKc2FYTm9UV1Z6YzJGblpTSXBMQ0J3WVhsc2IyRmtMQ0JWU1c1ME5qUW9NQ2twTEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBiMklLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlRYVc1blVHOXVaeTV3ZVRvM01nb2dJQ0FnTHk4Z1lXTmpiM1Z1ZEhNOUtFRmpZMjkxYm5Rb2MyVnNaaTVsYldsMGRHVnlYMnh6YVdjdWRtRnNkV1V1WW5sMFpYTXBMQ2tzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTXlBdkx5QWlaVzFwZEhSbGNsOXNjMmxuSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtVnRhWFIwWlhKZmJITnBaeUJsZUdsemRITUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRE15SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUVGa1pISmxjM01nYkdWdVozUm9JR2x6SURNeUlHSjVkR1Z6Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12VUdsdVoxQnZibWN1Y0hrNk56VUtJQ0FnSUM4dklHbDBlRzR1YzNWaWJXbDBYM1I0Ym5Nb2NHRjViV1Z1ZEN3Z1lYQndYMk5oYkd3cENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FXMXZkVzUwQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1VtVmpaV2wyWlhJS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5UWFXNW5VRzl1Wnk1d2VUbzJNeTAyTkFvZ0lDQWdMeThnSXlCallXeHNJSEIxWW14cGMyZ2diV1Z6YzJGblpRb2dJQ0FnTHk4Z2NHRjViV1Z1ZENBOUlHbDBlRzR1VUdGNWJXVnVkQ2dLSUNBZ0lHbHVkR05mTVNBdkx5QndZWGtLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OVFhVzVuVUc5dVp5NXdlVG8yTndvZ0lDQWdMeThnWm1WbFBUQXNDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OVFhVzVuVUc5dVp5NXdlVG8zTlFvZ0lDQWdMeThnYVhSNGJpNXpkV0p0YVhSZmRIaHVjeWh3WVhsdFpXNTBMQ0JoY0hCZlkyRnNiQ2tLSUNBZ0lHbDBlRzVmYm1WNGRBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQlkyTnZkVzUwY3dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDFCcGJtZFFiMjVuTG5CNU9qY3hDaUFnSUNBdkx5QmhjSEJmWVhKbmN6MG9RbmwwWlhNb1lpSndkV0pzYVhOb1RXVnpjMkZuWlNJcExDQndZWGxzYjJGa0xDQlZTVzUwTmpRb01Da3BMQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjROekEzTlRZeU5tTTJPVGN6TmpnMFpEWTFOek0zTXpZeE5qYzJOUW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5UWFXNW5VRzl1Wnk1d2VUbzJPUW9nSUNBZ0x5OGdZWEJ3WDJOaGJHd2dQU0JwZEhodUxrRndjR3hwWTJGMGFXOXVRMkZzYkNnS0lDQWdJR2x1ZEdOZk1pQXZMeUJoY0hCc0NpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12VUdsdVoxQnZibWN1Y0hrNk56TUtJQ0FnSUM4dklHWmxaVDB3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlRYVc1blVHOXVaeTV3ZVRvM05Rb2dJQ0FnTHk4Z2FYUjRiaTV6ZFdKdGFYUmZkSGh1Y3lod1lYbHRaVzUwTENCaGNIQmZZMkZzYkNrS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12VUdsdVoxQnZibWN1Y0hrNk56Y3ROemdLSUNBZ0lDOHZJQ01nYkc5bklIQnBibWN2Y0c5dVp3b2dJQ0FnTHk4Z2JHOW5LSEJoZVd4dllXUXBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUd4dlp3b2dJQ0FnY21WMGMzVmlDZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01TQXZMeUF4Q2lBZ0lDQnlaWFIxY200SyJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVBQUVHQlNZRURYZHZjbTFvYjJ4bFgyTnZjbVVFY0dsdVp3UndiMjVuREdWdGFYUjBaWEpmYkhOcFp6RWJRUUFqZ2dRRUpBMHZad1IzT1d4K0JCaUxqN1FFYjliSWREWWFBSTRFQUtZQW1BQ0xBQUlpUXpFWkZFUXhHRVF4RmlNSlNUZ1FKQkpFU1RnWUlpaGxSQkpFU1RnWkZFUkpJc0lhZ0FsMlpYSnBabmxXUVVFU1JDUENHa2tsVllGQ0N5TUlKUWhMQVJWTEFrc0NTd0pTQWdKUEFvRUlDRXNEU3dGWlRJRUNDRXNFU3dHQklGaE1nU2tJVHdWTVR3VlNUd093VHdJV3NFeXdLU3BQQW80Q0FBY0FBUUFwaUFBMUkwTXFpQUF2UXYvM01Sa1VSREVZUkNtSUFDRWpRekVaRkVReEdFUXJOaG9CWnlORE1Sa1VSREVZRkVRMkdnRVhLRXhuSTBPS0FRQWlLR1ZFY2doRUlpaGxSSUFLVFdWemMyRm5aVVpsWldWRUlpaGxSQ0lXSWl0bFJFa1ZnU0FTUkxGUEE3SUlUd095QnlPeUVDS3lBYmF5SElBT2NIVmliR2x6YUUxbGMzTmhaMld5R292L3NocXlHcklZSkxJUUlySUJzNHYvc0lrPSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NCwibWlub3IiOjQsInBhdGNoIjoyLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
