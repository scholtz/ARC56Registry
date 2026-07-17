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

namespace Arc56.Generated.nickthelegend.puya_algo_ts_smartcontracts.UserAccountContract_8a3c83e9
{


    public class UserAccountContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public UserAccountContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class VerifierStruct : AVMObjectType
            {
                public string Name { get; set; }

                public bool IsVerified { get; set; }

                public string ProofHash { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vName.From(Name);
                    stringRef[ret.Count] = vName.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIsVerified = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vIsVerified.From(IsVerified);
                    ret.AddRange(vIsVerified.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vProofHash = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vProofHash.From(ProofHash);
                    stringRef[ret.Count] = vProofHash.Encode();
                    ret.AddRange(new byte[2]);
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static VerifierStruct Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new VerifierStruct();
                    uint count = 0;
                    var indexName = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vName.Decode(bytes.Skip(indexName + prefixOffset).ToArray());
                    var valueName = vName.ToValue();
                    if (valueName is string vNameValue) { ret.Name = vNameValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIsVerified = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vIsVerified.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueIsVerified = vIsVerified.ToValue();
                    if (valueIsVerified is bool vIsVerifiedValue) { ret.IsVerified = vIsVerifiedValue; }
                    var indexProofHash = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vProofHash = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vProofHash.Decode(bytes.Skip(indexProofHash + prefixOffset).ToArray());
                    var valueProofHash = vProofHash.ToValue();
                    if (valueProofHash is string vProofHashValue) { ret.ProofHash = vProofHashValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as VerifierStruct);
                }
                public bool Equals(VerifierStruct? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(VerifierStruct left, VerifierStruct right)
                {
                    return EqualityComparer<VerifierStruct>.Default.Equals(left, right);
                }
                public static bool operator !=(VerifierStruct left, VerifierStruct right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="ownerAddress"> </param>
        public async Task CreateApplication(Address ownerAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { ownerAddress });
            byte ownerAddressRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 218, 83, 254, 254 };
            var ownerAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAddressAbi.From(ownerAddress);

            var result = await base.CallApp(new List<object> { abiHandle, ownerAddressRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateApplication_Transactions(Address ownerAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { ownerAddress });
            byte ownerAddressRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 218, 83, 254, 254 };
            var ownerAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAddressAbi.From(ownerAddress);

            return await base.MakeTransactionList(new List<object> { abiHandle, ownerAddressRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="providerName"> </param>
        /// <param name="proofHash"> </param>
        /// <param name="account"> </param>
        public async Task Verify(Address account, string providerName, string proofHash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { account });
            byte accountRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 131, 213, 60, 105 };
            var providerNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); providerNameAbi.From(providerName);
            var proofHashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); proofHashAbi.From(proofHash);
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            var result = await base.CallApp(new List<object> { abiHandle, providerNameAbi, proofHashAbi, accountRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Verify_Transactions(Address account, string providerName, string proofHash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { account });
            byte accountRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 131, 213, 60, 105 };
            var providerNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); providerNameAbi.From(providerName);
            var proofHashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); proofHashAbi.From(proofHash);
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            return await base.MakeTransactionList(new List<object> { abiHandle, providerNameAbi, proofHashAbi, accountRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiVXNlckFjY291bnRDb250cmFjdCIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJWZXJpZmllclN0cnVjdCI6W3sibmFtZSI6Im5hbWUiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoiaXNWZXJpZmllZCIsInR5cGUiOiJib29sIn0seyJuYW1lIjoicHJvb2ZIYXNoIiwidHlwZSI6InN0cmluZyJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGVBcHBsaWNhdGlvbiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhY2NvdW50Iiwic3RydWN0IjpudWxsLCJuYW1lIjoib3duZXJBZGRyZXNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InZlcmlmeSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcm92aWRlck5hbWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByb29mSGFzaCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWNjb3VudCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFjY291bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjIsImJ5dGVzIjoxfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlszMyw1OF0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBpcyBub3QgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE0Nl0sImVycm9yTWVzc2FnZSI6Ik9ubHkgdGhlIGFsbG93ZWQgYWRkcmVzcyBjYW4gYWNjZXNzIHRoaXMgbWV0aG9kIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjJdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNl0sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBub3QgY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlZYTmxja0ZqWTI5MWJuUXVZV3huYnk1MGN6b3lOZ29nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUZWelpYSkJZMk52ZFc1MFEyOXVkSEpoWTNRZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc0Z1RuVnRRWEJ3UVhKbmN3b2dJQ0FnWW5vZ2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFEZ0tJQ0FnSUhCMWMyaGllWFJsYzNNZ01IaGtZVFV6Wm1WbVpTQXdlRGd6WkRVell6WTVJQzh2SUcxbGRHaHZaQ0FpWTNKbFlYUmxRWEJ3YkdsallYUnBiMjRvWVdOamIzVnVkQ2wyYjJsa0lpd2diV1YwYUc5a0lDSjJaWEpwWm5rb2MzUnlhVzVuTEhOMGNtbHVaeXhoWTJOdmRXNTBLWFp2YVdRaUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQnRZV2x1WDJOeVpXRjBaVUZ3Y0d4cFkyRjBhVzl1WDNKdmRYUmxRRE1nYldGcGJsOTJaWEpwWm5sZmNtOTFkR1ZBTkFvS2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFEZzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlZYTmxja0ZqWTI5MWJuUXVZV3huYnk1MGN6b3lOZ29nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUZWelpYSkJZMk52ZFc1MFEyOXVkSEpoWTNRZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0J3ZFhOb2FXNTBJREFnTHk4Z01Bb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzWmxjbWxtZVY5eWIzVjBaVUEwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMVZ6WlhKQlkyTnZkVzUwTG1Gc1oyOHVkSE02TlRFS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12VlhObGNrRmpZMjkxYm5RdVlXeG5ieTUwY3pveU5nb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRlZ6WlhKQlkyTnZkVzUwUTI5dWRISmhZM1FnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoY3lCQlkyTnZkVzUwY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMVZ6WlhKQlkyTnZkVzUwTG1Gc1oyOHVkSE02TlRFS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnWTJGc2JITjFZaUIyWlhKcFpua0tJQ0FnSUhCMWMyaHBiblFnTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZZM0psWVhSbFFYQndiR2xqWVhScGIyNWZjbTkxZEdWQU16b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5VmMyVnlRV05qYjNWdWRDNWhiR2R2TG5Sek9qUXhDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZWWE5sY2tGalkyOTFiblF1WVd4bmJ5NTBjem95TmdvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklGVnpaWEpCWTJOdmRXNTBRMjl1ZEhKaFkzUWdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhjeUJCWTJOdmRXNTBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwxVnpaWEpCWTJOdmRXNTBMbUZzWjI4dWRITTZOREVLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdZMkZzYkhOMVlpQmpjbVZoZEdWQmNIQnNhV05oZEdsdmJnb2dJQ0FnY0hWemFHbHVkQ0F4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5VmMyVnlRV05qYjNWdWRDNWhiR2R2TG5Sek9qcFZjMlZ5UVdOamIzVnVkRU52Ym5SeVlXTjBMbU55WldGMFpVRndjR3hwWTJGMGFXOXVLRzkzYm1WeVFXUmtjbVZ6Y3pvZ1lubDBaWE1wSUMwK0lIWnZhV1E2Q21OeVpXRjBaVUZ3Y0d4cFkyRjBhVzl1T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMVZ6WlhKQlkyTnZkVzUwTG1Gc1oyOHVkSE02TkRFdE5ESUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ0x5OGdZM0psWVhSbFFYQndiR2xqWVhScGIyNG9iM2R1WlhKQlpHUnlaWE56SURvZ1FXTmpiM1Z1ZENrNklIWnZhV1FnZXdvZ0lDQWdjSEp2ZEc4Z01TQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlZYTmxja0ZqWTI5MWJuUXVZV3huYnk1MGN6b3lPUW9nSUNBZ0x5OGdiM2R1WlhKQlpHUnlaWE56SUQwZ1IyeHZZbUZzVTNSaGRHVThRV05qYjNWdWRENG9LVHNLSUNBZ0lIQjFjMmhpZVhSbGN5QWliM2R1WlhKQlpHUnlaWE56SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMVZ6WlhKQlkyTnZkVzUwTG1Gc1oyOHVkSE02TkRRS0lDQWdJQzh2SUhSb2FYTXViM2R1WlhKQlpHUnlaWE56TG5aaGJIVmxJRDBnYjNkdVpYSkJaR1J5WlhOek93b2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDFWelpYSkJZMk52ZFc1MExtRnNaMjh1ZEhNNk16QUtJQ0FnSUM4dklHeHBiV2wwSUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpZ3BPd29nSUNBZ2NIVnphR0o1ZEdWeklDSnNhVzFwZENJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlWYzJWeVFXTmpiM1Z1ZEM1aGJHZHZMblJ6T2pRMUNpQWdJQ0F2THlCMGFHbHpMbXhwYldsMExuWmhiSFZsSUQwZ01UQTdDaUFnSUNCd2RYTm9hVzUwSURFd0lDOHZJREV3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMVZ6WlhKQlkyTnZkVzUwTG1Gc1oyOHVkSE02T2xWelpYSkJZMk52ZFc1MFEyOXVkSEpoWTNRdWRtVnlhV1o1S0hCeWIzWnBaR1Z5VG1GdFpUb2dZbmwwWlhNc0lIQnliMjltU0dGemFEb2dZbmwwWlhNc0lHRmpZMjkxYm5RNklHSjVkR1Z6S1NBdFBpQjJiMmxrT2dwMlpYSnBabms2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZWWE5sY2tGalkyOTFiblF1WVd4bmJ5NTBjem8xTVMwMU1nb2dJQ0FnTHk4Z0lDQWdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQXZMeUIyWlhKcFpua29jSEp2ZG1sa1pYSk9ZVzFsSURvZ1UzUnlMQ0J3Y205dlpraGhjMmc2SUZOMGNpd2dZV05qYjNWdWREb2dRV05qYjNWdWRDbDdDaUFnSUNCd2NtOTBieUF6SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlWYzJWeVFXTmpiM1Z1ZEM1aGJHZHZMblJ6T2pVekNpQWdJQ0F2THlCaGMzTmxjblFvVkhodUxuTmxibVJsY2lBOVBUMGdZV3hzYjNkbFpFRmtaSEpsYzNNc0lDZFBibXg1SUhSb1pTQmhiR3h2ZDJWa0lHRmtaSEpsYzNNZ1kyRnVJR0ZqWTJWemN5QjBhR2x6SUcxbGRHaHZaQ2NwT3dvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwxVnpaWEpCWTJOdmRXNTBMbUZzWjI4dWRITTZNalFLSUNBZ0lDOHZJR052Ym5OMElHRnNiRzkzWldSQlpHUnlaWE56SUQwZ1FXTmpiM1Z1ZENnblRFVkhSVTVFVFZGUlNrcFhVMUZXU0ZKR1N6TTJSVkEzUjFSTk0wMVVTVE5XUkROSFRqSTFXVTFMU2paTlJVSlNNelZLTkZOQ1RsWkVOQ2NwT3dvZ0lDQWdjSFZ6YUdKNWRHVnpJR0poYzJVek1paE1SVWRGVGtSTlVWRktTbGRUVVZaSVVrWkxNelpGVURkSFZFMHpUVlJKTTFaRU0wZE9NalZaVFV0S05rMUZRbEl6TlVwUktTQXZMeUJoWkdSeUlFeEZSMFZPUkUxUlVVcEtWMU5SVmtoU1Jrc3pOa1ZRTjBkVVRUTk5WRWt6VmtRelIwNHlOVmxOUzBvMlRVVkNVak0xU2pSVFFrNVdSRFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OVZjMlZ5UVdOamIzVnVkQzVoYkdkdkxuUnpPalV6Q2lBZ0lDQXZMeUJoYzNObGNuUW9WSGh1TG5ObGJtUmxjaUE5UFQwZ1lXeHNiM2RsWkVGa1pISmxjM01zSUNkUGJteDVJSFJvWlNCaGJHeHZkMlZrSUdGa1pISmxjM01nWTJGdUlHRmpZMlZ6Y3lCMGFHbHpJRzFsZEdodlpDY3BPd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCUGJteDVJSFJvWlNCaGJHeHZkMlZrSUdGa1pISmxjM01nWTJGdUlHRmpZMlZ6Y3lCMGFHbHpJRzFsZEdodlpBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDFWelpYSkJZMk52ZFc1MExtRnNaMjh1ZEhNNk5UVXROVGtLSUNBZ0lDOHZJSFJvYVhNdWRtVnlhV1pwWlhKektHRmpZMjkxYm5RcExuWmhiSFZsSUQwZ2JtVjNJRlpsY21sbWFXVnlVM1J5ZFdOMEtIc0tJQ0FnSUM4dklDQWdibUZ0WlRvZ2NISnZkbWxrWlhKT1lXMWxMQW9nSUNBZ0x5OGdJQ0JwYzFabGNtbG1hV1ZrT2lCdVpYY2dZWEpqTkM1Q2IyOXNLSFJ5ZFdVcExBb2dJQ0FnTHk4Z0lDQndjbTl2WmtoaGMyZzZJSEJ5YjI5bVNHRnphQW9nSUNBZ0x5OGdmU2s3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBMUlDOHZJRFVLSUNBZ0lDc0tJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01EQTFPREFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0J6ZDJGd0NpQWdJQ0JpYjNoZmNIVjBDaUFnSUNCeVpYUnpkV0lLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDakViUVFBVmdnSUUybFArL2dTRDFUeHBOaG9BamdJQUhBQURnUUJETVJrVVJERVlSRFlhQVRZYUFqWWFBeGZBSElnQU5vRUJRekVaRkVReEdCUkVOaG9CRjhBY2lBQURnUUZEaWdFQWdBeHZkMjVsY2tGa1pISmxjM09MLzJlQUJXeHBiV2wwZ1FwbmlZb0RBREVBZ0NCWkRFYU5rSUpUYVVLbmlWVy9FZjgwMmJaTkc2ajJadXU0WXBQbUVESGZVeEpFaS8wVmdRVUlGbGNHQW9BREFBV0FURkNML1ZDTC9sQ0wvN3hJaS85TXY0az0iLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjQsIm1pbm9yIjo3LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
