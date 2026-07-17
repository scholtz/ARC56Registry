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

namespace Arc56.Generated.p2arthur.governance_test.CompxGovernance_83d92bf5
{


    public class CompxGovernanceProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public CompxGovernanceProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class ProposalDataType : AVMObjectType
            {
                public string ProposalTitle { get; set; }

                public string ProposalDescription { get; set; }

                public ulong ProposalTotalVotes { get; set; }

                public ulong ProposalYesVotes { get; set; }

                public ulong CreatedAtTimestamp { get; set; }

                public ulong ExpiryTimestamp { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vProposalTitle = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vProposalTitle.From(ProposalTitle);
                    stringRef[ret.Count] = vProposalTitle.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vProposalDescription = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vProposalDescription.From(ProposalDescription);
                    stringRef[ret.Count] = vProposalDescription.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vProposalTotalVotes = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vProposalTotalVotes.From(ProposalTotalVotes);
                    ret.AddRange(vProposalTotalVotes.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vProposalYesVotes = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vProposalYesVotes.From(ProposalYesVotes);
                    ret.AddRange(vProposalYesVotes.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCreatedAtTimestamp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vCreatedAtTimestamp.From(CreatedAtTimestamp);
                    ret.AddRange(vCreatedAtTimestamp.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExpiryTimestamp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vExpiryTimestamp.From(ExpiryTimestamp);
                    ret.AddRange(vExpiryTimestamp.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static ProposalDataType Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new ProposalDataType();
                    uint count = 0;
                    var indexProposalTitle = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vProposalTitle = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vProposalTitle.Decode(bytes.Skip(indexProposalTitle + prefixOffset).ToArray());
                    var valueProposalTitle = vProposalTitle.ToValue();
                    if (valueProposalTitle is string vProposalTitleValue) { ret.ProposalTitle = vProposalTitleValue; }
                    var indexProposalDescription = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vProposalDescription = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vProposalDescription.Decode(bytes.Skip(indexProposalDescription + prefixOffset).ToArray());
                    var valueProposalDescription = vProposalDescription.ToValue();
                    if (valueProposalDescription is string vProposalDescriptionValue) { ret.ProposalDescription = vProposalDescriptionValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vProposalTotalVotes = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vProposalTotalVotes.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueProposalTotalVotes = vProposalTotalVotes.ToValue();
                    if (valueProposalTotalVotes is ulong vProposalTotalVotesValue) { ret.ProposalTotalVotes = vProposalTotalVotesValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vProposalYesVotes = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vProposalYesVotes.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueProposalYesVotes = vProposalYesVotes.ToValue();
                    if (valueProposalYesVotes is ulong vProposalYesVotesValue) { ret.ProposalYesVotes = vProposalYesVotesValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCreatedAtTimestamp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vCreatedAtTimestamp.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCreatedAtTimestamp = vCreatedAtTimestamp.ToValue();
                    if (valueCreatedAtTimestamp is ulong vCreatedAtTimestampValue) { ret.CreatedAtTimestamp = vCreatedAtTimestampValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExpiryTimestamp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vExpiryTimestamp.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueExpiryTimestamp = vExpiryTimestamp.ToValue();
                    if (valueExpiryTimestamp is ulong vExpiryTimestampValue) { ret.ExpiryTimestamp = vExpiryTimestampValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ProposalDataType);
                }
                public bool Equals(ProposalDataType? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ProposalDataType left, ProposalDataType right)
                {
                    return EqualityComparer<ProposalDataType>.Default.Equals(left, right);
                }
                public static bool operator !=(ProposalDataType left, ProposalDataType right)
                {
                    return !(left == right);
                }

            }

            public class ProposalIdType : AVMObjectType
            {
                public ulong Nonce { get; set; }

                public string ProposalType { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNonce = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vNonce.From(Nonce);
                    ret.AddRange(vNonce.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vProposalType = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vProposalType.From(ProposalType);
                    stringRef[ret.Count] = vProposalType.Encode();
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

                public static ProposalIdType Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new ProposalIdType();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNonce = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vNonce.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueNonce = vNonce.ToValue();
                    if (valueNonce is ulong vNonceValue) { ret.Nonce = vNonceValue; }
                    var indexProposalType = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vProposalType = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vProposalType.Decode(bytes.Skip(indexProposalType + prefixOffset).ToArray());
                    var valueProposalType = vProposalType.ToValue();
                    if (valueProposalType is string vProposalTypeValue) { ret.ProposalType = vProposalTypeValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ProposalIdType);
                }
                public bool Equals(ProposalIdType? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ProposalIdType left, ProposalIdType right)
                {
                    return EqualityComparer<ProposalIdType>.Default.Equals(left, right);
                }
                public static bool operator !=(ProposalIdType left, ProposalIdType right)
                {
                    return !(left == right);
                }

            }

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

        ///<summary>
        ///Create a new proposal
        ///</summary>
        /// <param name="proposalType">Type of the proposal - can be reg or pool </param>
        /// <param name="proposalTitle">Title of the proposal </param>
        /// <param name="proposalDescription">Description of the proposal </param>
        /// <param name="expiresIn">Time in seconds for the proposal to expire </param>
        /// <param name="mbrTxn"> </param>
        public async Task CreateNewProposal(PaymentTransaction mbrTxn, string proposalType, string proposalTitle, string proposalDescription, ulong expiresIn, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrTxn });
            byte[] abiHandle = { 62, 92, 21, 230 };
            var proposalTypeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); proposalTypeAbi.From(proposalType);
            var proposalTitleAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); proposalTitleAbi.From(proposalTitle);
            var proposalDescriptionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); proposalDescriptionAbi.From(proposalDescription);
            var expiresInAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); expiresInAbi.From(expiresIn);

            var result = await base.CallApp(new List<object> { abiHandle, proposalTypeAbi, proposalTitleAbi, proposalDescriptionAbi, expiresInAbi, mbrTxn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateNewProposal_Transactions(PaymentTransaction mbrTxn, string proposalType, string proposalTitle, string proposalDescription, ulong expiresIn, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrTxn });
            byte[] abiHandle = { 62, 92, 21, 230 };
            var proposalTypeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); proposalTypeAbi.From(proposalType);
            var proposalTitleAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); proposalTitleAbi.From(proposalTitle);
            var proposalDescriptionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); proposalDescriptionAbi.From(proposalDescription);
            var expiresInAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); expiresInAbi.From(expiresIn);

