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

namespace Arc56.Generated.sambhavverma2004.aircargo_provenance.EvidenceRegistry_c46961c9
{


    public class EvidenceRegistryProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public EvidenceRegistryProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="evidence_id"> </param>
        /// <param name="shipment_id"> </param>
        /// <param name="evidence_hash"> </param>
        /// <param name="submitted_by"> </param>
        public async Task<string> RegisterEvidence(string evidence_id, string shipment_id, byte[] evidence_hash, string submitted_by, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 47, 231, 218, 197 };
            var evidence_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); evidence_idAbi.From(evidence_id);
            var shipment_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); shipment_idAbi.From(shipment_id);
            var evidence_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); evidence_hashAbi.From(evidence_hash);
            var submitted_byAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); submitted_byAbi.From(submitted_by);

            var result = await base.CallApp(new List<object> { abiHandle, evidence_idAbi, shipment_idAbi, evidence_hashAbi, submitted_byAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> RegisterEvidence_Transactions(string evidence_id, string shipment_id, byte[] evidence_hash, string submitted_by, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 47, 231, 218, 197 };
            var evidence_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); evidence_idAbi.From(evidence_id);
            var shipment_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); shipment_idAbi.From(shipment_id);
            var evidence_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); evidence_hashAbi.From(evidence_hash);
            var submitted_byAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); submitted_byAbi.From(submitted_by);

            return await base.MakeTransactionList(new List<object> { abiHandle, evidence_idAbi, shipment_idAbi, evidence_hashAbi, submitted_byAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="evidence_id"> </param>
        /// <param name="submitted_hash"> </param>
        public async Task<string> VerifyEvidence(string evidence_id, byte[] submitted_hash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 135, 56, 65, 120 };
            var evidence_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); evidence_idAbi.From(evidence_id);
            var submitted_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); submitted_hashAbi.From(submitted_hash);

            var result = await base.CallApp(new List<object> { abiHandle, evidence_idAbi, submitted_hashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> VerifyEvidence_Transactions(string evidence_id, byte[] submitted_hash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 135, 56, 65, 120 };
            var evidence_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); evidence_idAbi.From(evidence_id);
            var submitted_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); submitted_hashAbi.From(submitted_hash);

            return await base.MakeTransactionList(new List<object> { abiHandle, evidence_idAbi, submitted_hashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRXZpZGVuY2VSZWdpc3RyeSIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJyZWdpc3Rlcl9ldmlkZW5jZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJldmlkZW5jZV9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2hpcG1lbnRfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImV2aWRlbmNlX2hhc2giLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InN1Ym1pdHRlZF9ieSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InZlcmlmeV9ldmlkZW5jZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJldmlkZW5jZV9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoic3VibWl0dGVkX2hhc2giLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzEyNF0sImVycm9yTWVzc2FnZSI6IkV2aWRlbmNlIElEIGNhbm5vdCBiZSBlbXB0eSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE0NV0sImVycm9yTWVzc2FnZSI6IkV2aWRlbmNlIGFscmVhZHkgcmVnaXN0ZXJlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIzMV0sImVycm9yTWVzc2FnZSI6IkV2aWRlbmNlIGRvZXMgbm90IGV4aXN0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTMyXSwiZXJyb3JNZXNzYWdlIjoiRXZpZGVuY2UgaGFzaCBjYW5ub3QgYmUgZW1wdHkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjhdLCJlcnJvck1lc3NhZ2UiOiJTaGlwbWVudCBJRCBjYW5ub3QgYmUgZW1wdHkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMzVdLCJlcnJvck1lc3NhZ2UiOiJTdWJtaXR0ZXIgY2Fubm90IGJlIGVtcHR5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjIsNzgsOTQsMTEwLDE5OCwyMTRdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2OSw4NSwxMDEsMTE3LDIwNSwyMjFdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBd0lESWdNU0F6TWdvZ0lDQWdZbmwwWldOaWJHOWpheUFpWlhaa0lpQXdlRGRqQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWFpwWkdWdVkyVmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TlFvZ0lDQWdMeThnWTJ4aGMzTWdSWFpwWkdWdVkyVlNaV2RwYzNSeWVTaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJR0o2SUcxaGFXNWZYMTloYkdkdmNIbGZaR1ZtWVhWc2RGOWpjbVZoZEdWQU1URUtJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnY0hWemFHSjVkR1Z6Y3lBd2VESm1aVGRrWVdNMUlEQjRPRGN6T0RReE56Z2dMeThnYldWMGFHOWtJQ0p5WldkcGMzUmxjbDlsZG1sa1pXNWpaU2h6ZEhKcGJtY3NjM1J5YVc1bkxHSjVkR1ZiWFN4emRISnBibWNwYzNSeWFXNW5JaXdnYldWMGFHOWtJQ0oyWlhKcFpubGZaWFpwWkdWdVkyVW9jM1J5YVc1bkxHSjVkR1ZiWFNsemRISnBibWNpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCeVpXZHBjM1JsY2w5bGRtbGtaVzVqWlNCMlpYSnBabmxmWlhacFpHVnVZMlVLSUNBZ0lHVnljZ29LYldGcGJsOWZYMkZzWjI5d2VWOWtaV1poZFd4MFgyTnlaV0YwWlVBeE1Ub0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQWhDaUFnSUNBbUpnb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG1WMmFXUmxibU5sWDNKbFoybHpkSEo1TG1OdmJuUnlZV04wTGtWMmFXUmxibU5sVW1WbmFYTjBjbmt1Y21WbmFYTjBaWEpmWlhacFpHVnVZMlZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dweVpXZHBjM1JsY2w5bGRtbGtaVzVqWlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsZG1sa1pXNWpaVjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRveE1Bb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHhJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTVNBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUEwQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6RWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWMmFXUmxibU5sWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qRTRDaUFnSUNBdkx5QmhjM05sY25RZ1pYWnBaR1Z1WTJWZmFXUXNJQ0pGZG1sa1pXNWpaU0JKUkNCallXNXViM1FnWW1VZ1pXMXdkSGtpQ2lBZ0lDQmthV2NnTXdvZ0lDQWdiR1Z1Q2lBZ0lDQmhjM05sY25RZ0x5OGdSWFpwWkdWdVkyVWdTVVFnWTJGdWJtOTBJR0psSUdWdGNIUjVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYWnBaR1Z1WTJWZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZNVGtLSUNBZ0lDOHZJR0Z6YzJWeWRDQnphR2x3YldWdWRGOXBaQ3dnSWxOb2FYQnRaVzUwSUVsRUlHTmhibTV2ZENCaVpTQmxiWEIwZVNJS0lDQWdJR1JwWnlBeUNpQWdJQ0JzWlc0S0lDQWdJR0Z6YzJWeWRDQXZMeUJUYUdsd2JXVnVkQ0JKUkNCallXNXViM1FnWW1VZ1pXMXdkSGtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxkbWxrWlc1alpWOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG95TUFvZ0lDQWdMeThnWVhOelpYSjBJR1YyYVdSbGJtTmxYMmhoYzJnc0lDSkZkbWxrWlc1alpTQm9ZWE5vSUdOaGJtNXZkQ0JpWlNCbGJYQjBlU0lLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lHRnpjMlZ5ZENBdkx5QkZkbWxrWlc1alpTQm9ZWE5vSUdOaGJtNXZkQ0JpWlNCbGJYQjBlUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVjJhV1JsYm1ObFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPakl4Q2lBZ0lDQXZMeUJoYzNObGNuUWdjM1ZpYldsMGRHVmtYMko1TENBaVUzVmliV2wwZEdWeUlHTmhibTV2ZENCaVpTQmxiWEIwZVNJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQmhjM05sY25RZ0x5OGdVM1ZpYldsMGRHVnlJR05oYm01dmRDQmlaU0JsYlhCMGVRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWMmFXUmxibU5sWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qSXlDaUFnSUNBdkx5QmhjM05sY25RZ1pYWnBaR1Z1WTJWZmFXUWdibTkwSUdsdUlITmxiR1l1WlhacFpHVnVZMlVzSUNKRmRtbGtaVzVqWlNCaGJISmxZV1I1SUhKbFoybHpkR1Z5WldRaUNpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKbGRtUWlDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCRmRtbGtaVzVqWlNCaGJISmxZV1I1SUhKbFoybHpkR1Z5WldRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsZG1sa1pXNWpaVjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRveU55MHlPQW9nSUNBZ0x5OGdaWFpwWkdWdVkyVmZhR0Z6YUFvZ0lDQWdMeThnS3lCQ2VYUmxjeWhpSW53aUtRb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWFpwWkdWdVkyVmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TWpnS0lDQWdJQzh2SUNzZ1FubDBaWE1vWWlKOElpa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZzNZd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVjJhV1JsYm1ObFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPakkzTFRJNENpQWdJQ0F2THlCbGRtbGtaVzVqWlY5b1lYTm9DaUFnSUNBdkx5QXJJRUo1ZEdWektHSWlmQ0lwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsZG1sa1pXNWpaVjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRveU55MHlPUW9nSUNBZ0x5OGdaWFpwWkdWdVkyVmZhR0Z6YUFvZ0lDQWdMeThnS3lCQ2VYUmxjeWhpSW53aUtRb2dJQ0FnTHk4Z0t5QnphR2x3YldWdWRGOXBaQzVpZVhSbGN3b2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsZG1sa1pXNWpaVjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRvek1Bb2dJQ0FnTHk4Z0t5QkNlWFJsY3loaUlud2lLUW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlRGRqQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWFpwWkdWdVkyVmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TWpjdE16QUtJQ0FnSUM4dklHVjJhV1JsYm1ObFgyaGhjMmdLSUNBZ0lDOHZJQ3NnUW5sMFpYTW9ZaUo4SWlrS0lDQWdJQzh2SUNzZ2MyaHBjRzFsYm5SZmFXUXVZbmwwWlhNS0lDQWdJQzh2SUNzZ1FubDBaWE1vWWlKOElpa0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVjJhV1JsYm1ObFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPakkzTFRNeENpQWdJQ0F2THlCbGRtbGtaVzVqWlY5b1lYTm9DaUFnSUNBdkx5QXJJRUo1ZEdWektHSWlmQ0lwQ2lBZ0lDQXZMeUFySUhOb2FYQnRaVzUwWDJsa0xtSjVkR1Z6Q2lBZ0lDQXZMeUFySUVKNWRHVnpLR0lpZkNJcENpQWdJQ0F2THlBcklITjFZbTFwZEhSbFpGOWllUzVpZVhSbGN3b2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsZG1sa1pXNWpaVjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRvek5Bb2dJQ0FnTHk4Z2MyVnNaaTVsZG1sa1pXNWpaVnRsZG1sa1pXNWpaVjlwWkYwZ1BTQnlaV052Y21RS0lDQWdJR1JwWnlBeENpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxkbWxrWlc1alpWOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG94TUFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhneE5URm1OMk0zTlRBd01UTTBOVGMyTmprMk5EWTFObVUyTXpZMU1qQTNNalkxTmpjMk9UY3pOelEyTlRjeU5qVTJOQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG1WMmFXUmxibU5sWDNKbFoybHpkSEo1TG1OdmJuUnlZV04wTGtWMmFXUmxibU5sVW1WbmFYTjBjbmt1ZG1WeWFXWjVYMlYyYVdSbGJtTmxXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LZG1WeWFXWjVYMlYyYVdSbGJtTmxPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVjJhV1JsYm1ObFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPak0zQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNU0F2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlYyYVdSbGJtTmxYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pRekNpQWdJQ0F2THlCaGMzTmxjblFnWlhacFpHVnVZMlZmYVdRZ2FXNGdjMlZzWmk1bGRtbGtaVzVqWlN3Z0lrVjJhV1JsYm1ObElHUnZaWE1nYm05MElHVjRhWE4wSWdvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWlhaa0lnb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWVhOelpYSjBJQzh2SUVWMmFXUmxibU5sSUdSdlpYTWdibTkwSUdWNGFYTjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYWnBaR1Z1WTJWZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZORFlLSUNBZ0lDOHZJSE4wYjNKbFpGOW9ZWE5vSUQwZ2NtVmpiM0prV3pBNk16SmRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWkdsbklERUtJQ0FnSUQ0OUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaR2xuSURJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQnBiblJqWHpNZ0x5OGdNeklLSUNBZ0lHUnBaeUF5Q2lBZ0lDQStQUW9nSUNBZ2FXNTBZMTh6SUM4dklETXlDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWFpwWkdWdVkyVmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TkRVdE5EWUtJQ0FnSUM4dklISmxZMjl5WkNBOUlITmxiR1l1WlhacFpHVnVZMlZiWlhacFpHVnVZMlZmYVdSZENpQWdJQ0F2THlCemRHOXlaV1JmYUdGemFDQTlJSEpsWTI5eVpGc3dPak15WFFvZ0lDQWdaR2xuSURFS0lDQWdJQzBLSUNBZ0lHSnZlRjlsZUhSeVlXTjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYWnBaR1Z1WTJWZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZORGdLSUNBZ0lDOHZJR2xtSUhOMGIzSmxaRjlvWVhOb0lEMDlJSE4xWW0xcGRIUmxaRjlvWVhOb09nb2dJQ0FnUFQwS0lDQWdJR0o2SUhabGNtbG1lVjlsZG1sa1pXNWpaVjloWm5SbGNsOXBabDlsYkhObFFETUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGRtbGtaVzVqWlY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUbzBPUW9nSUNBZ0x5OGdjbVYwZFhKdUlGTjBjbWx1WnlnaVJYWnBaR1Z1WTJVZ2FHRnphQ0J0WVhSamFHVnpJaWtLSUNBZ0lIQjFjMmhpZVhSbGN5QWlSWFpwWkdWdVkyVWdhR0Z6YUNCdFlYUmphR1Z6SWdvS2RtVnlhV1o1WDJWMmFXUmxibU5sWDJGbWRHVnlYMmx1YkdsdVpXUmZjMjFoY25SZlkyOXVkSEpoWTNSekxtVjJhV1JsYm1ObFgzSmxaMmx6ZEhKNUxtTnZiblJ5WVdOMExrVjJhV1JsYm1ObFVtVm5hWE4wY25rdWRtVnlhV1o1WDJWMmFXUmxibU5sUURRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhacFpHVnVZMlZmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk16Y0tJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tkbVZ5YVdaNVgyVjJhV1JsYm1ObFgyRm1kR1Z5WDJsbVgyVnNjMlZBTXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsZG1sa1pXNWpaVjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRvMU1Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUZOMGNtbHVaeWdpUlhacFpHVnVZMlVnYUdGemFDQnRhWE50WVhSamFDSXBDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lrVjJhV1JsYm1ObElHaGhjMmdnYldsemJXRjBZMmdpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWFpwWkdWdVkyVmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TXpjS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnWWlCMlpYSnBabmxmWlhacFpHVnVZMlZmWVdaMFpYSmZhVzVzYVc1bFpGOXpiV0Z5ZEY5amIyNTBjbUZqZEhNdVpYWnBaR1Z1WTJWZmNtVm5hWE4wY25rdVkyOXVkSEpoWTNRdVJYWnBaR1Z1WTJWU1pXZHBjM1J5ZVM1MlpYSnBabmxmWlhacFpHVnVZMlZBTkFvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVBQUlCSUNZQ0EyVjJaQUY4TVJ0QkFCMHhHUlJFTVJoRWdnSUVMK2ZheFFTSE9FRjROaG9BamdJQUNRQ1JBREVaRkRFWUZCQkROaG9CU1NKWkl3aExBUlVTUkZjQ0FEWWFBa2tpV1NNSVN3RVZFa1JYQWdBMkdnTkpJbGtqQ0VzQkZSSkVWd0lBTmhvRVNTSlpJd2hMQVJVU1JGY0NBRXNERlVSTEFoVkVTd0VWUkVrVlJDaFBCRkJKdlVVQkZFUlBBaWxRVHdOUUtWQlBBbEJMQWJ4SXY0QVpGUjk4ZFFBVFJYWnBaR1Z1WTJVZ2NtVm5hWE4wWlhKbFpMQWtRellhQVVraVdTTUlTd0VWRWtSWEFnQTJHZ0pKSWxrakNFc0JGUkpFVndJQUtFOENVRW05UkNKTEFROGlTd0pQQWswbFN3SVBKVThEVHdKTlN3RUp1aEpCQUNxQUZVVjJhV1JsYm1ObElHaGhjMmdnYldGMFkyaGxjMGtWRmxjR0FreFFnQVFWSDN4MVRGQ3dKRU9BRmtWMmFXUmxibU5sSUdoaGMyZ2diV2x6YldGMFkyaEMvOUk9IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6MTAsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
