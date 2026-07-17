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

namespace Arc56.Generated.naveen_2111_dev.PeerZero_Contract_AlgoHack.PeerZero_55c604a9
{


    public class PeerZeroProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public PeerZeroProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class JobStruct : AVMObjectType
            {
                public ulong JobId { get; set; }

                public ulong Bid { get; set; }

                public Structs.LocationStruct Location { get; set; } = new Structs.LocationStruct();

                public ulong TimeOut { get; set; }

                public bool Status { get; set; }

                public ulong MechanicId { get; set; }

                public Algorand.Address Owner { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vJobId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vJobId.From(JobId);
                    ret.AddRange(vJobId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBid = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vBid.From(Bid);
                    ret.AddRange(vBid.Encode());
                    stringRef[ret.Count] = Location.ToByteArray();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTimeOut = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTimeOut.From(TimeOut);
                    ret.AddRange(vTimeOut.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStatus = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vStatus.From(Status);
                    ret.AddRange(vStatus.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMechanicId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vMechanicId.From(MechanicId);
                    ret.AddRange(vMechanicId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vOwner.From(Owner);
                    ret.AddRange(vOwner.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static JobStruct Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new JobStruct();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vJobId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vJobId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueJobId = vJobId.ToValue();
                    if (valueJobId is ulong vJobIdValue) { ret.JobId = vJobIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBid = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vBid.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBid = vBid.ToValue();
                    if (valueBid is ulong vBidValue) { ret.Bid = vBidValue; }
                    var indexLocation = queue.Dequeue() * 256 + queue.Dequeue();
                    ret.Location = Structs.LocationStruct.Parse(bytes.Skip(indexLocation + prefixOffset).ToArray());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTimeOut = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTimeOut.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTimeOut = vTimeOut.ToValue();
                    if (valueTimeOut is ulong vTimeOutValue) { ret.TimeOut = vTimeOutValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStatus = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vStatus.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueStatus = vStatus.ToValue();
                    if (valueStatus is bool vStatusValue) { ret.Status = vStatusValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMechanicId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vMechanicId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueMechanicId = vMechanicId.ToValue();
                    if (valueMechanicId is ulong vMechanicIdValue) { ret.MechanicId = vMechanicIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vOwner.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOwner = vOwner.ToValue();
                    if (valueOwner is Algorand.Address vOwnerValue) { ret.Owner = vOwnerValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as JobStruct);
                }
                public bool Equals(JobStruct? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(JobStruct left, JobStruct right)
                {
                    return EqualityComparer<JobStruct>.Default.Equals(left, right);
                }
                public static bool operator !=(JobStruct left, JobStruct right)
                {
                    return !(left == right);
                }

            }

            public class LocationStruct : AVMObjectType
            {
                public string Latitude { get; set; }

                public string Longitude { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLatitude = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vLatitude.From(Latitude);
                    stringRef[ret.Count] = vLatitude.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLongitude = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vLongitude.From(Longitude);
                    stringRef[ret.Count] = vLongitude.Encode();
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

                public static LocationStruct Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new LocationStruct();
                    var indexLatitude = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLatitude = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vLatitude.Decode(bytes.Skip(indexLatitude + prefixOffset).ToArray());
                    var valueLatitude = vLatitude.ToValue();
                    if (valueLatitude is string vLatitudeValue) { ret.Latitude = vLatitudeValue; }
                    var indexLongitude = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLongitude = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vLongitude.Decode(bytes.Skip(indexLongitude + prefixOffset).ToArray());
                    var valueLongitude = vLongitude.ToValue();
                    if (valueLongitude is string vLongitudeValue) { ret.Longitude = vLongitudeValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as LocationStruct);
                }
                public bool Equals(LocationStruct? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(LocationStruct left, LocationStruct right)
                {
                    return EqualityComparer<LocationStruct>.Default.Equals(left, right);
                }
                public static bool operator !=(LocationStruct left, LocationStruct right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="MechAppId"> </param>
        /// <param name="PrioAppId"> </param>
        public async Task SetRegisterAppId(ulong MechAppId, ulong PrioAppId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 13, 169, 123, 227 };
            var MechAppIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); MechAppIdAbi.From(MechAppId);
            var PrioAppIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); PrioAppIdAbi.From(PrioAppId);

            var result = await base.CallApp(new List<object> { abiHandle, MechAppIdAbi, PrioAppIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetRegisterAppId_Transactions(ulong MechAppId, ulong PrioAppId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 13, 169, 123, 227 };
            var MechAppIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); MechAppIdAbi.From(MechAppId);
            var PrioAppIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); PrioAppIdAbi.From(PrioAppId);

            return await base.MakeTransactionList(new List<object> { abiHandle, MechAppIdAbi, PrioAppIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="mechanicId"> </param>
        public async Task<bool> IsRegisteredMechanic(ulong mechanicId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 137, 76, 71, 20 };
            var mechanicIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); mechanicIdAbi.From(mechanicId);

            var result = await base.CallApp(new List<object> { abiHandle, mechanicIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IsRegisteredMechanic_Transactions(ulong mechanicId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 137, 76, 71, 20 };
            var mechanicIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); mechanicIdAbi.From(mechanicId);

            return await base.MakeTransactionList(new List<object> { abiHandle, mechanicIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="jobData"> JobStruct</param>
        /// <param name="payDeposit"> </param>
        public async Task<ulong> CreateJob(PaymentTransaction payDeposit, Structs.JobStruct jobData, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payDeposit });
            byte[] abiHandle = { 148, 71, 120, 52 };

            var result = await base.CallApp(new List<object> { abiHandle, jobData, payDeposit }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CreateJob_Transactions(PaymentTransaction payDeposit, Structs.JobStruct jobData, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payDeposit });
            byte[] abiHandle = { 148, 71, 120, 52 };

            return await base.MakeTransactionList(new List<object> { abiHandle, jobData, payDeposit }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="jobId"> </param>
        /// <param name="mechanicId"> </param>
        /// <param name="amount"> </param>
        public async Task<bool> PlaceBid(ulong jobId, ulong mechanicId, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 73, 208, 115, 47 };
            var jobIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); jobIdAbi.From(jobId);
            var mechanicIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); mechanicIdAbi.From(mechanicId);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, jobIdAbi, mechanicIdAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> PlaceBid_Transactions(ulong jobId, ulong mechanicId, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 73, 208, 115, 47 };
            var jobIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); jobIdAbi.From(jobId);
            var mechanicIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); mechanicIdAbi.From(mechanicId);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, jobIdAbi, mechanicIdAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="jobId"> </param>
        public async Task<bool> CompleteJob(ulong jobId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 189, 185, 54, 244 };
            var jobIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); jobIdAbi.From(jobId);

            var result = await base.CallApp(new List<object> { abiHandle, jobIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CompleteJob_Transactions(ulong jobId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 189, 185, 54, 244 };
            var jobIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); jobIdAbi.From(jobId);

            return await base.MakeTransactionList(new List<object> { abiHandle, jobIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="jobId"> </param>
        public async Task<bool> CancelJob(ulong jobId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 72, 137, 44, 255 };
            var jobIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); jobIdAbi.From(jobId);

            var result = await base.CallApp(new List<object> { abiHandle, jobIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CancelJob_Transactions(ulong jobId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 72, 137, 44, 255 };
            var jobIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); jobIdAbi.From(jobId);

            return await base.MakeTransactionList(new List<object> { abiHandle, jobIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="jobId"> </param>
        public async Task<Structs.JobStruct> GetJob(ulong jobId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 152, 133, 182, 37 };
            var jobIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); jobIdAbi.From(jobId);

            var result = await base.CallApp(new List<object> { abiHandle, jobIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.JobStruct.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetJob_Transactions(ulong jobId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 152, 133, 182, 37 };
            var jobIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); jobIdAbi.From(jobId);

            return await base.MakeTransactionList(new List<object> { abiHandle, jobIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> GetJobCount(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 254, 144, 106, 190 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetJobCount_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 254, 144, 106, 190 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="jobId"> </param>
        /// <param name="amount"> </param>
        public async Task DepositJobTip(ulong jobId, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 214, 50, 232, 231 };
            var jobIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); jobIdAbi.From(jobId);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, jobIdAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DepositJobTip_Transactions(ulong jobId, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 214, 50, 232, 231 };
            var jobIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); jobIdAbi.From(jobId);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, jobIdAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="jobId"> </param>
        public async Task RefundTip(ulong jobId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 214, 128, 186, 238 };
            var jobIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); jobIdAbi.From(jobId);

            var result = await base.CallApp(new List<object> { abiHandle, jobIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RefundTip_Transactions(ulong jobId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 214, 128, 186, 238 };
            var jobIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); jobIdAbi.From(jobId);

            return await base.MakeTransactionList(new List<object> { abiHandle, jobIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="jobId"> </param>
        public async Task ReleaseTip(ulong jobId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 74, 223, 127, 114 };
            var jobIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); jobIdAbi.From(jobId);

            var result = await base.CallApp(new List<object> { abiHandle, jobIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ReleaseTip_Transactions(ulong jobId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 74, 223, 127, 114 };
            var jobIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); jobIdAbi.From(jobId);

            return await base.MakeTransactionList(new List<object> { abiHandle, jobIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUGVlclplcm8iLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiSm9iU3RydWN0IjpbeyJuYW1lIjoiam9iX2lkIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImJpZCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJsb2NhdGlvbiIsInR5cGUiOiJMb2NhdGlvblN0cnVjdCJ9LHsibmFtZSI6InRpbWVPdXQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoic3RhdHVzIiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJtZWNoYW5pY0lkIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6Im93bmVyIiwidHlwZSI6ImFkZHJlc3MifV0sIkxvY2F0aW9uU3RydWN0IjpbeyJuYW1lIjoibGF0aXR1ZGUiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoibG9uZ2l0dWRlIiwidHlwZSI6InN0cmluZyJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJzZXRSZWdpc3RlckFwcElkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Ik1lY2hBcHBJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiUHJpb0FwcElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImlzUmVnaXN0ZXJlZE1lY2hhbmljIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1lY2hhbmljSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiQ3JlYXRlSm9iIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6Iih1aW50NjQsdWludDY0LChzdHJpbmcsc3RyaW5nKSx1aW50NjQsYm9vbCx1aW50NjQsYWRkcmVzcykiLCJzdHJ1Y3QiOiJKb2JTdHJ1Y3QiLCJuYW1lIjoiam9iRGF0YSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5RGVwb3NpdCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6IlBsYWNlQmlkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImpvYklkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtZWNoYW5pY0lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY29tcGxldGVKb2IiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiam9iSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiQ2FuY2VsSm9iIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImpvYklkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldEpvYiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJqb2JJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NCwoc3RyaW5nLHN0cmluZyksdWludDY0LGJvb2wsdWludDY0LGFkZHJlc3MpIiwic3RydWN0IjoiSm9iU3RydWN0IiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0Sm9iQ291bnQiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJkZXBvc2l0Sm9iVGlwIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImpvYklkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVmdW5kVGlwIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImpvYklkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlbGVhc2VUaXAiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiam9iSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls2MTldLCJlcnJvck1lc3NhZ2UiOiJCaWQgbXVzdCBiZSBsb3dlciB0aGFuIGN1cnJlbnQgYmlkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDI0LDQ4NSw1NzEsNTg2LDYwMyw2MTUsNjI0LDYzOSw2NTQsNjc5LDY5NCw3MDEsNzE2LDczMiw3MzgsNzY3LDc4NCw4MzcsODUzLDg2MCw4NzYsODkxLDkxNCw5MjUsOTQxLDk3OSwxMDEzXSwiZXJyb3JNZXNzYWdlIjoiQm94IG11c3QgaGF2ZSB2YWx1ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ2N10sImVycm9yTWVzc2FnZSI6IkRlcG9zaXQgc2VudCBpcyBsZXNzIHRoYW4gcmVxdWlyZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NTgsNzM5LDc2MCw3ODUsODU0XSwiZXJyb3JNZXNzYWdlIjoiSW5kZXggYWNjZXNzIGlzIG91dCBvZiBib3VuZHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2OTEsODQ5XSwiZXJyb3JNZXNzYWdlIjoiSm9iIGFscmVhZHkgY29tcGxldGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTY4LDY3Niw4MzQsOTEyXSwiZXJyb3JNZXNzYWdlIjoiSm9iIGRvZXMgbm90IGV4aXN0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTkzXSwiZXJyb3JNZXNzYWdlIjoiSm9iIGV4cGlyZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1ODNdLCJlcnJvck1lc3NhZ2UiOiJKb2IgaW5hY3RpdmUvY29tcGxldGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjAxXSwiZXJyb3JNZXNzYWdlIjoiTWVjaGFuaWMgbm90IHJlZ2lzdGVyZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2OThdLCJlcnJvck1lc3NhZ2UiOiJObyBtZWNoYW5pYyBzZWxlY3RlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE3NiwxOTEsMjA2LDIyNCwyNDAsMjU5LDI3OCwyOTcsMzIyLDM1MSwzNzBdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gaXMgbm90IE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NzVdLCJlcnJvck1lc3NhZ2UiOiJQYXltZW50IG11c3QgYmUgdG8gdGhlIGNvbnRyYWN0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTM3XSwiZXJyb3JNZXNzYWdlIjoiVGlwIGNvbnRyYWN0IG5vdCBzZXQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszOTVdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNzksMTk0LDIwOSwyMjcsMjQzLDI2MiwyODEsMzAwLDMyNSwzNTQsMzczXSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIG5vdCBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQyMSw3MjldLCJlcnJvck1lc3NhZ2UiOiJyZWdpc3RyeSBhcHAgbm90IHNldCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMzOF0sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHR5cGUgaXMgcGF5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNQ0F4SURZZ09DQXlNRGdLSUNBZ0lHSjVkR1ZqWW14dlkyc2dNSGd4TlRGbU4yTTNOU0FpYldWamFGSmxaMmx6ZEdWeVFYQndTV1FpSUNKd2NtbHZjbWwwZVdabFpVRndjRWxrSWlBaWFtOWlRMjkxYm5RaUlDSnFiMklpSURCNE9EQWdNSGd3TURBd01EQXdNREF3TURBd01EQXdJREI0TURBZ01IZzVaams1TVRrelpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCbFpYSmZlbVZ5Ynk5amIyNTBjbUZqZEMxaGNIQXVZV3huYnk1MGN6b3pNQW9nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUZCbFpYSmFaWEp2SUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJR0o2SUcxaGFXNWZZbUZ5WlY5eWIzVjBhVzVuUURFMkNpQWdJQ0J3ZFhOb1lubDBaWE56SURCNE1HUmhPVGRpWlRNZ01IZzRPVFJqTkRjeE5DQXdlRGswTkRjM09ETTBJREI0TkRsa01EY3pNbVlnTUhoaVpHSTVNelptTkNBd2VEUTRPRGt5WTJabUlEQjRPVGc0TldJMk1qVWdNSGhtWlRrd05tRmlaU0F3ZUdRMk16SmxPR1UzSURCNFpEWTRNR0poWldVZ01IZzBZV1JtTjJZM01pQXZMeUJ0WlhSb2IyUWdJbk5sZEZKbFoybHpkR1Z5UVhCd1NXUW9kV2x1ZERZMExIVnBiblEyTkNsMmIybGtJaXdnYldWMGFHOWtJQ0pwYzFKbFoybHpkR1Z5WldSTlpXTm9ZVzVwWXloMWFXNTBOalFwWW05dmJDSXNJRzFsZEdodlpDQWlRM0psWVhSbFNtOWlLQ2gxYVc1ME5qUXNkV2x1ZERZMExDaHpkSEpwYm1jc2MzUnlhVzVuS1N4MWFXNTBOalFzWW05dmJDeDFhVzUwTmpRc1lXUmtjbVZ6Y3lrc2NHRjVLWFZwYm5RMk5DSXNJRzFsZEdodlpDQWlVR3hoWTJWQ2FXUW9kV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFwWW05dmJDSXNJRzFsZEdodlpDQWlZMjl0Y0d4bGRHVktiMklvZFdsdWREWTBLV0p2YjJ3aUxDQnRaWFJvYjJRZ0lrTmhibU5sYkVwdllpaDFhVzUwTmpRcFltOXZiQ0lzSUcxbGRHaHZaQ0FpWjJWMFNtOWlLSFZwYm5RMk5Da29kV2x1ZERZMExIVnBiblEyTkN3b2MzUnlhVzVuTEhOMGNtbHVaeWtzZFdsdWREWTBMR0p2YjJ3c2RXbHVkRFkwTEdGa1pISmxjM01wSWl3Z2JXVjBhRzlrSUNKblpYUktiMkpEYjNWdWRDZ3BkV2x1ZERZMElpd2diV1YwYUc5a0lDSmtaWEJ2YzJsMFNtOWlWR2x3S0hWcGJuUTJOQ3gxYVc1ME5qUXBkbTlwWkNJc0lHMWxkR2h2WkNBaWNtVm1kVzVrVkdsd0tIVnBiblEyTkNsMmIybGtJaXdnYldWMGFHOWtJQ0p5Wld4bFlYTmxWR2x3S0hWcGJuUTJOQ2wyYjJsa0lnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2diV0ZwYmw5elpYUlNaV2RwYzNSbGNrRndjRWxrWDNKdmRYUmxRRE1nYldGcGJsOXBjMUpsWjJsemRHVnlaV1JOWldOb1lXNXBZMTl5YjNWMFpVQTBJRzFoYVc1ZlEzSmxZWFJsU205aVgzSnZkWFJsUURVZ2JXRnBibDlRYkdGalpVSnBaRjl5YjNWMFpVQTJJRzFoYVc1ZlkyOXRjR3hsZEdWS2IySmZjbTkxZEdWQU55QnRZV2x1WDBOaGJtTmxiRXB2WWw5eWIzVjBaVUE0SUcxaGFXNWZaMlYwU205aVgzSnZkWFJsUURrZ2JXRnBibDluWlhSS2IySkRiM1Z1ZEY5eWIzVjBaVUF4TUNCdFlXbHVYMlJsY0c5emFYUktiMkpVYVhCZmNtOTFkR1ZBTVRFZ2JXRnBibDl5WldaMWJtUlVhWEJmY205MWRHVkFNVElnYldGcGJsOXlaV3hsWVhObFZHbHdYM0p2ZFhSbFFERXpDZ3B0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWpBNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0dWbGNsOTZaWEp2TDJOdmJuUnlZV04wTFdGd2NDNWhiR2R2TG5Sek9qTXdDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nVUdWbGNscGxjbThnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYM0psYkdWaGMyVlVhWEJmY205MWRHVkFNVE02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR1ZsY2w5NlpYSnZMMk52Ym5SeVlXTjBMV0Z3Y0M1aGJHZHZMblJ6T2pJeE5Bb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d1pXVnlYM3BsY204dlkyOXVkSEpoWTNRdFlYQndMbUZzWjI4dWRITTZNekFLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCUVpXVnlXbVZ5YnlCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WldWeVgzcGxjbTh2WTI5dWRISmhZM1F0WVhCd0xtRnNaMjh1ZEhNNk1qRTBDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHTmhiR3h6ZFdJZ2NtVnNaV0Z6WlZScGNBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5eVpXWjFibVJVYVhCZmNtOTFkR1ZBTVRJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0dWbGNsOTZaWEp2TDJOdmJuUnlZV04wTFdGd2NDNWhiR2R2TG5Sek9qSXdNUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdaV1Z5WDNwbGNtOHZZMjl1ZEhKaFkzUXRZWEJ3TG1Gc1oyOHVkSE02TXpBS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QlFaV1Z5V21WeWJ5QmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d1pXVnlYM3BsY204dlkyOXVkSEpoWTNRdFlYQndMbUZzWjI4dWRITTZNakF4Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJR05oYkd4emRXSWdjbVZtZFc1a1ZHbHdDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyUmxjRzl6YVhSS2IySlVhWEJmY205MWRHVkFNVEU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR1ZsY2w5NlpYSnZMMk52Ym5SeVlXTjBMV0Z3Y0M1aGJHZHZMblJ6T2pFNE5Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d1pXVnlYM3BsY204dlkyOXVkSEpoWTNRdFlYQndMbUZzWjI4dWRITTZNekFLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCUVpXVnlXbVZ5YnlCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WldWeVgzcGxjbTh2WTI5dWRISmhZM1F0WVhCd0xtRnNaMjh1ZEhNNk1UZzFDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHTmhiR3h6ZFdJZ1pHVndiM05wZEVwdllsUnBjQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOW5aWFJLYjJKRGIzVnVkRjl5YjNWMFpVQXhNRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdaV1Z5WDNwbGNtOHZZMjl1ZEhKaFkzUXRZWEJ3TG1Gc1oyOHVkSE02TVRjNUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnWTJGc2JITjFZaUJuWlhSS2IySkRiM1Z1ZEFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDluWlhSS2IySmZjbTkxZEdWQU9Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d1pXVnlYM3BsY204dlkyOXVkSEpoWTNRdFlYQndMbUZzWjI4dWRITTZNVGN5Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JsWlhKZmVtVnlieTlqYjI1MGNtRmpkQzFoY0hBdVlXeG5ieTUwY3pvek1Bb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRkJsWlhKYVpYSnZJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQmxaWEpmZW1WeWJ5OWpiMjUwY21GamRDMWhjSEF1WVd4bmJ5NTBjem94TnpJS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnWTJGc2JITjFZaUJuWlhSS2IySUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZlEyRnVZMlZzU205aVgzSnZkWFJsUURnNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0dWbGNsOTZaWEp2TDJOdmJuUnlZV04wTFdGd2NDNWhiR2R2TG5Sek9qRTFOUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdaV1Z5WDNwbGNtOHZZMjl1ZEhKaFkzUXRZWEJ3TG1Gc1oyOHVkSE02TXpBS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QlFaV1Z5V21WeWJ5QmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d1pXVnlYM3BsY204dlkyOXVkSEpoWTNRdFlYQndMbUZzWjI4dWRITTZNVFUxQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJR05oYkd4emRXSWdRMkZ1WTJWc1NtOWlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyTnZiWEJzWlhSbFNtOWlYM0p2ZFhSbFFEYzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHVmxjbDk2WlhKdkwyTnZiblJ5WVdOMExXRndjQzVoYkdkdkxuUnpPakV3TmdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WldWeVgzcGxjbTh2WTI5dWRISmhZM1F0WVhCd0xtRnNaMjh1ZEhNNk16QUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJRWldWeVdtVnlieUJsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdaV1Z5WDNwbGNtOHZZMjl1ZEhKaFkzUXRZWEJ3TG1Gc1oyOHVkSE02TVRBMkNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdOaGJHeHpkV0lnWTI5dGNHeGxkR1ZLYjJJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmVUd4aFkyVkNhV1JmY205MWRHVkFOam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdaV1Z5WDNwbGNtOHZZMjl1ZEhKaFkzUXRZWEJ3TG1Gc1oyOHVkSE02T0RnS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0dWbGNsOTZaWEp2TDJOdmJuUnlZV04wTFdGd2NDNWhiR2R2TG5Sek9qTXdDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nVUdWbGNscGxjbThnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR1ZsY2w5NlpYSnZMMk52Ym5SeVlXTjBMV0Z3Y0M1aGJHZHZMblJ6T2pnNENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdOaGJHeHpkV0lnVUd4aFkyVkNhV1FLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZRM0psWVhSbFNtOWlYM0p2ZFhSbFFEVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHVmxjbDk2WlhKdkwyTnZiblJ5WVdOMExXRndjQzVoYkdkdkxuUnpPalU1Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JsWlhKZmVtVnlieTlqYjI1MGNtRmpkQzFoY0hBdVlXeG5ieTUwY3pvek1Bb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRkJsWlhKYVpYSnZJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBdENpQWdJQ0JrZFhBS0lDQWdJR2QwZUc1eklGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6RWdMeThnY0dGNUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJSFJ5WVc1ellXTjBhVzl1SUhSNWNHVWdhWE1nY0dGNUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0dWbGNsOTZaWEp2TDJOdmJuUnlZV04wTFdGd2NDNWhiR2R2TG5Sek9qVTVDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHTmhiR3h6ZFdJZ1EzSmxZWFJsU205aUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJselVtVm5hWE4wWlhKbFpFMWxZMmhoYm1salgzSnZkWFJsUURRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0dWbGNsOTZaWEp2TDJOdmJuUnlZV04wTFdGd2NDNWhiR2R2TG5Sek9qUXlDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQmxaWEpmZW1WeWJ5OWpiMjUwY21GamRDMWhjSEF1WVd4bmJ5NTBjem96TUFvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklGQmxaWEphWlhKdklHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCbFpYSmZlbVZ5Ynk5amIyNTBjbUZqZEMxaGNIQXVZV3huYnk1MGN6bzBNZ29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQmpZV3hzYzNWaUlHbHpVbVZuYVhOMFpYSmxaRTFsWTJoaGJtbGpDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzTmxkRkpsWjJsemRHVnlRWEJ3U1dSZmNtOTFkR1ZBTXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WldWeVgzcGxjbTh2WTI5dWRISmhZM1F0WVhCd0xtRnNaMjh1ZEhNNk16WUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHVmxjbDk2WlhKdkwyTnZiblJ5WVdOMExXRndjQzVoYkdkdkxuUnpPak13Q2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1VHVmxjbHBsY204Z1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JpZEc5cENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0dWbGNsOTZaWEp2TDJOdmJuUnlZV04wTFdGd2NDNWhiR2R2TG5Sek9qTTJDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHTmhiR3h6ZFdJZ2MyVjBVbVZuYVhOMFpYSkJjSEJKWkFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlpWVhKbFgzSnZkWFJwYm1kQU1UWTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHVmxjbDk2WlhKdkwyTnZiblJ5WVdOMExXRndjQzVoYkdkdkxuUnpPak13Q2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1VHVmxjbHBsY204Z1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCaWJub2diV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRREl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJqY21WaGRHbHVad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d1pXVnlYM3BsY204dlkyOXVkSEpoWTNRdFlYQndMbUZzWjI4dWRITTZPbEJsWlhKYVpYSnZMbk5sZEZKbFoybHpkR1Z5UVhCd1NXUW9UV1ZqYUVGd2NFbGtPaUIxYVc1ME5qUXNJRkJ5YVc5QmNIQkpaRG9nZFdsdWREWTBLU0F0UGlCMmIybGtPZ3B6WlhSU1pXZHBjM1JsY2tGd2NFbGtPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQmxaWEpmZW1WeWJ5OWpiMjUwY21GamRDMWhjSEF1WVd4bmJ5NTBjem96Tmkwek53b2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNBdkx5QndkV0pzYVdNZ2MyVjBVbVZuYVhOMFpYSkJjSEJKWkNoTlpXTm9RWEJ3U1dRNklIVnBiblEyTkN3Z1VISnBiMEZ3Y0Vsa09pQjFhVzUwTmpRcE9pQjJiMmxrSUhzS0lDQWdJSEJ5YjNSdklESWdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQmxaWEpmZW1WeWJ5OWpiMjUwY21GamRDMWhjSEF1WVd4bmJ5NTBjem96T0FvZ0lDQWdMeThnZEdocGN5NXRaV05vWVc1cFkxSmxaMmx6ZEdWeVFYQndTV1F1ZG1Gc2RXVWdQU0J1WlhjZ1lYSmpOQzVWYVc1MFRqWTBLRTFsWTJoQmNIQkpaQ2s3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHbDBiMklLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdaV1Z5WDNwbGNtOHZZMjl1ZEhKaFkzUXRZWEJ3TG1Gc1oyOHVkSE02TXpFS0lDQWdJQzh2SUhCMVlteHBZeUJ0WldOb1lXNXBZMUpsWjJsemRHVnlRWEJ3U1dRZ1BTQkNiM2c4WVhKak5DNVZhVzUwVGpZMFBpaDdJR3RsZVRvZ0ltMWxZMmhTWldkcGMzUmxja0Z3Y0Vsa0lpQjlLUW9nSUNBZ1lubDBaV05mTVNBdkx5QWliV1ZqYUZKbFoybHpkR1Z5UVhCd1NXUWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHVmxjbDk2WlhKdkwyTnZiblJ5WVdOMExXRndjQzVoYkdkdkxuUnpPak00Q2lBZ0lDQXZMeUIwYUdsekxtMWxZMmhoYm1salVtVm5hWE4wWlhKQmNIQkpaQzUyWVd4MVpTQTlJRzVsZHlCaGNtTTBMbFZwYm5ST05qUW9UV1ZqYUVGd2NFbGtLVHNLSUNBZ0lITjNZWEFLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WldWeVgzcGxjbTh2WTI5dWRISmhZM1F0WVhCd0xtRnNaMjh1ZEhNNk16a0tJQ0FnSUM4dklIUm9hWE11VUhKcGIzSnBkSGxmWm1WbFFYQndTV1F1ZG1Gc2RXVWdQU0J1WlhjZ1lYSmpOQzVWYVc1MFRqWTBLRkJ5YVc5QmNIQkpaQ2s3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHbDBiMklLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdaV1Z5WDNwbGNtOHZZMjl1ZEhKaFkzUXRZWEJ3TG1Gc1oyOHVkSE02TXpJS0lDQWdJQzh2SUhCMVlteHBZeUJRY21sdmNtbDBlVjltWldWQmNIQkpaQ0E5SUVKdmVEeGhjbU0wTGxWcGJuUk9OalErS0hzZ2EyVjVPaUFpY0hKcGIzSnBkSGxtWldWQmNIQkpaQ0lnZlNrS0lDQWdJR0o1ZEdWalh6SWdMeThnSW5CeWFXOXlhWFI1Wm1WbFFYQndTV1FpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR1ZsY2w5NlpYSnZMMk52Ym5SeVlXTjBMV0Z3Y0M1aGJHZHZMblJ6T2pNNUNpQWdJQ0F2THlCMGFHbHpMbEJ5YVc5eWFYUjVYMlpsWlVGd2NFbGtMblpoYkhWbElEMGdibVYzSUdGeVl6UXVWV2x1ZEU0Mk5DaFFjbWx2UVhCd1NXUXBPd29nSUNBZ2MzZGhjQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JsWlhKZmVtVnlieTlqYjI1MGNtRmpkQzFoY0hBdVlXeG5ieTUwY3pvNlVHVmxjbHBsY204dWFYTlNaV2RwYzNSbGNtVmtUV1ZqYUdGdWFXTW9iV1ZqYUdGdWFXTkpaRG9nWW5sMFpYTXBJQzArSUdKNWRHVnpPZ3BwYzFKbFoybHpkR1Z5WldSTlpXTm9ZVzVwWXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WldWeVgzcGxjbTh2WTI5dWRISmhZM1F0WVhCd0xtRnNaMjh1ZEhNNk5ESXRORE1LSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdMeThnY0hWaWJHbGpJR2x6VW1WbmFYTjBaWEpsWkUxbFkyaGhibWxqS0cxbFkyaGhibWxqU1dRNklHRnlZelF1VldsdWRFNDJOQ2s2SUdGeVl6UXVRbTl2YkNCN0NpQWdJQ0J3Y205MGJ5QXhJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdaV1Z5WDNwbGNtOHZZMjl1ZEhKaFkzUXRZWEJ3TG1Gc1oyOHVkSE02TXpFS0lDQWdJQzh2SUhCMVlteHBZeUJ0WldOb1lXNXBZMUpsWjJsemRHVnlRWEJ3U1dRZ1BTQkNiM2c4WVhKak5DNVZhVzUwVGpZMFBpaDdJR3RsZVRvZ0ltMWxZMmhTWldkcGMzUmxja0Z3Y0Vsa0lpQjlLUW9nSUNBZ1lubDBaV05mTVNBdkx5QWliV1ZqYUZKbFoybHpkR1Z5UVhCd1NXUWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHVmxjbDk2WlhKdkwyTnZiblJ5WVdOMExXRndjQzVoYkdkdkxuUnpPalEwQ2lBZ0lDQXZMeUJoYzNObGNuUW9kR2hwY3k1dFpXTm9ZVzVwWTFKbFoybHpkR1Z5UVhCd1NXUXVaWGhwYzNSekxDQWljbVZuYVhOMGNua2dZWEJ3SUc1dmRDQnpaWFFpS1FvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaGMzTmxjblFnTHk4Z2NtVm5hWE4wY25rZ1lYQndJRzV2ZENCelpYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d1pXVnlYM3BsY204dlkyOXVkSEpoWTNRdFlYQndMbUZzWjI4dWRITTZNekVLSUNBZ0lDOHZJSEIxWW14cFl5QnRaV05vWVc1cFkxSmxaMmx6ZEdWeVFYQndTV1FnUFNCQ2IzZzhZWEpqTkM1VmFXNTBUalkwUGloN0lHdGxlVG9nSW0xbFkyaFNaV2RwYzNSbGNrRndjRWxrSWlCOUtRb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWJXVmphRkpsWjJsemRHVnlRWEJ3U1dRaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0dWbGNsOTZaWEp2TDJOdmJuUnlZV04wTFdGd2NDNWhiR2R2TG5Sek9qUTFDaUFnSUNBdkx5QmpiMjV6ZENCeVpXZEJjSEJKWkNBOUlIUm9hWE11YldWamFHRnVhV05TWldkcGMzUmxja0Z3Y0Vsa0xuWmhiSFZsTG01aGRHbDJaUW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZWE56WlhKMElDOHZJRUp2ZUNCdGRYTjBJR2hoZG1VZ2RtRnNkV1VLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdaV1Z5WDNwbGNtOHZZMjl1ZEhKaFkzUXRZWEJ3TG1Gc1oyOHVkSE02TkRZdE5UVUtJQ0FnSUM4dklHTnZibk4wSUdGd2NFTmhiR3hVZUc0Z1BTQnBkSGh1TG1Gd2NHeHBZMkYwYVc5dVEyRnNiQ2g3Q2lBZ0lDQXZMeUFnSUdGd2NFbGtPaUJ5WldkQmNIQkpaQ3dLSUNBZ0lDOHZJQ0FnWVhCd1FYSm5jem9nV3dvZ0lDQWdMeThnSUNBZ0lHRnlZelF1YldWMGFHOWtVMlZzWldOMGIzSW9DaUFnSUNBdkx5QWdJQ0FnSUNBaVoyVjBUV1ZqYUdGdWFXTW9kV2x1ZERZMEtTaHpkSEpwYm1jc2MzUnlhVzVuTEhOMGNtbHVaeXgxYVc1ME5qUXNZV1JrY21WemN5eGliMjlzTEhWcGJuUTJOQ2tpQ2lBZ0lDQXZMeUFnSUNBZ0tTd0tJQ0FnSUM4dklDQWdJQ0J0WldOb1lXNXBZMGxrQ2lBZ0lDQXZMeUFnSUYwc0NpQWdJQ0F2THlBZ0lHWmxaVG9nTUFvZ0lDQWdMeThnZlNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdaV1Z5WDNwbGNtOHZZMjl1ZEhKaFkzUXRZWEJ3TG1Gc1oyOHVkSE02TkRrdE5URUtJQ0FnSUM4dklHRnlZelF1YldWMGFHOWtVMlZzWldOMGIzSW9DaUFnSUNBdkx5QWdJQ0puWlhSTlpXTm9ZVzVwWXloMWFXNTBOalFwS0hOMGNtbHVaeXh6ZEhKcGJtY3NjM1J5YVc1bkxIVnBiblEyTkN4aFpHUnlaWE56TEdKdmIyd3NkV2x1ZERZMEtTSUtJQ0FnSUM4dklDa3NDaUFnSUNCaWVYUmxZeUE0SUM4dklHMWxkR2h2WkNBaVoyVjBUV1ZqYUdGdWFXTW9kV2x1ZERZMEtTaHpkSEpwYm1jc2MzUnlhVzVuTEhOMGNtbHVaeXgxYVc1ME5qUXNZV1JrY21WemN5eGliMjlzTEhWcGJuUTJOQ2tpQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR1ZsY2w5NlpYSnZMMk52Ym5SeVlXTjBMV0Z3Y0M1aGJHZHZMblJ6T2pRMkxUVTFDaUFnSUNBdkx5QmpiMjV6ZENCaGNIQkRZV3hzVkhodUlEMGdhWFI0Ymk1aGNIQnNhV05oZEdsdmJrTmhiR3dvZXdvZ0lDQWdMeThnSUNCaGNIQkpaRG9nY21WblFYQndTV1FzQ2lBZ0lDQXZMeUFnSUdGd2NFRnlaM002SUZzS0lDQWdJQzh2SUNBZ0lDQmhjbU0wTG0xbGRHaHZaRk5sYkdWamRHOXlLQW9nSUNBZ0x5OGdJQ0FnSUNBZ0ltZGxkRTFsWTJoaGJtbGpLSFZwYm5RMk5Da29jM1J5YVc1bkxITjBjbWx1Wnl4emRISnBibWNzZFdsdWREWTBMR0ZrWkhKbGMzTXNZbTl2YkN4MWFXNTBOalFwSWdvZ0lDQWdMeThnSUNBZ0lDa3NDaUFnSUNBdkx5QWdJQ0FnYldWamFHRnVhV05KWkFvZ0lDQWdMeThnSUNCZExBb2dJQ0FnTHk4Z0lDQm1aV1U2SURBS0lDQWdJQzh2SUgwcExuTjFZbTFwZENncENpQWdJQ0JwYm5Salh6SWdMeThnTmdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQmxaWEpmZW1WeWJ5OWpiMjUwY21GamRDMWhjSEF1WVd4bmJ5NTBjem8xTkFvZ0lDQWdMeThnWm1WbE9pQXdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d1pXVnlYM3BsY204dlkyOXVkSEpoWTNRdFlYQndMbUZzWjI4dWRITTZORFl0TlRVS0lDQWdJQzh2SUdOdmJuTjBJR0Z3Y0VOaGJHeFVlRzRnUFNCcGRIaHVMbUZ3Y0d4cFkyRjBhVzl1UTJGc2JDaDdDaUFnSUNBdkx5QWdJR0Z3Y0Vsa09pQnlaV2RCY0hCSlpDd0tJQ0FnSUM4dklDQWdZWEJ3UVhKbmN6b2dXd29nSUNBZ0x5OGdJQ0FnSUdGeVl6UXViV1YwYUc5a1UyVnNaV04wYjNJb0NpQWdJQ0F2THlBZ0lDQWdJQ0FpWjJWMFRXVmphR0Z1YVdNb2RXbHVkRFkwS1NoemRISnBibWNzYzNSeWFXNW5MSE4wY21sdVp5eDFhVzUwTmpRc1lXUmtjbVZ6Y3l4aWIyOXNMSFZwYm5RMk5Da2lDaUFnSUNBdkx5QWdJQ0FnS1N3S0lDQWdJQzh2SUNBZ0lDQnRaV05vWVc1cFkwbGtDaUFnSUNBdkx5QWdJRjBzQ2lBZ0lDQXZMeUFnSUdabFpUb2dNQW9nSUNBZ0x5OGdmU2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCcGRIaHVJRXhoYzNSTWIyY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d1pXVnlYM3BsY204dlkyOXVkSEpoWTNRdFlYQndMbUZzWjI4dWRITTZOVFlLSUNBZ0lDOHZJSEpsZEhWeWJpQmhjbU0wTG1sdWRHVnljSEpsZEVGelFYSmpORHhoY21NMExrSnZiMncrS0dGd2NFTmhiR3hVZUc0dWJHRnpkRXh2WnlrS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WldWeVgzcGxjbTh2WTI5dWRISmhZM1F0WVhCd0xtRnNaMjh1ZEhNNk9sQmxaWEphWlhKdkxrTnlaV0YwWlVwdllpaHFiMkpFWVhSaE9pQmllWFJsY3l3Z2NHRjVSR1Z3YjNOcGREb2dkV2x1ZERZMEtTQXRQaUJpZVhSbGN6b0tRM0psWVhSbFNtOWlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQmxaWEpmZW1WeWJ5OWpiMjUwY21GamRDMWhjSEF1WVd4bmJ5NTBjem8xT1MwMk1Bb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNBdkx5QndkV0pzYVdNZ1EzSmxZWFJsU205aUtHcHZZa1JoZEdFNklFcHZZbE4wY25WamRDd2djR0Y1UkdWd2IzTnBkRG9nWjNSNGJpNVFZWGx0Wlc1MFZIaHVLVG9nWVhKak5DNVZhVzUwVGpZMElIc0tJQ0FnSUhCeWIzUnZJRElnTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JsWlhKZmVtVnlieTlqYjI1MGNtRmpkQzFoY0hBdVlXeG5ieTUwY3pvMk1Rb2dJQ0FnTHk4Z1kyOXVjM1FnYzJWdVpHVnlJRDBnVkhodUxuTmxibVJsY2dvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQmxaWEpmZW1WeWJ5OWpiMjUwY21GamRDMWhjSEF1WVd4bmJ5NTBjem8yTWdvZ0lDQWdMeThnWVhOelpYSjBLSEJoZVVSbGNHOXphWFF1WVcxdmRXNTBJRDQ5SUdwdllrUmhkR0V1WW1sa0xtNWhkR2wyWlN3Z0lrUmxjRzl6YVhRZ2MyVnVkQ0JwY3lCc1pYTnpJSFJvWVc0Z2NtVnhkV2x5WldRaUtRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JuZEhodWN5QkJiVzkxYm5RS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdaWGgwY21GamRDQTRJRGdnTHk4Z2IyNGdaWEp5YjNJNklFbHVaR1Y0SUdGalkyVnpjeUJwY3lCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCemQyRndDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnUGowS0lDQWdJR0Z6YzJWeWRDQXZMeUJFWlhCdmMybDBJSE5sYm5RZ2FYTWdiR1Z6Y3lCMGFHRnVJSEpsY1hWcGNtVmtDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHVmxjbDk2WlhKdkwyTnZiblJ5WVdOMExXRndjQzVoYkdkdkxuUnpPall6Q2lBZ0lDQXZMeUJoYzNObGNuUW9jR0Y1UkdWd2IzTnBkQzV5WldObGFYWmxjaUE5UFQwZ1IyeHZZbUZzTG1OMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01zSUNKUVlYbHRaVzUwSUcxMWMzUWdZbVVnZEc4Z2RHaGxJR052Ym5SeVlXTjBJaWtLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1ozUjRibk1nVW1WalpXbDJaWElLSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklGQmhlVzFsYm5RZ2JYVnpkQ0JpWlNCMGJ5QjBhR1VnWTI5dWRISmhZM1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdaV1Z5WDNwbGNtOHZZMjl1ZEhKaFkzUXRZWEJ3TG1Gc1oyOHVkSE02TXpRS0lDQWdJQzh2SUhCMVlteHBZeUJxYjJKRGIzVnVkQ0E5SUVKdmVEeGhjbU0wTGxWcGJuUk9OalErS0hzZ2EyVjVPaUFpYW05aVEyOTFiblFpSUgwcENpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKcWIySkRiM1Z1ZENJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WldWeVgzcGxjbTh2WTI5dWRISmhZM1F0WVhCd0xtRnNaMjh1ZEhNNk5qWUtJQ0FnSUM4dklHbG1JQ2gwYUdsekxtcHZZa052ZFc1MExtVjRhWE4wY3lrZ2V3b2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmllaUJEY21WaGRHVktiMkpmWld4elpWOWliMlI1UURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WldWeVgzcGxjbTh2WTI5dWRISmhZM1F0WVhCd0xtRnNaMjh1ZEhNNk16UUtJQ0FnSUM4dklIQjFZbXhwWXlCcWIySkRiM1Z1ZENBOUlFSnZlRHhoY21NMExsVnBiblJPTmpRK0tIc2dhMlY1T2lBaWFtOWlRMjkxYm5RaUlIMHBDaUFnSUNCaWVYUmxZMTh6SUM4dklDSnFiMkpEYjNWdWRDSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d1pXVnlYM3BsY204dlkyOXVkSEpoWTNRdFlYQndMbUZzWjI4dWRITTZOamNLSUNBZ0lDOHZJR04xY25KbGJuUkRiM1Z1ZENBOUlIUm9hWE11YW05aVEyOTFiblF1ZG1Gc2RXVUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHRnpjMlZ5ZENBdkx5QkNiM2dnYlhWemRDQm9ZWFpsSUhaaGJIVmxDZ3BEY21WaGRHVktiMkpmWVdaMFpYSmZhV1pmWld4elpVQXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQmxaWEpmZW1WeWJ5OWpiMjUwY21GamRDMWhjSEF1WVd4bmJ5NTBjem8zTlFvZ0lDQWdMeThnYkc5allYUnBiMjQ2SUdwdllrUmhkR0V1Ykc5allYUnBiMjR1WTI5d2VTZ3BMQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCd2RYTm9hVzUwSURFMklDOHZJREUyQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQnNaVzRLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1kyOTJaWElnTWdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQmxaWEpmZW1WeWJ5OWpiMjUwY21GamRDMWhjSEF1WVd4bmJ5NTBjem8zTmdvZ0lDQWdMeThnZEdsdFpVOTFkRG9nYm1WM0lHRnlZelF1VldsdWRFNDJOQ2hIYkc5aVlXd3ViR0YwWlhOMFZHbHRaWE4wWVcxd0tTd0tJQ0FnSUdkc2IySmhiQ0JNWVhSbGMzUlVhVzFsYzNSaGJYQUtJQ0FnSUdsMGIySUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d1pXVnlYM3BsY204dlkyOXVkSEpoWTNRdFlYQndMbUZzWjI4dWRITTZOekl0T0RBS0lDQWdJQzh2SUdOdmJuTjBJRzVsZDBwdllpQTlJRzVsZHlCS2IySlRkSEoxWTNRb2V3b2dJQ0FnTHk4Z0lDQnFiMkpmYVdRNklHTjFjbkpsYm5SRGIzVnVkQ3dLSUNBZ0lDOHZJQ0FnWW1sa09pQnFiMkpFWVhSaExtSnBaQ3dLSUNBZ0lDOHZJQ0FnYkc5allYUnBiMjQ2SUdwdllrUmhkR0V1Ykc5allYUnBiMjR1WTI5d2VTZ3BMQW9nSUNBZ0x5OGdJQ0IwYVcxbFQzVjBPaUJ1WlhjZ1lYSmpOQzVWYVc1MFRqWTBLRWRzYjJKaGJDNXNZWFJsYzNSVWFXMWxjM1JoYlhBcExBb2dJQ0FnTHk4Z0lDQnpkR0YwZFhNNklHNWxkeUJoY21NMExrSnZiMndvZEhKMVpTa3NDaUFnSUNBdkx5QWdJRzFsWTJoaGJtbGpTV1E2SUc1bGR5QmhjbU0wTGxWcGJuUk9OalFvTUNrc0NpQWdJQ0F2THlBZ0lHOTNibVZ5T2lCdVpYY2dZWEpqTkM1QlpHUnlaWE56S0hObGJtUmxjaTVpZVhSbGN5a0tJQ0FnSUM4dklIMHBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWm5KaGJXVmZaR2xuSURFS0lDQWdJR052Ym1OaGRBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQTBNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WldWeVgzcGxjbTh2WTI5dWRISmhZM1F0WVhCd0xtRnNaMjh1ZEhNNk56Y0tJQ0FnSUM4dklITjBZWFIxY3pvZ2JtVjNJR0Z5WXpRdVFtOXZiQ2gwY25WbEtTd0tJQ0FnSUdKNWRHVmpJRFVnTHk4Z01IZzRNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQmxaWEpmZW1WeWJ5OWpiMjUwY21GamRDMWhjSEF1WVd4bmJ5NTBjem8zTWkwNE1Bb2dJQ0FnTHk4Z1kyOXVjM1FnYm1WM1NtOWlJRDBnYm1WM0lFcHZZbE4wY25WamRDaDdDaUFnSUNBdkx5QWdJR3B2WWw5cFpEb2dZM1Z5Y21WdWRFTnZkVzUwTEFvZ0lDQWdMeThnSUNCaWFXUTZJR3B2WWtSaGRHRXVZbWxrTEFvZ0lDQWdMeThnSUNCc2IyTmhkR2x2YmpvZ2FtOWlSR0YwWVM1c2IyTmhkR2x2Ymk1amIzQjVLQ2tzQ2lBZ0lDQXZMeUFnSUhScGJXVlBkWFE2SUc1bGR5QmhjbU0wTGxWcGJuUk9OalFvUjJ4dlltRnNMbXhoZEdWemRGUnBiV1Z6ZEdGdGNDa3NDaUFnSUNBdkx5QWdJSE4wWVhSMWN6b2dibVYzSUdGeVl6UXVRbTl2YkNoMGNuVmxLU3dLSUNBZ0lDOHZJQ0FnYldWamFHRnVhV05KWkRvZ2JtVjNJR0Z5WXpRdVZXbHVkRTQyTkNnd0tTd0tJQ0FnSUM4dklDQWdiM2R1WlhJNklHNWxkeUJoY21NMExrRmtaSEpsYzNNb2MyVnVaR1Z5TG1KNWRHVnpLUW9nSUNBZ0x5OGdmU2tLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JsWlhKZmVtVnlieTlqYjI1MGNtRmpkQzFoY0hBdVlXeG5ieTUwY3pvM09Bb2dJQ0FnTHk4Z2JXVmphR0Z1YVdOSlpEb2dibVYzSUdGeVl6UXVWV2x1ZEU0Mk5DZ3dLU3dLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHVmxjbDk2WlhKdkwyTnZiblJ5WVdOMExXRndjQzVoYkdkdkxuUnpPamN5TFRnd0NpQWdJQ0F2THlCamIyNXpkQ0J1WlhkS2IySWdQU0J1WlhjZ1NtOWlVM1J5ZFdOMEtIc0tJQ0FnSUM4dklDQWdhbTlpWDJsa09pQmpkWEp5Wlc1MFEyOTFiblFzQ2lBZ0lDQXZMeUFnSUdKcFpEb2dhbTlpUkdGMFlTNWlhV1FzQ2lBZ0lDQXZMeUFnSUd4dlkyRjBhVzl1T2lCcWIySkVZWFJoTG14dlkyRjBhVzl1TG1OdmNIa29LU3dLSUNBZ0lDOHZJQ0FnZEdsdFpVOTFkRG9nYm1WM0lHRnlZelF1VldsdWRFNDJOQ2hIYkc5aVlXd3ViR0YwWlhOMFZHbHRaWE4wWVcxd0tTd0tJQ0FnSUM4dklDQWdjM1JoZEhWek9pQnVaWGNnWVhKak5DNUNiMjlzS0hSeWRXVXBMQW9nSUNBZ0x5OGdJQ0J0WldOb1lXNXBZMGxrT2lCdVpYY2dZWEpqTkM1VmFXNTBUalkwS0RBcExBb2dJQ0FnTHk4Z0lDQnZkMjVsY2pvZ2JtVjNJR0Z5WXpRdVFXUmtjbVZ6Y3loelpXNWtaWEl1WW5sMFpYTXBDaUFnSUNBdkx5QjlLUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQmxaWEpmZW1WeWJ5OWpiMjUwY21GamRDMWhjSEF1WVd4bmJ5NTBjem96TXdvZ0lDQWdMeThnY0hWaWJHbGpJRXB2WW5NZ1BTQkNiM2hOWVhBOFlYSmpOQzVWYVc1MFRqWTBMQ0JLYjJKVGRISjFZM1ErS0hzZ2EyVjVVSEpsWm1sNE9pQWlhbTlpSWlCOUtRb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaWFtOWlJZ29nSUNBZ1pHbG5JRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JsWlhKZmVtVnlieTlqYjI1MGNtRmpkQzFoY0hBdVlXeG5ieTUwY3pvNE1nb2dJQ0FnTHk4Z2RHaHBjeTVLYjJKektHTjFjbkpsYm5SRGIzVnVkQ2t1ZG1Gc2RXVWdQU0J1WlhkS2IySXVZMjl3ZVNncENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb2dJQ0FnYzNkaGNBb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQmxaWEpmZW1WeWJ5OWpiMjUwY21GamRDMWhjSEF1WVd4bmJ5NTBjem80TXdvZ0lDQWdMeThnZEdocGN5NXFiMkpEYjNWdWRDNTJZV3gxWlNBOUlHNWxkeUJoY21NMExsVnBiblJPTmpRb1kzVnljbVZ1ZEVOdmRXNTBMbTVoZEdsMlpTQXJJREVwQ2lBZ0lDQmtkWEFLSUNBZ0lHSjBiMmtLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBckNpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0dWbGNsOTZaWEp2TDJOdmJuUnlZV04wTFdGd2NDNWhiR2R2TG5Sek9qTTBDaUFnSUNBdkx5QndkV0pzYVdNZ2FtOWlRMjkxYm5RZ1BTQkNiM2c4WVhKak5DNVZhVzUwVGpZMFBpaDdJR3RsZVRvZ0ltcHZZa052ZFc1MElpQjlLUW9nSUNBZ1lubDBaV05mTXlBdkx5QWlhbTlpUTI5MWJuUWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHVmxjbDk2WlhKdkwyTnZiblJ5WVdOMExXRndjQzVoYkdkdkxuUnpPamd6Q2lBZ0lDQXZMeUIwYUdsekxtcHZZa052ZFc1MExuWmhiSFZsSUQwZ2JtVjNJR0Z5WXpRdVZXbHVkRTQyTkNoamRYSnlaVzUwUTI5MWJuUXVibUYwYVhabElDc2dNU2tLSUNBZ0lITjNZWEFLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WldWeVgzcGxjbTh2WTI5dWRISmhZM1F0WVhCd0xtRnNaMjh1ZEhNNk9EVUtJQ0FnSUM4dklISmxkSFZ5YmlCamRYSnlaVzUwUTI5MWJuUUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb2dJQ0FnY21WMGMzVmlDZ3BEY21WaGRHVktiMkpmWld4elpWOWliMlI1UURJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0dWbGNsOTZaWEp2TDJOdmJuUnlZV04wTFdGd2NDNWhiR2R2TG5Sek9qWTVDaUFnSUNBdkx5QmpkWEp5Wlc1MFEyOTFiblFnUFNCdVpYY2dZWEpqTkM1VmFXNTBUalkwS0RBcENpQWdJQ0JpZVhSbFl5QTJJQzh2SURCNE1EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZaUJEY21WaGRHVktiMkpmWVdaMFpYSmZhV1pmWld4elpVQXpDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCbFpYSmZlbVZ5Ynk5amIyNTBjbUZqZEMxaGNIQXVZV3huYnk1MGN6bzZVR1ZsY2xwbGNtOHVVR3hoWTJWQ2FXUW9hbTlpU1dRNklHSjVkR1Z6TENCdFpXTm9ZVzVwWTBsa09pQmllWFJsY3l3Z1lXMXZkVzUwT2lCaWVYUmxjeWtnTFQ0Z1lubDBaWE02Q2xCc1lXTmxRbWxrT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JsWlhKZmVtVnlieTlqYjI1MGNtRmpkQzFoY0hBdVlXeG5ieTUwY3pvNE9DMDRPUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdVR3hoWTJWQ2FXUW9hbTlpU1dRNklHRnlZelF1VldsdWRFNDJOQ3dnYldWamFHRnVhV05KWkRvZ1lYSmpOQzVWYVc1MFRqWTBMQ0JoYlc5MWJuUTZJR0Z5WXpRdVZXbHVkRTQyTkNrNklHRnlZelF1UW05dmJDQjdDaUFnSUNCd2NtOTBieUF6SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WldWeVgzcGxjbTh2WTI5dWRISmhZM1F0WVhCd0xtRnNaMjh1ZEhNNk16TUtJQ0FnSUM4dklIQjFZbXhwWXlCS2IySnpJRDBnUW05NFRXRndQR0Z5WXpRdVZXbHVkRTQyTkN3Z1NtOWlVM1J5ZFdOMFBpaDdJR3RsZVZCeVpXWnBlRG9nSW1wdllpSWdmU2tLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJbXB2WWlJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WldWeVgzcGxjbTh2WTI5dWRISmhZM1F0WVhCd0xtRnNaMjh1ZEhNNk9UQUtJQ0FnSUM4dklHTnZibk4wSUdwdllpQTlJSFJvYVhNdVNtOWljeWhxYjJKSlpDa0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCbFpYSmZlbVZ5Ynk5amIyNTBjbUZqZEMxaGNIQXVZV3huYnk1MGN6b3pNd29nSUNBZ0x5OGdjSFZpYkdsaklFcHZZbk1nUFNCQ2IzaE5ZWEE4WVhKak5DNVZhVzUwVGpZMExDQktiMkpUZEhKMVkzUStLSHNnYTJWNVVISmxabWw0T2lBaWFtOWlJaUI5S1FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0dWbGNsOTZaWEp2TDJOdmJuUnlZV04wTFdGd2NDNWhiR2R2TG5Sek9qa3dDaUFnSUNBdkx5QmpiMjV6ZENCcWIySWdQU0IwYUdsekxrcHZZbk1vYW05aVNXUXBDaUFnSUNCa2RYQnVJRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdaV1Z5WDNwbGNtOHZZMjl1ZEhKaFkzUXRZWEJ3TG1Gc1oyOHVkSE02T1RFS0lDQWdJQzh2SUdGemMyVnlkQ2hxYjJJdVpYaHBjM1J6TENBaVNtOWlJR1J2WlhNZ2JtOTBJR1Y0YVhOMElpa0tJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZWE56WlhKMElDOHZJRXB2WWlCa2IyVnpJRzV2ZENCbGVHbHpkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQmxaWEpmZW1WeWJ5OWpiMjUwY21GamRDMWhjSEF1WVd4bmJ5NTBjem81TWdvZ0lDQWdMeThnWVhOelpYSjBLR3B2WWk1MllXeDFaUzV6ZEdGMGRYTXVibUYwYVhabExDQWlTbTlpSUdsdVlXTjBhWFpsTDJOdmJYQnNaWFJsWkNJcENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdGemMyVnlkQ0F2THlCQ2IzZ2diWFZ6ZENCb1lYWmxJSFpoYkhWbENpQWdJQ0JwYm5SaklEUWdMeThnTWpBNENpQWdJQ0JuWlhSaWFYUUtJQ0FnSUdKNWRHVmpJRGNnTHk4Z01IZ3dNQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjMlYwWW1sMENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaMlYwWW1sMENpQWdJQ0JoYzNObGNuUWdMeThnU205aUlHbHVZV04wYVhabEwyTnZiWEJzWlhSbFpBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCbFpYSmZlbVZ5Ynk5amIyNTBjbUZqZEMxaGNIQXVZV3huYnk1MGN6bzVNd29nSUNBZ0x5OGdZWE56WlhKMEtHcHZZaTUyWVd4MVpTNTBhVzFsVDNWMExtNWhkR2wyWlNBK1BTQkhiRzlpWVd3dWJHRjBaWE4wVkdsdFpYTjBZVzF3TENBaVNtOWlJR1Y0Y0dseVpXUWlLUW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmhjM05sY25RZ0x5OGdRbTk0SUcxMWMzUWdhR0YyWlNCMllXeDFaUW9nSUNBZ2NIVnphR2x1ZENBeE9DQXZMeUF4T0FvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR2RzYjJKaGJDQk1ZWFJsYzNSVWFXMWxjM1JoYlhBS0lDQWdJRDQ5Q2lBZ0lDQmhjM05sY25RZ0x5OGdTbTlpSUdWNGNHbHlaV1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdaV1Z5WDNwbGNtOHZZMjl1ZEhKaFkzUXRZWEJ3TG1Gc1oyOHVkSE02T1RRS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxtbHpVbVZuYVhOMFpYSmxaRTFsWTJoaGJtbGpLRzFsWTJoaGJtbGpTV1FwTG01aGRHbDJaU3dnSWsxbFkyaGhibWxqSUc1dmRDQnlaV2RwYzNSbGNtVmtJaWtLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1kyRnNiSE4xWWlCcGMxSmxaMmx6ZEdWeVpXUk5aV05vWVc1cFl3b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2RsZEdKcGRBb2dJQ0FnWVhOelpYSjBJQzh2SUUxbFkyaGhibWxqSUc1dmRDQnlaV2RwYzNSbGNtVmtDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHVmxjbDk2WlhKdkwyTnZiblJ5WVdOMExXRndjQzVoYkdkdkxuUnpPamsyQ2lBZ0lDQXZMeUJwWmlBb2FtOWlMblpoYkhWbExtSnBaQzV1WVhScGRtVWdQaUF3S1NCN0NpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaGMzTmxjblFnTHk4Z1FtOTRJRzExYzNRZ2FHRjJaU0IyWVd4MVpRb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JpZWlCUWJHRmpaVUpwWkY5aFpuUmxjbDlwWmw5bGJITmxRRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdaV1Z5WDNwbGNtOHZZMjl1ZEhKaFkzUXRZWEJ3TG1Gc1oyOHVkSE02T1RjS0lDQWdJQzh2SUdGemMyVnlkQ2hoYlc5MWJuUXVibUYwYVhabElEd2dhbTlpTG5aaGJIVmxMbUpwWkM1dVlYUnBkbVVzSUNKQ2FXUWdiWFZ6ZENCaVpTQnNiM2RsY2lCMGFHRnVJR04xY25KbGJuUWdZbWxrSWlrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZblJ2YVFvZ0lDQWdabkpoYldWZlpHbG5JREFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0Z6YzJWeWRDQXZMeUJDYjNnZ2JYVnpkQ0JvWVhabElIWmhiSFZsQ2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lEd0tJQ0FnSUdGemMyVnlkQ0F2THlCQ2FXUWdiWFZ6ZENCaVpTQnNiM2RsY2lCMGFHRnVJR04xY25KbGJuUWdZbWxrQ2dwUWJHRmpaVUpwWkY5aFpuUmxjbDlwWmw5bGJITmxRREk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR1ZsY2w5NlpYSnZMMk52Ym5SeVlXTjBMV0Z3Y0M1aGJHZHZMblJ6T2pFd01Bb2dJQ0FnTHk4Z2FtOWlMblpoYkhWbExtSnBaQ0E5SUdGdGIzVnVkQW9nSUNBZ1puSmhiV1ZmWkdsbklEQUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lYTnpaWEowSUM4dklFSnZlQ0J0ZFhOMElHaGhkbVVnZG1Gc2RXVUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnY21Wd2JHRmpaVElnT0FvZ0lDQWdaR2xuSURFS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb2dJQ0FnWkdsbklERUtJQ0FnSUhOM1lYQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdaV1Z5WDNwbGNtOHZZMjl1ZEhKaFkzUXRZWEJ3TG1Gc1oyOHVkSE02TVRBeENpQWdJQ0F2THlCcWIySXVkbUZzZFdVdWJXVmphR0Z1YVdOSlpDQTlJRzFsWTJoaGJtbGpTV1FLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZWE56WlhKMElDOHZJRUp2ZUNCdGRYTjBJR2hoZG1VZ2RtRnNkV1VLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2NtVndiR0ZqWlRJZ01qY0tJQ0FnSUdScFp5QXhDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0dWbGNsOTZaWEp2TDJOdmJuUnlZV04wTFdGd2NDNWhiR2R2TG5Sek9qRXdNZ29nSUNBZ0x5OGdkR2hwY3k1S2IySnpLR3B2WWtsa0tTNTJZV3gxWlNBOUlHcHZZaTUyWVd4MVpTNWpiM0I1S0NrS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWVhOelpYSjBJQzh2SUVKdmVDQnRkWE4wSUdoaGRtVWdkbUZzZFdVS0lDQWdJR1JwWnlBeENpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdaV1Z5WDNwbGNtOHZZMjl1ZEhKaFkzUXRZWEJ3TG1Gc1oyOHVkSE02TVRBekNpQWdJQ0F2THlCeVpYUjFjbTRnYm1WM0lHRnlZelF1UW05dmJDaDBjblZsS1FvZ0lDQWdZbmwwWldNZ05TQXZMeUF3ZURnd0NpQWdJQ0J6ZDJGd0NpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0dWbGNsOTZaWEp2TDJOdmJuUnlZV04wTFdGd2NDNWhiR2R2TG5Sek9qcFFaV1Z5V21WeWJ5NWpiMjF3YkdWMFpVcHZZaWhxYjJKSlpEb2dZbmwwWlhNcElDMCtJR0o1ZEdWek9ncGpiMjF3YkdWMFpVcHZZam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdaV1Z5WDNwbGNtOHZZMjl1ZEhKaFkzUXRZWEJ3TG1Gc1oyOHVkSE02TVRBMkxURXdOd29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdZMjl0Y0d4bGRHVktiMklvYW05aVNXUTZJR0Z5WXpRdVZXbHVkRTQyTkNrNklHRnlZelF1UW05dmJDQjdDaUFnSUNCd2NtOTBieUF4SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WldWeVgzcGxjbTh2WTI5dWRISmhZM1F0WVhCd0xtRnNaMjh1ZEhNNk16TUtJQ0FnSUM4dklIQjFZbXhwWXlCS2IySnpJRDBnUW05NFRXRndQR0Z5WXpRdVZXbHVkRTQyTkN3Z1NtOWlVM1J5ZFdOMFBpaDdJR3RsZVZCeVpXWnBlRG9nSW1wdllpSWdmU2tLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJbXB2WWlJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WldWeVgzcGxjbTh2WTI5dWRISmhZM1F0WVhCd0xtRnNaMjh1ZEhNNk1UQTRDaUFnSUNBdkx5QmpiMjV6ZENCcWIySWdQU0IwYUdsekxrcHZZbk1vYW05aVNXUXBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d1pXVnlYM3BsY204dlkyOXVkSEpoWTNRdFlYQndMbUZzWjI4dWRITTZNek1LSUNBZ0lDOHZJSEIxWW14cFl5QktiMkp6SUQwZ1FtOTRUV0Z3UEdGeVl6UXVWV2x1ZEU0Mk5Dd2dTbTlpVTNSeWRXTjBQaWg3SUd0bGVWQnlaV1pwZURvZ0ltcHZZaUlnZlNrS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCbFpYSmZlbVZ5Ynk5amIyNTBjbUZqZEMxaGNIQXVZV3huYnk1MGN6b3hNRGtLSUNBZ0lDOHZJR0Z6YzJWeWRDaHFiMkl1WlhocGMzUnpMQ0FpU205aUlHUnZaWE1nYm05MElHVjRhWE4wSWlrS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaGMzTmxjblFnTHk4Z1NtOWlJR1J2WlhNZ2JtOTBJR1Y0YVhOMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0dWbGNsOTZaWEp2TDJOdmJuUnlZV04wTFdGd2NDNWhiR2R2TG5Sek9qRXhNQW9nSUNBZ0x5OGdZWE56WlhKMEtHcHZZaTUyWVd4MVpTNXpkR0YwZFhNdWJtRjBhWFpsTENBaVNtOWlJR0ZzY21WaFpIa2dZMjl0Y0d4bGRHVmtJaWtLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZWE56WlhKMElDOHZJRUp2ZUNCdGRYTjBJR2hoZG1VZ2RtRnNkV1VLSUNBZ0lHbHVkR01nTkNBdkx5QXlNRGdLSUNBZ0lHZGxkR0pwZEFvZ0lDQWdZbmwwWldNZ055QXZMeUF3ZURBd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCelpYUmlhWFFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCblpYUmlhWFFLSUNBZ0lHRnpjMlZ5ZENBdkx5QktiMklnWVd4eVpXRmtlU0JqYjIxd2JHVjBaV1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdaV1Z5WDNwbGNtOHZZMjl1ZEhKaFkzUXRZWEJ3TG1Gc1oyOHVkSE02TVRFeENpQWdJQ0F2THlCaGMzTmxjblFvYW05aUxuWmhiSFZsTG0xbFkyaGhibWxqU1dRdWJtRjBhWFpsSUQ0Z01Dd2dJazV2SUcxbFkyaGhibWxqSUhObGJHVmpkR1ZrSWlrS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWVhOelpYSjBJQzh2SUVKdmVDQnRkWE4wSUdoaGRtVWdkbUZzZFdVS0lDQWdJSEIxYzJocGJuUWdNamNnTHk4Z01qY0tJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCaGMzTmxjblFnTHk4Z1RtOGdiV1ZqYUdGdWFXTWdjMlZzWldOMFpXUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d1pXVnlYM3BsY204dlkyOXVkSEpoWTNRdFlYQndMbUZzWjI4dWRITTZNVEV6Q2lBZ0lDQXZMeUJxYjJJdWRtRnNkV1V1YzNSaGRIVnpJRDBnYm1WM0lHRnlZelF1UW05dmJDaG1ZV3h6WlNrS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWVhOelpYSjBJQzh2SUVKdmVDQnRkWE4wSUdoaGRtVWdkbUZzZFdVS0lDQWdJR2x1ZEdNZ05DQXZMeUF5TURnS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnpaWFJpYVhRS0lDQWdJR1JwWnlBeENpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUdScFp5QXhDaUFnSUNCemQyRndDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR1ZsY2w5NlpYSnZMMk52Ym5SeVlXTjBMV0Z3Y0M1aGJHZHZMblJ6T2pFeE5Bb2dJQ0FnTHk4Z2RHaHBjeTVLYjJKektHcHZZa2xrS1M1MllXeDFaU0E5SUdwdllpNTJZV3gxWlM1amIzQjVLQ2tLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZWE56WlhKMElDOHZJRUp2ZUNCdGRYTjBJR2hoZG1VZ2RtRnNkV1VLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJR1JwWnlBeENpQWdJQ0J6ZDJGd0NpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHVmxjbDk2WlhKdkwyTnZiblJ5WVdOMExXRndjQzVoYkdkdkxuUnpPak14Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdiV1ZqYUdGdWFXTlNaV2RwYzNSbGNrRndjRWxrSUQwZ1FtOTRQR0Z5WXpRdVZXbHVkRTQyTkQ0b2V5QnJaWGs2SUNKdFpXTm9VbVZuYVhOMFpYSkJjSEJKWkNJZ2ZTa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltMWxZMmhTWldkcGMzUmxja0Z3Y0Vsa0lnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCbFpYSmZlbVZ5Ynk5amIyNTBjbUZqZEMxaGNIQXVZV3huYnk1MGN6b3hNVFlLSUNBZ0lDOHZJR0Z6YzJWeWRDaDBhR2x6TG0xbFkyaGhibWxqVW1WbmFYTjBaWEpCY0hCSlpDNWxlR2x6ZEhNc0lDSnlaV2RwYzNSeWVTQmhjSEFnYm05MElITmxkQ0lwQ2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdGemMyVnlkQ0F2THlCeVpXZHBjM1J5ZVNCaGNIQWdibTkwSUhObGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCbFpYSmZlbVZ5Ynk5amIyNTBjbUZqZEMxaGNIQXVZV3huYnk1MGN6b3pNUW9nSUNBZ0x5OGdjSFZpYkdsaklHMWxZMmhoYm1salVtVm5hWE4wWlhKQmNIQkpaQ0E5SUVKdmVEeGhjbU0wTGxWcGJuUk9OalErS0hzZ2EyVjVPaUFpYldWamFGSmxaMmx6ZEdWeVFYQndTV1FpSUgwcENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKdFpXTm9VbVZuYVhOMFpYSkJjSEJKWkNJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WldWeVgzcGxjbTh2WTI5dWRISmhZM1F0WVhCd0xtRnNaMjh1ZEhNNk1URTNDaUFnSUNBdkx5QmpiMjV6ZENCeVpXZEJjSEJKWkNBOUlIUm9hWE11YldWamFHRnVhV05TWldkcGMzUmxja0Z3Y0Vsa0xuWmhiSFZsTG01aGRHbDJaUW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZWE56WlhKMElDOHZJRUp2ZUNCdGRYTjBJR2hoZG1VZ2RtRnNkV1VLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdaV1Z5WDNwbGNtOHZZMjl1ZEhKaFkzUXRZWEJ3TG1Gc1oyOHVkSE02TVRFNUxURXlPQW9nSUNBZ0x5OGdZMjl1YzNRZ1lYQndRMkZzYkZSNGJpQTlJR2wwZUc0dVlYQndiR2xqWVhScGIyNURZV3hzS0hzS0lDQWdJQzh2SUNBZ1lYQndTV1E2SUhKbFowRndjRWxrTEFvZ0lDQWdMeThnSUNCaGNIQkJjbWR6T2lCYkNpQWdJQ0F2THlBZ0lDQWdZWEpqTkM1dFpYUm9iMlJUWld4bFkzUnZjaWdLSUNBZ0lDOHZJQ0FnSUNBZ0lDSm5aWFJOWldOb1lXNXBZeWgxYVc1ME5qUXBLSE4wY21sdVp5eHpkSEpwYm1jc2MzUnlhVzVuTEhWcGJuUTJOQ3hoWkdSeVpYTnpMR0p2YjJ3c2RXbHVkRFkwS1NJS0lDQWdJQzh2SUNBZ0lDQXBMQW9nSUNBZ0x5OGdJQ0FnSUdwdllpNTJZV3gxWlM1dFpXTm9ZVzVwWTBsa0NpQWdJQ0F2THlBZ0lGMHNDaUFnSUNBdkx5QWdJR1psWlRvZ01Bb2dJQ0FnTHk4Z2ZTa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WldWeVgzcGxjbTh2WTI5dWRISmhZM1F0WVhCd0xtRnNaMjh1ZEhNNk1USTFDaUFnSUNBdkx5QnFiMkl1ZG1Gc2RXVXViV1ZqYUdGdWFXTkpaQW9nSUNBZ1pHbG5JREVLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0Z6YzJWeWRDQXZMeUJDYjNnZ2JYVnpkQ0JvWVhabElIWmhiSFZsQ2lBZ0lDQmxlSFJ5WVdOMElESTNJRGdnTHk4Z2IyNGdaWEp5YjNJNklFbHVaR1Y0SUdGalkyVnpjeUJwY3lCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHVmxjbDk2WlhKdkwyTnZiblJ5WVdOMExXRndjQzVoYkdkdkxuUnpPakV5TWkweE1qUUtJQ0FnSUM4dklHRnlZelF1YldWMGFHOWtVMlZzWldOMGIzSW9DaUFnSUNBdkx5QWdJQ0puWlhSTlpXTm9ZVzVwWXloMWFXNTBOalFwS0hOMGNtbHVaeXh6ZEhKcGJtY3NjM1J5YVc1bkxIVnBiblEyTkN4aFpHUnlaWE56TEdKdmIyd3NkV2x1ZERZMEtTSUtJQ0FnSUM4dklDa3NDaUFnSUNCaWVYUmxZeUE0SUM4dklHMWxkR2h2WkNBaVoyVjBUV1ZqYUdGdWFXTW9kV2x1ZERZMEtTaHpkSEpwYm1jc2MzUnlhVzVuTEhOMGNtbHVaeXgxYVc1ME5qUXNZV1JrY21WemN5eGliMjlzTEhWcGJuUTJOQ2tpQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHUjFjQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR1ZsY2w5NlpYSnZMMk52Ym5SeVlXTjBMV0Z3Y0M1aGJHZHZMblJ6T2pFeE9TMHhNamdLSUNBZ0lDOHZJR052Ym5OMElHRndjRU5oYkd4VWVHNGdQU0JwZEhodUxtRndjR3hwWTJGMGFXOXVRMkZzYkNoN0NpQWdJQ0F2THlBZ0lHRndjRWxrT2lCeVpXZEJjSEJKWkN3S0lDQWdJQzh2SUNBZ1lYQndRWEpuY3pvZ1d3b2dJQ0FnTHk4Z0lDQWdJR0Z5WXpRdWJXVjBhRzlrVTJWc1pXTjBiM0lvQ2lBZ0lDQXZMeUFnSUNBZ0lDQWlaMlYwVFdWamFHRnVhV01vZFdsdWREWTBLU2h6ZEhKcGJtY3NjM1J5YVc1bkxITjBjbWx1Wnl4MWFXNTBOalFzWVdSa2NtVnpjeXhpYjI5c0xIVnBiblEyTkNraUNpQWdJQ0F2THlBZ0lDQWdLU3dLSUNBZ0lDOHZJQ0FnSUNCcWIySXVkbUZzZFdVdWJXVmphR0Z1YVdOSlpBb2dJQ0FnTHk4Z0lDQmRMQW9nSUNBZ0x5OGdJQ0JtWldVNklEQUtJQ0FnSUM4dklIMHBMbk4xWW0xcGRDZ3BDaUFnSUNCcGJuUmpYeklnTHk4Z05nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JsWlhKZmVtVnlieTlqYjI1MGNtRmpkQzFoY0hBdVlXeG5ieTUwY3pveE1qY0tJQ0FnSUM4dklHWmxaVG9nTUFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR1ZsY2w5NlpYSnZMMk52Ym5SeVlXTjBMV0Z3Y0M1aGJHZHZMblJ6T2pFeE9TMHhNamdLSUNBZ0lDOHZJR052Ym5OMElHRndjRU5oYkd4VWVHNGdQU0JwZEhodUxtRndjR3hwWTJGMGFXOXVRMkZzYkNoN0NpQWdJQ0F2THlBZ0lHRndjRWxrT2lCeVpXZEJjSEJKWkN3S0lDQWdJQzh2SUNBZ1lYQndRWEpuY3pvZ1d3b2dJQ0FnTHk4Z0lDQWdJR0Z5WXpRdWJXVjBhRzlrVTJWc1pXTjBiM0lvQ2lBZ0lDQXZMeUFnSUNBZ0lDQWlaMlYwVFdWamFHRnVhV01vZFdsdWREWTBLU2h6ZEhKcGJtY3NjM1J5YVc1bkxITjBjbWx1Wnl4MWFXNTBOalFzWVdSa2NtVnpjeXhpYjI5c0xIVnBiblEyTkNraUNpQWdJQ0F2THlBZ0lDQWdLU3dLSUNBZ0lDOHZJQ0FnSUNCcWIySXVkbUZzZFdVdWJXVmphR0Z1YVdOSlpBb2dJQ0FnTHk4Z0lDQmRMQW9nSUNBZ0x5OGdJQ0JtWldVNklEQUtJQ0FnSUM4dklIMHBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnYVhSNGJpQk1ZWE4wVEc5bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0dWbGNsOTZaWEp2TDJOdmJuUnlZV04wTFdGd2NDNWhiR2R2TG5Sek9qRXpOQW9nSUNBZ0x5OGdZMjl1YzNRZ2JXVmphR0Z1YVdOWFlXeHNaWFFnUFNCdFpXTm9ZVzVwWXk1aGRDZzBLVHNLSUNBZ0lHVjRkSEpoWTNRZ01UUWdNeklnTHk4Z2IyNGdaWEp5YjNJNklFbHVaR1Y0SUdGalkyVnpjeUJwY3lCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHVmxjbDk2WlhKdkwyTnZiblJ5WVdOMExXRndjQzVoYkdkdkxuUnpPakV6TmkweE5EQUtJQ0FnSUM4dklHbDBlRzR1Y0dGNWJXVnVkQ2g3Q2lBZ0lDQXZMeUFnSUhKbFkyVnBkbVZ5T2lCdFpXTm9ZVzVwWTFkaGJHeGxkQzVpZVhSbGN5d0tJQ0FnSUM4dklDQWdZVzF2ZFc1ME9pQnFiMkl1ZG1Gc2RXVXVZbWxrTG01aGRHbDJaU3dLSUNBZ0lDOHZJQ0FnWm1WbE9pQXdDaUFnSUNBdkx5QjlLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCbFpYSmZlbVZ5Ynk5amIyNTBjbUZqZEMxaGNIQXVZV3huYnk1MGN6b3hNemdLSUNBZ0lDOHZJR0Z0YjNWdWREb2dhbTlpTG5aaGJIVmxMbUpwWkM1dVlYUnBkbVVzQ2lBZ0lDQmthV2NnTWdvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWVhOelpYSjBJQzh2SUVKdmVDQnRkWE4wSUdoaGRtVWdkbUZzZFdVS0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYlc5MWJuUUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1VtVmpaV2wyWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WldWeVgzcGxjbTh2WTI5dWRISmhZM1F0WVhCd0xtRnNaMjh1ZEhNNk1UTTJMVEUwTUFvZ0lDQWdMeThnYVhSNGJpNXdZWGx0Wlc1MEtIc0tJQ0FnSUM4dklDQWdjbVZqWldsMlpYSTZJRzFsWTJoaGJtbGpWMkZzYkdWMExtSjVkR1Z6TEFvZ0lDQWdMeThnSUNCaGJXOTFiblE2SUdwdllpNTJZV3gxWlM1aWFXUXVibUYwYVhabExBb2dJQ0FnTHk4Z0lDQm1aV1U2SURBS0lDQWdJQzh2SUgwcExuTjFZbTFwZENncENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQmxaWEpmZW1WeWJ5OWpiMjUwY21GamRDMWhjSEF1WVd4bmJ5NTBjem94TXprS0lDQWdJQzh2SUdabFpUb2dNQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHVmxjbDk2WlhKdkwyTnZiblJ5WVdOMExXRndjQzVoYkdkdkxuUnpPakV6TmkweE5EQUtJQ0FnSUM4dklHbDBlRzR1Y0dGNWJXVnVkQ2g3Q2lBZ0lDQXZMeUFnSUhKbFkyVnBkbVZ5T2lCdFpXTm9ZVzVwWTFkaGJHeGxkQzVpZVhSbGN5d0tJQ0FnSUM4dklDQWdZVzF2ZFc1ME9pQnFiMkl1ZG1Gc2RXVXVZbWxrTG01aGRHbDJaU3dLSUNBZ0lDOHZJQ0FnWm1WbE9pQXdDaUFnSUNBdkx5QjlLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d1pXVnlYM3BsY204dlkyOXVkSEpoWTNRdFlYQndMbUZzWjI4dWRITTZNVFF5TFRFMU1Bb2dJQ0FnTHk4Z2FYUjRiaTVoY0hCc2FXTmhkR2x2YmtOaGJHd29ld29nSUNBZ0x5OGdJQ0JoY0hCSlpEb2djbVZuUVhCd1NXUXNDaUFnSUNBdkx5QWdJR0Z3Y0VGeVozTTZJRnNLSUNBZ0lDOHZJQ0FnSUNCaGNtTTBMbTFsZEdodlpGTmxiR1ZqZEc5eUtDSjFjR1JoZEdWU1lYUnBibWNvZFdsdWREWTBMSFZwYm5RMk5DbDFhVzUwTmpRaUtTd0tJQ0FnSUM4dklDQWdJQ0JxYjJJdWRtRnNkV1V1YldWamFHRnVhV05KWkN3S0lDQWdJQzh2SUNBZ0lDQnVaWGNnWVhKak5DNVZhVzUwVGpZMEtERXBDaUFnSUNBdkx5QWdJRjBzQ2lBZ0lDQXZMeUFnSUdabFpUb2dNQW9nSUNBZ0x5OGdmU2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d1pXVnlYM3BsY204dlkyOXVkSEpoWTNRdFlYQndMbUZzWjI4dWRITTZNVFEyQ2lBZ0lDQXZMeUJxYjJJdWRtRnNkV1V1YldWamFHRnVhV05KWkN3S0lDQWdJSE4zWVhBS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdGemMyVnlkQ0F2THlCQ2IzZ2diWFZ6ZENCb1lYWmxJSFpoYkhWbENpQWdJQ0JsZUhSeVlXTjBJREkzSURnZ0x5OGdiMjRnWlhKeWIzSTZJRWx1WkdWNElHRmpZMlZ6Y3lCcGN5QnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR1ZsY2w5NlpYSnZMMk52Ym5SeVlXTjBMV0Z3Y0M1aGJHZHZMblJ6T2pFME5Rb2dJQ0FnTHk4Z1lYSmpOQzV0WlhSb2IyUlRaV3hsWTNSdmNpZ2lkWEJrWVhSbFVtRjBhVzVuS0hWcGJuUTJOQ3gxYVc1ME5qUXBkV2x1ZERZMElpa3NDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3hOemt3TldJek1DQXZMeUJ0WlhSb2IyUWdJblZ3WkdGMFpWSmhkR2x1WnloMWFXNTBOalFzZFdsdWREWTBLWFZwYm5RMk5DSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCbFpYSmZlbVZ5Ynk5amIyNTBjbUZqZEMxaGNIQXVZV3huYnk1MGN6b3hORGNLSUNBZ0lDOHZJRzVsZHlCaGNtTTBMbFZwYm5ST05qUW9NU2tLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3TURBd01EQXdNREF3TURBd01ERUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WldWeVgzcGxjbTh2WTI5dWRISmhZM1F0WVhCd0xtRnNaMjh1ZEhNNk1UUXlMVEUxTUFvZ0lDQWdMeThnYVhSNGJpNWhjSEJzYVdOaGRHbHZia05oYkd3b2V3b2dJQ0FnTHk4Z0lDQmhjSEJKWkRvZ2NtVm5RWEJ3U1dRc0NpQWdJQ0F2THlBZ0lHRndjRUZ5WjNNNklGc0tJQ0FnSUM4dklDQWdJQ0JoY21NMExtMWxkR2h2WkZObGJHVmpkRzl5S0NKMWNHUmhkR1ZTWVhScGJtY29kV2x1ZERZMExIVnBiblEyTkNsMWFXNTBOalFpS1N3S0lDQWdJQzh2SUNBZ0lDQnFiMkl1ZG1Gc2RXVXViV1ZqYUdGdWFXTkpaQ3dLSUNBZ0lDOHZJQ0FnSUNCdVpYY2dZWEpqTkM1VmFXNTBUalkwS0RFcENpQWdJQ0F2THlBZ0lGMHNDaUFnSUNBdkx5QWdJR1psWlRvZ01Bb2dJQ0FnTHk4Z2ZTa3VjM1ZpYldsMEtDa0tJQ0FnSUdsdWRHTmZNaUF2THlBMkNpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR1ZsY2w5NlpYSnZMMk52Ym5SeVlXTjBMV0Z3Y0M1aGJHZHZMblJ6T2pFME9Rb2dJQ0FnTHk4Z1ptVmxPaUF3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdaV1Z5WDNwbGNtOHZZMjl1ZEhKaFkzUXRZWEJ3TG1Gc1oyOHVkSE02TVRReUxURTFNQW9nSUNBZ0x5OGdhWFI0Ymk1aGNIQnNhV05oZEdsdmJrTmhiR3dvZXdvZ0lDQWdMeThnSUNCaGNIQkpaRG9nY21WblFYQndTV1FzQ2lBZ0lDQXZMeUFnSUdGd2NFRnlaM002SUZzS0lDQWdJQzh2SUNBZ0lDQmhjbU0wTG0xbGRHaHZaRk5sYkdWamRHOXlLQ0oxY0dSaGRHVlNZWFJwYm1jb2RXbHVkRFkwTEhWcGJuUTJOQ2wxYVc1ME5qUWlLU3dLSUNBZ0lDOHZJQ0FnSUNCcWIySXVkbUZzZFdVdWJXVmphR0Z1YVdOSlpDd0tJQ0FnSUM4dklDQWdJQ0J1WlhjZ1lYSmpOQzVWYVc1MFRqWTBLREVwQ2lBZ0lDQXZMeUFnSUYwc0NpQWdJQ0F2THlBZ0lHWmxaVG9nTUFvZ0lDQWdMeThnZlNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR1ZsY2w5NlpYSnZMMk52Ym5SeVlXTjBMV0Z3Y0M1aGJHZHZMblJ6T2pFMU1nb2dJQ0FnTHk4Z2NtVjBkWEp1SUc1bGR5QmhjbU0wTGtKdmIyd29kSEoxWlNrS0lDQWdJR0o1ZEdWaklEVWdMeThnTUhnNE1Bb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCbFpYSmZlbVZ5Ynk5amIyNTBjbUZqZEMxaGNIQXVZV3huYnk1MGN6bzZVR1ZsY2xwbGNtOHVRMkZ1WTJWc1NtOWlLR3B2WWtsa09pQmllWFJsY3lrZ0xUNGdZbmwwWlhNNkNrTmhibU5sYkVwdllqb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d1pXVnlYM3BsY204dlkyOXVkSEpoWTNRdFlYQndMbUZzWjI4dWRITTZNVFUxTFRFMU5nb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNBdkx5QndkV0pzYVdNZ1EyRnVZMlZzU205aUtHcHZZa2xrT2lCaGNtTTBMbFZwYm5ST05qUXBPaUJoY21NMExrSnZiMndnZXdvZ0lDQWdjSEp2ZEc4Z01TQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHVmxjbDk2WlhKdkwyTnZiblJ5WVdOMExXRndjQzVoYkdkdkxuUnpPak16Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdTbTlpY3lBOUlFSnZlRTFoY0R4aGNtTTBMbFZwYm5ST05qUXNJRXB2WWxOMGNuVmpkRDRvZXlCclpYbFFjbVZtYVhnNklDSnFiMklpSUgwcENpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKcWIySWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHVmxjbDk2WlhKdkwyTnZiblJ5WVdOMExXRndjQzVoYkdkdkxuUnpPakUxTndvZ0lDQWdMeThnWTI5dWMzUWdhbTlpSUQwZ2RHaHBjeTVLYjJKektHcHZZa2xrS1FvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR1ZsY2w5NlpYSnZMMk52Ym5SeVlXTjBMV0Z3Y0M1aGJHZHZMblJ6T2pNekNpQWdJQ0F2THlCd2RXSnNhV01nU205aWN5QTlJRUp2ZUUxaGNEeGhjbU0wTGxWcGJuUk9OalFzSUVwdllsTjBjblZqZEQ0b2V5QnJaWGxRY21WbWFYZzZJQ0pxYjJJaUlIMHBDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdaV1Z5WDNwbGNtOHZZMjl1ZEhKaFkzUXRZWEJ3TG1Gc1oyOHVkSE02TVRVNENpQWdJQ0F2THlCaGMzTmxjblFvYW05aUxtVjRhWE4wY3l3Z0lrcHZZaUJrYjJWeklHNXZkQ0JsZUdsemRDSXBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZWE56WlhKMElDOHZJRXB2WWlCa2IyVnpJRzV2ZENCbGVHbHpkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQmxaWEpmZW1WeWJ5OWpiMjUwY21GamRDMWhjSEF1WVd4bmJ5NTBjem94TlRrS0lDQWdJQzh2SUdGemMyVnlkQ2hxYjJJdWRtRnNkV1V1YzNSaGRIVnpMbTVoZEdsMlpTd2dJa3B2WWlCaGJISmxZV1I1SUdOdmJYQnNaWFJsWkNJcENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdGemMyVnlkQ0F2THlCQ2IzZ2diWFZ6ZENCb1lYWmxJSFpoYkhWbENpQWdJQ0JwYm5SaklEUWdMeThnTWpBNENpQWdJQ0JuWlhSaWFYUUtJQ0FnSUdKNWRHVmpJRGNnTHk4Z01IZ3dNQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjMlYwWW1sMENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaMlYwWW1sMENpQWdJQ0JoYzNObGNuUWdMeThnU205aUlHRnNjbVZoWkhrZ1kyOXRjR3hsZEdWa0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0dWbGNsOTZaWEp2TDJOdmJuUnlZV04wTFdGd2NDNWhiR2R2TG5Sek9qRTJNUzB4TmpVS0lDQWdJQzh2SUdsMGVHNHVjR0Y1YldWdWRDaDdDaUFnSUNBdkx5QWdJSEpsWTJWcGRtVnlPaUJxYjJJdWRtRnNkV1V1YjNkdVpYSXVZbmwwWlhNc0NpQWdJQ0F2THlBZ0lHRnRiM1Z1ZERvZ2FtOWlMblpoYkhWbExtSnBaQzV1WVhScGRtVXNDaUFnSUNBdkx5QWdJR1psWlRvZ01Bb2dJQ0FnTHk4Z2ZTa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WldWeVgzcGxjbTh2WTI5dWRISmhZM1F0WVhCd0xtRnNaMjh1ZEhNNk1UWXlDaUFnSUNBdkx5QnlaV05sYVhabGNqb2dhbTlpTG5aaGJIVmxMbTkzYm1WeUxtSjVkR1Z6TEFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JoYzNObGNuUWdMeThnUW05NElHMTFjM1FnYUdGMlpTQjJZV3gxWlFvZ0lDQWdaWGgwY21GamRDQXpOU0F6TWlBdkx5QnZiaUJsY25KdmNqb2dTVzVrWlhnZ1lXTmpaWE56SUdseklHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdaV1Z5WDNwbGNtOHZZMjl1ZEhKaFkzUXRZWEJ3TG1Gc1oyOHVkSE02TVRZekNpQWdJQ0F2THlCaGJXOTFiblE2SUdwdllpNTJZV3gxWlM1aWFXUXVibUYwYVhabExBb2dJQ0FnWkdsbklERUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHRnpjMlZ5ZENBdkx5QkNiM2dnYlhWemRDQm9ZWFpsSUhaaGJIVmxDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FXMXZkVzUwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRkpsWTJWcGRtVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHVmxjbDk2WlhKdkwyTnZiblJ5WVdOMExXRndjQzVoYkdkdkxuUnpPakUyTVMweE5qVUtJQ0FnSUM4dklHbDBlRzR1Y0dGNWJXVnVkQ2g3Q2lBZ0lDQXZMeUFnSUhKbFkyVnBkbVZ5T2lCcWIySXVkbUZzZFdVdWIzZHVaWEl1WW5sMFpYTXNDaUFnSUNBdkx5QWdJR0Z0YjNWdWREb2dhbTlpTG5aaGJIVmxMbUpwWkM1dVlYUnBkbVVzQ2lBZ0lDQXZMeUFnSUdabFpUb2dNQW9nSUNBZ0x5OGdmU2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0dWbGNsOTZaWEp2TDJOdmJuUnlZV04wTFdGd2NDNWhiR2R2TG5Sek9qRTJOQW9nSUNBZ0x5OGdabVZsT2lBd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WldWeVgzcGxjbTh2WTI5dWRISmhZM1F0WVhCd0xtRnNaMjh1ZEhNNk1UWXhMVEUyTlFvZ0lDQWdMeThnYVhSNGJpNXdZWGx0Wlc1MEtIc0tJQ0FnSUM4dklDQWdjbVZqWldsMlpYSTZJR3B2WWk1MllXeDFaUzV2ZDI1bGNpNWllWFJsY3l3S0lDQWdJQzh2SUNBZ1lXMXZkVzUwT2lCcWIySXVkbUZzZFdVdVltbGtMbTVoZEdsMlpTd0tJQ0FnSUM4dklDQWdabVZsT2lBd0NpQWdJQ0F2THlCOUtTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WldWeVgzcGxjbTh2WTI5dWRISmhZM1F0WVhCd0xtRnNaMjh1ZEhNNk1UWTNDaUFnSUNBdkx5QnFiMkl1ZG1Gc2RXVXVjM1JoZEhWeklEMGdibVYzSUdGeVl6UXVRbTl2YkNobVlXeHpaU2tLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZWE56WlhKMElDOHZJRUp2ZUNCdGRYTjBJR2hoZG1VZ2RtRnNkV1VLSUNBZ0lHbHVkR01nTkNBdkx5QXlNRGdLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCelpYUmlhWFFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJR1JwWnlBeENpQWdJQ0J6ZDJGd0NpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHVmxjbDk2WlhKdkwyTnZiblJ5WVdOMExXRndjQzVoYkdkdkxuUnpPakUyT0FvZ0lDQWdMeThnZEdocGN5NUtiMkp6S0dwdllrbGtLUzUyWVd4MVpTQTlJR3B2WWk1MllXeDFaUzVqYjNCNUtDa0tJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lYTnpaWEowSUM4dklFSnZlQ0J0ZFhOMElHaGhkbVVnZG1Gc2RXVUtJQ0FnSUdScFp5QXhDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WldWeVgzcGxjbTh2WTI5dWRISmhZM1F0WVhCd0xtRnNaMjh1ZEhNNk1UWTVDaUFnSUNBdkx5QnlaWFIxY200Z2JtVjNJR0Z5WXpRdVFtOXZiQ2gwY25WbEtRb2dJQ0FnWW5sMFpXTWdOU0F2THlBd2VEZ3dDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHVmxjbDk2WlhKdkwyTnZiblJ5WVdOMExXRndjQzVoYkdkdkxuUnpPanBRWldWeVdtVnlieTVuWlhSS2IySW9hbTlpU1dRNklHSjVkR1Z6S1NBdFBpQmllWFJsY3pvS1oyVjBTbTlpT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JsWlhKZmVtVnlieTlqYjI1MGNtRmpkQzFoY0hBdVlXeG5ieTUwY3pveE56SXRNVGN6Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJQzh2SUhCMVlteHBZeUJuWlhSS2IySW9hbTlpU1dRNklHRnlZelF1VldsdWRFNDJOQ2s2SUVwdllsTjBjblZqZENCN0NpQWdJQ0J3Y205MGJ5QXhJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdaV1Z5WDNwbGNtOHZZMjl1ZEhKaFkzUXRZWEJ3TG1Gc1oyOHVkSE02TXpNS0lDQWdJQzh2SUhCMVlteHBZeUJLYjJKeklEMGdRbTk0VFdGd1BHRnlZelF1VldsdWRFNDJOQ3dnU205aVUzUnlkV04wUGloN0lHdGxlVkJ5WldacGVEb2dJbXB2WWlJZ2ZTa0tJQ0FnSUdKNWRHVmpJRFFnTHk4Z0ltcHZZaUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdaV1Z5WDNwbGNtOHZZMjl1ZEhKaFkzUXRZWEJ3TG1Gc1oyOHVkSE02TVRjMENpQWdJQ0F2THlCamIyNXpkQ0JxYjJJZ1BTQjBhR2x6TGtwdlluTW9hbTlpU1dRcENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WldWeVgzcGxjbTh2WTI5dWRISmhZM1F0WVhCd0xtRnNaMjh1ZEhNNk16TUtJQ0FnSUM4dklIQjFZbXhwWXlCS2IySnpJRDBnUW05NFRXRndQR0Z5WXpRdVZXbHVkRTQyTkN3Z1NtOWlVM1J5ZFdOMFBpaDdJR3RsZVZCeVpXWnBlRG9nSW1wdllpSWdmU2tLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JsWlhKZmVtVnlieTlqYjI1MGNtRmpkQzFoY0hBdVlXeG5ieTUwY3pveE56VUtJQ0FnSUM4dklHRnpjMlZ5ZENocWIySXVaWGhwYzNSekxDQWlTbTlpSUdSdlpYTWdibTkwSUdWNGFYTjBJaWtLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JoYzNObGNuUWdMeThnU205aUlHUnZaWE1nYm05MElHVjRhWE4wQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR1ZsY2w5NlpYSnZMMk52Ym5SeVlXTjBMV0Z3Y0M1aGJHZHZMblJ6T2pFM05nb2dJQ0FnTHk4Z2NtVjBkWEp1SUdwdllpNTJZV3gxWlFvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWVhOelpYSjBJQzh2SUVKdmVDQnRkWE4wSUdoaGRtVWdkbUZzZFdVS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WldWeVgzcGxjbTh2WTI5dWRISmhZM1F0WVhCd0xtRnNaMjh1ZEhNNk9sQmxaWEphWlhKdkxtZGxkRXB2WWtOdmRXNTBLQ2tnTFQ0Z1lubDBaWE02Q21kbGRFcHZZa052ZFc1ME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCbFpYSmZlbVZ5Ynk5amIyNTBjbUZqZEMxaGNIQXVZV3huYnk1MGN6b3pOQW9nSUNBZ0x5OGdjSFZpYkdsaklHcHZZa052ZFc1MElEMGdRbTk0UEdGeVl6UXVWV2x1ZEU0Mk5ENG9leUJyWlhrNklDSnFiMkpEYjNWdWRDSWdmU2tLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbXB2WWtOdmRXNTBJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQmxaWEpmZW1WeWJ5OWpiMjUwY21GamRDMWhjSEF1WVd4bmJ5NTBjem94T0RFS0lDQWdJQzh2SUdsbUlDaDBhR2x6TG1wdllrTnZkVzUwTG1WNGFYTjBjeWtnY21WMGRYSnVJSFJvYVhNdWFtOWlRMjkxYm5RdWRtRnNkV1VLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWW5vZ1oyVjBTbTlpUTI5MWJuUmZZV1owWlhKZmFXWmZaV3h6WlVBeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0dWbGNsOTZaWEp2TDJOdmJuUnlZV04wTFdGd2NDNWhiR2R2TG5Sek9qTTBDaUFnSUNBdkx5QndkV0pzYVdNZ2FtOWlRMjkxYm5RZ1BTQkNiM2c4WVhKak5DNVZhVzUwVGpZMFBpaDdJR3RsZVRvZ0ltcHZZa052ZFc1MElpQjlLUW9nSUNBZ1lubDBaV05mTXlBdkx5QWlhbTlpUTI5MWJuUWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHVmxjbDk2WlhKdkwyTnZiblJ5WVdOMExXRndjQzVoYkdkdkxuUnpPakU0TVFvZ0lDQWdMeThnYVdZZ0tIUm9hWE11YW05aVEyOTFiblF1WlhocGMzUnpLU0J5WlhSMWNtNGdkR2hwY3k1cWIySkRiM1Z1ZEM1MllXeDFaUW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZWE56WlhKMElDOHZJRUp2ZUNCdGRYTjBJR2hoZG1VZ2RtRnNkV1VLSUNBZ0lISmxkSE4xWWdvS1oyVjBTbTlpUTI5MWJuUmZZV1owWlhKZmFXWmZaV3h6WlVBeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCbFpYSmZlbVZ5Ynk5amIyNTBjbUZqZEMxaGNIQXVZV3huYnk1MGN6b3hPRElLSUNBZ0lDOHZJSEpsZEhWeWJpQnVaWGNnWVhKak5DNVZhVzUwVGpZMEtEQXBDaUFnSUNCaWVYUmxZeUEySUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCbFpYSmZlbVZ5Ynk5amIyNTBjbUZqZEMxaGNIQXVZV3huYnk1MGN6bzZVR1ZsY2xwbGNtOHVaR1Z3YjNOcGRFcHZZbFJwY0NocWIySkpaRG9nWW5sMFpYTXNJR0Z0YjNWdWREb2dZbmwwWlhNcElDMCtJSFp2YVdRNkNtUmxjRzl6YVhSS2IySlVhWEE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR1ZsY2w5NlpYSnZMMk52Ym5SeVlXTjBMV0Z3Y0M1aGJHZHZMblJ6T2pFNE5TMHhPRFlLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdMeThnY0hWaWJHbGpJR1JsY0c5emFYUktiMkpVYVhBb2FtOWlTV1E2SUdGeVl6UXVWV2x1ZEU0Mk5Dd2dZVzF2ZFc1ME9pQmhjbU0wTGxWcGJuUk9OalFwT2lCMmIybGtJSHNLSUNBZ0lIQnliM1J2SURJZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCbFpYSmZlbVZ5Ynk5amIyNTBjbUZqZEMxaGNIQXVZV3huYnk1MGN6b3pNZ29nSUNBZ0x5OGdjSFZpYkdsaklGQnlhVzl5YVhSNVgyWmxaVUZ3Y0Vsa0lEMGdRbTk0UEdGeVl6UXVWV2x1ZEU0Mk5ENG9leUJyWlhrNklDSndjbWx2Y21sMGVXWmxaVUZ3Y0Vsa0lpQjlLUW9nSUNBZ1lubDBaV05mTWlBdkx5QWljSEpwYjNKcGRIbG1aV1ZCY0hCSlpDSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d1pXVnlYM3BsY204dlkyOXVkSEpoWTNRdFlYQndMbUZzWjI4dWRITTZNVGczQ2lBZ0lDQXZMeUJoYzNObGNuUW9kR2hwY3k1UWNtbHZjbWwwZVY5bVpXVkJjSEJKWkM1bGVHbHpkSE1zSUNKVWFYQWdZMjl1ZEhKaFkzUWdibTkwSUhObGRDSXBPd29nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JoYzNObGNuUWdMeThnVkdsd0lHTnZiblJ5WVdOMElHNXZkQ0J6WlhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WldWeVgzcGxjbTh2WTI5dWRISmhZM1F0WVhCd0xtRnNaMjh1ZEhNNk1UZzVMVEU1T0FvZ0lDQWdMeThnYVhSNGJpNWhjSEJzYVdOaGRHbHZia05oYkd3b2V3b2dJQ0FnTHk4Z0lDQmhjSEJKWkRvZ2RHaHBjeTVRY21sdmNtbDBlVjltWldWQmNIQkpaQzUyWVd4MVpTNXVZWFJwZG1Vc0NpQWdJQ0F2THlBZ0lHRndjRUZ5WjNNNklGc0tJQ0FnSUM4dklDQWdJQ0JoY21NMExtMWxkR2h2WkZObGJHVmpkRzl5S0NKa1pYQnZjMmwwVkdsd0tIVnBiblEyTkN4MWFXNTBOalFzWVdSa2NtVnpjeWtpS1N3S0lDQWdJQzh2SUNBZ0lDQnFiMkpKWkN3S0lDQWdJQzh2SUNBZ0lDQmhiVzkxYm5Rc0NpQWdJQ0F2THlBZ0lDQWdWSGh1TG5ObGJtUmxjaTVpZVhSbGN3b2dJQ0FnTHk4Z0lDQmRMQW9nSUNBZ0x5OGdJQ0JtWldVNklEQUtJQ0FnSUM4dklIMHBMbk4xWW0xcGRDZ3BPd29nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCbFpYSmZlbVZ5Ynk5amIyNTBjbUZqZEMxaGNIQXVZV3huYnk1MGN6b3pNZ29nSUNBZ0x5OGdjSFZpYkdsaklGQnlhVzl5YVhSNVgyWmxaVUZ3Y0Vsa0lEMGdRbTk0UEdGeVl6UXVWV2x1ZEU0Mk5ENG9leUJyWlhrNklDSndjbWx2Y21sMGVXWmxaVUZ3Y0Vsa0lpQjlLUW9nSUNBZ1lubDBaV05mTWlBdkx5QWljSEpwYjNKcGRIbG1aV1ZCY0hCSlpDSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d1pXVnlYM3BsY204dlkyOXVkSEpoWTNRdFlYQndMbUZzWjI4dWRITTZNVGt3Q2lBZ0lDQXZMeUJoY0hCSlpEb2dkR2hwY3k1UWNtbHZjbWwwZVY5bVpXVkJjSEJKWkM1MllXeDFaUzV1WVhScGRtVXNDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmhjM05sY25RZ0x5OGdRbTk0SUcxMWMzUWdhR0YyWlNCMllXeDFaUW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQmxaWEpmZW1WeWJ5OWpiMjUwY21GamRDMWhjSEF1WVd4bmJ5NTBjem94T1RVS0lDQWdJQzh2SUZSNGJpNXpaVzVrWlhJdVlubDBaWE1LSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d1pXVnlYM3BsY204dlkyOXVkSEpoWTNRdFlYQndMbUZzWjI4dWRITTZNVGt5Q2lBZ0lDQXZMeUJoY21NMExtMWxkR2h2WkZObGJHVmpkRzl5S0NKa1pYQnZjMmwwVkdsd0tIVnBiblEyTkN4MWFXNTBOalFzWVdSa2NtVnpjeWtpS1N3S0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBMlpERXdZVFptSUM4dklHMWxkR2h2WkNBaVpHVndiM05wZEZScGNDaDFhVzUwTmpRc2RXbHVkRFkwTEdGa1pISmxjM01wSWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdaV1Z5WDNwbGNtOHZZMjl1ZEhKaFkzUXRZWEJ3TG1Gc1oyOHVkSE02TVRnNUxURTVPQW9nSUNBZ0x5OGdhWFI0Ymk1aGNIQnNhV05oZEdsdmJrTmhiR3dvZXdvZ0lDQWdMeThnSUNCaGNIQkpaRG9nZEdocGN5NVFjbWx2Y21sMGVWOW1aV1ZCY0hCSlpDNTJZV3gxWlM1dVlYUnBkbVVzQ2lBZ0lDQXZMeUFnSUdGd2NFRnlaM002SUZzS0lDQWdJQzh2SUNBZ0lDQmhjbU0wTG0xbGRHaHZaRk5sYkdWamRHOXlLQ0prWlhCdmMybDBWR2x3S0hWcGJuUTJOQ3gxYVc1ME5qUXNZV1JrY21WemN5a2lLU3dLSUNBZ0lDOHZJQ0FnSUNCcWIySkpaQ3dLSUNBZ0lDOHZJQ0FnSUNCaGJXOTFiblFzQ2lBZ0lDQXZMeUFnSUNBZ1ZIaHVMbk5sYm1SbGNpNWllWFJsY3dvZ0lDQWdMeThnSUNCZExBb2dJQ0FnTHk4Z0lDQm1aV1U2SURBS0lDQWdJQzh2SUgwcExuTjFZbTFwZENncE93b2dJQ0FnYVc1MFkxOHlJQzh2SURZS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdaV1Z5WDNwbGNtOHZZMjl1ZEhKaFkzUXRZWEJ3TG1Gc1oyOHVkSE02TVRrM0NpQWdJQ0F2THlCbVpXVTZJREFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQmxaWEpmZW1WeWJ5OWpiMjUwY21GamRDMWhjSEF1WVd4bmJ5NTBjem94T0RrdE1UazRDaUFnSUNBdkx5QnBkSGh1TG1Gd2NHeHBZMkYwYVc5dVEyRnNiQ2g3Q2lBZ0lDQXZMeUFnSUdGd2NFbGtPaUIwYUdsekxsQnlhVzl5YVhSNVgyWmxaVUZ3Y0Vsa0xuWmhiSFZsTG01aGRHbDJaU3dLSUNBZ0lDOHZJQ0FnWVhCd1FYSm5jem9nV3dvZ0lDQWdMeThnSUNBZ0lHRnlZelF1YldWMGFHOWtVMlZzWldOMGIzSW9JbVJsY0c5emFYUlVhWEFvZFdsdWREWTBMSFZwYm5RMk5DeGhaR1J5WlhOektTSXBMQW9nSUNBZ0x5OGdJQ0FnSUdwdllrbGtMQW9nSUNBZ0x5OGdJQ0FnSUdGdGIzVnVkQ3dLSUNBZ0lDOHZJQ0FnSUNCVWVHNHVjMlZ1WkdWeUxtSjVkR1Z6Q2lBZ0lDQXZMeUFnSUYwc0NpQWdJQ0F2THlBZ0lHWmxaVG9nTUFvZ0lDQWdMeThnZlNrdWMzVmliV2wwS0NrN0NpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JsWlhKZmVtVnlieTlqYjI1MGNtRmpkQzFoY0hBdVlXeG5ieTUwY3pvNlVHVmxjbHBsY204dWNtVm1kVzVrVkdsd0tHcHZZa2xrT2lCaWVYUmxjeWtnTFQ0Z2RtOXBaRG9LY21WbWRXNWtWR2x3T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JsWlhKZmVtVnlieTlqYjI1MGNtRmpkQzFoY0hBdVlXeG5ieTUwY3pveU1ERXRNakF5Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJQzh2SUhCMVlteHBZeUJ5WldaMWJtUlVhWEFvYW05aVNXUTZJR0Z5WXpRdVZXbHVkRTQyTkNrNklIWnZhV1FnZXdvZ0lDQWdjSEp2ZEc4Z01TQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHVmxjbDk2WlhKdkwyTnZiblJ5WVdOMExXRndjQzVoYkdkdkxuUnpPakl3TXkweU1URUtJQ0FnSUM4dklHbDBlRzR1WVhCd2JHbGpZWFJwYjI1RFlXeHNLSHNLSUNBZ0lDOHZJQ0FnWVhCd1NXUTZJSFJvYVhNdVVISnBiM0pwZEhsZlptVmxRWEJ3U1dRdWRtRnNkV1V1Ym1GMGFYWmxMQW9nSUNBZ0x5OGdJQ0JoY0hCQmNtZHpPaUJiQ2lBZ0lDQXZMeUFnSUNBZ1lYSmpOQzV0WlhSb2IyUlRaV3hsWTNSdmNpZ2ljbVZtZFc1a1ZHbHdLSFZwYm5RMk5DeGhaR1J5WlhOektTSXBMQW9nSUNBZ0x5OGdJQ0FnSUdwdllrbGtMQW9nSUNBZ0x5OGdJQ0FnSUZSNGJpNXpaVzVrWlhJdVlubDBaWE1LSUNBZ0lDOHZJQ0FnWFN3S0lDQWdJQzh2SUNBZ1ptVmxPaUF3Q2lBZ0lDQXZMeUI5S1M1emRXSnRhWFFvS1RzS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdaV1Z5WDNwbGNtOHZZMjl1ZEhKaFkzUXRZWEJ3TG1Gc1oyOHVkSE02TXpJS0lDQWdJQzh2SUhCMVlteHBZeUJRY21sdmNtbDBlVjltWldWQmNIQkpaQ0E5SUVKdmVEeGhjbU0wTGxWcGJuUk9OalErS0hzZ2EyVjVPaUFpY0hKcGIzSnBkSGxtWldWQmNIQkpaQ0lnZlNrS0lDQWdJR0o1ZEdWalh6SWdMeThnSW5CeWFXOXlhWFI1Wm1WbFFYQndTV1FpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR1ZsY2w5NlpYSnZMMk52Ym5SeVlXTjBMV0Z3Y0M1aGJHZHZMblJ6T2pJd05Bb2dJQ0FnTHk4Z1lYQndTV1E2SUhSb2FYTXVVSEpwYjNKcGRIbGZabVZsUVhCd1NXUXVkbUZzZFdVdWJtRjBhWFpsTEFvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWVhOelpYSjBJQzh2SUVKdmVDQnRkWE4wSUdoaGRtVWdkbUZzZFdVS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WldWeVgzcGxjbTh2WTI5dWRISmhZM1F0WVhCd0xtRnNaMjh1ZEhNNk1qQTRDaUFnSUNBdkx5QlVlRzR1YzJWdVpHVnlMbUo1ZEdWekNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR1ZsY2w5NlpYSnZMMk52Ym5SeVlXTjBMV0Z3Y0M1aGJHZHZMblJ6T2pJd05nb2dJQ0FnTHk4Z1lYSmpOQzV0WlhSb2IyUlRaV3hsWTNSdmNpZ2ljbVZtZFc1a1ZHbHdLSFZwYm5RMk5DeGhaR1J5WlhOektTSXBMQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNMkV4TnpOaVpUY2dMeThnYldWMGFHOWtJQ0p5WldaMWJtUlVhWEFvZFdsdWREWTBMR0ZrWkhKbGMzTXBJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WldWeVgzcGxjbTh2WTI5dWRISmhZM1F0WVhCd0xtRnNaMjh1ZEhNNk1qQXpMVEl4TVFvZ0lDQWdMeThnYVhSNGJpNWhjSEJzYVdOaGRHbHZia05oYkd3b2V3b2dJQ0FnTHk4Z0lDQmhjSEJKWkRvZ2RHaHBjeTVRY21sdmNtbDBlVjltWldWQmNIQkpaQzUyWVd4MVpTNXVZWFJwZG1Vc0NpQWdJQ0F2THlBZ0lHRndjRUZ5WjNNNklGc0tJQ0FnSUM4dklDQWdJQ0JoY21NMExtMWxkR2h2WkZObGJHVmpkRzl5S0NKeVpXWjFibVJVYVhBb2RXbHVkRFkwTEdGa1pISmxjM01wSWlrc0NpQWdJQ0F2THlBZ0lDQWdhbTlpU1dRc0NpQWdJQ0F2THlBZ0lDQWdWSGh1TG5ObGJtUmxjaTVpZVhSbGN3b2dJQ0FnTHk4Z0lDQmRMQW9nSUNBZ0x5OGdJQ0JtWldVNklEQUtJQ0FnSUM4dklIMHBMbk4xWW0xcGRDZ3BPd29nSUNBZ2FXNTBZMTh5SUM4dklEWUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WldWeVgzcGxjbTh2WTI5dWRISmhZM1F0WVhCd0xtRnNaMjh1ZEhNNk1qRXdDaUFnSUNBdkx5Qm1aV1U2SURBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JsWlhKZmVtVnlieTlqYjI1MGNtRmpkQzFoY0hBdVlXeG5ieTUwY3pveU1ETXRNakV4Q2lBZ0lDQXZMeUJwZEhodUxtRndjR3hwWTJGMGFXOXVRMkZzYkNoN0NpQWdJQ0F2THlBZ0lHRndjRWxrT2lCMGFHbHpMbEJ5YVc5eWFYUjVYMlpsWlVGd2NFbGtMblpoYkhWbExtNWhkR2wyWlN3S0lDQWdJQzh2SUNBZ1lYQndRWEpuY3pvZ1d3b2dJQ0FnTHk4Z0lDQWdJR0Z5WXpRdWJXVjBhRzlrVTJWc1pXTjBiM0lvSW5KbFpuVnVaRlJwY0NoMWFXNTBOalFzWVdSa2NtVnpjeWtpS1N3S0lDQWdJQzh2SUNBZ0lDQnFiMkpKWkN3S0lDQWdJQzh2SUNBZ0lDQlVlRzR1YzJWdVpHVnlMbUo1ZEdWekNpQWdJQ0F2THlBZ0lGMHNDaUFnSUNBdkx5QWdJR1psWlRvZ01Bb2dJQ0FnTHk4Z2ZTa3VjM1ZpYldsMEtDazdDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCbFpYSmZlbVZ5Ynk5amIyNTBjbUZqZEMxaGNIQXVZV3huYnk1MGN6bzZVR1ZsY2xwbGNtOHVjbVZzWldGelpWUnBjQ2hxYjJKSlpEb2dZbmwwWlhNcElDMCtJSFp2YVdRNkNuSmxiR1ZoYzJWVWFYQTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHVmxjbDk2WlhKdkwyTnZiblJ5WVdOMExXRndjQzVoYkdkdkxuUnpPakl4TkMweU1UVUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ0x5OGdjSFZpYkdsaklISmxiR1ZoYzJWVWFYQW9hbTlpU1dRNklHRnlZelF1VldsdWRFNDJOQ2s2SUhadmFXUWdld29nSUNBZ2NISnZkRzhnTVNBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0dWbGNsOTZaWEp2TDJOdmJuUnlZV04wTFdGd2NDNWhiR2R2TG5Sek9qSXhOaTB5TWpRS0lDQWdJQzh2SUdsMGVHNHVZWEJ3YkdsallYUnBiMjVEWVd4c0tIc0tJQ0FnSUM4dklDQWdZWEJ3U1dRNklIUm9hWE11VUhKcGIzSnBkSGxmWm1WbFFYQndTV1F1ZG1Gc2RXVXVibUYwYVhabExBb2dJQ0FnTHk4Z0lDQmhjSEJCY21kek9pQmJDaUFnSUNBdkx5QWdJQ0FnWVhKak5DNXRaWFJvYjJSVFpXeGxZM1J2Y2lnaWNtVnNaV0Z6WlZScGNDaDFhVzUwTmpRc1lXUmtjbVZ6Y3lraUtTd0tJQ0FnSUM4dklDQWdJQ0JxYjJKSlpDd0tJQ0FnSUM4dklDQWdJQ0JVZUc0dWMyVnVaR1Z5TG1KNWRHVnpDaUFnSUNBdkx5QWdJRjBzQ2lBZ0lDQXZMeUFnSUdabFpUb2dNQW9nSUNBZ0x5OGdmU2t1YzNWaWJXbDBLQ2s3Q2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHVmxjbDk2WlhKdkwyTnZiblJ5WVdOMExXRndjQzVoYkdkdkxuUnpPak15Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdVSEpwYjNKcGRIbGZabVZsUVhCd1NXUWdQU0JDYjNnOFlYSmpOQzVWYVc1MFRqWTBQaWg3SUd0bGVUb2dJbkJ5YVc5eWFYUjVabVZsUVhCd1NXUWlJSDBwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0p3Y21sdmNtbDBlV1psWlVGd2NFbGtJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQmxaWEpmZW1WeWJ5OWpiMjUwY21GamRDMWhjSEF1WVd4bmJ5NTBjem95TVRjS0lDQWdJQzh2SUdGd2NFbGtPaUIwYUdsekxsQnlhVzl5YVhSNVgyWmxaVUZ3Y0Vsa0xuWmhiSFZsTG01aGRHbDJaU3dLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0Z6YzJWeWRDQXZMeUJDYjNnZ2JYVnpkQ0JvWVhabElIWmhiSFZsQ2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR1ZsY2w5NlpYSnZMMk52Ym5SeVlXTjBMV0Z3Y0M1aGJHZHZMblJ6T2pJeU1Rb2dJQ0FnTHk4Z1ZIaHVMbk5sYm1SbGNpNWllWFJsY3dvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQmxaWEpmZW1WeWJ5OWpiMjUwY21GamRDMWhjSEF1WVd4bmJ5NTBjem95TVRrS0lDQWdJQzh2SUdGeVl6UXViV1YwYUc5a1UyVnNaV04wYjNJb0luSmxiR1ZoYzJWVWFYQW9kV2x1ZERZMExHRmtaSEpsYzNNcElpa3NDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZzNNVGs0TW1VeVppQXZMeUJ0WlhSb2IyUWdJbkpsYkdWaGMyVlVhWEFvZFdsdWREWTBMR0ZrWkhKbGMzTXBJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WldWeVgzcGxjbTh2WTI5dWRISmhZM1F0WVhCd0xtRnNaMjh1ZEhNNk1qRTJMVEl5TkFvZ0lDQWdMeThnYVhSNGJpNWhjSEJzYVdOaGRHbHZia05oYkd3b2V3b2dJQ0FnTHk4Z0lDQmhjSEJKWkRvZ2RHaHBjeTVRY21sdmNtbDBlVjltWldWQmNIQkpaQzUyWVd4MVpTNXVZWFJwZG1Vc0NpQWdJQ0F2THlBZ0lHRndjRUZ5WjNNNklGc0tJQ0FnSUM4dklDQWdJQ0JoY21NMExtMWxkR2h2WkZObGJHVmpkRzl5S0NKeVpXeGxZWE5sVkdsd0tIVnBiblEyTkN4aFpHUnlaWE56S1NJcExBb2dJQ0FnTHk4Z0lDQWdJR3B2WWtsa0xBb2dJQ0FnTHk4Z0lDQWdJRlI0Ymk1elpXNWtaWEl1WW5sMFpYTUtJQ0FnSUM4dklDQWdYU3dLSUNBZ0lDOHZJQ0FnWm1WbE9pQXdDaUFnSUNBdkx5QjlLUzV6ZFdKdGFYUW9LVHNLSUNBZ0lHbHVkR05mTWlBdkx5QTJDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0dWbGNsOTZaWEp2TDJOdmJuUnlZV04wTFdGd2NDNWhiR2R2TG5Sek9qSXlNd29nSUNBZ0x5OGdabVZsT2lBd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WldWeVgzcGxjbTh2WTI5dWRISmhZM1F0WVhCd0xtRnNaMjh1ZEhNNk1qRTJMVEl5TkFvZ0lDQWdMeThnYVhSNGJpNWhjSEJzYVdOaGRHbHZia05oYkd3b2V3b2dJQ0FnTHk4Z0lDQmhjSEJKWkRvZ2RHaHBjeTVRY21sdmNtbDBlVjltWldWQmNIQkpaQzUyWVd4MVpTNXVZWFJwZG1Vc0NpQWdJQ0F2THlBZ0lHRndjRUZ5WjNNNklGc0tJQ0FnSUM4dklDQWdJQ0JoY21NMExtMWxkR2h2WkZObGJHVmpkRzl5S0NKeVpXeGxZWE5sVkdsd0tIVnBiblEyTkN4aFpHUnlaWE56S1NJcExBb2dJQ0FnTHk4Z0lDQWdJR3B2WWtsa0xBb2dJQ0FnTHk4Z0lDQWdJRlI0Ymk1elpXNWtaWEl1WW5sMFpYTUtJQ0FnSUM4dklDQWdYU3dLSUNBZ0lDOHZJQ0FnWm1WbE9pQXdDaUFnSUNBdkx5QjlLUzV6ZFdKdGFYUW9LVHNLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCeVpYUnpkV0lLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFGQUFFR0NOQUJKZ2tFRlI5OGRSRnRaV05vVW1WbmFYTjBaWEpCY0hCSlpCQndjbWx2Y21sMGVXWmxaVUZ3Y0Vsa0NHcHZZa052ZFc1MEEycHZZZ0dBQ0FBQUFBQUFBQUFBQVFBRW41a1pQakViUVFFc2dnc0VEYWw3NHdTSlRFY1VCSlJIZURRRVNkQnpMd1M5dVRiMEJFaUpMUDhFbUlXMkpRVCtrR3ErQk5ZeTZPY0Uxb0M2N2dSSzMzOXlOaG9BamdzQXhBQ3hBSlFBZXdCb0FGVUFRZ0F5QUNBQUVRQUNJa014R1JSRU1SaEVOaG9CaUFNMUkwTXhHUlJFTVJoRU5ob0JpQU1FSTBNeEdSUkVNUmhFTmhvQk5ob0NpQUxISTBNeEdSUkVNUmhFaUFLdEtFeFFzQ05ETVJrVVJERVlSRFlhQVlnQ2lpaE1VTEFqUXpFWkZFUXhHRVEyR2dHSUFpa29URkN3STBNeEdSUkVNUmhFTmhvQmlBRjRLRXhRc0NORE1Sa1VSREVZUkRZYUFUWWFBallhQTRnQThpaE1VTEFqUXpFWkZFUXhHRVEyR2dFeEZpTUpTVGdRSXhKRWlBQnBLRXhRc0NORE1Sa1VSREVZUkRZYUFZZ0FOU2hNVUxBalF6RVpGRVF4R0VRMkdnRVhOaG9DRjRnQURTTkRNUmxBL3lNeEdCUkVJME9LQWdDTC9oWXBUTCtML3hZcVRMK0ppZ0VCS2IxRkFVUXB2a1FYc1NjSXNocUwvN0lhc2hna3NoQWlzZ0d6dEQ2SmlnSUJNUUNML3pnSWkvNVhDQWhNaS80bFd3OUVpLzg0QnpJS0VrUXJ2VVVCUVFCREs3NUVpLzZCRUZtTC9oV0wvazRDVWpJSEZrOENTVTRDaXdGUWdBSUFRMUJNVUNjRlVDY0dVSXNBVUU4Q1VDY0VTd0pRU2J4SVRMOUpGeU1JRml0TXY0d0FpU2NHUXYrN2lnTUJKd1NML1ZCSEFyMUZBVVJKdmtRaEJGTW5CeUpQQWxRaVUwUkp2a1NCRWxzeUJ3OUVpLzZJLzBjaVUwUytSQ1ZiUVFBTGkvOFhpd0MrUkNWYkRFU0xBRW0rUkl2L1hBaExBYnhJU3dGTXYwbStSSXYrWEJ0TEFieElTd0ZNdjBtK1JFc0J2RWkvSndWTWlZb0JBU2NFaS85UVNiMUZBVVJKdmtRaEJGTW5CeUpQQWxRaVUwUkp2a1NCRzF0RVNiNUVJUVFpVkVzQnZFaExBVXkvU2I1RVN3RzhTRXNCVEw4cHZVVUJSQ20rUkJleFN3RytSRmNiQ0NjSXNocXlHa215R0NTeUVDS3lBYk8wUGxjT0lMRkxBcjVFSlZ1eUNMSUhJN0lRSXJJQnM3Rk12a1JYR3dpQUJCZVFXekN5R3JJYWdBZ0FBQUFBQUFBQUFiSWFzaGdrc2hBaXNnR3pKd1dKaWdFQkp3U0wvMUJKdlVVQlJFbStSQ0VFVXljSElrOENWQ0pUUkxGSnZrUlhJeUJMQWI1RUpWdXlDTElISTdJUUlySUJzMG0rUkNFRUlsUkxBYnhJU3dGTXYwbStSRXNCdkVpL0p3V0ppZ0VCSndTTC8xQkp2VVVCUkw1RWlTdTlSUUZCQUFRcnZrU0pKd2FKaWdJQUtyMUZBVVN4S3I1RUZ6RUFnQVFHMFFwdnNocUwvcklhaS8reUdySWFzaGdrc2hBaXNnR3ppWW9CQUxFcXZrUVhNUUNBQkRvWE8rZXlHb3Yvc2hxeUdySVlKTElRSXJJQnM0bUtBUUN4S3I1RUZ6RUFnQVJ4bUM0dnNocUwvN0lhc2hxeUdDU3lFQ0t5QWJPSiIsImNsZWFyIjoiQ29FQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NCwibWlub3IiOjcsInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