            return await base.MakeTransactionList(new List<object> { abiHandle, proposalTypeAbi, proposalTitleAbi, proposalDescriptionAbi, expiresInAbi, mbrTxn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbNCw1Nl0sIm5hbWUiOiJDb21weEdvdmVybmFuY2UiLCJkZXNjIjoiIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IlByb3Bvc2FsRGF0YVR5cGUiOlt7Im5hbWUiOiJwcm9wb3NhbFRpdGxlIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6InByb3Bvc2FsRGVzY3JpcHRpb24iLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoiUHJvcG9zYWxUb3RhbFZvdGVzIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6IlByb3Bvc2FsWWVzVm90ZXMiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiQ3JlYXRlZEF0VGltZXN0YW1wIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6IkV4cGlyeVRpbWVzdGFtcCIsInR5cGUiOiJ1aW50NjQifV0sIlByb3Bvc2FsSWRUeXBlIjpbeyJuYW1lIjoibm9uY2UiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoicHJvcG9zYWxUeXBlIiwidHlwZSI6InN0cmluZyJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGVBcHBsaWNhdGlvbiIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH0seyJuYW1lIjoiY3JlYXRlTmV3UHJvcG9zYWwiLCJkZXNjIjoiQ3JlYXRlIGEgbmV3IHByb3Bvc2FsIiwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByb3Bvc2FsVHlwZSIsImRlc2MiOiJUeXBlIG9mIHRoZSBwcm9wb3NhbCAtIGNhbiBiZSByZWcgb3IgcG9vbCIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJvcG9zYWxUaXRsZSIsImRlc2MiOiJUaXRsZSBvZiB0aGUgcHJvcG9zYWwiLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByb3Bvc2FsRGVzY3JpcHRpb24iLCJkZXNjIjoiRGVzY3JpcHRpb24gb2YgdGhlIHByb3Bvc2FsIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJleHBpcmVzSW4iLCJkZXNjIjoiVGltZSBpbiBzZWNvbmRzIGZvciB0aGUgcHJvcG9zYWwgdG8gZXhwaXJlIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtYnJUeG4iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpudWxsLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjoxLCJieXRlcyI6MX0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MSwic291cmNlIjoiY29udHJhY3RzL0NvbXB4R292ZXJuYW5jZS5hbGdvLnRzOjcifSx7InBjIjpbMSwyLDMsNF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6Miwic291cmNlIjoiY29udHJhY3RzL0NvbXB4R292ZXJuYW5jZS5hbGdvLnRzOjcifSx7InBjIjpbNSw2LDcsOCw5LDEwLDExLDEyLDEzLDE0LDE1LDE2LDE3LDE4LDE5LDIwLDIxLDIyLDIzLDI0LDI1LDI2LDI3LDI4LDI5LDMwLDMxLDMyLDMzLDM0LDM1LDM2LDM3LDM4LDM5LDQwLDQxLDQyLDQzLDQ0LDQ1LDQ2LDQ3LDQ4LDQ5LDUwLDUxLDUyLDUzLDU0LDU1LDU2LDU3LDU4LDU5LDYwLDYxLDYyLDYzXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozLCJzb3VyY2UiOiJjb250cmFjdHMvQ29tcHhHb3Zlcm5hbmNlLmFsZ28udHM6NyJ9LHsicGMiOls2NCw2NV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTUsInNvdXJjZSI6ImNvbnRyYWN0cy9Db21weEdvdmVybmFuY2UuYWxnby50czo3In0seyJwYyI6WzY2XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxNiwic291cmNlIjoiY29udHJhY3RzL0NvbXB4R292ZXJuYW5jZS5hbGdvLnRzOjcifSx7InBjIjpbNjcsNjhdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE3LCJzb3VyY2UiOiJjb250cmFjdHMvQ29tcHhHb3Zlcm5hbmNlLmFsZ28udHM6NyJ9LHsicGMiOls2OV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTgsInNvdXJjZSI6ImNvbnRyYWN0cy9Db21weEdvdmVybmFuY2UuYWxnby50czo3In0seyJwYyI6WzcwLDcxXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxOSwic291cmNlIjoiY29udHJhY3RzL0NvbXB4R292ZXJuYW5jZS5hbGdvLnRzOjcifSx7InBjIjpbNzJdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjIwLCJzb3VyY2UiOiJjb250cmFjdHMvQ29tcHhHb3Zlcm5hbmNlLmFsZ28udHM6NyJ9LHsicGMiOls3Myw3NCw3NSw3Niw3Nyw3OCw3OSw4MCw4MSw4Miw4Myw4NCw4NSw4Niw4Nyw4OCw4OSw5MCw5MSw5Miw5Myw5NCw5NSw5Niw5Nyw5OF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MjEsInNvdXJjZSI6ImNvbnRyYWN0cy9Db21weEdvdmVybmFuY2UuYWxnby50czo3In0seyJwYyI6Wzk5XSwiZXJyb3JNZXNzYWdlIjoiVGhlIHJlcXVlc3RlZCBhY3Rpb24gaXMgbm90IGltcGxlbWVudGVkIGluIHRoaXMgY29udHJhY3QuIEFyZSB5b3UgdXNpbmcgdGhlIGNvcnJlY3QgT25Db21wbGV0ZT8gRGlkIHlvdSBzZXQgeW91ciBhcHAgSUQ/IiwidGVhbCI6MjUsInNvdXJjZSI6ImNvbnRyYWN0cy9Db21weEdvdmVybmFuY2UuYWxnby50czo3In0seyJwYyI6WzEwMCwxMDEsMTAyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozMCwic291cmNlIjoiY29udHJhY3RzL0NvbXB4R292ZXJuYW5jZS5hbGdvLnRzOjE3In0seyJwYyI6WzEwM10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MzEsInNvdXJjZSI6ImNvbnRyYWN0cy9Db21weEdvdmVybmFuY2UuYWxnby50czoxNyJ9LHsicGMiOlsxMDRdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjMyLCJzb3VyY2UiOiJjb250cmFjdHMvQ29tcHhHb3Zlcm5hbmNlLmFsZ28udHM6MTcifSx7InBjIjpbMTA1LDEwNiwxMDddLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjM2LCJzb3VyY2UiOiJjb250cmFjdHMvQ29tcHhHb3Zlcm5hbmNlLmFsZ28udHM6MTcifSx7InBjIjpbMTA4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo0MCwic291cmNlIjoiY29udHJhY3RzL0NvbXB4R292ZXJuYW5jZS5hbGdvLnRzOjE4In0seyJwYyI6WzEwOV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NDEsInNvdXJjZSI6ImNvbnRyYWN0cy9Db21weEdvdmVybmFuY2UuYWxnby50czoxOCJ9LHsicGMiOlsxMTBdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjQyLCJzb3VyY2UiOiJjb250cmFjdHMvQ29tcHhHb3Zlcm5hbmNlLmFsZ28udHM6MTgifSx7InBjIjpbMTExXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo0Niwic291cmNlIjoiY29udHJhY3RzL0NvbXB4R292ZXJuYW5jZS5hbGdvLnRzOjE5In0seyJwYyI6WzExMiwxMTNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjQ3LCJzb3VyY2UiOiJjb250cmFjdHMvQ29tcHhHb3Zlcm5hbmNlLmFsZ28udHM6MTkifSx7InBjIjpbMTE0XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo0OCwic291cmNlIjoiY29udHJhY3RzL0NvbXB4R292ZXJuYW5jZS5hbGdvLnRzOjE5In0seyJwYyI6WzExNV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NTIsInNvdXJjZSI6ImNvbnRyYWN0cy9Db21weEdvdmVybmFuY2UuYWxnby50czoyMCJ9LHsicGMiOlsxMTZdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjUzLCJzb3VyY2UiOiJjb250cmFjdHMvQ29tcHhHb3Zlcm5hbmNlLmFsZ28udHM6MjAifSx7InBjIjpbMTE3XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1NCwic291cmNlIjoiY29udHJhY3RzL0NvbXB4R292ZXJuYW5jZS5hbGdvLnRzOjIwIn0seyJwYyI6WzExOF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NTUsInNvdXJjZSI6ImNvbnRyYWN0cy9Db21weEdvdmVybmFuY2UuYWxnby50czoxNyJ9LHsicGMiOlsxMTksMTIwXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo2MCwic291cmNlIjoiY29udHJhY3RzL0NvbXB4R292ZXJuYW5jZS5hbGdvLnRzOjM2In0seyJwYyI6WzEyMV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NjEsInNvdXJjZSI6ImNvbnRyYWN0cy9Db21weEdvdmVybmFuY2UuYWxnby50czozNiJ9LHsicGMiOlsxMjJdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjYyLCJzb3VyY2UiOiJjb250cmFjdHMvQ29tcHhHb3Zlcm5hbmNlLmFsZ28udHM6MzYifSx7InBjIjpbMTIzXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo2Mywic291cmNlIjoiY29udHJhY3RzL0NvbXB4R292ZXJuYW5jZS5hbGdvLnRzOjM2In0seyJwYyI6WzEyNCwxMjVdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjY0LCJzb3VyY2UiOiJjb250cmFjdHMvQ29tcHhHb3Zlcm5hbmNlLmFsZ28udHM6MzYifSx7InBjIjpbMTI2XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo2NSwic291cmNlIjoiY29udHJhY3RzL0NvbXB4R292ZXJuYW5jZS5hbGdvLnRzOjM2In0seyJwYyI6WzEyN10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NjYsInNvdXJjZSI6ImNvbnRyYWN0cy9Db21weEdvdmVybmFuY2UuYWxnby50czozNiJ9LHsicGMiOlsxMjhdLCJlcnJvck1lc3NhZ2UiOiJhcmd1bWVudCAwIChtYnJUeG4pIGZvciBjcmVhdGVOZXdQcm9wb3NhbCBtdXN0IGJlIGEgcGF5IHRyYW5zYWN0aW9uIiwidGVhbCI6NjksInNvdXJjZSI6ImNvbnRyYWN0cy9Db21weEdvdmVybmFuY2UuYWxnby50czozNiJ9LHsicGMiOlsxMjksMTMwLDEzMV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NzIsInNvdXJjZSI6ImNvbnRyYWN0cy9Db21weEdvdmVybmFuY2UuYWxnby50czozNSJ9LHsicGMiOlsxMzJdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjczLCJzb3VyY2UiOiJjb250cmFjdHMvQ29tcHhHb3Zlcm5hbmNlLmFsZ28udHM6MzUifSx7InBjIjpbMTMzLDEzNCwxMzVdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjc2LCJzb3VyY2UiOiJjb250cmFjdHMvQ29tcHhHb3Zlcm5hbmNlLmFsZ28udHM6MzQifSx7InBjIjpbMTM2LDEzNywxMzhdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjc3LCJzb3VyY2UiOiJjb250cmFjdHMvQ29tcHhHb3Zlcm5hbmNlLmFsZ28udHM6MzQifSx7InBjIjpbMTM5LDE0MCwxNDFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjgwLCJzb3VyY2UiOiJjb250cmFjdHMvQ29tcHhHb3Zlcm5hbmNlLmFsZ28udHM6MzMifSx7InBjIjpbMTQyLDE0MywxNDRdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjgxLCJzb3VyY2UiOiJjb250cmFjdHMvQ29tcHhHb3Zlcm5hbmNlLmFsZ28udHM6MzMifSx7InBjIjpbMTQ1LDE0NiwxNDddLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjg0LCJzb3VyY2UiOiJjb250cmFjdHMvQ29tcHhHb3Zlcm5hbmNlLmFsZ28udHM6MzIifSx7InBjIjpbMTQ4LDE0OSwxNTBdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjg1LCJzb3VyY2UiOiJjb250cmFjdHMvQ29tcHhHb3Zlcm5hbmNlLmFsZ28udHM6MzIifSx7InBjIjpbMTUxLDE1MiwxNTNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjg4LCJzb3VyY2UiOiJjb250cmFjdHMvQ29tcHhHb3Zlcm5hbmNlLmFsZ28udHM6MzEifSx7InBjIjpbMTU0XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo4OSwic291cmNlIjoiY29udHJhY3RzL0NvbXB4R292ZXJuYW5jZS5hbGdvLnRzOjMxIn0seyJwYyI6WzE1NV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6OTAsInNvdXJjZSI6ImNvbnRyYWN0cy9Db21weEdvdmVybmFuY2UuYWxnby50czozMSJ9LHsicGMiOlsxNTYsMTU3LDE1OF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTAwLCJzb3VyY2UiOiJjb250cmFjdHMvQ29tcHhHb3Zlcm5hbmNlLmFsZ28udHM6MzEifSx7InBjIjpbMTU5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMDMsInNvdXJjZSI6ImNvbnRyYWN0cy9Db21weEdvdmVybmFuY2UuYWxnby50czozMSJ9LHsicGMiOlsxNjAsMTYxXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMDQsInNvdXJjZSI6ImNvbnRyYWN0cy9Db21weEdvdmVybmFuY2UuYWxnby50czozMSJ9LHsicGMiOlsxNjIsMTYzXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMDgsInNvdXJjZSI6ImNvbnRyYWN0cy9Db21weEdvdmVybmFuY2UuYWxnby50czozOCJ9LHsicGMiOlsxNjQsMTY1XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMDksInNvdXJjZSI6ImNvbnRyYWN0cy9Db21weEdvdmVybmFuY2UuYWxnby50czozOCJ9LHsicGMiOlsxNjZdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjExMywic291cmNlIjoiY29udHJhY3RzL0NvbXB4R292ZXJuYW5jZS5hbGdvLnRzOjQxIn0seyJwYyI6WzE2N10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTE0LCJzb3VyY2UiOiJjb250cmFjdHMvQ29tcHhHb3Zlcm5hbmNlLmFsZ28udHM6NDEifSx7InBjIjpbMTY4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMTUsInNvdXJjZSI6ImNvbnRyYWN0cy9Db21weEdvdmVybmFuY2UuYWxnby50czo0MSJ9LHsicGMiOlsxNjldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjExNiwic291cmNlIjoiY29udHJhY3RzL0NvbXB4R292ZXJuYW5jZS5hbGdvLnRzOjQxIn0seyJwYyI6WzE3MCwxNzFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjExNywic291cmNlIjoiY29udHJhY3RzL0NvbXB4R292ZXJuYW5jZS5hbGdvLnRzOjQxIn0seyJwYyI6WzE3MiwxNzNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEyMSwic291cmNlIjoiY29udHJhY3RzL0NvbXB4R292ZXJuYW5jZS5hbGdvLnRzOjQyIn0seyJwYyI6WzE3NCwxNzVdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEyMiwic291cmNlIjoiY29udHJhY3RzL0NvbXB4R292ZXJuYW5jZS5hbGdvLnRzOjQyIn0seyJwYyI6WzE3NiwxNzddLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEyNiwic291cmNlIjoiY29udHJhY3RzL0NvbXB4R292ZXJuYW5jZS5hbGdvLnRzOjQ1In0seyJwYyI6WzE3OCwxNzldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEyNywic291cmNlIjoiY29udHJhY3RzL0NvbXB4R292ZXJuYW5jZS5hbGdvLnRzOjQ1In0seyJwYyI6WzE4MF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTI4LCJzb3VyY2UiOiJjb250cmFjdHMvQ29tcHhHb3Zlcm5hbmNlLmFsZ28udHM6NDUifSx7InBjIjpbMTgxLDE4Ml0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTI5LCJzb3VyY2UiOiJjb250cmFjdHMvQ29tcHhHb3Zlcm5hbmNlLmFsZ28udHM6NDUifSx7InBjIjpbMTgzLDE4NF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTMzLCJzb3VyY2UiOiJjb250cmFjdHMvQ29tcHhHb3Zlcm5hbmNlLmFsZ28udHM6NDgifSx7InBjIjpbMTg1XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMzQsInNvdXJjZSI6ImNvbnRyYWN0cy9Db21weEdvdmVybmFuY2UuYWxnby50czo0OCJ9LHsicGMiOlsxODZdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEzNSwic291cmNlIjoiY29udHJhY3RzL0NvbXB4R292ZXJuYW5jZS5hbGdvLnRzOjQ4In0seyJwYyI6WzE4N10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTM2LCJzb3VyY2UiOiJjb250cmFjdHMvQ29tcHhHb3Zlcm5hbmNlLmFsZ28udHM6NDgifSx7InBjIjpbMTg4XSwiZXJyb3JNZXNzYWdlIjoiT25seSB0aGUgZGVwbG95ZXIgY2FuIGNyZWF0ZSBwcm9wb3NhbHMiLCJ0ZWFsIjoxMzksInNvdXJjZSI6ImNvbnRyYWN0cy9Db21weEdvdmVybmFuY2UuYWxnby50czo0OCJ9LHsicGMiOlsxODldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE0Mywic291cmNlIjoiY29udHJhY3RzL0NvbXB4R292ZXJuYW5jZS5hbGdvLnRzOjQ5In0seyJwYyI6WzE5MF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTQ0LCJzb3VyY2UiOiJjb250cmFjdHMvQ29tcHhHb3Zlcm5hbmNlLmFsZ28udHM6NDkifSx7InBjIjpbMTkxXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxNDUsInNvdXJjZSI6ImNvbnRyYWN0cy9Db21weEdvdmVybmFuY2UuYWxnby50czo0OSJ9LHsicGMiOlsxOTIsMTkzXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxNDYsInNvdXJjZSI6ImNvbnRyYWN0cy9Db21weEdvdmVybmFuY2UuYWxnby50czo0OSJ9LHsicGMiOlsxOTQsMTk1XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxNDcsInNvdXJjZSI6ImNvbnRyYWN0cy9Db21weEdvdmVybmFuY2UuYWxnby50czo0OSJ9LHsicGMiOlsxOTZdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE0OCwic291cmNlIjoiY29udHJhY3RzL0NvbXB4R292ZXJuYW5jZS5hbGdvLnRzOjQ5In0seyJwYyI6WzE5NywxOTgsMTk5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxNDksInNvdXJjZSI6ImNvbnRyYWN0cy9Db21weEdvdmVybmFuY2UuYWxnby50czo0OSJ9LHsicGMiOlsyMDAsMjAxXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxNTAsInNvdXJjZSI6ImNvbnRyYWN0cy9Db21weEdvdmVybmFuY2UuYWxnby50czo0OSJ9LHsicGMiOlsyMDJdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE1MSwic291cmNlIjoiY29udHJhY3RzL0NvbXB4R292ZXJuYW5jZS5hbGdvLnRzOjQ5In0seyJwYyI6WzIwM10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTUyLCJzb3VyY2UiOiJjb250cmFjdHMvQ29tcHhHb3Zlcm5hbmNlLmFsZ28udHM6NDkifSx7InBjIjpbMjA0XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxNTMsInNvdXJjZSI6ImNvbnRyYWN0cy9Db21weEdvdmVybmFuY2UuYWxnby50czo0OSJ9LHsicGMiOlsyMDUsMjA2LDIwN10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTU0LCJzb3VyY2UiOiJjb250cmFjdHMvQ29tcHhHb3Zlcm5hbmNlLmFsZ28udHM6NDkifSx7InBjIjpbMjA4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxNTUsInNvdXJjZSI6ImNvbnRyYWN0cy9Db21weEdvdmVybmFuY2UuYWxnby50czo0OSJ9LHsicGMiOlsyMDldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE1Niwic291cmNlIjoiY29udHJhY3RzL0NvbXB4R292ZXJuYW5jZS5hbGdvLnRzOjQ5In0seyJwYyI6WzIxMCwyMTEsMjEyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxNTcsInNvdXJjZSI6ImNvbnRyYWN0cy9Db21weEdvdmVybmFuY2UuYWxnby50czo0OSJ9LHsicGMiOlsyMTNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE1OCwic291cmNlIjoiY29udHJhY3RzL0NvbXB4R292ZXJuYW5jZS5hbGdvLnRzOjQ5In0seyJwYyI6WzIxNF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTU5LCJzb3VyY2UiOiJjb250cmFjdHMvQ29tcHhHb3Zlcm5hbmNlLmFsZ28udHM6NDkifSx7InBjIjpbMjE1XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxNjAsInNvdXJjZSI6ImNvbnRyYWN0cy9Db21weEdvdmVybmFuY2UuYWxnby50czo0OSJ9LHsicGMiOlsyMTZdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE2MSwic291cmNlIjoiY29udHJhY3RzL0NvbXB4R292ZXJuYW5jZS5hbGdvLnRzOjQ5In0seyJwYyI6WzIxN10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTYyLCJzb3VyY2UiOiJjb250cmFjdHMvQ29tcHhHb3Zlcm5hbmNlLmFsZ28udHM6NDkifSx7InBjIjpbMjE4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxNjMsInNvdXJjZSI6ImNvbnRyYWN0cy9Db21weEdvdmVybmFuY2UuYWxnby50czo0OSJ9LHsicGMiOlsyMTldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE2NCwic291cmNlIjoiY29udHJhY3RzL0NvbXB4R292ZXJuYW5jZS5hbGdvLnRzOjQ5In0seyJwYyI6WzIyMF0sImVycm9yTWVzc2FnZSI6IlByb3Bvc2FsIGFscmVhZHkgZXhpc3RzIiwidGVhbCI6MTY3LCJzb3VyY2UiOiJjb250cmFjdHMvQ29tcHhHb3Zlcm5hbmNlLmFsZ28udHM6NDkifSx7InBjIjpbMjIxLDIyMl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTcyLCJzb3VyY2UiOiJjb250cmFjdHMvQ29tcHhHb3Zlcm5hbmNlLmFsZ28udHM6NTIifSx7InBjIjpbMjIzLDIyNF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTczLCJzb3VyY2UiOiJjb250cmFjdHMvQ29tcHhHb3Zlcm5hbmNlLmFsZ28udHM6NTIifSx7InBjIjpbMjI1LDIyNiwyMjddLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE3NCwic291cmNlIjoiY29udHJhY3RzL0NvbXB4R292ZXJuYW5jZS5hbGdvLnRzOjUyIn0seyJwYyI6WzIyOF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTc1LCJzb3VyY2UiOiJjb250cmFjdHMvQ29tcHhHb3Zlcm5hbmNlLmFsZ28udHM6NTIifSx7InBjIjpbMjI5XSwiZXJyb3JNZXNzYWdlIjoidHJhbnNhY3Rpb24gdmVyaWZpY2F0aW9uIGZhaWxlZDoge1widHhuXCI6XCJtYnJUeG5cIixcImZpZWxkXCI6XCJhbW91bnRcIixcImNvbmRpdGlvblwiOlwiZ3JlYXRlclRoYW5FcXVhbFRvXCIsXCJleHBlY3RlZFwiOlwiPj1wcm9wb3NhbE1iclwifSIsInRlYWwiOjE3OCwic291cmNlIjoiY29udHJhY3RzL0NvbXB4R292ZXJuYW5jZS5hbGdvLnRzOjUyIn0seyJwYyI6WzIzMF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTg5LCJzb3VyY2UiOiJjb250cmFjdHMvQ29tcHhHb3Zlcm5hbmNlLmFsZ28udHM6NTUifSx7InBjIjpbMjMxXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxOTAsInNvdXJjZSI6ImNvbnRyYWN0cy9Db21weEdvdmVybmFuY2UuYWxnby50czo1NSJ9LHsicGMiOlsyMzJdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE5MSwic291cmNlIjoiY29udHJhY3RzL0NvbXB4R292ZXJuYW5jZS5hbGdvLnRzOjU1In0seyJwYyI6WzIzMywyMzRdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE5Miwic291cmNlIjoiY29udHJhY3RzL0NvbXB4R292ZXJuYW5jZS5hbGdvLnRzOjU1In0seyJwYyI6WzIzNSwyMzZdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE5Mywic291cmNlIjoiY29udHJhY3RzL0NvbXB4R292ZXJuYW5jZS5hbGdvLnRzOjU1In0seyJwYyI6WzIzN10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTk0LCJzb3VyY2UiOiJjb250cmFjdHMvQ29tcHhHb3Zlcm5hbmNlLmFsZ28udHM6NTUifSx7InBjIjpbMjM4LDIzOSwyNDBdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE5NSwic291cmNlIjoiY29udHJhY3RzL0NvbXB4R292ZXJuYW5jZS5hbGdvLnRzOjU1In0seyJwYyI6WzI0MSwyNDJdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE5Niwic291cmNlIjoiY29udHJhY3RzL0NvbXB4R292ZXJuYW5jZS5hbGdvLnRzOjU1In0seyJwYyI6WzI0M10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTk3LCJzb3VyY2UiOiJjb250cmFjdHMvQ29tcHhHb3Zlcm5hbmNlLmFsZ28udHM6NTUifSx7InBjIjpbMjQ0XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxOTgsInNvdXJjZSI6ImNvbnRyYWN0cy9Db21weEdvdmVybmFuY2UuYWxnby50czo1NSJ9LHsicGMiOlsyNDVdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE5OSwic291cmNlIjoiY29udHJhY3RzL0NvbXB4R292ZXJuYW5jZS5hbGdvLnRzOjU1In0seyJwYyI6WzI0NiwyNDcsMjQ4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoyMDAsInNvdXJjZSI6ImNvbnRyYWN0cy9Db21weEdvdmVybmFuY2UuYWxnby50czo1NSJ9LHsicGMiOlsyNDldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjIwMSwic291cmNlIjoiY29udHJhY3RzL0NvbXB4R292ZXJuYW5jZS5hbGdvLnRzOjU1In0seyJwYyI6WzI1MF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MjAyLCJzb3VyY2UiOiJjb250cmFjdHMvQ29tcHhHb3Zlcm5hbmNlLmFsZ28udHM6NTUifSx7InBjIjpbMjUxLDI1MiwyNTNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjIwMywic291cmNlIjoiY29udHJhY3RzL0NvbXB4R292ZXJuYW5jZS5hbGdvLnRzOjU1In0seyJwYyI6WzI1NF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MjA0LCJzb3VyY2UiOiJjb250cmFjdHMvQ29tcHhHb3Zlcm5hbmNlLmFsZ28udHM6NTUifSx7InBjIjpbMjU1XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoyMDUsInNvdXJjZSI6ImNvbnRyYWN0cy9Db21weEdvdmVybmFuY2UuYWxnby50czo1NSJ9LHsicGMiOlsyNTZdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjIwNiwic291cmNlIjoiY29udHJhY3RzL0NvbXB4R292ZXJuYW5jZS5hbGdvLnRzOjU1In0seyJwYyI6WzI1N10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MjA3LCJzb3VyY2UiOiJjb250cmFjdHMvQ29tcHhHb3Zlcm5hbmNlLmFsZ28udHM6NTUifSx7InBjIjpbMjU4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoyMDgsInNvdXJjZSI6ImNvbnRyYWN0cy9Db21weEdvdmVybmFuY2UuYWxnby50czo1NSJ9LHsicGMiOlsyNTldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjIwOSwic291cmNlIjoiY29udHJhY3RzL0NvbXB4R292ZXJuYW5jZS5hbGdvLnRzOjU1In0seyJwYyI6WzI2MF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MjEwLCJzb3VyY2UiOiJjb250cmFjdHMvQ29tcHhHb3Zlcm5hbmNlLmFsZ28udHM6NTUifSx7InBjIjpbMjYxXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoyMTEsInNvdXJjZSI6ImNvbnRyYWN0cy9Db21weEdvdmVybmFuY2UuYWxnby50czo1NSJ9LHsicGMiOlsyNjIsMjYzLDI2NCwyNjVdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjIxMiwic291cmNlIjoiY29udHJhY3RzL0NvbXB4R292ZXJuYW5jZS5hbGdvLnRzOjU1In0seyJwYyI6WzI2NiwyNjddLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjIxMywic291cmNlIjoiY29udHJhY3RzL0NvbXB4R292ZXJuYW5jZS5hbGdvLnRzOjU2In0seyJwYyI6WzI2OF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MjE0LCJzb3VyY2UiOiJjb250cmFjdHMvQ29tcHhHb3Zlcm5hbmNlLmFsZ28udHM6NTYifSx7InBjIjpbMjY5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoyMTUsInNvdXJjZSI6ImNvbnRyYWN0cy9Db21weEdvdmVybmFuY2UuYWxnby50czo1NiJ9LHsicGMiOlsyNzBdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjIxNiwic291cmNlIjoiY29udHJhY3RzL0NvbXB4R292ZXJuYW5jZS5hbGdvLnRzOjU2In0seyJwYyI6WzI3MSwyNzIsMjczXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoyMTcsInNvdXJjZSI6ImNvbnRyYWN0cy9Db21weEdvdmVybmFuY2UuYWxnby50czo1NiJ9LHsicGMiOlsyNzRdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjIxOCwic291cmNlIjoiY29udHJhY3RzL0NvbXB4R292ZXJuYW5jZS5hbGdvLnRzOjU2In0seyJwYyI6WzI3NV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MjE5LCJzb3VyY2UiOiJjb250cmFjdHMvQ29tcHhHb3Zlcm5hbmNlLmFsZ28udHM6NTYifSx7InBjIjpbMjc2LDI3NywyNzhdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjIyMCwic291cmNlIjoiY29udHJhY3RzL0NvbXB4R292ZXJuYW5jZS5hbGdvLnRzOjU2In0seyJwYyI6WzI3OSwyODBdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjIyMSwic291cmNlIjoiY29udHJhY3RzL0NvbXB4R292ZXJuYW5jZS5hbGdvLnRzOjU3In0seyJwYyI6WzI4MV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MjIyLCJzb3VyY2UiOiJjb250cmFjdHMvQ29tcHhHb3Zlcm5hbmNlLmFsZ28udHM6NTcifSx7InBjIjpbMjgyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoyMjMsInNvdXJjZSI6ImNvbnRyYWN0cy9Db21weEdvdmVybmFuY2UuYWxnby50czo1NyJ9LHsicGMiOlsyODNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjIyNCwic291cmNlIjoiY29udHJhY3RzL0NvbXB4R292ZXJuYW5jZS5hbGdvLnRzOjU3In0seyJwYyI6WzI4NCwyODUsMjg2XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoyMjUsInNvdXJjZSI6ImNvbnRyYWN0cy9Db21weEdvdmVybmFuY2UuYWxnby50czo1NyJ9LHsicGMiOlsyODddLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjIyNiwic291cmNlIjoiY29udHJhY3RzL0NvbXB4R292ZXJuYW5jZS5hbGdvLnRzOjU3In0seyJwYyI6WzI4OF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MjI3LCJzb3VyY2UiOiJjb250cmFjdHMvQ29tcHhHb3Zlcm5hbmNlLmFsZ28udHM6NTcifSx7InBjIjpbMjg5LDI5MCwyOTFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjIyOCwic291cmNlIjoiY29udHJhY3RzL0NvbXB4R292ZXJuYW5jZS5hbGdvLnRzOjU3In0seyJwYyI6WzI5MiwyOTNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjIyOSwic291cmNlIjoiY29udHJhY3RzL0NvbXB4R292ZXJuYW5jZS5hbGdvLnRzOjU4In0seyJwYyI6WzI5NCwyOTUsMjk2XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoyMzAsInNvdXJjZSI6ImNvbnRyYWN0cy9Db21weEdvdmVybmFuY2UuYWxnby50czo1OCJ9LHsicGMiOlsyOTcsMjk4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoyMzEsInNvdXJjZSI6ImNvbnRyYWN0cy9Db21weEdvdmVybmFuY2UuYWxnby50czo1OSJ9LHsicGMiOlsyOTksMzAwLDMwMV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MjMyLCJzb3VyY2UiOiJjb250cmFjdHMvQ29tcHhHb3Zlcm5hbmNlLmFsZ28udHM6NTkifSx7InBjIjpbMzAyLDMwM10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MjMzLCJzb3VyY2UiOiJjb250cmFjdHMvQ29tcHhHb3Zlcm5hbmNlLmFsZ28udHM6NjAifSx7InBjIjpbMzA0XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoyMzQsInNvdXJjZSI6ImNvbnRyYWN0cy9Db21weEdvdmVybmFuY2UuYWxnby50czo2MCJ9LHsicGMiOlszMDUsMzA2LDMwN10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MjM1LCJzb3VyY2UiOiJjb250cmFjdHMvQ29tcHhHb3Zlcm5hbmNlLmFsZ28udHM6NjAifSx7InBjIjpbMzA4LDMwOV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MjM2LCJzb3VyY2UiOiJjb250cmFjdHMvQ29tcHhHb3Zlcm5hbmNlLmFsZ28udHM6NjEifSx7InBjIjpbMzEwXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoyMzcsInNvdXJjZSI6ImNvbnRyYWN0cy9Db21weEdvdmVybmFuY2UuYWxnby50czo2MSJ9LHsicGMiOlszMTEsMzEyLDMxM10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MjM4LCJzb3VyY2UiOiJjb250cmFjdHMvQ29tcHhHb3Zlcm5hbmNlLmFsZ28udHM6NjEifSx7InBjIjpbMzE0XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoyMzksInNvdXJjZSI6ImNvbnRyYWN0cy9Db21weEdvdmVybmFuY2UuYWxnby50czo1NSJ9LHsicGMiOlszMTVdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjI0MCwic291cmNlIjoiY29udHJhY3RzL0NvbXB4R292ZXJuYW5jZS5hbGdvLnRzOjU1In0seyJwYyI6WzMxNl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MjQxLCJzb3VyY2UiOiJjb250cmFjdHMvQ29tcHhHb3Zlcm5hbmNlLmFsZ28udHM6NTUifSx7InBjIjpbMzE3XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoyNDUsInNvdXJjZSI6ImNvbnRyYWN0cy9Db21weEdvdmVybmFuY2UuYWxnby50czo2NCJ9LHsicGMiOlszMThdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjI0Niwic291cmNlIjoiY29udHJhY3RzL0NvbXB4R292ZXJuYW5jZS5hbGdvLnRzOjY0In0seyJwYyI6WzMxOV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MjQ3LCJzb3VyY2UiOiJjb250cmFjdHMvQ29tcHhHb3Zlcm5hbmNlLmFsZ28udHM6NjQifSx7InBjIjpbMzIwXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoyNDgsInNvdXJjZSI6ImNvbnRyYWN0cy9Db21weEdvdmVybmFuY2UuYWxnby50czo2NCJ9LHsicGMiOlszMjFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjI0OSwic291cmNlIjoiY29udHJhY3RzL0NvbXB4R292ZXJuYW5jZS5hbGdvLnRzOjY0In0seyJwYyI6WzMyMl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MjUwLCJzb3VyY2UiOiJjb250cmFjdHMvQ29tcHhHb3Zlcm5hbmNlLmFsZ28udHM6NjQifSx7InBjIjpbMzIzXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoyNTEsInNvdXJjZSI6ImNvbnRyYWN0cy9Db21weEdvdmVybmFuY2UuYWxnby50czo2NCJ9LHsicGMiOlszMjRdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjI1Miwic291cmNlIjoiY29udHJhY3RzL0NvbXB4R292ZXJuYW5jZS5hbGdvLnRzOjMxIn0seyJwYyI6WzMyNSwzMjYsMzI3LDMyOCwzMjksMzMwXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoyNTUsInNvdXJjZSI6ImNvbnRyYWN0cy9Db21weEdvdmVybmFuY2UuYWxnby50czo3In0seyJwYyI6WzMzMSwzMzIsMzMzXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoyNTYsInNvdXJjZSI6ImNvbnRyYWN0cy9Db21weEdvdmVybmFuY2UuYWxnby50czo3In0seyJwYyI6WzMzNCwzMzUsMzM2LDMzN10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MjU3LCJzb3VyY2UiOiJjb250cmFjdHMvQ29tcHhHb3Zlcm5hbmNlLmFsZ28udHM6NyJ9LHsicGMiOlszMzhdLCJlcnJvck1lc3NhZ2UiOiJ0aGlzIGNvbnRyYWN0IGRvZXMgbm90IGltcGxlbWVudCB0aGUgZ2l2ZW4gQUJJIG1ldGhvZCBmb3IgY3JlYXRlIE5vT3AiLCJ0ZWFsIjoyNjAsInNvdXJjZSI6ImNvbnRyYWN0cy9Db21weEdvdmVybmFuY2UuYWxnby50czo3In0seyJwYyI6WzMzOSwzNDAsMzQxLDM0MiwzNDMsMzQ0XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoyNjMsInNvdXJjZSI6ImNvbnRyYWN0cy9Db21weEdvdmVybmFuY2UuYWxnby50czo3In0seyJwYyI6WzM0NSwzNDYsMzQ3XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoyNjQsInNvdXJjZSI6ImNvbnRyYWN0cy9Db21weEdvdmVybmFuY2UuYWxnby50czo3In0seyJwYyI6WzM0OCwzNDksMzUwLDM1MV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MjY1LCJzb3VyY2UiOiJjb250cmFjdHMvQ29tcHhHb3Zlcm5hbmNlLmFsZ28udHM6NyJ9LHsicGMiOlszNTJdLCJlcnJvck1lc3NhZ2UiOiJ0aGlzIGNvbnRyYWN0IGRvZXMgbm90IGltcGxlbWVudCB0aGUgZ2l2ZW4gQUJJIG1ldGhvZCBmb3IgY2FsbCBOb09wIiwidGVhbCI6MjY4LCJzb3VyY2UiOiJjb250cmFjdHMvQ29tcHhHb3Zlcm5hbmNlLmFsZ28udHM6NyJ9LHsicGMiOlszNTMsMzU0LDM1NV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MjcxLCJzb3VyY2UiOiJjb250cmFjdHMvQ29tcHhHb3Zlcm5hbmNlLmFsZ28udHM6NyJ9LHsicGMiOlszNTYsMzU3XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoyNzIsInNvdXJjZSI6ImNvbnRyYWN0cy9Db21weEdvdmVybmFuY2UuYWxnby50czo3In0seyJwYyI6WzM1OCwzNTldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjI3Mywic291cmNlIjoiY29udHJhY3RzL0NvbXB4R292ZXJuYW5jZS5hbGdvLnRzOjcifSx7InBjIjpbMzYwXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoyNzQsInNvdXJjZSI6ImNvbnRyYWN0cy9Db21weEdvdmVybmFuY2UuYWxnby50czo3In0seyJwYyI6WzM2MSwzNjJdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjI3NSwic291cmNlIjoiY29udHJhY3RzL0NvbXB4R292ZXJuYW5jZS5hbGdvLnRzOjcifSx7InBjIjpbMzYzLDM2NF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6Mjc2LCJzb3VyY2UiOiJjb250cmFjdHMvQ29tcHhHb3Zlcm5hbmNlLmFsZ28udHM6NyJ9LHsicGMiOlszNjVdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjI3Nywic291cmNlIjoiY29udHJhY3RzL0NvbXB4R292ZXJuYW5jZS5hbGdvLnRzOjcifSx7InBjIjpbMzY2LDM2NywzNjhdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjI4MCwic291cmNlIjoiY29udHJhY3RzL0NvbXB4R292ZXJuYW5jZS5hbGdvLnRzOjcifSx7InBjIjpbMzY5LDM3MF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MjgxLCJzb3VyY2UiOiJjb250cmFjdHMvQ29tcHhHb3Zlcm5hbmNlLmFsZ28udHM6NyJ9LHsicGMiOlszNzEsMzcyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoyODIsInNvdXJjZSI6ImNvbnRyYWN0cy9Db21weEdvdmVybmFuY2UuYWxnby50czo3In0seyJwYyI6WzM3M10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MjgzLCJzb3VyY2UiOiJjb250cmFjdHMvQ29tcHhHb3Zlcm5hbmNlLmFsZ28udHM6NyJ9LHsicGMiOlszNzQsMzc1XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoyODQsInNvdXJjZSI6ImNvbnRyYWN0cy9Db21weEdvdmVybmFuY2UuYWxnby50czo3In0seyJwYyI6WzM3NiwzNzddLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjI4NSwic291cmNlIjoiY29udHJhY3RzL0NvbXB4R292ZXJuYW5jZS5hbGdvLnRzOjcifSx7InBjIjpbMzc4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoyODYsInNvdXJjZSI6ImNvbnRyYWN0cy9Db21weEdvdmVybmFuY2UuYWxnby50czo3In0seyJwYyI6WzM3OV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6Mjg3LCJzb3VyY2UiOiJjb250cmFjdHMvQ29tcHhHb3Zlcm5hbmNlLmFsZ28udHM6NyJ9LHsicGMiOlszODAsMzgxXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoyODgsInNvdXJjZSI6ImNvbnRyYWN0cy9Db21weEdvdmVybmFuY2UuYWxnby50czo3In0seyJwYyI6WzM4Ml0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6Mjg5LCJzb3VyY2UiOiJjb250cmFjdHMvQ29tcHhHb3Zlcm5hbmNlLmFsZ28udHM6NyJ9LHsicGMiOlszODNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjI5MCwic291cmNlIjoiY29udHJhY3RzL0NvbXB4R292ZXJuYW5jZS5hbGdvLnRzOjcifSx7InBjIjpbMzg0XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoyOTEsInNvdXJjZSI6ImNvbnRyYWN0cy9Db21weEdvdmVybmFuY2UuYWxnby50czo3In0seyJwYyI6WzM4NSwzODYsMzg3XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoyOTIsInNvdXJjZSI6ImNvbnRyYWN0cy9Db21weEdvdmVybmFuY2UuYWxnby50czo3In0seyJwYyI6WzM4OCwzODldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjI5Mywic291cmNlIjoiY29udHJhY3RzL0NvbXB4R292ZXJuYW5jZS5hbGdvLnRzOjcifSx7InBjIjpbMzkwLDM5MV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6Mjk0LCJzb3VyY2UiOiJjb250cmFjdHMvQ29tcHhHb3Zlcm5hbmNlLmFsZ28udHM6NyJ9LHsicGMiOlszOTJdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjI5NSwic291cmNlIjoiY29udHJhY3RzL0NvbXB4R292ZXJuYW5jZS5hbGdvLnRzOjcifSx7InBjIjpbMzkzXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoyOTYsInNvdXJjZSI6ImNvbnRyYWN0cy9Db21weEdvdmVybmFuY2UuYWxnby50czo3In0seyJwYyI6WzM5NCwzOTVdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjI5Nywic291cmNlIjoiY29udHJhY3RzL0NvbXB4R292ZXJuYW5jZS5hbGdvLnRzOjcifSx7InBjIjpbMzk2LDM5N10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6Mjk4LCJzb3VyY2UiOiJjb250cmFjdHMvQ29tcHhHb3Zlcm5hbmNlLmFsZ28udHM6NyJ9LHsicGMiOlszOTgsMzk5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoyOTksInNvdXJjZSI6ImNvbnRyYWN0cy9Db21weEdvdmVybmFuY2UuYWxnby50czo3In0seyJwYyI6WzQwMCw0MDFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjMwMCwic291cmNlIjoiY29udHJhY3RzL0NvbXB4R292ZXJuYW5jZS5hbGdvLnRzOjcifSx7InBjIjpbNDAyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozMDEsInNvdXJjZSI6ImNvbnRyYWN0cy9Db21weEdvdmVybmFuY2UuYWxnby50czo3In1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q21sdWRHTmliRzlqYXlBeElEQUtZbmwwWldOaWJHOWpheUF3ZUNBd2VEYzBObVkzTkRZeE5tTTFaamN3TnpJMlpqY3dObVkzTXpZeE5tTTNNeUF3ZURZME5qVTNNRFpqTm1ZM09UWTFOekkxWmpZeE5qUTJORGN5TmpVM016Y3pJREI0TldZM01EY3lObVkzTURabU56TTJNVFpqTnpNZ01IZ3dNREF3TURBd01EQXdNREF3TURBd0lEQjRNREF3WVFvS0x5OGdWR2hwY3lCVVJVRk1JSGRoY3lCblpXNWxjbUYwWldRZ1lua2dWRVZCVEZOamNtbHdkQ0IyTUM0eE1EWXVNZ292THlCb2RIUndjem92TDJkcGRHaDFZaTVqYjIwdllXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwxUkZRVXhUWTNKcGNIUUtDaTh2SUZSb2FYTWdZMjl1ZEhKaFkzUWdhWE1nWTI5dGNHeHBZVzUwSUhkcGRHZ2dZVzVrTDI5eUlHbHRjR3hsYldWdWRITWdkR2hsSUdadmJHeHZkMmx1WnlCQlVrTnpPaUJiSUVGU1F6UWdYUW9LTHk4Z1ZHaGxJR1p2Ykd4dmQybHVaeUIwWlc0Z2JHbHVaWE1nYjJZZ1ZFVkJUQ0JvWVc1a2JHVWdhVzVwZEdsaGJDQndjbTluY21GdElHWnNiM2NLTHk4Z1ZHaHBjeUJ3WVhSMFpYSnVJR2x6SUhWelpXUWdkRzhnYldGclpTQnBkQ0JsWVhONUlHWnZjaUJoYm5sdmJtVWdkRzhnY0dGeWMyVWdkR2hsSUhOMFlYSjBJRzltSUhSb1pTQndjbTluY21GdElHRnVaQ0JrWlhSbGNtMXBibVVnYVdZZ1lTQnpjR1ZqYVdacFl5QmhZM1JwYjI0Z2FYTWdZV3hzYjNkbFpBb3ZMeUJJWlhKbExDQmhZM1JwYjI0Z2NtVm1aWEp6SUhSdklIUm9aU0JQYmtOdmJYQnNaWFJsSUdsdUlHTnZiV0pwYm1GMGFXOXVJSGRwZEdnZ2QyaGxkR2hsY2lCMGFHVWdZWEJ3SUdseklHSmxhVzVuSUdOeVpXRjBaV1FnYjNJZ1kyRnNiR1ZrQ2k4dklFVjJaWEo1SUhCdmMzTnBZbXhsSUdGamRHbHZiaUJtYjNJZ2RHaHBjeUJqYjI1MGNtRmpkQ0JwY3lCeVpYQnlaWE5sYm5SbFpDQnBiaUIwYUdVZ2MzZHBkR05vSUhOMFlYUmxiV1Z1ZEFvdkx5QkpaaUIwYUdVZ1lXTjBhVzl1SUdseklHNXZkQ0JwYlhCc1pXMWxiblJsWkNCcGJpQjBhR1VnWTI5dWRISmhZM1FzSUdsMGN5QnlaWE53WldOMGFYWmxJR0p5WVc1amFDQjNhV3hzSUdKbElDSXFUazlVWDBsTlVFeEZUVVZPVkVWRUlpQjNhR2xqYUNCcWRYTjBJR052Ym5SaGFXNXpJQ0psY25JaUNuUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpRUtjSFZ6YUdsdWRDQTJDaW9LZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29yQ25OM2FYUmphQ0FxWTJGc2JGOU9iMDl3SUNwT1QxUmZTVTFRVEVWTlJVNVVSVVFnS2s1UFZGOUpUVkJNUlUxRlRsUkZSQ0FxVGs5VVgwbE5VRXhGVFVWT1ZFVkVJQ3BPVDFSZlNVMVFURVZOUlU1VVJVUWdLazVQVkY5SlRWQk1SVTFGVGxSRlJDQXFZM0psWVhSbFgwNXZUM0FnS2s1UFZGOUpUVkJNUlUxRlRsUkZSQ0FxVGs5VVgwbE5VRXhGVFVWT1ZFVkVJQ3BPVDFSZlNVMVFURVZOUlU1VVJVUWdLazVQVkY5SlRWQk1SVTFGVGxSRlJDQXFUazlVWDBsTlVFeEZUVVZPVkVWRUNnb3FUazlVWDBsTlVFeEZUVVZPVkVWRU9nb0pMeThnVkdobElISmxjWFZsYzNSbFpDQmhZM1JwYjI0Z2FYTWdibTkwSUdsdGNHeGxiV1Z1ZEdWa0lHbHVJSFJvYVhNZ1kyOXVkSEpoWTNRdUlFRnlaU0I1YjNVZ2RYTnBibWNnZEdobElHTnZjbkpsWTNRZ1QyNURiMjF3YkdWMFpUOGdSR2xrSUhsdmRTQnpaWFFnZVc5MWNpQmhjSEFnU1VRL0NnbGxjbklLQ2k4dklHTnlaV0YwWlVGd2NHeHBZMkYwYVc5dUtDbDJiMmxrQ2lwaFltbGZjbTkxZEdWZlkzSmxZWFJsUVhCd2JHbGpZWFJwYjI0NkNna3ZMeUJsZUdWamRYUmxJR055WldGMFpVRndjR3hwWTJGMGFXOXVLQ2wyYjJsa0NnbGpZV3hzYzNWaUlHTnlaV0YwWlVGd2NHeHBZMkYwYVc5dUNnbHBiblJqSURBZ0x5OGdNUW9KY21WMGRYSnVDZ292THlCamNtVmhkR1ZCY0hCc2FXTmhkR2x2YmlncE9pQjJiMmxrQ21OeVpXRjBaVUZ3Y0d4cFkyRjBhVzl1T2dvSmNISnZkRzhnTUNBd0Nnb0pMeThnWTI5dWRISmhZM1J6TDBOdmJYQjRSMjkyWlhKdVlXNWpaUzVoYkdkdkxuUnpPakU0Q2drdkx5QjBhR2x6TG5SdmRHRnNYM0J5YjNCdmMyRnNjeTUyWVd4MVpTQTlJREFLQ1dKNWRHVmpJREVnTHk4Z0lDSjBiM1JoYkY5d2NtOXdiM05oYkhNaUNnbHBiblJqSURFZ0x5OGdNQW9KWVhCd1gyZHNiMkpoYkY5d2RYUUtDZ2t2THlCamIyNTBjbUZqZEhNdlEyOXRjSGhIYjNabGNtNWhibU5sTG1Gc1oyOHVkSE02TVRrS0NTOHZJSFJvYVhNdVpHVndiRzk1WlhKZllXUmtjbVZ6Y3k1MllXeDFaU0E5SUhSb2FYTXVkSGh1TG5ObGJtUmxjZ29KWW5sMFpXTWdNaUF2THlBZ0ltUmxjR3h2ZVdWeVgyRmtaSEpsYzNNaUNnbDBlRzRnVTJWdVpHVnlDZ2xoY0hCZloyeHZZbUZzWDNCMWRBb0tDUzh2SUdOdmJuUnlZV04wY3k5RGIyMXdlRWR2ZG1WeWJtRnVZMlV1WVd4bmJ5NTBjem95TUFvSkx5OGdkR2hwY3k1MGIzUmhiRjl3Y205d2IzTmhiSE11ZG1Gc2RXVWdQU0F3Q2dsaWVYUmxZeUF4SUM4dklDQWlkRzkwWVd4ZmNISnZjRzl6WVd4eklnb0phVzUwWXlBeElDOHZJREFLQ1dGd2NGOW5iRzlpWVd4ZmNIVjBDZ2x5WlhSemRXSUtDaTh2SUdOeVpXRjBaVTVsZDFCeWIzQnZjMkZzS0hOMGNtbHVaeXh6ZEhKcGJtY3NjM1J5YVc1bkxIVnBiblEyTkN4d1lYa3BkbTlwWkFvcVlXSnBYM0p2ZFhSbFgyTnlaV0YwWlU1bGQxQnliM0J2YzJGc09nb0pMeThnYldKeVZIaHVPaUJ3WVhrS0NYUjRiaUJIY205MWNFbHVaR1Y0Q2dscGJuUmpJREFnTHk4Z01Rb0pMUW9KWkhWd0NnbG5kSGh1Y3lCVWVYQmxSVzUxYlFvSmFXNTBZeUF3SUM4dklDQndZWGtLQ1QwOUNnb0pMeThnWVhKbmRXMWxiblFnTUNBb2JXSnlWSGh1S1NCbWIzSWdZM0psWVhSbFRtVjNVSEp2Y0c5ellXd2diWFZ6ZENCaVpTQmhJSEJoZVNCMGNtRnVjMkZqZEdsdmJnb0pZWE56WlhKMENnb0pMeThnWlhod2FYSmxjMGx1T2lCMWFXNTBOalFLQ1hSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEUUtDV0owYjJrS0Nna3ZMeUJ3Y205d2IzTmhiRVJsYzJOeWFYQjBhVzl1T2lCemRISnBibWNLQ1hSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtDV1Y0ZEhKaFkzUWdNaUF3Q2dvSkx5OGdjSEp2Y0c5ellXeFVhWFJzWlRvZ2MzUnlhVzVuQ2dsMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDZ2xsZUhSeVlXTjBJRElnTUFvS0NTOHZJSEJ5YjNCdmMyRnNWSGx3WlRvZ2MzUnlhVzVuQ2dsMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDZ2xsZUhSeVlXTjBJRElnTUFvS0NTOHZJR1Y0WldOMWRHVWdZM0psWVhSbFRtVjNVSEp2Y0c5ellXd29jM1J5YVc1bkxITjBjbWx1Wnl4emRISnBibWNzZFdsdWREWTBMSEJoZVNsMmIybGtDZ2xqWVd4c2MzVmlJR055WldGMFpVNWxkMUJ5YjNCdmMyRnNDZ2xwYm5SaklEQWdMeThnTVFvSmNtVjBkWEp1Q2dvdkx5QmpjbVZoZEdWT1pYZFFjbTl3YjNOaGJDaHdjbTl3YjNOaGJGUjVjR1U2SUhOMGNtbHVaeXdnY0hKdmNHOXpZV3hVYVhSc1pUb2djM1J5YVc1bkxDQndjbTl3YjNOaGJFUmxjMk55YVhCMGFXOXVPaUJ6ZEhKcGJtY3NJR1Y0Y0dseVpYTkpiam9nZFdsdWREWTBMQ0J0WW5KVWVHNDZJRkJoZVZSNGJpazZJSFp2YVdRS0x5OEtMeThnUTNKbFlYUmxJR0VnYm1WM0lIQnliM0J2YzJGc0NpOHZJRUJ3WVhKaGJTQndjbTl3YjNOaGJGUjVjR1VnVkhsd1pTQnZaaUIwYUdVZ2NISnZjRzl6WVd3Z0xTQmpZVzRnWW1VZ2NtVm5JRzl5SUhCdmIyd0tMeThnUUhCaGNtRnRJSEJ5YjNCdmMyRnNWR2wwYkdVZ1ZHbDBiR1VnYjJZZ2RHaGxJSEJ5YjNCdmMyRnNDaTh2SUVCd1lYSmhiU0J3Y205d2IzTmhiRVJsYzJOeWFYQjBhVzl1SUVSbGMyTnlhWEIwYVc5dUlHOW1JSFJvWlNCd2NtOXdiM05oYkFvdkx5QkFjR0Z5WVcwZ1pYaHdhWEpsYzBsdUlGUnBiV1VnYVc0Z2MyVmpiMjVrY3lCbWIzSWdkR2hsSUhCeWIzQnZjMkZzSUhSdklHVjRjR2x5WlFwamNtVmhkR1ZPWlhkUWNtOXdiM05oYkRvS0NYQnliM1J2SURVZ01Bb0tDUzh2SUZCMWMyZ2daVzF3ZEhrZ1lubDBaWE1nWVdaMFpYSWdkR2hsSUdaeVlXMWxJSEJ2YVc1MFpYSWdkRzhnY21WelpYSjJaU0J6Y0dGalpTQm1iM0lnYkc5allXd2dkbUZ5YVdGaWJHVnpDZ2xpZVhSbFl5QXdJQzh2SURCNENnbGtkWEJ1SURNS0Nna3ZMeUJqYjI1MGNtRmpkSE12UTI5dGNIaEhiM1psY201aGJtTmxMbUZzWjI4dWRITTZNemdLQ1M4dklIQnliM0J2YzJWeVFXUmtjbVZ6Y3pvZ1FXUmtjbVZ6Y3lBOUlIUm9hWE11ZEhodUxuTmxibVJsY2dvSmRIaHVJRk5sYm1SbGNnb0pabkpoYldWZlluVnllU0F3SUM4dklIQnliM0J2YzJWeVFXUmtjbVZ6Y3pvZ1FXUmtjbVZ6Y3dvS0NTOHZJR052Ym5SeVlXTjBjeTlEYjIxd2VFZHZkbVZ5Ym1GdVkyVXVZV3huYnk1MGN6bzBNUW9KTHk4Z2NISnZjRzl6WVd4T2IyNWpaVG9nZFdsdWREWTBJRDBnZEdocGN5NTBiM1JoYkY5d2NtOXdiM05oYkhNdWRtRnNkV1VnS3lBeENnbGllWFJsWXlBeElDOHZJQ0FpZEc5MFlXeGZjSEp2Y0c5ellXeHpJZ29KWVhCd1gyZHNiMkpoYkY5blpYUUtDV2x1ZEdNZ01DQXZMeUF4Q2drckNnbG1jbUZ0WlY5aWRYSjVJREVnTHk4Z2NISnZjRzl6WVd4T2IyNWpaVG9nZFdsdWREWTBDZ29KTHk4Z1kyOXVkSEpoWTNSekwwTnZiWEI0UjI5MlpYSnVZVzVqWlM1aGJHZHZMblJ6T2pReUNna3ZMeUJqZFhKeVpXNTBWR2x0WlhOMFlXMXdPaUIxYVc1ME5qUWdQU0JuYkc5aVlXeHpMbXhoZEdWemRGUnBiV1Z6ZEdGdGNBb0paMnh2WW1Gc0lFeGhkR1Z6ZEZScGJXVnpkR0Z0Y0FvSlpuSmhiV1ZmWW5WeWVTQXlJQzh2SUdOMWNuSmxiblJVYVcxbGMzUmhiWEE2SUhWcGJuUTJOQW9LQ1M4dklHTnZiblJ5WVdOMGN5OURiMjF3ZUVkdmRtVnlibUZ1WTJVdVlXeG5ieTUwY3pvME5Rb0pMeThnWlhod2FYSjVWR2x0WlhOMFlXMXdPaUIxYVc1ME5qUWdQU0JqZFhKeVpXNTBWR2x0WlhOMFlXMXdJQ3NnWlhod2FYSmxjMGx1Q2dsbWNtRnRaVjlrYVdjZ01pQXZMeUJqZFhKeVpXNTBWR2x0WlhOMFlXMXdPaUIxYVc1ME5qUUtDV1p5WVcxbFgyUnBaeUF0TkNBdkx5QmxlSEJwY21WelNXNDZJSFZwYm5RMk5Bb0pLd29KWm5KaGJXVmZZblZ5ZVNBeklDOHZJR1Y0Y0dseWVWUnBiV1Z6ZEdGdGNEb2dkV2x1ZERZMENnb0pMeThnWTI5dWRISmhZM1J6TDBOdmJYQjRSMjkyWlhKdVlXNWpaUzVoYkdkdkxuUnpPalE0Q2drdkx5QmhjM05sY25Rb2NISnZjRzl6WlhKQlpHUnlaWE56SUQwOVBTQjBhR2x6TG1SbGNHeHZlV1Z5WDJGa1pISmxjM011ZG1Gc2RXVXNJQ2RQYm14NUlIUm9aU0JrWlhCc2IzbGxjaUJqWVc0Z1kzSmxZWFJsSUhCeWIzQnZjMkZzY3ljcENnbG1jbUZ0WlY5a2FXY2dNQ0F2THlCd2NtOXdiM05sY2tGa1pISmxjM002SUVGa1pISmxjM01LQ1dKNWRHVmpJRElnTHk4Z0lDSmtaWEJzYjNsbGNsOWhaR1J5WlhOeklnb0pZWEJ3WDJkc2IySmhiRjluWlhRS0NUMDlDZ29KTHk4Z1QyNXNlU0IwYUdVZ1pHVndiRzk1WlhJZ1kyRnVJR055WldGMFpTQndjbTl3YjNOaGJITUtDV0Z6YzJWeWRBb0tDUzh2SUdOdmJuUnlZV04wY3k5RGIyMXdlRWR2ZG1WeWJtRnVZMlV1WVd4bmJ5NTBjem8wT1FvSkx5OGdZWE56WlhKMEtDRjBhR2x6TG5CeWIzQnZjMkZzY3loN0lHNXZibU5sT2lCd2NtOXdiM05oYkU1dmJtTmxMQ0J3Y205d2IzTmhiRlI1Y0dVNklIQnliM0J2YzJGc1ZIbHdaU0I5S1M1bGVHbHpkSE1zSUNkUWNtOXdiM05oYkNCaGJISmxZV1I1SUdWNGFYTjBjeWNwQ2dsaWVYUmxZeUF6SUM4dklDQWlYM0J5YjNCdmMyRnNjeUlLQ1dKNWRHVmpJREFnTHk4Z0lHbHVhWFJwWVd3Z2FHVmhaQW9KWW5sMFpXTWdNQ0F2THlBZ2FXNXBkR2xoYkNCMFlXbHNDZ2xpZVhSbFl5QTFJQzh2SUNCcGJtbDBhV0ZzSUdobFlXUWdiMlptYzJWMENnbG1jbUZ0WlY5a2FXY2dNU0F2THlCd2NtOXdiM05oYkU1dmJtTmxPaUIxYVc1ME5qUUtDV2wwYjJJS0NXTmhiR3h6ZFdJZ0tuQnliMk5sYzNOZmMzUmhkR2xqWDNSMWNHeGxYMlZzWlcxbGJuUUtDV1p5WVcxbFgyUnBaeUF0TVNBdkx5QndjbTl3YjNOaGJGUjVjR1U2SUhOMGNtbHVad29KWkhWd0NnbHNaVzRLQ1dsMGIySUtDV1Y0ZEhKaFkzUWdOaUF5Q2dsemQyRndDZ2xqYjI1allYUUtDV05oYkd4emRXSWdLbkJ5YjJObGMzTmZaSGx1WVcxcFkxOTBkWEJzWlY5bGJHVnRaVzUwQ2dsd2IzQWdMeThnY0c5d0lHaGxZV1FnYjJabWMyVjBDZ2xqYjI1allYUWdMeThnWTI5dVkyRjBJR2hsWVdRZ1lXNWtJSFJoYVd3S0NXTnZibU5oZEFvSlltOTRYMnhsYmdvSmMzZGhjQW9KY0c5d0Nna2hDZ29KTHk4Z1VISnZjRzl6WVd3Z1lXeHlaV0ZrZVNCbGVHbHpkSE1LQ1dGemMyVnlkQW9LQ1M4dklHTnZiblJ5WVdOMGN5OURiMjF3ZUVkdmRtVnlibUZ1WTJVdVlXeG5ieTUwY3pvMU1nb0pMeThnZG1WeWFXWjVVR0Y1VkhodUtHMWljbFI0Yml3Z2V5QmhiVzkxYm5RNklIc2daM0psWVhSbGNsUm9ZVzVGY1hWaGJGUnZPaUJ3Y205d2IzTmhiRTFpY2lCOUlIMHBDZ2t2THlCMlpYSnBabmtnWVcxdmRXNTBDZ2xtY21GdFpWOWthV2NnTFRVZ0x5OGdiV0p5VkhodU9pQlFZWGxVZUc0S0NXZDBlRzV6SUVGdGIzVnVkQW9KY0hWemFHbHVkQ0F5T1RFeUNnaytQUW9LQ1M4dklIUnlZVzV6WVdOMGFXOXVJSFpsY21sbWFXTmhkR2x2YmlCbVlXbHNaV1E2SUhzaWRIaHVJam9pYldKeVZIaHVJaXdpWm1sbGJHUWlPaUpoYlc5MWJuUWlMQ0pqYjI1a2FYUnBiMjRpT2lKbmNtVmhkR1Z5VkdoaGJrVnhkV0ZzVkc4aUxDSmxlSEJsWTNSbFpDSTZJajQ5Y0hKdmNHOXpZV3hOWW5JaWZRb0pZWE56WlhKMENnb0pMeThnWTI5dWRISmhZM1J6TDBOdmJYQjRSMjkyWlhKdVlXNWpaUzVoYkdkdkxuUnpPalUxQ2drdkx5QjBhR2x6TG5CeWIzQnZjMkZzY3loN0lHNXZibU5sT2lCd2NtOXdiM05oYkU1dmJtTmxMQ0J3Y205d2IzTmhiRlI1Y0dVNklIQnliM0J2YzJGc1ZIbHdaU0I5S1M1MllXeDFaU0E5SUhzS0NTOHZJQ0FnSUNBZ0lIQnliM0J2YzJGc1ZHbDBiR1U2SUhCeWIzQnZjMkZzVkdsMGJHVXNDZ2t2THlBZ0lDQWdJQ0J3Y205d2IzTmhiRVJsYzJOeWFYQjBhVzl1T2lCd2NtOXdiM05oYkVSbGMyTnlhWEIwYVc5dUxBb0pMeThnSUNBZ0lDQWdVSEp2Y0c5ellXeFViM1JoYkZadmRHVnpPaUF3TEFvSkx5OGdJQ0FnSUNBZ1VISnZjRzl6WVd4WlpYTldiM1JsY3pvZ01Dd0tDUzh2SUNBZ0lDQWdJRU55WldGMFpXUkJkRlJwYldWemRHRnRjRG9nWTNWeWNtVnVkRlJwYldWemRHRnRjQ3dLQ1M4dklDQWdJQ0FnSUVWNGNHbHllVlJwYldWemRHRnRjRG9nWlhod2FYSjVWR2x0WlhOMFlXMXdMQW9KTHk4Z0lDQWdJSDBLQ1dKNWRHVmpJRE1nTHk4Z0lDSmZjSEp2Y0c5ellXeHpJZ29KWW5sMFpXTWdNQ0F2THlBZ2FXNXBkR2xoYkNCb1pXRmtDZ2xpZVhSbFl5QXdJQzh2SUNCcGJtbDBhV0ZzSUhSaGFXd0tDV0o1ZEdWaklEVWdMeThnSUdsdWFYUnBZV3dnYUdWaFpDQnZabVp6WlhRS0NXWnlZVzFsWDJScFp5QXhJQzh2SUhCeWIzQnZjMkZzVG05dVkyVTZJSFZwYm5RMk5Bb0phWFJ2WWdvSlkyRnNiSE4xWWlBcWNISnZZMlZ6YzE5emRHRjBhV05mZEhWd2JHVmZaV3hsYldWdWRBb0pabkpoYldWZlpHbG5JQzB4SUM4dklIQnliM0J2YzJGc1ZIbHdaVG9nYzNSeWFXNW5DZ2xrZFhBS0NXeGxiZ29KYVhSdllnb0paWGgwY21GamRDQTJJRElLQ1hOM1lYQUtDV052Ym1OaGRBb0pZMkZzYkhOMVlpQXFjSEp2WTJWemMxOWtlVzVoYldsalgzUjFjR3hsWDJWc1pXMWxiblFLQ1hCdmNDQXZMeUJ3YjNBZ2FHVmhaQ0J2Wm1aelpYUUtDV052Ym1OaGRDQXZMeUJqYjI1allYUWdhR1ZoWkNCaGJtUWdkR0ZwYkFvSlkyOXVZMkYwQ2dsa2RYQUtDV0p2ZUY5a1pXd0tDWEJ2Y0FvSllubDBaV01nTUNBdkx5QWdhVzVwZEdsaGJDQm9aV0ZrQ2dsaWVYUmxZeUF3SUM4dklDQnBibWwwYVdGc0lIUmhhV3dLQ1hCMWMyaGllWFJsY3lBd2VEQXdNalFnTHk4Z2FXNXBkR2xoYkNCb1pXRmtJRzltWm5ObGRBb0pabkpoYldWZlpHbG5JQzB5SUM4dklIQnliM0J2YzJGc1ZHbDBiR1U2SUhOMGNtbHVad29KWkhWd0NnbHNaVzRLQ1dsMGIySUtDV1Y0ZEhKaFkzUWdOaUF5Q2dsemQyRndDZ2xqYjI1allYUUtDV05oYkd4emRXSWdLbkJ5YjJObGMzTmZaSGx1WVcxcFkxOTBkWEJzWlY5bGJHVnRaVzUwQ2dsbWNtRnRaVjlrYVdjZ0xUTWdMeThnY0hKdmNHOXpZV3hFWlhOamNtbHdkR2x2YmpvZ2MzUnlhVzVuQ2dsa2RYQUtDV3hsYmdvSmFYUnZZZ29KWlhoMGNtRmpkQ0EySURJS0NYTjNZWEFLQ1dOdmJtTmhkQW9KWTJGc2JITjFZaUFxY0hKdlkyVnpjMTlrZVc1aGJXbGpYM1IxY0d4bFgyVnNaVzFsYm5RS0NXSjVkR1ZqSURRZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdDZ2xqWVd4c2MzVmlJQ3B3Y205alpYTnpYM04wWVhScFkxOTBkWEJzWlY5bGJHVnRaVzUwQ2dsaWVYUmxZeUEwSUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01Bb0pZMkZzYkhOMVlpQXFjSEp2WTJWemMxOXpkR0YwYVdOZmRIVndiR1ZmWld4bGJXVnVkQW9KWm5KaGJXVmZaR2xuSURJZ0x5OGdZM1Z5Y21WdWRGUnBiV1Z6ZEdGdGNEb2dkV2x1ZERZMENnbHBkRzlpQ2dsallXeHNjM1ZpSUNwd2NtOWpaWE56WDNOMFlYUnBZMTkwZFhCc1pWOWxiR1Z0Wlc1MENnbG1jbUZ0WlY5a2FXY2dNeUF2THlCbGVIQnBjbmxVYVcxbGMzUmhiWEE2SUhWcGJuUTJOQW9KYVhSdllnb0pZMkZzYkhOMVlpQXFjSEp2WTJWemMxOXpkR0YwYVdOZmRIVndiR1ZmWld4bGJXVnVkQW9KY0c5d0lDOHZJSEJ2Y0NCb1pXRmtJRzltWm5ObGRBb0pZMjl1WTJGMElDOHZJR052Ym1OaGRDQm9aV0ZrSUdGdVpDQjBZV2xzQ2dsaWIzaGZjSFYwQ2dvSkx5OGdZMjl1ZEhKaFkzUnpMME52YlhCNFIyOTJaWEp1WVc1alpTNWhiR2R2TG5Sek9qWTBDZ2t2THlCMGFHbHpMblJ2ZEdGc1gzQnliM0J2YzJGc2N5NTJZV3gxWlNBclBTQXhDZ2xpZVhSbFl5QXhJQzh2SUNBaWRHOTBZV3hmY0hKdmNHOXpZV3h6SWdvSllYQndYMmRzYjJKaGJGOW5aWFFLQ1dsdWRHTWdNQ0F2THlBeENna3JDZ2xpZVhSbFl5QXhJQzh2SUNBaWRHOTBZV3hmY0hKdmNHOXpZV3h6SWdvSmMzZGhjQW9KWVhCd1gyZHNiMkpoYkY5d2RYUUtDWEpsZEhOMVlnb0tLbU55WldGMFpWOU9iMDl3T2dvSmNIVnphR0o1ZEdWeklEQjRZamcwTkRkaU16WWdMeThnYldWMGFHOWtJQ0pqY21WaGRHVkJjSEJzYVdOaGRHbHZiaWdwZG05cFpDSUtDWFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0NXMWhkR05vSUNwaFltbGZjbTkxZEdWZlkzSmxZWFJsUVhCd2JHbGpZWFJwYjI0S0Nna3ZMeUIwYUdseklHTnZiblJ5WVdOMElHUnZaWE1nYm05MElHbHRjR3hsYldWdWRDQjBhR1VnWjJsMlpXNGdRVUpKSUcxbGRHaHZaQ0JtYjNJZ1kzSmxZWFJsSUU1dlQzQUtDV1Z5Y2dvS0ttTmhiR3hmVG05UGNEb0tDWEIxYzJoaWVYUmxjeUF3ZURObE5XTXhOV1UySUM4dklHMWxkR2h2WkNBaVkzSmxZWFJsVG1WM1VISnZjRzl6WVd3b2MzUnlhVzVuTEhOMGNtbHVaeXh6ZEhKcGJtY3NkV2x1ZERZMExIQmhlU2wyYjJsa0lnb0pkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvSmJXRjBZMmdnS21GaWFWOXliM1YwWlY5amNtVmhkR1ZPWlhkUWNtOXdiM05oYkFvS0NTOHZJSFJvYVhNZ1kyOXVkSEpoWTNRZ1pHOWxjeUJ1YjNRZ2FXMXdiR1Z0Wlc1MElIUm9aU0JuYVhabGJpQkJRa2tnYldWMGFHOWtJR1p2Y2lCallXeHNJRTV2VDNBS0NXVnljZ29LS25CeWIyTmxjM05mYzNSaGRHbGpYM1IxY0d4bFgyVnNaVzFsYm5RNkNnbHdjbTkwYnlBMElETUtDV1p5WVcxbFgyUnBaeUF0TkNBdkx5QjBkWEJzWlNCb1pXRmtDZ2xtY21GdFpWOWthV2NnTFRFZ0x5OGdaV3hsYldWdWRBb0pZMjl1WTJGMENnbG1jbUZ0WlY5a2FXY2dMVE1nTHk4Z2RIVndiR1VnZEdGcGJBb0pabkpoYldWZlpHbG5JQzB5SUM4dklHaGxZV1FnYjJabWMyVjBDZ2x5WlhSemRXSUtDaXB3Y205alpYTnpYMlI1Ym1GdGFXTmZkSFZ3YkdWZlpXeGxiV1Z1ZERvS0NYQnliM1J2SURRZ013b0pabkpoYldWZlpHbG5JQzAwSUM4dklIUjFjR3hsSUdobFlXUUtDV1p5WVcxbFgyUnBaeUF0TWlBdkx5Qm9aV0ZrSUc5bVpuTmxkQW9KWTI5dVkyRjBDZ2xtY21GdFpWOWlkWEo1SUMwMElDOHZJSFIxY0d4bElHaGxZV1FLQ1daeVlXMWxYMlJwWnlBdE1TQXZMeUJsYkdWdFpXNTBDZ2xrZFhBS0NXeGxiZ29KWm5KaGJXVmZaR2xuSUMweUlDOHZJR2hsWVdRZ2IyWm1jMlYwQ2dsaWRHOXBDZ2tyQ2dscGRHOWlDZ2xsZUhSeVlXTjBJRFlnTWdvSlpuSmhiV1ZmWW5WeWVTQXRNaUF2THlCb1pXRmtJRzltWm5ObGRBb0pabkpoYldWZlpHbG5JQzB6SUM4dklIUjFjR3hsSUhSaGFXd0tDWE4zWVhBS0NXTnZibU5oZEFvSlpuSmhiV1ZmWW5WeWVTQXRNeUF2THlCMGRYQnNaU0IwWVdsc0NnbG1jbUZ0WlY5a2FXY2dMVFFnTHk4Z2RIVndiR1VnYUdWaFpBb0pabkpoYldWZlpHbG5JQzB6SUM4dklIUjFjR3hsSUhSaGFXd0tDV1p5WVcxbFgyUnBaeUF0TWlBdkx5Qm9aV0ZrSUc5bVpuTmxkQW9KY21WMGMzVmkiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFdyJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQUNBUUFtQmdBUGRHOTBZV3hmY0hKdmNHOXpZV3h6RUdSbGNHeHZlV1Z5WDJGa1pISmxjM01LWDNCeWIzQnZjMkZzY3dnQUFBQUFBQUFBQUFJQUNqRVlGSUVHQ3pFWkNJME1BUEFBQUFBQUFBQUFBQUFBQU9JQUFBQUFBQUFBQUFBQUFJZ0FBaUpEaWdBQUtTTm5LakVBWnlralo0a3hGaUlKU1RnUUloSkVOaG9FRnpZYUExY0NBRFlhQWxjQ0FEWWFBVmNDQUlnQUFpSkRpZ1VBS0VjRE1RQ01BQ2xrSWdpTUFUSUhqQUtMQW92OENJd0Rpd0FxWkJKRUt5Z29Kd1dMQVJhSUFKbUwvMGtWRmxjR0FreFFpQUNaU0ZCUXZVeElGRVNMK3pnSWdlQVdEMFFyS0NnbkJZc0JGb2dBY0l2L1NSVVdWd1lDVEZDSUFIQklVRkJKdkVnb0tJQUNBQ1NML2trVkZsY0dBa3hRaUFCWGkvMUpGUlpYQmdKTVVJZ0FTaWNFaUFBNEp3U0lBRE9MQWhhSUFDMkxBeGFJQUNkSVVMOHBaQ0lJS1V4bmlZQUV1RVI3TmpZYUFJNEIveElBZ0FRK1hCWG1OaG9BamdIL0Z3Q0tCQU9ML0l2L1VJdjlpLzZKaWdRRGkveUwvbENNL0l2L1NSV0wvaGNJRmxjR0FveitpLzFNVUl6OWkveUwvWXYraVE9PSIsImNsZWFyIjoiQ2c9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJhbGdvZCIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6MywibWlub3IiOjI1LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6Ijk4NTVmNTdjIn19LCJldmVudHMiOm51bGwsInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
