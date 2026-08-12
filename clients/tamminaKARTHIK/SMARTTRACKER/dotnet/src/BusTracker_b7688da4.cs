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

namespace Arc56.Generated.tamminaKARTHIK.SMARTTRACKER.BusTracker_b7688da4
{


    public class BusTrackerProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public BusTrackerProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class GetTrackingAccessReturn : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public ulong Field1 { get; set; }

                public byte[] Field2 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vField2.From(Field2);
                    ret.AddRange(vField2.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static GetTrackingAccessReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetTrackingAccessReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is ulong vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is ulong vField1Value) { ret.Field1 = vField1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is byte[] vField2Value) { ret.Field2 = vField2Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetTrackingAccessReturn);
                }
                public bool Equals(GetTrackingAccessReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetTrackingAccessReturn left, GetTrackingAccessReturn right)
                {
                    return EqualityComparer<GetTrackingAccessReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetTrackingAccessReturn left, GetTrackingAccessReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="pay_txn"> </param>
        /// <param name="bus_id"> </param>
        /// <param name="route_id"> </param>
        /// <param name="duration_seconds"> </param>
        public async Task CreateTrackingAccess(PaymentTransaction pay_txn, byte[] bus_id, byte[] route_id, ulong duration_seconds, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { pay_txn });
            byte[] abiHandle = { 248, 88, 30, 156 };
            var bus_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); bus_idAbi.From(bus_id);
            var route_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); route_idAbi.From(route_id);
            var duration_secondsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); duration_secondsAbi.From(duration_seconds);

            var result = await base.CallApp(new List<object> { abiHandle, pay_txn, bus_idAbi, route_idAbi, duration_secondsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateTrackingAccess_Transactions(PaymentTransaction pay_txn, byte[] bus_id, byte[] route_id, ulong duration_seconds, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { pay_txn });
            byte[] abiHandle = { 248, 88, 30, 156 };
            var bus_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); bus_idAbi.From(bus_id);
            var route_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); route_idAbi.From(route_id);
            var duration_secondsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); duration_secondsAbi.From(duration_seconds);

            return await base.MakeTransactionList(new List<object> { abiHandle, pay_txn, bus_idAbi, route_idAbi, duration_secondsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="user"> </param>
        /// <param name="bus_id"> </param>
        public async Task<ulong> IsTrackingAccessValid(Algorand.Address user, byte[] bus_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 203, 210, 124, 129 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);
            var bus_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); bus_idAbi.From(bus_id);

            var result = await base.CallApp(new List<object> { abiHandle, userAbi, bus_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IsTrackingAccessValid_Transactions(Algorand.Address user, byte[] bus_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 203, 210, 124, 129 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);
            var bus_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); bus_idAbi.From(bus_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, userAbi, bus_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="user"> </param>
        /// <param name="bus_id"> </param>
        public async Task<Structs.GetTrackingAccessReturn> GetTrackingAccess(Algorand.Address user, byte[] bus_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 201, 123, 20, 131 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);
            var bus_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); bus_idAbi.From(bus_id);

            var result = await base.CallApp(new List<object> { abiHandle, userAbi, bus_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetTrackingAccessReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetTrackingAccess_Transactions(Algorand.Address user, byte[] bus_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 201, 123, 20, 131 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);
            var bus_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); bus_idAbi.From(bus_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, userAbi, bus_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="user"> </param>
        /// <param name="bus_id"> </param>
        public async Task ExpireTrackingAccess(Algorand.Address user, byte[] bus_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 215, 108, 24, 10 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);
            var bus_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); bus_idAbi.From(bus_id);

            var result = await base.CallApp(new List<object> { abiHandle, userAbi, bus_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ExpireTrackingAccess_Transactions(Algorand.Address user, byte[] bus_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 215, 108, 24, 10 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);
            var bus_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); bus_idAbi.From(bus_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, userAbi, bus_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="activity_type"> </param>
        /// <param name="bus_id"> </param>
        public async Task RecordUserActivity(byte[] activity_type, byte[] bus_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 16, 4, 34, 196 };
            var activity_typeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); activity_typeAbi.From(activity_type);
            var bus_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); bus_idAbi.From(bus_id);

            var result = await base.CallApp(new List<object> { abiHandle, activity_typeAbi, bus_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RecordUserActivity_Transactions(byte[] activity_type, byte[] bus_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 16, 4, 34, 196 };
            var activity_typeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); activity_typeAbi.From(activity_type);
            var bus_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); bus_idAbi.From(bus_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, activity_typeAbi, bus_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQnVzVHJhY2tlciIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJHZXRUcmFja2luZ0FjY2Vzc1JldHVybiI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQyIiwidHlwZSI6ImJ5dGVbXSJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGVfdHJhY2tpbmdfYWNjZXNzIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheV90eG4iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJ1c19pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoicm91dGVfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImR1cmF0aW9uX3NlY29uZHMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiaXNfdHJhY2tpbmdfYWNjZXNzX3ZhbGlkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ1c2VyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJidXNfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfdHJhY2tpbmdfYWNjZXNzIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ1c2VyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJidXNfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQsYnl0ZVtdKSIsInN0cnVjdCI6IkdldFRyYWNraW5nQWNjZXNzUmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZXhwaXJlX3RyYWNraW5nX2FjY2VzcyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidXNlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYnVzX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlY29yZF91c2VyX2FjdGl2aXR5IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFjdGl2aXR5X3R5cGUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJ1c19pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzE3NV0sImVycm9yTWVzc2FnZSI6IkluY29ycmVjdCBwYXltZW50IGFtb3VudCBmb3IgdHJhY2tpbmcgZHVyYXRpb24iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNThdLCJlcnJvck1lc3NhZ2UiOiJQYXltZW50IHJlY2VpdmVyIG11c3QgYmUgYXBwIGFkZHJlc3MiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNzZdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnJvdXRlX2lkcyBlbnRyeSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNjldLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnN0YXJ0X3RpbWVzIGVudHJ5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwOSwxMjcsMjQ3LDMwNSwzOTksNDY4LDQ4NF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExNiwxMzQsMjU0LDMxMiw0MDYsNDc1LDQ5MV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNDEsMjk5LDM5M10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNDhdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDNdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIHBheSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXdJREVnTWlBek1nb2dJQ0FnWW5sMFpXTmliRzlqYXlBd2VEWTFOemczTUNBd2VEY3pOelEyTVRjeU56UWdNSGczTWpabU56VTNORFkxSURCNE1UVXhaamRqTnpVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpZFhOZmRISmhZMnRsY2k5amIyNTBjbUZqZEM1d2VUbzBDaUFnSUNBdkx5QmpiR0Z6Y3lCQ2RYTlVjbUZqYTJWeUtFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzRnVG5WdFFYQndRWEpuY3dvZ0lDQWdZbm9nYldGcGJsOWZYMkZzWjI5d2VWOWtaV1poZFd4MFgyTnlaV0YwWlVBeE5Bb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMENpQWdJQ0J3ZFhOb1lubDBaWE56SURCNFpqZzFPREZsT1dNZ01IaGpZbVF5TjJNNE1TQXdlR001TjJJeE5EZ3pJREI0WkRjMll6RTRNR0VnTUhneE1EQTBNakpqTkNBdkx5QnRaWFJvYjJRZ0ltTnlaV0YwWlY5MGNtRmphMmx1WjE5aFkyTmxjM01vY0dGNUxHSjVkR1ZiWFN4aWVYUmxXMTBzZFdsdWREWTBLWFp2YVdRaUxDQnRaWFJvYjJRZ0ltbHpYM1J5WVdOcmFXNW5YMkZqWTJWemMxOTJZV3hwWkNoaFpHUnlaWE56TEdKNWRHVmJYU2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbWRsZEY5MGNtRmphMmx1WjE5aFkyTmxjM01vWVdSa2NtVnpjeXhpZVhSbFcxMHBLSFZwYm5RMk5DeDFhVzUwTmpRc1lubDBaVnRkS1NJc0lHMWxkR2h2WkNBaVpYaHdhWEpsWDNSeVlXTnJhVzVuWDJGalkyVnpjeWhoWkdSeVpYTnpMR0o1ZEdWYlhTbDJiMmxrSWl3Z2JXVjBhRzlrSUNKeVpXTnZjbVJmZFhObGNsOWhZM1JwZG1sMGVTaGllWFJsVzEwc1lubDBaVnRkS1hadmFXUWlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0JqY21WaGRHVmZkSEpoWTJ0cGJtZGZZV05qWlhOeklHbHpYM1J5WVdOcmFXNW5YMkZqWTJWemMxOTJZV3hwWkNCblpYUmZkSEpoWTJ0cGJtZGZZV05qWlhOeklHVjRjR2x5WlY5MGNtRmphMmx1WjE5aFkyTmxjM01nY21WamIzSmtYM1Z6WlhKZllXTjBhWFpwZEhrS0lDQWdJR1Z5Y2dvS2JXRnBibDlmWDJGc1oyOXdlVjlrWldaaGRXeDBYMk55WldGMFpVQXhORG9LSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0FoQ2lBZ0lDQW1KZ29nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxtSjFjMTkwY21GamEyVnlMbU52Ym5SeVlXTjBMa0oxYzFSeVlXTnJaWEl1WTNKbFlYUmxYM1J5WVdOcmFXNW5YMkZqWTJWemMxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbU55WldGMFpWOTBjbUZqYTJsdVoxOWhZMk5sYzNNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW5WelgzUnlZV05yWlhJdlkyOXVkSEpoWTNRdWNIazZNVEVLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCa2RYQnVJRElLSUNBZ0lHZDBlRzV6SUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdjR0Y1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklIUnlZVzV6WVdOMGFXOXVJSFI1Y0dVZ2FYTWdjR0Y1Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6SWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJR052ZG1WeUlETUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCa2RYQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkoxYzE5MGNtRmphMlZ5TDJOdmJuUnlZV04wTG5CNU9qRTVMVEl3Q2lBZ0lDQXZMeUFqSURFdUlGWmxjbWxtZVNCMGFHVWdjR0Y1YldWdWRDQjBjbUZ1YzJGamRHbHZiaUJwY3lCamIzSnlaV04wQ2lBZ0lDQXZMeUJoYzNObGNuUWdjR0Y1WDNSNGJpNXlaV05sYVhabGNpQTlQU0JIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMQ0FpVUdGNWJXVnVkQ0J5WldObGFYWmxjaUJ0ZFhOMElHSmxJR0Z3Y0NCaFpHUnlaWE56SWdvZ0lDQWdaM1I0Ym5NZ1VtVmpaV2wyWlhJS0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRkJoZVcxbGJuUWdjbVZqWldsMlpYSWdiWFZ6ZENCaVpTQmhjSEFnWVdSa2NtVnpjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySjFjMTkwY21GamEyVnlMMk52Ym5SeVlXTjBMbkI1T2pJM0NpQWdJQ0F2THlCcFppQmtkWEpoZEdsdmJsOXpaV052Ym1SeklEdzlJRGt3TURvS0lDQWdJSEIxYzJocGJuUWdPVEF3Q2lBZ0lDQThQUW9nSUNBZ1lub2dZM0psWVhSbFgzUnlZV05yYVc1blgyRmpZMlZ6YzE5bGJITmxYMkp2WkhsQU13b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKMWMxOTBjbUZqYTJWeUwyTnZiblJ5WVdOMExuQjVPakk0Q2lBZ0lDQXZMeUJsZUhCbFkzUmxaRjl3Y21salpTQTlJRlZKYm5RMk5DZ3hNREJmTURBd0tRb2dJQ0FnY0hWemFHbHVkQ0F4TURBd01EQUtDbU55WldGMFpWOTBjbUZqYTJsdVoxOWhZMk5sYzNOZllXWjBaWEpmYVdaZlpXeHpaVUEzT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkoxYzE5MGNtRmphMlZ5TDJOdmJuUnlZV04wTG5CNU9qTTBDaUFnSUNBdkx5QmhjM05sY25RZ2NHRjVYM1I0Ymk1aGJXOTFiblFnUGowZ1pYaHdaV04wWldSZmNISnBZMlVzSUNKSmJtTnZjbkpsWTNRZ2NHRjViV1Z1ZENCaGJXOTFiblFnWm05eUlIUnlZV05yYVc1bklHUjFjbUYwYVc5dUlnb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQm5kSGh1Y3lCQmJXOTFiblFLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z1NXNWpiM0p5WldOMElIQmhlVzFsYm5RZ1lXMXZkVzUwSUdadmNpQjBjbUZqYTJsdVp5QmtkWEpoZEdsdmJnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKMWMxOTBjbUZqYTJWeUwyTnZiblJ5WVdOMExuQjVPak0yTFRNM0NpQWdJQ0F2THlBaklETXVJRk4wYjNKbElHRjFkR2h2Y21sNllYUnBiMjRnWkdWMFlXbHNjd29nSUNBZ0x5OGdhMlY1SUQwZ1ZIaHVMbk5sYm1SbGNpNWllWFJsY3lBcklHSjFjMTlwWkFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWRYTmZkSEpoWTJ0bGNpOWpiMjUwY21GamRDNXdlVG96T0FvZ0lDQWdMeThnYzJWc1ppNWxlSEJwY25sZmRHbHRaWE5iYTJWNVhTQTlJRWRzYjJKaGJDNXNZWFJsYzNSZmRHbHRaWE4wWVcxd0lDc2daSFZ5WVhScGIyNWZjMlZqYjI1a2N3b2dJQ0FnWjJ4dlltRnNJRXhoZEdWemRGUnBiV1Z6ZEdGdGNBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQXJDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjROalUzT0Rjd0NpQWdJQ0JrYVdjZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCcGRHOWlDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZblZ6WDNSeVlXTnJaWEl2WTI5dWRISmhZM1F1Y0hrNk16a0tJQ0FnSUM4dklITmxiR1l1YzNSaGNuUmZkR2x0WlhOYmEyVjVYU0E5SUVkc2IySmhiQzVzWVhSbGMzUmZkR2x0WlhOMFlXMXdDaUFnSUNCbmJHOWlZV3dnVEdGMFpYTjBWR2x0WlhOMFlXMXdDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjROek0zTkRZeE56STNOQW9nSUNBZ1pHbG5JRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKMWMxOTBjbUZqYTJWeUwyTnZiblJ5WVdOMExuQjVPalF3Q2lBZ0lDQXZMeUJ6Wld4bUxuSnZkWFJsWDJsa2MxdHJaWGxkSUQwZ2NtOTFkR1ZmYVdRS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhnM01qWm1OelUzTkRZMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNCemQyRndDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZblZ6WDNSeVlXTnJaWEl2WTI5dWRISmhZM1F1Y0hrNk1URUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LWTNKbFlYUmxYM1J5WVdOcmFXNW5YMkZqWTJWemMxOWxiSE5sWDJKdlpIbEFNem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWlkWE5mZEhKaFkydGxjaTlqYjI1MGNtRmpkQzV3ZVRveU9Rb2dJQ0FnTHk4Z1pXeHBaaUJrZFhKaGRHbHZibDl6WldOdmJtUnpJRHc5SURFNE1EQTZDaUFnSUNCa2RYQUtJQ0FnSUhCMWMyaHBiblFnTVRnd01Bb2dJQ0FnUEQwS0lDQWdJR0o2SUdOeVpXRjBaVjkwY21GamEybHVaMTloWTJObGMzTmZaV3h6WlY5aWIyUjVRRFVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWlkWE5mZEhKaFkydGxjaTlqYjI1MGNtRmpkQzV3ZVRvek1Bb2dJQ0FnTHk4Z1pYaHdaV04wWldSZmNISnBZMlVnUFNCVlNXNTBOalFvTVRVd1h6QXdNQ2tLSUNBZ0lIQjFjMmhwYm5RZ01UVXdNREF3Q2lBZ0lDQmlJR055WldGMFpWOTBjbUZqYTJsdVoxOWhZMk5sYzNOZllXWjBaWEpmYVdaZlpXeHpaVUEzQ2dwamNtVmhkR1ZmZEhKaFkydHBibWRmWVdOalpYTnpYMlZzYzJWZlltOWtlVUExT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkoxYzE5MGNtRmphMlZ5TDJOdmJuUnlZV04wTG5CNU9qTXlDaUFnSUNBdkx5QmxlSEJsWTNSbFpGOXdjbWxqWlNBOUlGVkpiblEyTkNneU5UQmZNREF3S1FvZ0lDQWdjSFZ6YUdsdWRDQXlOVEF3TURBS0lDQWdJR0lnWTNKbFlYUmxYM1J5WVdOcmFXNW5YMkZqWTJWemMxOWhablJsY2w5cFpsOWxiSE5sUURjS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVZblZ6WDNSeVlXTnJaWEl1WTI5dWRISmhZM1F1UW5WelZISmhZMnRsY2k1cGMxOTBjbUZqYTJsdVoxOWhZMk5sYzNOZmRtRnNhV1JiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwcGMxOTBjbUZqYTJsdVoxOWhZMk5sYzNOZmRtRnNhV1E2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZblZ6WDNSeVlXTnJaWEl2WTI5dWRISmhZM1F1Y0hrNk5ESUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkoxYzE5MGNtRmphMlZ5TDJOdmJuUnlZV04wTG5CNU9qUTBDaUFnSUNBdkx5QnJaWGtnUFNCMWMyVnlMbUo1ZEdWeklDc2dZblZ6WDJsa0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWRYTmZkSEpoWTJ0bGNpOWpiMjUwY21GamRDNXdlVG8wTlFvZ0lDQWdMeThnWlhod2FYSjVMQ0JsZUdsemRITWdQU0J6Wld4bUxtVjRjR2x5ZVY5MGFXMWxjeTV0WVhsaVpTaHJaWGtwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TmpVM09EY3dDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJSE4zWVhBS0lDQWdJR0owYjJrS0lDQWdJSE4zWVhBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpZFhOZmRISmhZMnRsY2k5amIyNTBjbUZqZEM1d2VUbzBOZ29nSUNBZ0x5OGdhV1lnYm05MElHVjRhWE4wY3pvS0lDQWdJR0p1ZWlCcGMxOTBjbUZqYTJsdVoxOWhZMk5sYzNOZmRtRnNhV1JmWVdaMFpYSmZhV1pmWld4elpVQXpDaUFnSUNCd2IzQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWRYTmZkSEpoWTJ0bGNpOWpiMjUwY21GamRDNXdlVG8wTndvZ0lDQWdMeThnY21WMGRYSnVJRlZKYm5RMk5DZ3dLUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtDbWx6WDNSeVlXTnJhVzVuWDJGalkyVnpjMTkyWVd4cFpGOWhablJsY2w5cGJteHBibVZrWDNOdFlYSjBYMk52Ym5SeVlXTjBjeTVpZFhOZmRISmhZMnRsY2k1amIyNTBjbUZqZEM1Q2RYTlVjbUZqYTJWeUxtbHpYM1J5WVdOcmFXNW5YMkZqWTJWemMxOTJZV3hwWkVBMk9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKMWMxOTBjbUZqYTJWeUwyTnZiblJ5WVdOMExuQjVPalF5Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtbHpYM1J5WVdOcmFXNW5YMkZqWTJWemMxOTJZV3hwWkY5aFpuUmxjbDlwWmw5bGJITmxRRE02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZblZ6WDNSeVlXTnJaWEl2WTI5dWRISmhZM1F1Y0hrNk5Ea0tJQ0FnSUM4dklHbG1JRWRzYjJKaGJDNXNZWFJsYzNSZmRHbHRaWE4wWVcxd0lEd2daWGh3YVhKNU9nb2dJQ0FnWjJ4dlltRnNJRXhoZEdWemRGUnBiV1Z6ZEdGdGNBb2dJQ0FnUGdvZ0lDQWdZbm9nYVhOZmRISmhZMnRwYm1kZllXTmpaWE56WDNaaGJHbGtYMlZzYzJWZlltOWtlVUExQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZblZ6WDNSeVlXTnJaWEl2WTI5dWRISmhZM1F1Y0hrNk5UQUtJQ0FnSUM4dklISmxkSFZ5YmlCVlNXNTBOalFvTVNrS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZblZ6WDNSeVlXTnJaWEl2WTI5dWRISmhZM1F1Y0hrNk5ESUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ1lpQnBjMTkwY21GamEybHVaMTloWTJObGMzTmZkbUZzYVdSZllXWjBaWEpmYVc1c2FXNWxaRjl6YldGeWRGOWpiMjUwY21GamRITXVZblZ6WDNSeVlXTnJaWEl1WTI5dWRISmhZM1F1UW5WelZISmhZMnRsY2k1cGMxOTBjbUZqYTJsdVoxOWhZMk5sYzNOZmRtRnNhV1JBTmdvS2FYTmZkSEpoWTJ0cGJtZGZZV05qWlhOelgzWmhiR2xrWDJWc2MyVmZZbTlrZVVBMU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKMWMxOTBjbUZqYTJWeUwyTnZiblJ5WVdOMExuQjVPalV5Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdWVWx1ZERZMEtEQXBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKMWMxOTBjbUZqYTJWeUwyTnZiblJ5WVdOMExuQjVPalF5Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJR0lnYVhOZmRISmhZMnRwYm1kZllXTmpaWE56WDNaaGJHbGtYMkZtZEdWeVgybHViR2x1WldSZmMyMWhjblJmWTI5dWRISmhZM1J6TG1KMWMxOTBjbUZqYTJWeUxtTnZiblJ5WVdOMExrSjFjMVJ5WVdOclpYSXVhWE5mZEhKaFkydHBibWRmWVdOalpYTnpYM1poYkdsa1FEWUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11WW5WelgzUnlZV05yWlhJdVkyOXVkSEpoWTNRdVFuVnpWSEpoWTJ0bGNpNW5aWFJmZEhKaFkydHBibWRmWVdOalpYTnpXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWjJWMFgzUnlZV05yYVc1blgyRmpZMlZ6Y3pvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpZFhOZmRISmhZMnRsY2k5amIyNTBjbUZqZEM1d2VUbzFOQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW5WelgzUnlZV05yWlhJdlkyOXVkSEpoWTNRdWNIazZOVFlLSUNBZ0lDOHZJR3RsZVNBOUlIVnpaWEl1WW5sMFpYTWdLeUJpZFhOZmFXUUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlluVnpYM1J5WVdOclpYSXZZMjl1ZEhKaFkzUXVjSGs2TlRjS0lDQWdJQzh2SUdWNGNHbHllU3dnWlhocGMzUnpJRDBnYzJWc1ppNWxlSEJwY25sZmRHbHRaWE11YldGNVltVW9hMlY1S1FvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURZMU56ZzNNQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0J6ZDJGd0NpQWdJQ0JpZEc5cENpQWdJQ0J6ZDJGd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW5WelgzUnlZV05yWlhJdlkyOXVkSEpoWTNRdWNIazZOVGdLSUNBZ0lDOHZJR2xtSUc1dmRDQmxlR2x6ZEhNNkNpQWdJQ0JpYm5vZ1oyVjBYM1J5WVdOcmFXNW5YMkZqWTJWemMxOWhablJsY2w5cFpsOWxiSE5sUURNS0lDQWdJSEJ2Y0c0Z01nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKMWMxOTBjbUZqYTJWeUwyTnZiblJ5WVdOMExuQjVPalU1Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdLRlZKYm5RMk5DZ3dLU3dnVlVsdWREWTBLREFwTENCQ2VYUmxjeWhpSWlJcEtRb2dJQ0FnY0hWemFHSjVkR1Z6SURCNENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaSFZ3Q2dwblpYUmZkSEpoWTJ0cGJtZGZZV05qWlhOelgyRm1kR1Z5WDJsdWJHbHVaV1JmYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbUoxYzE5MGNtRmphMlZ5TG1OdmJuUnlZV04wTGtKMWMxUnlZV05yWlhJdVoyVjBYM1J5WVdOcmFXNW5YMkZqWTJWemMwQTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySjFjMTkwY21GamEyVnlMMk52Ym5SeVlXTjBMbkI1T2pVMENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdsMGIySUtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdNVElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFkxOHpJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncG5aWFJmZEhKaFkydHBibWRmWVdOalpYTnpYMkZtZEdWeVgybG1YMlZzYzJWQU16b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWRYTmZkSEpoWTJ0bGNpOWpiMjUwY21GamRDNXdlVG8yTVFvZ0lDQWdMeThnYzJWc1ppNXpkR0Z5ZEY5MGFXMWxjMXRyWlhsZExBb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VEY3pOelEyTVRjeU56UUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1Mbk4wWVhKMFgzUnBiV1Z6SUdWdWRISjVJR1Y0YVhOMGN3b2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKMWMxOTBjbUZqYTJWeUwyTnZiblJ5WVdOMExuQjVPall6Q2lBZ0lDQXZMeUJ6Wld4bUxuSnZkWFJsWDJsa2MxdHJaWGxkQ2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TnpJMlpqYzFOelEyTlFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5KdmRYUmxYMmxrY3lCbGJuUnllU0JsZUdsemRITUtJQ0FnSUhOM1lYQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkoxYzE5MGNtRmphMlZ5TDJOdmJuUnlZV04wTG5CNU9qVTBDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHSWdaMlYwWDNSeVlXTnJhVzVuWDJGalkyVnpjMTloWm5SbGNsOXBibXhwYm1Wa1gzTnRZWEowWDJOdmJuUnlZV04wY3k1aWRYTmZkSEpoWTJ0bGNpNWpiMjUwY21GamRDNUNkWE5VY21GamEyVnlMbWRsZEY5MGNtRmphMmx1WjE5aFkyTmxjM05BTkFvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NWlkWE5mZEhKaFkydGxjaTVqYjI1MGNtRmpkQzVDZFhOVWNtRmphMlZ5TG1WNGNHbHlaVjkwY21GamEybHVaMTloWTJObGMzTmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BsZUhCcGNtVmZkSEpoWTJ0cGJtZGZZV05qWlhOek9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1IxY0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkoxYzE5MGNtRmphMlZ5TDJOdmJuUnlZV04wTG5CNU9qWTJDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpZFhOZmRISmhZMnRsY2k5amIyNTBjbUZqZEM1d2VUbzJPQW9nSUNBZ0x5OGdhMlY1SUQwZ2RYTmxjaTVpZVhSbGN5QXJJR0oxYzE5cFpBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWRYTmZkSEpoWTJ0bGNpOWpiMjUwY21GamRDNXdlVG8yT1FvZ0lDQWdMeThnWlhod2FYSjVMQ0JsZUdsemRITWdQU0J6Wld4bUxtVjRjR2x5ZVY5MGFXMWxjeTV0WVhsaVpTaHJaWGtwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TmpVM09EY3dDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlluVnpYM1J5WVdOclpYSXZZMjl1ZEhKaFkzUXVjSGs2TnpBS0lDQWdJQzh2SUdsbUlHVjRhWE4wY3pvS0lDQWdJR0o2SUdWNGNHbHlaVjkwY21GamEybHVaMTloWTJObGMzTmZZV1owWlhKZmFXWmZaV3h6WlVBekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW5WelgzUnlZV05yWlhJdlkyOXVkSEpoWTNRdWNIazZOekVLSUNBZ0lDOHZJR1JsYkNCelpXeG1MbVY0Y0dseWVWOTBhVzFsYzF0clpYbGRDaUFnSUNCa2FXY2dNUW9nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2dwbGVIQnBjbVZmZEhKaFkydHBibWRmWVdOalpYTnpYMkZtZEdWeVgybG1YMlZzYzJWQU16b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWRYTmZkSEpoWTJ0bGNpOWpiMjUwY21GamRDNXdlVG8zTXdvZ0lDQWdMeThnYzNSaGNuUXNJR1Y0YVhOMGMxOXpkR0Z5ZENBOUlITmxiR1l1YzNSaGNuUmZkR2x0WlhNdWJXRjVZbVVvYTJWNUtRb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VEY3pOelEyTVRjeU56UUtJQ0FnSUdScFp5QXhDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0ExQ2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWRYTmZkSEpoWTJ0bGNpOWpiMjUwY21GamRDNXdlVG8zTkFvZ0lDQWdMeThnYVdZZ1pYaHBjM1J6WDNOMFlYSjBPZ29nSUNBZ1lub2daWGh3YVhKbFgzUnlZV05yYVc1blgyRmpZMlZ6YzE5aFpuUmxjbDlwWmw5bGJITmxRRFVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWlkWE5mZEhKaFkydGxjaTlqYjI1MGNtRmpkQzV3ZVRvM05Rb2dJQ0FnTHk4Z1pHVnNJSE5sYkdZdWMzUmhjblJmZEdsdFpYTmJhMlY1WFFvZ0lDQWdaR2xuSURNS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb0taWGh3YVhKbFgzUnlZV05yYVc1blgyRmpZMlZ6YzE5aFpuUmxjbDlwWmw5bGJITmxRRFU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZblZ6WDNSeVlXTnJaWEl2WTI5dWRISmhZM1F1Y0hrNk56Y0tJQ0FnSUM4dklISnZkWFJsTENCbGVHbHpkSE5mY205MWRHVWdQU0J6Wld4bUxuSnZkWFJsWDJsa2N5NXRZWGxpWlNoclpYa3BDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjROekkyWmpjMU56UTJOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHSjFjbmtnTXdvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlluVnpYM1J5WVdOclpYSXZZMjl1ZEhKaFkzUXVjSGs2TnpnS0lDQWdJQzh2SUdsbUlHVjRhWE4wYzE5eWIzVjBaVG9LSUNBZ0lHSjZJR1Y0Y0dseVpWOTBjbUZqYTJsdVoxOWhZMk5sYzNOZllXWjBaWEpmYVdaZlpXeHpaVUEzQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZblZ6WDNSeVlXTnJaWEl2WTI5dWRISmhZM1F1Y0hrNk56a0tJQ0FnSUM4dklHUmxiQ0J6Wld4bUxuSnZkWFJsWDJsa2MxdHJaWGxkQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NncGxlSEJwY21WZmRISmhZMnRwYm1kZllXTmpaWE56WDJGbWRHVnlYMmxtWDJWc2MyVkFOem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWlkWE5mZEhKaFkydGxjaTlqYjI1MGNtRmpkQzV3ZVRvMk5nb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG1KMWMxOTBjbUZqYTJWeUxtTnZiblJ5WVdOMExrSjFjMVJ5WVdOclpYSXVjbVZqYjNKa1gzVnpaWEpmWVdOMGFYWnBkSGxiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dweVpXTnZjbVJmZFhObGNsOWhZM1JwZG1sMGVUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWRYTmZkSEpoWTJ0bGNpOWpiMjUwY21GamRDNXdlVG80TVFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpZFhOZmRISmhZMnRsY2k5amIyNTBjbUZqZEM1d2VUbzRNd29nSUNBZ0x5OGdhMlY1SUQwZ1ZIaHVMbk5sYm1SbGNpNWllWFJsY3lBcklHRmpkR2wyYVhSNVgzUjVjR1VLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW5WelgzUnlZV05yWlhJdlkyOXVkSEpoWTNRdWNIazZPRFFLSUNBZ0lDOHZJSE5sYkdZdVlXTjBhWFpwZEdsbGMxdHJaWGxkSUQwZ1luVnpYMmxrQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGcyTVRZek56UUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lITjNZWEFLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpZFhOZmRISmhZMnRsY2k5amIyNTBjbUZqZEM1d2VUbzRNUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVBQUVDSUNZRUEyVjRjQVZ6ZEdGeWRBVnliM1YwWlFRVkgzeDFNUnRCQURJeEdSUkVNUmhFZ2dVRStGZ2VuQVRMMG55QkJNbDdGSU1FMTJ3WUNnUVFCQ0xFTmhvQWpnVUFDUUNXQU5BQkxBRjdBREVaRkRFWUZCQkRNUllqQ1VjQ09CQWpFa1EyR2dGSklsa2tDRXNCRlJKRVZ3SUFUZ0kyR2dKSklsa2tDRXNCRlJKRVZ3SUFUZ00yR2dOSkZZRUlFa1FYU1U4Q09BY3lDaEpFZ1lRSERrRUFMb0dnalFaUEFqZ0lEa1F4QUU4Q1VESUhUd0lJS0VzQ1VFd1d2eklIS1VzQ1VFd1d2eXBNVUVtOFNFeS9JME5KZ1lnT0RrRUFCNEh3a3dsQy84ZUJrS0VQUXYvQU5ob0JTUlVsRWtRMkdnSkpJbGtrQ0VzQkZSSkVWd0lBVUNoTVVMNU1GMHhBQUFsSUloWXJURkN3STBNeUJ3MUJBQVFqUXYvdklrTC82ellhQVVrVkpSSkVOaG9DU1NKWkpBaExBUlVTUkZjQ0FGQkpLRXhRdmt3WFRFQUFJVVlDZ0FBaVNSWk1GbEJNU1JVV1Z3WUNURkJNZ0FJQUVsQk1VQ3RNVUxBalF5bFBBa2xPQWxDK1JCY3FUd0pRdmtSTVR3Sk1Rdi9PSWtrMkdnRkpGU1VTUkRZYUFra2lXU1FJU3dFVkVrUlhBZ0JRU1NoTVVFbE9BcjFGQVVFQUJFc0J2RWdwU3dGUVNVVUZ2VVVCUVFBRVN3TzhTQ3BNVUVsRkE3MUZBVUVBQkVzQnZFZ2pRellhQVVraVdTUUlTd0VWRWtSWEFnQTJHZ0pKSWxra0NFc0JGUkpFVndJQU1RQlBBbENBQTJGamRFeFFTYnhJVEw4alF3PT0iLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo5LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
