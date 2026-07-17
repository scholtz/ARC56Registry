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

namespace Arc56.Generated.p2arthur.wesource_test_bounties.SourceFactory_843cef72
{


    public class SourceFactoryProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public SourceFactoryProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class BountyDataType : AVMObjectType
            {
                public ulong BountyTotalValue { get; set; }

                public bool BountyPaid { get; set; }

                public Algorand.Address BountyWinner { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBountyTotalValue = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vBountyTotalValue.From(BountyTotalValue);
                    ret.AddRange(vBountyTotalValue.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBountyPaid = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vBountyPaid.From(BountyPaid);
                    ret.AddRange(vBountyPaid.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBountyWinner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vBountyWinner.From(BountyWinner);
                    ret.AddRange(vBountyWinner.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static BountyDataType Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new BountyDataType();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBountyTotalValue = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vBountyTotalValue.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBountyTotalValue = vBountyTotalValue.ToValue();
                    if (valueBountyTotalValue is ulong vBountyTotalValueValue) { ret.BountyTotalValue = vBountyTotalValueValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBountyPaid = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vBountyPaid.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBountyPaid = vBountyPaid.ToValue();
                    if (valueBountyPaid is bool vBountyPaidValue) { ret.BountyPaid = vBountyPaidValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBountyWinner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vBountyWinner.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBountyWinner = vBountyWinner.ToValue();
                    if (valueBountyWinner is Algorand.Address vBountyWinnerValue) { ret.BountyWinner = vBountyWinnerValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as BountyDataType);
                }
                public bool Equals(BountyDataType? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(BountyDataType left, BountyDataType right)
                {
                    return EqualityComparer<BountyDataType>.Default.Equals(left, right);
                }
                public static bool operator !=(BountyDataType left, BountyDataType right)
                {
                    return !(left == right);
                }

            }

            public class BountyIdType : AVMObjectType
            {
                public ulong BountyId { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBountyId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vBountyId.From(BountyId);
                    ret.AddRange(vBountyId.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static BountyIdType Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new BountyIdType();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBountyId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vBountyId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBountyId = vBountyId.ToValue();
                    if (valueBountyId is ulong vBountyIdValue) { ret.BountyId = vBountyIdValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as BountyIdType);
                }
                public bool Equals(BountyIdType? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(BountyIdType left, BountyIdType right)
                {
                    return EqualityComparer<BountyIdType>.Default.Equals(left, right);
                }
                public static bool operator !=(BountyIdType left, BountyIdType right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        public async Task Bootstrap(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 190, 199, 109, 135 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Bootstrap_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 190, 199, 109, 135 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="bounty_id"> </param>
        /// <param name="bounty_total_value"> </param>
        public async Task CreateBounty(ulong bounty_id, ulong bounty_total_value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 50, 137, 98, 118 };
            var bounty_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bounty_idAbi.From(bounty_id);
            var bounty_total_valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bounty_total_valueAbi.From(bounty_total_value);

            var result = await base.CallApp(new List<object> { abiHandle, bounty_idAbi, bounty_total_valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateBounty_Transactions(ulong bounty_id, ulong bounty_total_value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 50, 137, 98, 118 };
            var bounty_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bounty_idAbi.From(bounty_id);
            var bounty_total_valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bounty_total_valueAbi.From(bounty_total_value);

            return await base.MakeTransactionList(new List<object> { abiHandle, bounty_idAbi, bounty_total_valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="bounty_id"> </param>
        /// <param name="winner"> </param>
        public async Task WithdrawBounty(ulong bounty_id, Algorand.Address winner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 64, 1, 254, 45 };
            var bounty_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bounty_idAbi.From(bounty_id);
            var winnerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); winnerAbi.From(winner);

            var result = await base.CallApp(new List<object> { abiHandle, bounty_idAbi, winnerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> WithdrawBounty_Transactions(ulong bounty_id, Algorand.Address winner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 64, 1, 254, 45 };
            var bounty_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bounty_idAbi.From(bounty_id);
            var winnerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); winnerAbi.From(winner);

            return await base.MakeTransactionList(new List<object> { abiHandle, bounty_idAbi, winnerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiU291cmNlRmFjdG9yeSIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJCb3VudHlEYXRhVHlwZSI6W3sibmFtZSI6ImJvdW50eV90b3RhbF92YWx1ZSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJib3VudHlfcGFpZCIsInR5cGUiOiJib29sIn0seyJuYW1lIjoiYm91bnR5X3dpbm5lciIsInR5cGUiOiJhZGRyZXNzIn1dLCJCb3VudHlJZFR5cGUiOlt7Im5hbWUiOiJib3VudHlfaWQiLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImJvb3RzdHJhcCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjcmVhdGVfYm91bnR5IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJvdW50eV9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYm91bnR5X3RvdGFsX3ZhbHVlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6IndpdGhkcmF3X2JvdW50eSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJib3VudHlfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ3aW5uZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjEsImJ5dGVzIjoxfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsxMTBdLCJlcnJvck1lc3NhZ2UiOiJBbHJlYWR5IGJvb3RzdHJhcHBlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE0NV0sImVycm9yTWVzc2FnZSI6IkJvdW50eSBhbHJlYWR5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIyMF0sImVycm9yTWVzc2FnZSI6IkJvdW50eSBhbHJlYWR5IHBhaWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMDRdLCJlcnJvck1lc3NhZ2UiOiJCb3VudHkgbm90IGZvdW5kIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTM1LDIyNV0sImVycm9yTWVzc2FnZSI6IkJvdW50eSB2YWx1ZSBtdXN0IGJlID4gMCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE4Nl0sImVycm9yTWVzc2FnZSI6IkNvbnRyYWN0IG5vdCBib290c3RyYXBwZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMzJdLCJlcnJvck1lc3NhZ2UiOiJJbnN1ZmZpY2llbnQgYXBwIGJhbGFuY2UiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2MV0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBtdXN0IGJlIE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDFdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gbXVzdCBiZSBOb09wICYmIGNhbiBvbmx5IGNhbGwgd2hlbiBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE5MF0sImVycm9yTWVzc2FnZSI6Ik9ubHkgbWFuYWdlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE5NV0sImVycm9yTWVzc2FnZSI6Ildpbm5lciByZXF1aXJlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1OF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIEdsb2JhbFN0YXRlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE4Ml0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjQsMTMyLDE3M10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTUNBeElEZ0tJQ0FnSUdKNWRHVmpZbXh2WTJzZ0lsUlBWRUZNWDBKUFZVNVVTVVZUSWlBaVRVRk9RVWRGVWw5QlJFUlNSVk5USWlBaVlsOWZJaUF3ZURBd0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1ltNTZJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjkxY21ObFgyWmhZM1J2Y25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE9Bb2dJQ0FnTHk4Z1ZFOVVRVXhmUWs5VlRsUkpSVk1nUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tIc2dhVzVwZEdsaGJGWmhiSFZsT2lBd0lIMHBDaUFnSUNCaWVYUmxZMTh3SUM4dklDSlVUMVJCVEY5Q1QxVk9WRWxGVXlJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvS2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFESTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOTFjbU5sWDJaaFkzUnZjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TmdvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklGTnZkWEpqWlVaaFkzUnZjbmtnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzRnVG5WdFFYQndRWEpuY3dvZ0lDQWdZbm9nYldGcGJsOWZYMkZzWjI5MGMxOWZMbVJsWm1GMWJIUkRjbVZoZEdWQU1USUtJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdiWFZ6ZENCaVpTQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBDaUFnSUNCd2RYTm9ZbmwwWlhOeklEQjRZbVZqTnpaa09EY2dNSGd6TWpnNU5qSTNOaUF3ZURRd01ERm1aVEprSUM4dklHMWxkR2h2WkNBaVltOXZkSE4wY21Gd0tDbDJiMmxrSWl3Z2JXVjBhRzlrSUNKamNtVmhkR1ZmWW05MWJuUjVLSFZwYm5RMk5DeDFhVzUwTmpRcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpZDJsMGFHUnlZWGRmWW05MWJuUjVLSFZwYm5RMk5DeGhaR1J5WlhOektYWnZhV1FpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCaWIyOTBjM1J5WVhBZ1kzSmxZWFJsWDJKdmRXNTBlU0IzYVhSb1pISmhkMTlpYjNWdWRIa0tJQ0FnSUdWeWNnb0tiV0ZwYmw5ZlgyRnNaMjkwYzE5ZkxtUmxabUYxYkhSRGNtVmhkR1ZBTVRJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5MWNtTmxYMlpoWTNSdmNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOZ29nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUZOdmRYSmpaVVpoWTNSdmNua2daWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdJUW9nSUNBZ0ppWUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdiWFZ6ZENCaVpTQk9iMDl3SUNZbUlHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQmpjbVZoZEdsdVp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjNWeVkyVmZabUZqZEc5eWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcFRiM1Z5WTJWR1lXTjBiM0o1TG1KdmIzUnpkSEpoY0Z0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtSnZiM1J6ZEhKaGNEb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIzVnlZMlZmWm1GamRHOXllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl6Q2lBZ0lDQXZMeUJoYzNObGNuUW9JWFJvYVhNdVRVRk9RVWRGVWw5QlJFUlNSVk5UTG1oaGMxWmhiSFZsTENBblFXeHlaV0ZrZVNCaWIyOTBjM1J5WVhCd1pXUW5LUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIzVnlZMlZmWm1GamRHOXllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUzQ2lBZ0lDQXZMeUJOUVU1QlIwVlNYMEZFUkZKRlUxTWdQU0JIYkc5aVlXeFRkR0YwWlR4QlkyTnZkVzUwUGlncENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKTlFVNUJSMFZTWDBGRVJGSkZVMU1pQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjkxY21ObFgyWmhZM1J2Y25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU13b2dJQ0FnTHk4Z1lYTnpaWEowS0NGMGFHbHpMazFCVGtGSFJWSmZRVVJFVWtWVFV5NW9ZWE5XWVd4MVpTd2dKMEZzY21WaFpIa2dZbTl2ZEhOMGNtRndjR1ZrSnlrS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaWRYSjVJREVLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCQmJISmxZV1I1SUdKdmIzUnpkSEpoY0hCbFpBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdmRYSmpaVjltWVdOMGIzSjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGNLSUNBZ0lDOHZJRTFCVGtGSFJWSmZRVVJFVWtWVFV5QTlJRWRzYjJKaGJGTjBZWFJsUEVGalkyOTFiblErS0NrS0lDQWdJR0o1ZEdWalh6RWdMeThnSWsxQlRrRkhSVkpmUVVSRVVrVlRVeUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiM1Z5WTJWZlptRmpkRzl5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJMENpQWdJQ0F2THlCMGFHbHpMazFCVGtGSFJWSmZRVVJFVWtWVFV5NTJZV3gxWlNBOUlGUjRiaTV6Wlc1a1pYSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5MWNtTmxYMlpoWTNSdmNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lNZ29nSUNBZ0x5OGdjSFZpYkdsaklHSnZiM1J6ZEhKaGNDZ3BJSHNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOTFjbU5sWDJaaFkzUnZjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VTI5MWNtTmxSbUZqZEc5eWVTNWpjbVZoZEdWZlltOTFiblI1VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1kzSmxZWFJsWDJKdmRXNTBlVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiM1Z5WTJWZlptRmpkRzl5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJM0NpQWdJQ0F2THlCd2RXSnNhV01nWTNKbFlYUmxYMkp2ZFc1MGVTaGliM1Z1ZEhsZmFXUTZJSFZwYm5RMk5Dd2dZbTkxYm5SNVgzUnZkR0ZzWDNaaGJIVmxPaUIxYVc1ME5qUXBJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdSMWNBb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdmRYSmpaVjltWVdOMGIzSjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNamdLSUNBZ0lDOHZJR0Z6YzJWeWRDaGliM1Z1ZEhsZmRHOTBZV3hmZG1Gc2RXVWdQaUF3TENBblFtOTFiblI1SUhaaGJIVmxJRzExYzNRZ1ltVWdQaUF3SnlrS0lDQWdJR0Z6YzJWeWRDQXZMeUJDYjNWdWRIa2dkbUZzZFdVZ2JYVnpkQ0JpWlNBK0lEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIzVnlZMlZmWm1GamRHOXllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl3Q2lBZ0lDQXZMeUJpYjNWdWRHbGxjeUE5SUVKdmVFMWhjRHhDYjNWdWRIbEpaRlI1Y0dVc0lFSnZkVzUwZVVSaGRHRlVlWEJsUGloN0lHdGxlVkJ5WldacGVEb2dKMkpmWHljZ2ZTa0tJQ0FnSUdKNWRHVmpYeklnTHk4Z0ltSmZYeUlLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOTFjbU5sWDJaaFkzUnZjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TUFvZ0lDQWdMeThnWVhOelpYSjBLQ0ZpYjNWdWRIa3VaWGhwYzNSekxDQW5RbTkxYm5SNUlHRnNjbVZoWkhrZ1pYaHBjM1J6SnlrS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnUW05MWJuUjVJR0ZzY21WaFpIa2daWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5MWNtTmxYMlpoWTNSdmNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pOQW9nSUNBZ0x5OGdZbTkxYm5SNVgzZHBibTVsY2pvZ2JtVjNJR0Z5WXpRdVFXUmtjbVZ6Y3loSGJHOWlZV3d1ZW1WeWIwRmtaSEpsYzNNcExBb2dJQ0FnWjJ4dlltRnNJRnBsY205QlpHUnlaWE56Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjkxY21ObFgyWmhZM1J2Y25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek1TMHpOUW9nSUNBZ0x5OGdZbTkxYm5SNUxuWmhiSFZsSUQwZ2JtVjNJRUp2ZFc1MGVVUmhkR0ZVZVhCbEtIc0tJQ0FnSUM4dklDQWdZbTkxYm5SNVgzUnZkR0ZzWDNaaGJIVmxPaUJ1WlhjZ1lYSmpOQzVWYVc1ME5qUW9ZbTkxYm5SNVgzUnZkR0ZzWDNaaGJIVmxLU3dLSUNBZ0lDOHZJQ0FnWW05MWJuUjVYM0JoYVdRNklHNWxkeUJoY21NMExrSnZiMndvWm1Gc2MyVXBMQW9nSUNBZ0x5OGdJQ0JpYjNWdWRIbGZkMmx1Ym1WeU9pQnVaWGNnWVhKak5DNUJaR1J5WlhOektFZHNiMkpoYkM1NlpYSnZRV1JrY21WemN5a3NDaUFnSUNBdkx5QjlLUW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5MWNtTmxYMlpoWTNSdmNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pNd29nSUNBZ0x5OGdZbTkxYm5SNVgzQmhhV1E2SUc1bGR5QmhjbU0wTGtKdmIyd29abUZzYzJVcExBb2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VEQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOTFjbU5sWDJaaFkzUnZjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TVMwek5Rb2dJQ0FnTHk4Z1ltOTFiblI1TG5aaGJIVmxJRDBnYm1WM0lFSnZkVzUwZVVSaGRHRlVlWEJsS0hzS0lDQWdJQzh2SUNBZ1ltOTFiblI1WDNSdmRHRnNYM1poYkhWbE9pQnVaWGNnWVhKak5DNVZhVzUwTmpRb1ltOTFiblI1WDNSdmRHRnNYM1poYkhWbEtTd0tJQ0FnSUM4dklDQWdZbTkxYm5SNVgzQmhhV1E2SUc1bGR5QmhjbU0wTGtKdmIyd29abUZzYzJVcExBb2dJQ0FnTHk4Z0lDQmliM1Z1ZEhsZmQybHVibVZ5T2lCdVpYY2dZWEpqTkM1QlpHUnlaWE56S0Vkc2IySmhiQzU2WlhKdlFXUmtjbVZ6Y3lrc0NpQWdJQ0F2THlCOUtRb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjNWeVkyVmZabUZqZEc5eWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTTJDaUFnSUNBdkx5QjBhR2x6TGxSUFZFRk1YMEpQVlU1VVNVVlRMblpoYkhWbElDczlJREVLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOTFjbU5sWDJaaFkzUnZjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94T0FvZ0lDQWdMeThnVkU5VVFVeGZRazlWVGxSSlJWTWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0hzZ2FXNXBkR2xoYkZaaGJIVmxPaUF3SUgwcENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKVVQxUkJURjlDVDFWT1ZFbEZVeUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiM1Z5WTJWZlptRmpkRzl5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNMkNpQWdJQ0F2THlCMGFHbHpMbFJQVkVGTVgwSlBWVTVVU1VWVExuWmhiSFZsSUNzOUlERUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdLd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZkWEpqWlY5bVlXTjBiM0o1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRnS0lDQWdJQzh2SUZSUFZFRk1YMEpQVlU1VVNVVlRJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGloN0lHbHVhWFJwWVd4V1lXeDFaVG9nTUNCOUtRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVZFOVVRVXhmUWs5VlRsUkpSVk1pQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjkxY21ObFgyWmhZM1J2Y25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek5nb2dJQ0FnTHk4Z2RHaHBjeTVVVDFSQlRGOUNUMVZPVkVsRlV5NTJZV3gxWlNBclBTQXhDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZkWEpqWlY5bVlXTjBiM0o1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpjS0lDQWdJQzh2SUhCMVlteHBZeUJqY21WaGRHVmZZbTkxYm5SNUtHSnZkVzUwZVY5cFpEb2dkV2x1ZERZMExDQmliM1Z1ZEhsZmRHOTBZV3hmZG1Gc2RXVTZJSFZwYm5RMk5Da2dld29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIzVnlZMlZmWm1GamRHOXllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBUYjNWeVkyVkdZV04wYjNKNUxuZHBkR2hrY21GM1gySnZkVzUwZVZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuZHBkR2hrY21GM1gySnZkVzUwZVRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjNWeVkyVmZabUZqZEc5eWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTTVDaUFnSUNBdkx5QndkV0pzYVdNZ2QybDBhR1J5WVhkZlltOTFiblI1S0dKdmRXNTBlVjlwWkRvZ2RXbHVkRFkwTENCM2FXNXVaWEk2SUVGalkyOTFiblFwSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRE15SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiM1Z5WTJWZlptRmpkRzl5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZM0NpQWdJQ0F2THlCaGMzTmxjblFvZEdocGN5NU5RVTVCUjBWU1gwRkVSRkpGVTFNdWFHRnpWbUZzZFdVc0lDZERiMjUwY21GamRDQnViM1FnWW05dmRITjBjbUZ3Y0dWa0p5a0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5MWNtTmxYMlpoWTNSdmNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOd29nSUNBZ0x5OGdUVUZPUVVkRlVsOUJSRVJTUlZOVElEMGdSMnh2WW1Gc1UzUmhkR1U4UVdOamIzVnVkRDRvS1FvZ0lDQWdZbmwwWldOZk1TQXZMeUFpVFVGT1FVZEZVbDlCUkVSU1JWTlRJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZkWEpqWlY5bVlXTjBiM0o1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmpjS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxrMUJUa0ZIUlZKZlFVUkVVa1ZUVXk1b1lYTldZV3gxWlN3Z0owTnZiblJ5WVdOMElHNXZkQ0JpYjI5MGMzUnlZWEJ3WldRbktRb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QkRiMjUwY21GamRDQnViM1FnWW05dmRITjBjbUZ3Y0dWa0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5MWNtTmxYMlpoWTNSdmNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJPQW9nSUNBZ0x5OGdZWE56WlhKMEtGUjRiaTV6Wlc1a1pYSWdQVDA5SUhSb2FYTXVUVUZPUVVkRlVsOUJSRVJTUlZOVExuWmhiSFZsTENBblQyNXNlU0J0WVc1aFoyVnlKeWtLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnVDI1c2VTQnRZVzVoWjJWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5MWNtTmxYMlpoWTNSdmNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBNUW9nSUNBZ0x5OGdZWE56WlhKMEtIZHBibTVsY2lBaFBUMGdSMnh2WW1Gc0xucGxjbTlCWkdSeVpYTnpMQ0FuVjJsdWJtVnlJSEpsY1hWcGNtVmtKeWtLSUNBZ0lHUjFjQW9nSUNBZ1oyeHZZbUZzSUZwbGNtOUJaR1J5WlhOekNpQWdJQ0FoUFFvZ0lDQWdZWE56WlhKMElDOHZJRmRwYm01bGNpQnlaWEYxYVhKbFpBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdmRYSmpaVjltWVdOMGIzSjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNakFLSUNBZ0lDOHZJR0p2ZFc1MGFXVnpJRDBnUW05NFRXRndQRUp2ZFc1MGVVbGtWSGx3WlN3Z1FtOTFiblI1UkdGMFlWUjVjR1UrS0hzZ2EyVjVVSEpsWm1sNE9pQW5ZbDlmSnlCOUtRb2dJQ0FnWW5sMFpXTmZNaUF2THlBaVlsOWZJZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIzVnlZMlZmWm1GamRHOXllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalF6Q2lBZ0lDQXZMeUJoYzNObGNuUW9ZbTkxYm5SNUxtVjRhWE4wY3l3Z0owSnZkVzUwZVNCdWIzUWdabTkxYm1RbktRb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lHRnpjMlZ5ZENBdkx5QkNiM1Z1ZEhrZ2JtOTBJR1p2ZFc1a0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5MWNtTmxYMlpoWTNSdmNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBOUW9nSUNBZ0x5OGdZWE56WlhKMEtDRmliM1Z1ZEhrdWRtRnNkV1V1WW05MWJuUjVYM0JoYVdRdWJtRjBhWFpsTENBblFtOTFiblI1SUdGc2NtVmhaSGtnY0dGcFpDY3BDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lIQnZjQW9nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURZMElDOHZJRFkwQ2lBZ0lDQm5aWFJpYVhRS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhnd01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVjBZbWwwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1oyVjBZbWwwQ2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1FtOTFiblI1SUdGc2NtVmhaSGtnY0dGcFpBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdmRYSmpaVjltWVdOMGIzSjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZORGNLSUNBZ0lDOHZJR052Ym5OMElHRnRiM1Z1ZENBOUlHSnZkVzUwZVM1MllXeDFaUzVpYjNWdWRIbGZkRzkwWVd4ZmRtRnNkV1V1WVhOVmFXNTBOalFvS1FvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiM1Z5WTJWZlptRmpkRzl5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRNENpQWdJQ0F2THlCaGMzTmxjblFvWVcxdmRXNTBJRDRnTUN3Z0owSnZkVzUwZVNCMllXeDFaU0J0ZFhOMElHSmxJRDRnTUNjcENpQWdJQ0JrZFhBS0lDQWdJR0Z6YzJWeWRDQXZMeUJDYjNWdWRIa2dkbUZzZFdVZ2JYVnpkQ0JpWlNBK0lEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIzVnlZMlZmWm1GamRHOXllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalE1Q2lBZ0lDQXZMeUJoYzNObGNuUW9iM0F1WW1Gc1lXNWpaU2hIYkc5aVlXd3VZM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN5a2dQajBnWVcxdmRXNTBMQ0FuU1c1emRXWm1hV05wWlc1MElHRndjQ0JpWVd4aGJtTmxKeWtLSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56Q2lBZ0lDQmlZV3hoYm1ObENpQWdJQ0JrYVdjZ01Rb2dJQ0FnUGowS0lDQWdJR0Z6YzJWeWRDQXZMeUJKYm5OMVptWnBZMmxsYm5RZ1lYQndJR0poYkdGdVkyVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIzVnlZMlZmWm1GamRHOXllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalV5Q2lBZ0lDQXZMeUJpYjNWdWRIbGZkRzkwWVd4ZmRtRnNkV1U2SUdKdmRXNTBlUzUyWVd4MVpTNWliM1Z1ZEhsZmRHOTBZV3hmZG1Gc2RXVXNDaUFnSUNCemQyRndDaUFnSUNCbGVIUnlZV04wSURBZ09Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdmRYSmpaVjltWVdOMGIzSjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVE1LSUNBZ0lDOHZJR0p2ZFc1MGVWOXdZV2xrT2lCdVpYY2dZWEpqTkM1Q2IyOXNLSFJ5ZFdVcExBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE9EQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIzVnlZMlZmWm1GamRHOXllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalV4TFRVMUNpQWdJQ0F2THlCaWIzVnVkSGt1ZG1Gc2RXVWdQU0J1WlhjZ1FtOTFiblI1UkdGMFlWUjVjR1VvZXdvZ0lDQWdMeThnSUNCaWIzVnVkSGxmZEc5MFlXeGZkbUZzZFdVNklHSnZkVzUwZVM1MllXeDFaUzVpYjNWdWRIbGZkRzkwWVd4ZmRtRnNkV1VzQ2lBZ0lDQXZMeUFnSUdKdmRXNTBlVjl3WVdsa09pQnVaWGNnWVhKak5DNUNiMjlzS0hSeWRXVXBMQW9nSUNBZ0x5OGdJQ0JpYjNWdWRIbGZkMmx1Ym1WeU9pQnVaWGNnWVhKak5DNUJaR1J5WlhOektIZHBibTVsY2lrc0NpQWdJQ0F2THlCOUtRb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2FXY2dNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhOM1lYQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiM1Z5WTJWZlptRmpkRzl5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVM0xUWXpDaUFnSUNBdkx5QnBkSGh1Q2lBZ0lDQXZMeUFnSUM1d1lYbHRaVzUwS0hzS0lDQWdJQzh2SUNBZ0lDQnlaV05sYVhabGNqb2dkMmx1Ym1WeUxBb2dJQ0FnTHk4Z0lDQWdJR0Z0YjNWdWREb2dZVzF2ZFc1MExBb2dJQ0FnTHk4Z0lDQWdJR1psWlRvZ01Dd0tJQ0FnSUM4dklDQWdmU2tLSUNBZ0lDOHZJQ0FnTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNCcGRIaHVYMlpwWld4a0lFRnRiM1Z1ZEFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JTWldObGFYWmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZkWEpqWlY5bVlXTjBiM0o1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRjdE5qSUtJQ0FnSUM4dklHbDBlRzRLSUNBZ0lDOHZJQ0FnTG5CaGVXMWxiblFvZXdvZ0lDQWdMeThnSUNBZ0lISmxZMlZwZG1WeU9pQjNhVzV1WlhJc0NpQWdJQ0F2THlBZ0lDQWdZVzF2ZFc1ME9pQmhiVzkxYm5Rc0NpQWdJQ0F2THlBZ0lDQWdabVZsT2lBd0xBb2dJQ0FnTHk4Z0lDQjlLUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjNWeVkyVmZabUZqZEc5eWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWXhDaUFnSUNBdkx5Qm1aV1U2SURBc0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjNWeVkyVmZabUZqZEc5eWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qVTNMVFl6Q2lBZ0lDQXZMeUJwZEhodUNpQWdJQ0F2THlBZ0lDNXdZWGx0Wlc1MEtIc0tJQ0FnSUM4dklDQWdJQ0J5WldObGFYWmxjam9nZDJsdWJtVnlMQW9nSUNBZ0x5OGdJQ0FnSUdGdGIzVnVkRG9nWVcxdmRXNTBMQW9nSUNBZ0x5OGdJQ0FnSUdabFpUb2dNQ3dLSUNBZ0lDOHZJQ0FnZlNrS0lDQWdJQzh2SUNBZ0xuTjFZbTFwZENncENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052ZFhKalpWOW1ZV04wYjNKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16a0tJQ0FnSUM4dklIQjFZbXhwWXlCM2FYUm9aSEpoZDE5aWIzVnVkSGtvWW05MWJuUjVYMmxrT2lCMWFXNTBOalFzSUhkcGJtNWxjam9nUVdOamIzVnVkQ2tnZXdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBREFBRUlKZ1FPVkU5VVFVeGZRazlWVGxSSlJWTVBUVUZPUVVkRlVsOUJSRVJTUlZOVEEySmZYd0VBTVJoQUFBTW9JbWN4RzBFQUpERVpGRVF4R0VTQ0F3Uyt4MjJIQkRLSlluWUVRQUgrTFRZYUFJNERBQXNBR0FCSkFERVpGREVZRkJCRUkwTWlLV1ZGQVJSRUtURUFaeU5ETmhvQlNSVWtFa1EyR2dKSkZTUVNSRWtYUkNwUEFsQkp2VVVCRkVReUEwOENLMUJNVUw4aUtHVkVJd2dvVEdjalF6WWFBVWtWSkJKRU5ob0NTUldCSUJKRUlpbGxSREVBRWtSSk1nTVRSQ3BQQWxCSnZVVUJSRW0rU0VtQlFGTXJJazhDVkNKVEZFUkpJbHRKUkRJS1lFc0JEMFJNVndBSWdBR0FVRXNEVUU4Q1RMK3hzZ2l5QnlPeUVDS3lBYk1qUXc9PSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjMsInBhdGNoIjoyLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
