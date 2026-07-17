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

namespace Arc56.Generated.algorandfoundation.puya_ts_demo.ARC75_94c73f98
{


    public class ARC75Proxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ARC75Proxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class Whitelist : AVMObjectType
            {
                public Algorand.Address Account { get; set; }

                public ushort BoxIndex { get; set; }

                public string Arc { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAccount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vAccount.From(Account);
                    ret.AddRange(vAccount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBoxIndex = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint16");
                    vBoxIndex.From(BoxIndex);
                    ret.AddRange(vBoxIndex.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vArc = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vArc.From(Arc);
                    stringRef[ret.Count] = vArc.Encode();
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

                public static Whitelist Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new Whitelist();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAccount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vAccount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAccount = vAccount.ToValue();
                    if (valueAccount is Algorand.Address vAccountValue) { ret.Account = vAccountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBoxIndex = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint16");
                    count = vBoxIndex.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBoxIndex = vBoxIndex.ToValue();
                    if (valueBoxIndex is ushort vBoxIndexValue) { ret.BoxIndex = vBoxIndexValue; }
                    var indexArc = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vArc = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vArc.Decode(bytes.Skip(indexArc + prefixOffset).ToArray());
                    var valueArc = vArc.ToValue();
                    if (valueArc is string vArcValue) { ret.Arc = vArcValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Whitelist);
                }
                public bool Equals(Whitelist? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Whitelist left, Whitelist right)
                {
                    return EqualityComparer<Whitelist>.Default.Equals(left, right);
                }
                public static bool operator !=(Whitelist left, Whitelist right)
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
        ///Add app to whitelist box
        ///</summary>
        /// <param name="arc">- The ARC the whitelist corresponds to </param>
        /// <param name="boxIndex">- The index of the whitelist box to add the app to </param>
        /// <param name="appID">- The app ID to add to the whitelist </param>
        /// <param name="payment">- The payment transaction to cover the MBR change </param>
        public async Task AddAppToWhiteList(PaymentTransaction payment, string arc, ushort boxIndex, ulong appID, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 70, 124, 124, 189 };
            var arcAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); arcAbi.From(arc);
            var boxIndexAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt16(); boxIndexAbi.From(boxIndex);
            var appIDAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); appIDAbi.From(appID);

            var result = await base.CallApp(new List<object> { abiHandle, arcAbi, boxIndexAbi, appIDAbi, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AddAppToWhiteList_Transactions(PaymentTransaction payment, string arc, ushort boxIndex, ulong appID, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 70, 124, 124, 189 };
            var arcAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); arcAbi.From(arc);
            var boxIndexAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt16(); boxIndexAbi.From(boxIndex);
            var appIDAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); appIDAbi.From(appID);

            return await base.MakeTransactionList(new List<object> { abiHandle, arcAbi, boxIndexAbi, appIDAbi, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Sets a app whitelist for the sender. Should only be used when adding/removing
        ///more than one app
        ///</summary>
        /// <param name="arc"> </param>
        /// <param name="boxIndex">- The index of the whitelist box to put the app IDs in </param>
        /// <param name="appIDs">- Array of app IDs that signify the whitelisted apps </param>
        public async Task SetAppWhitelist(string arc, ushort boxIndex, ulong[] appIDs, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 209, 152, 252, 184 };
            var arcAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); arcAbi.From(arc);
            var boxIndexAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt16(); boxIndexAbi.From(boxIndex);
            var appIDsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); appIDsAbi.From(appIDs);

            var result = await base.CallApp(new List<object> { abiHandle, arcAbi, boxIndexAbi, appIDsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetAppWhitelist_Transactions(string arc, ushort boxIndex, ulong[] appIDs, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 209, 152, 252, 184 };
            var arcAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); arcAbi.From(arc);
            var boxIndexAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt16(); boxIndexAbi.From(boxIndex);
            var appIDsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); appIDsAbi.From(appIDs);

            return await base.MakeTransactionList(new List<object> { abiHandle, arcAbi, boxIndexAbi, appIDsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Deletes a app whitelist for the sender
        ///</summary>
        /// <param name="arc">- The ARC the whitelist corresponds to </param>
        /// <param name="boxIndex">- The index of the whitelist box to delete </param>
        public async Task DeleteWhitelist(string arc, ushort boxIndex, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 124, 51, 232, 50 };
            var arcAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); arcAbi.From(arc);
            var boxIndexAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt16(); boxIndexAbi.From(boxIndex);

            var result = await base.CallApp(new List<object> { abiHandle, arcAbi, boxIndexAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DeleteWhitelist_Transactions(string arc, ushort boxIndex, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 124, 51, 232, 50 };
            var arcAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); arcAbi.From(arc);
            var boxIndexAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt16(); boxIndexAbi.From(boxIndex);

            return await base.MakeTransactionList(new List<object> { abiHandle, arcAbi, boxIndexAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Deletes a app from a whitelist for the sender
        ///</summary>
        /// <param name="arc"> </param>
        /// <param name="boxIndex">- The index of the whitelist box to delete from </param>
        /// <param name="appID">- The app ID to delete from the whitelist </param>
        /// <param name="index">- The index of the app in the whitelist </param>
        public async Task DeleteAppFromWhitelist(string arc, ushort boxIndex, ulong appID, ulong index, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 126, 22, 116, 172 };
            var arcAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); arcAbi.From(arc);
            var boxIndexAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt16(); boxIndexAbi.From(boxIndex);
            var appIDAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); appIDAbi.From(appID);
            var indexAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); indexAbi.From(index);

            var result = await base.CallApp(new List<object> { abiHandle, arcAbi, boxIndexAbi, appIDAbi, indexAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DeleteAppFromWhitelist_Transactions(string arc, ushort boxIndex, ulong appID, ulong index, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 126, 22, 116, 172 };
            var arcAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); arcAbi.From(arc);
            var boxIndexAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt16(); boxIndexAbi.From(boxIndex);
            var appIDAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); appIDAbi.From(appID);
            var indexAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); indexAbi.From(index);

            return await base.MakeTransactionList(new List<object> { abiHandle, arcAbi, boxIndexAbi, appIDAbi, indexAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQVJDNzUiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiV2hpdGVsaXN0IjpbeyJuYW1lIjoiYWNjb3VudCIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoiYm94SW5kZXgiLCJ0eXBlIjoidWludDE2In0seyJuYW1lIjoiYXJjIiwidHlwZSI6InN0cmluZyJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGVBcHBsaWNhdGlvbiIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhZGRBcHBUb1doaXRlTGlzdCIsImRlc2MiOiJBZGQgYXBwIHRvIHdoaXRlbGlzdCBib3giLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXJjIiwiZGVzYyI6Ii0gVGhlIEFSQyB0aGUgd2hpdGVsaXN0IGNvcnJlc3BvbmRzIHRvIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJib3hJbmRleCIsImRlc2MiOiItIFRoZSBpbmRleCBvZiB0aGUgd2hpdGVsaXN0IGJveCB0byBhZGQgdGhlIGFwcCB0byIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXBwSUQiLCJkZXNjIjoiLSBUaGUgYXBwIElEIHRvIGFkZCB0byB0aGUgd2hpdGVsaXN0IiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXltZW50IiwiZGVzYyI6Ii0gVGhlIHBheW1lbnQgdHJhbnNhY3Rpb24gdG8gY292ZXIgdGhlIE1CUiBjaGFuZ2UiLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0QXBwV2hpdGVsaXN0IiwiZGVzYyI6IlNldHMgYSBhcHAgd2hpdGVsaXN0IGZvciB0aGUgc2VuZGVyLiBTaG91bGQgb25seSBiZSB1c2VkIHdoZW4gYWRkaW5nL3JlbW92aW5nXG5tb3JlIHRoYW4gb25lIGFwcCIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcmMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQxNiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJveEluZGV4IiwiZGVzYyI6Ii0gVGhlIGluZGV4IG9mIHRoZSB3aGl0ZWxpc3QgYm94IHRvIHB1dCB0aGUgYXBwIElEcyBpbiIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0W10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcHBJRHMiLCJkZXNjIjoiLSBBcnJheSBvZiBhcHAgSURzIHRoYXQgc2lnbmlmeSB0aGUgd2hpdGVsaXN0ZWQgYXBwcyIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJkZWxldGVXaGl0ZWxpc3QiLCJkZXNjIjoiRGVsZXRlcyBhIGFwcCB3aGl0ZWxpc3QgZm9yIHRoZSBzZW5kZXIiLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXJjIiwiZGVzYyI6Ii0gVGhlIEFSQyB0aGUgd2hpdGVsaXN0IGNvcnJlc3BvbmRzIHRvIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJib3hJbmRleCIsImRlc2MiOiItIFRoZSBpbmRleCBvZiB0aGUgd2hpdGVsaXN0IGJveCB0byBkZWxldGUiLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZGVsZXRlQXBwRnJvbVdoaXRlbGlzdCIsImRlc2MiOiJEZWxldGVzIGEgYXBwIGZyb20gYSB3aGl0ZWxpc3QgZm9yIHRoZSBzZW5kZXIiLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXJjIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJib3hJbmRleCIsImRlc2MiOiItIFRoZSBpbmRleCBvZiB0aGUgd2hpdGVsaXN0IGJveCB0byBkZWxldGUgZnJvbSIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXBwSUQiLCJkZXNjIjoiLSBUaGUgYXBwIElEIHRvIGRlbGV0ZSBmcm9tIHRoZSB3aGl0ZWxpc3QiLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImluZGV4IiwiZGVzYyI6Ii0gVGhlIGluZGV4IG9mIHRoZSBhcHAgaW4gdGhlIHdoaXRlbGlzdCIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzE4Ml0sImVycm9yTWVzc2FnZSI6IkJveCBtdXN0IGhhdmUgdmFsdWUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNV0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBtdXN0IGJlIE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDcsMjU0LDMyOSwzNjksNDcwLDY0Nyw2NjVdLCJlcnJvck1lc3NhZ2UiOiJhY2NvdW50IGZ1bmRlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY1M10sImVycm9yTWVzc2FnZSI6ImFzc2VydCB0YXJnZXQgaXMgbWF0Y2ggZm9yIGNvbmRpdGlvbnMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxODksNTg2XSwiZXJyb3JNZXNzYWdlIjoibWF4IGFycmF5IGxlbmd0aCBleGNlZWRlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzk5LDM0OF0sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHR5cGUgaXMgcGF5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNU0F3SURNMElEZ0tJQ0FnSUdKNWRHVmpZbXh2WTJzZ01IZ3dNREkwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WVhKak56VXZZWEpqTnpVdVlXeG5ieTUwY3pveU5nb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRUZTUXpjMUlHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnRkWE4wSUdKbElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpZWlCdFlXbHVYMk55WldGMFpWOU9iMDl3UURnS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhnME5qZGpOMk5pWkNBd2VHUXhPVGhtWTJJNElEQjROMk16TTJVNE16SWdNSGczWlRFMk56UmhZeUF2THlCdFpYUm9iMlFnSW1Ga1pFRndjRlJ2VjJocGRHVk1hWE4wS0hOMGNtbHVaeXgxYVc1ME1UWXNkV2x1ZERZMExIQmhlU2wyYjJsa0lpd2diV1YwYUc5a0lDSnpaWFJCY0hCWGFHbDBaV3hwYzNRb2MzUnlhVzVuTEhWcGJuUXhOaXgxYVc1ME5qUmJYU2wyYjJsa0lpd2diV1YwYUc5a0lDSmtaV3hsZEdWWGFHbDBaV3hwYzNRb2MzUnlhVzVuTEhWcGJuUXhOaWwyYjJsa0lpd2diV1YwYUc5a0lDSmtaV3hsZEdWQmNIQkdjbTl0VjJocGRHVnNhWE4wS0hOMGNtbHVaeXgxYVc1ME1UWXNkV2x1ZERZMExIVnBiblEyTkNsMmIybGtJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnWVdSa1FYQndWRzlYYUdsMFpVeHBjM1FnYzJWMFFYQndWMmhwZEdWc2FYTjBJR1JsYkdWMFpWZG9hWFJsYkdsemRDQmtaV3hsZEdWQmNIQkdjbTl0VjJocGRHVnNhWE4wQ2lBZ0lDQmxjbklLQ20xaGFXNWZZM0psWVhSbFgwNXZUM0JBT0RvS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5aGNtTTNOUzloY21NM05TNWhiR2R2TG5Sek9qSTJDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nUVZKRE56VWdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IaGlPRFEwTjJJek5pQXZMeUJ0WlhSb2IyUWdJbU55WldGMFpVRndjR3hwWTJGMGFXOXVLQ2wyYjJsa0lnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2diV0ZwYmw5amNtVmhkR1ZCY0hCc2FXTmhkR2x2Ymw5eWIzVjBaVUE1Q2lBZ0lDQmxjbklLQ20xaGFXNWZZM0psWVhSbFFYQndiR2xqWVhScGIyNWZjbTkxZEdWQU9Ub0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWhjbU0zTlM5aGNtTTNOUzVoYkdkdkxuUnpPalExQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hzZ2IyNURjbVZoZEdVNklDSnlaWEYxYVhKbElpQjlLUW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklHTnZiblJ5WVdOMGN5OWhjbU0zTlM5aGNtTTNOUzVoYkdkdkxuUnpPanBCVWtNM05TNWhaR1JCY0hCVWIxZG9hWFJsVEdsemRGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbUZrWkVGd2NGUnZWMmhwZEdWTWFYTjBPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkZ5WXpjMUwyRnlZemMxTG1Gc1oyOHVkSE02TlRjdE5qSUtJQ0FnSUM4dklHRmtaRUZ3Y0ZSdlYyaHBkR1ZNYVhOMEtBb2dJQ0FnTHk4Z0lDQmhjbU02SUhOMGNtbHVaeXdLSUNBZ0lDOHZJQ0FnWW05NFNXNWtaWGc2SUZWcGJuUXhOaXdLSUNBZ0lDOHZJQ0FnWVhCd1NVUTZJSFZwYm5RMk5Dd0tJQ0FnSUM4dklDQWdjR0Y1YldWdWREb2daM1I0Ymk1UVlYbHRaVzUwVkhodUxBb2dJQ0FnTHk4Z0tUb2dkbTlwWkNCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdZblJ2YVFvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0F0Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURRS0lDQWdJR2QwZUc1eklGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnY0dGNUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJSFJ5WVc1ellXTjBhVzl1SUhSNWNHVWdhWE1nY0dGNUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdllYSmpOelV2WVhKak56VXVZV3huYnk1MGN6bzJNd29nSUNBZ0x5OGdZMjl1YzNRZ2NISmxUVUpTSUQwZ1IyeHZZbUZzTG1OMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM011YldsdVFtRnNZVzVqWlRzS0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0JoWTJOMFgzQmhjbUZ0YzE5blpYUWdRV05qZEUxcGJrSmhiR0Z1WTJVS0lDQWdJSE4zWVhBS0lDQWdJR052ZG1WeUlEUUtJQ0FnSUdGemMyVnlkQ0F2THlCaFkyTnZkVzUwSUdaMWJtUmxaQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkZ5WXpjMUwyRnlZemMxTG1Gc1oyOHVkSE02TmpVS0lDQWdJQzh2SUdGalkyOTFiblE2SUc1bGR5QkJaR1J5WlhOektGUjRiaTV6Wlc1a1pYSXBMQW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyRnlZemMxTDJGeVl6YzFMbUZzWjI4dWRITTZOalF0TmpnS0lDQWdJQzh2SUdOdmJuTjBJSGRvYVhSbGJHbHpkQ0E5SUhzS0lDQWdJQzh2SUNBZ1lXTmpiM1Z1ZERvZ2JtVjNJRUZrWkhKbGMzTW9WSGh1TG5ObGJtUmxjaWtzQ2lBZ0lDQXZMeUFnSUdKdmVFbHVaR1Y0T2lCaWIzaEpibVJsZUN3S0lDQWdJQzh2SUNBZ1lYSmpPaUJoY21Nc0NpQWdJQ0F2THlCOU93b2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnd01ESTBDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJGeVl6YzFMMkZ5WXpjMUxtRnNaMjh1ZEhNNk56QUtJQ0FnSUM4dklHbG1JQ2gwYUdsekxuZG9hWFJsYkdsemRDaDNhR2wwWld4cGMzUXBMbVY0YVhOMGN5a2dld29nSUNBZ1pIVndDaUFnSUNCbGVIUnlZV04wSURBZ016SUtJQ0FnSUdScFp5QXhDaUFnSUNCbGVIUnlZV04wSURNeUlESUtJQ0FnSUdScFp5QXlDaUFnSUNCcGJuUmpYeklnTHk4Z016UUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCa2FXY2dNd29nSUNBZ2JHVnVDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURBd01qUUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lub2dZV1JrUVhCd1ZHOVhhR2wwWlV4cGMzUmZaV3h6WlY5aWIyUjVRRE1LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTloY21NM05TOWhjbU0zTlM1aGJHZHZMblJ6T2pjeENpQWdJQ0F2THlCMGFHbHpMbmRvYVhSbGJHbHpkQ2gzYUdsMFpXeHBjM1FwTG5aaGJIVmxMbkIxYzJnb1lYQndTVVFwT3dvZ0lDQWdaR2xuSURFS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWVhOelpYSjBJQzh2SUVKdmVDQnRkWE4wSUdoaGRtVWdkbUZzZFdVS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2FYUnZZZ29nSUNBZ1pHbG5JREVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZENBdkx5QnZiaUJsY25KdmNqb2diV0Y0SUdGeWNtRjVJR3hsYm1kMGFDQmxlR05sWldSbFpBb2dJQ0FnYzNkaGNBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdLd29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhKbGNHeGhZMlV5SURBS0lDQWdJR1JwWnlBeENpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUdKdmVGOXdkWFFLQ21Ga1pFRndjRlJ2VjJocGRHVk1hWE4wWDJGbWRHVnlYMmxtWDJWc2MyVkFORG9LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTloY21NM05TOWhjbU0zTlM1aGJHZHZMblJ6T2pjMkNpQWdJQ0F2THlCMGFHbHpMblpsY21sbWVVMUNVbEJoZVcxbGJuUW9jR0Y1YldWdWRDd2djSEpsVFVKU0tUc0tJQ0FnSUdScFp5QXlDaUFnSUNCa2FXY2dNZ29nSUNBZ1kyRnNiSE4xWWlCMlpYSnBabmxOUWxKUVlYbHRaVzUwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WVhKak56VXZZWEpqTnpVdVlXeG5ieTUwY3pvMU55MDJNZ29nSUNBZ0x5OGdZV1JrUVhCd1ZHOVhhR2wwWlV4cGMzUW9DaUFnSUNBdkx5QWdJR0Z5WXpvZ2MzUnlhVzVuTEFvZ0lDQWdMeThnSUNCaWIzaEpibVJsZURvZ1ZXbHVkREUyTEFvZ0lDQWdMeThnSUNCaGNIQkpSRG9nZFdsdWREWTBMQW9nSUNBZ0x5OGdJQ0J3WVhsdFpXNTBPaUJuZEhodUxsQmhlVzFsYm5SVWVHNHNDaUFnSUNBdkx5QXBPaUIyYjJsa0lIc0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbUZrWkVGd2NGUnZWMmhwZEdWTWFYTjBYMlZzYzJWZlltOWtlVUF6T2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJGeVl6YzFMMkZ5WXpjMUxtRnNaMjh1ZEhNNk56TUtJQ0FnSUM4dklIUm9hWE11ZDJocGRHVnNhWE4wS0hkb2FYUmxiR2x6ZENrdWRtRnNkV1VnUFNCYllYQndTVVJkT3dvZ0lDQWdhWFJ2WWdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBd01Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2FXY2dNUW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lITjNZWEFLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJR0lnWVdSa1FYQndWRzlYYUdsMFpVeHBjM1JmWVdaMFpYSmZhV1pmWld4elpVQTBDZ29LTHk4Z1kyOXVkSEpoWTNSekwyRnlZemMxTDJGeVl6YzFMbUZzWjI4dWRITTZPa0ZTUXpjMUxuTmxkRUZ3Y0Zkb2FYUmxiR2x6ZEZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuTmxkRUZ3Y0Zkb2FYUmxiR2x6ZERvS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5aGNtTTNOUzloY21NM05TNWhiR2R2TG5Sek9qZzNDaUFnSUNBdkx5QnpaWFJCY0hCWGFHbDBaV3hwYzNRb1lYSmpPaUJ6ZEhKcGJtY3NJR0p2ZUVsdVpHVjRPaUJWYVc1ME1UWXNJR0Z3Y0VsRWN6b2dkV2x1ZERZMFcxMHBPaUIyYjJsa0lIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdllYSmpOelV2WVhKak56VXVZV3huYnk1MGN6bzRPQW9nSUNBZ0x5OGdZMjl1YzNRZ2NISmxUVUpTSUQwZ1IyeHZZbUZzTG1OMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM011YldsdVFtRnNZVzVqWlRzS0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0JoWTJOMFgzQmhjbUZ0YzE5blpYUWdRV05qZEUxcGJrSmhiR0Z1WTJVS0lDQWdJSE4zWVhBS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ05Rb2dJQ0FnWTI5MlpYSWdOUW9nSUNBZ1lYTnpaWEowSUM4dklHRmpZMjkxYm5RZ1puVnVaR1ZrQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WVhKak56VXZZWEpqTnpVdVlXeG5ieTUwY3pvNU1Bb2dJQ0FnTHk4Z1lXTmpiM1Z1ZERvZ2JtVjNJRUZrWkhKbGMzTW9WSGh1TG5ObGJtUmxjaWtzQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZWEpqTnpVdllYSmpOelV1WVd4bmJ5NTBjem80T1MwNU13b2dJQ0FnTHk4Z1kyOXVjM1FnZDJocGRHVnNhWE4wSUQwZ2V3b2dJQ0FnTHk4Z0lDQmhZMk52ZFc1ME9pQnVaWGNnUVdSa2NtVnpjeWhVZUc0dWMyVnVaR1Z5S1N3S0lDQWdJQzh2SUNBZ1ltOTRTVzVrWlhnNklHSnZlRWx1WkdWNExBb2dJQ0FnTHk4Z0lDQmhjbU02SUdGeVl5d0tJQ0FnSUM4dklIMDdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklESUtJQ0FnSUd4bGJnb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TURBeU5Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTloY21NM05TOWhjbU0zTlM1aGJHZHZMblJ6T2prMUNpQWdJQ0F2THlCMGFHbHpMbmRvYVhSbGJHbHpkQ2gzYUdsMFpXeHBjM1FwTG1SbGJHVjBaU2dwT3dvZ0lDQWdaSFZ3Q2lBZ0lDQmxlSFJ5WVdOMElEQWdNeklLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmxlSFJ5WVdOMElETXlJRElLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNelFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQmthV2NnTXdvZ0lDQWdiR1Z1Q2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lITjFZbk4wY21sdVp6TUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEQXdNalFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyRnlZemMxTDJGeVl6YzFMbUZzWjI4dWRITTZPVGNLSUNBZ0lDOHZJSFJvYVhNdWQyaHBkR1ZzYVhOMEtIZG9hWFJsYkdsemRDa3VkbUZzZFdVZ1BTQmpiRzl1WlNoaGNIQkpSSE1wT3dvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJSE4zWVhBS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWhjbU0zTlM5aGNtTTNOUzVoYkdkdkxuUnpPams1Q2lBZ0lDQXZMeUJwWmlBb2NISmxUVUpTSUQ0Z1IyeHZZbUZzTG1OMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM011YldsdVFtRnNZVzVqWlNrZ2V3b2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUdGalkzUmZjR0Z5WVcxelgyZGxkQ0JCWTJOMFRXbHVRbUZzWVc1alpRb2dJQ0FnWVhOelpYSjBJQzh2SUdGalkyOTFiblFnWm5WdVpHVmtDaUFnSUNBK0NpQWdJQ0JpZWlCelpYUkJjSEJYYUdsMFpXeHBjM1JmWld4elpWOWliMlI1UURNS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5aGNtTTNOUzloY21NM05TNWhiR2R2TG5Sek9qRXdNQW9nSUNBZ0x5OGdkR2hwY3k1elpXNWtUVUpTVUdGNWJXVnVkQ2h3Y21WTlFsSXBPd29nSUNBZ1kyRnNiSE4xWWlCelpXNWtUVUpTVUdGNWJXVnVkQW9LYzJWMFFYQndWMmhwZEdWc2FYTjBYMkZtZEdWeVgybG1YMlZzYzJWQU5Eb0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWhjbU0zTlM5aGNtTTNOUzVoYkdkdkxuUnpPamczQ2lBZ0lDQXZMeUJ6WlhSQmNIQlhhR2wwWld4cGMzUW9ZWEpqT2lCemRISnBibWNzSUdKdmVFbHVaR1Y0T2lCVmFXNTBNVFlzSUdGd2NFbEVjem9nZFdsdWREWTBXMTBwT2lCMmIybGtJSHNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ25ObGRFRndjRmRvYVhSbGJHbHpkRjlsYkhObFgySnZaSGxBTXpvS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5aGNtTTNOUzloY21NM05TNWhiR2R2TG5Sek9qRXdNZ29nSUNBZ0x5OGdkR2hwY3k1MlpYSnBabmxOUWxKUVlYbHRaVzUwS0dkMGVHNHVVR0Y1YldWdWRGUjRiaWhVZUc0dVozSnZkWEJKYm1SbGVDQXRJREVwTENCd2NtVk5RbElwT3dvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCa2RYQUtJQ0FnSUdkMGVHNXpJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z2NHRjVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUhSeVlXNXpZV04wYVc5dUlIUjVjR1VnYVhNZ2NHRjVDaUFnSUNCemQyRndDaUFnSUNCallXeHNjM1ZpSUhabGNtbG1lVTFDVWxCaGVXMWxiblFLSUNBZ0lHSWdjMlYwUVhCd1YyaHBkR1ZzYVhOMFgyRm1kR1Z5WDJsbVgyVnNjMlZBTkFvS0NpOHZJR052Ym5SeVlXTjBjeTloY21NM05TOWhjbU0zTlM1aGJHZHZMblJ6T2pwQlVrTTNOUzVrWld4bGRHVlhhR2wwWld4cGMzUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BrWld4bGRHVlhhR2wwWld4cGMzUTZDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZWEpqTnpVdllYSmpOelV1WVd4bmJ5NTBjem94TVRNS0lDQWdJQzh2SUdSbGJHVjBaVmRvYVhSbGJHbHpkQ2hoY21NNklITjBjbWx1Wnl3Z1ltOTRTVzVrWlhnNklGVnBiblF4TmlrNklIWnZhV1FnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTloY21NM05TOWhjbU0zTlM1aGJHZHZMblJ6T2pFeE5Bb2dJQ0FnTHk4Z1kyOXVjM1FnY0hKbFRVSlNJRDBnUjJ4dlltRnNMbU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTXViV2x1UW1Gc1lXNWpaVHNLSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56Q2lBZ0lDQmhZMk4wWDNCaGNtRnRjMTluWlhRZ1FXTmpkRTFwYmtKaGJHRnVZMlVLSUNBZ0lHRnpjMlZ5ZENBdkx5QmhZMk52ZFc1MElHWjFibVJsWkFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJGeVl6YzFMMkZ5WXpjMUxtRnNaMjh1ZEhNNk1URTJDaUFnSUNBdkx5QmhZMk52ZFc1ME9pQnVaWGNnUVdSa2NtVnpjeWhVZUc0dWMyVnVaR1Z5S1N3S0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTloY21NM05TOWhjbU0zTlM1aGJHZHZMblJ6T2pFeE5TMHhNVGtLSUNBZ0lDOHZJR052Ym5OMElIZG9hWFJsYkdsemRDQTlJSHNLSUNBZ0lDOHZJQ0FnWVdOamIzVnVkRG9nYm1WM0lFRmtaSEpsYzNNb1ZIaHVMbk5sYm1SbGNpa3NDaUFnSUNBdkx5QWdJR0p2ZUVsdVpHVjRPaUJpYjNoSmJtUmxlQ3dLSUNBZ0lDOHZJQ0FnWVhKak9pQmhjbU1zQ2lBZ0lDQXZMeUI5T3dvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEQXdNalFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdllYSmpOelV2WVhKak56VXVZV3huYnk1MGN6b3hNakVLSUNBZ0lDOHZJSFJvYVhNdWQyaHBkR1ZzYVhOMEtIZG9hWFJsYkdsemRDa3VaR1ZzWlhSbEtDazdDaUFnSUNCa2RYQUtJQ0FnSUdWNGRISmhZM1FnTUNBek1nb2dJQ0FnWkdsbklERUtJQ0FnSUdWNGRISmhZM1FnTXpJZ01nb2dJQ0FnWkdsbklESUtJQ0FnSUdsdWRHTmZNaUF2THlBek5Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUdScFp5QXpDaUFnSUNCc1pXNEtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TURBeU5Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJGeVl6YzFMMkZ5WXpjMUxtRnNaMjh1ZEhNNk1USXpDaUFnSUNBdkx5QjBhR2x6TG5ObGJtUk5RbEpRWVhsdFpXNTBLSEJ5WlUxQ1VpazdDaUFnSUNCallXeHNjM1ZpSUhObGJtUk5RbEpRWVhsdFpXNTBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZWEpqTnpVdllYSmpOelV1WVd4bmJ5NTBjem94TVRNS0lDQWdJQzh2SUdSbGJHVjBaVmRvYVhSbGJHbHpkQ2hoY21NNklITjBjbWx1Wnl3Z1ltOTRTVzVrWlhnNklGVnBiblF4TmlrNklIWnZhV1FnZXdvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJR052Ym5SeVlXTjBjeTloY21NM05TOWhjbU0zTlM1aGJHZHZMblJ6T2pwQlVrTTNOUzVrWld4bGRHVkJjSEJHY205dFYyaHBkR1ZzYVhOMFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0taR1ZzWlhSbFFYQndSbkp2YlZkb2FYUmxiR2x6ZERvS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5aGNtTTNOUzloY21NM05TNWhiR2R2TG5Sek9qRXpOQzB4TXprS0lDQWdJQzh2SUdSbGJHVjBaVUZ3Y0VaeWIyMVhhR2wwWld4cGMzUW9DaUFnSUNBdkx5QWdJR0Z5WXpvZ2MzUnlhVzVuTEFvZ0lDQWdMeThnSUNCaWIzaEpibVJsZURvZ1ZXbHVkREUyTEFvZ0lDQWdMeThnSUNCaGNIQkpSRG9nZFdsdWREWTBMQW9nSUNBZ0x5OGdJQ0JwYm1SbGVEb2dkV2x1ZERZMExBb2dJQ0FnTHk4Z0tUb2dkbTlwWkNCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdZblJ2YVFvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05Bb2dJQ0FnWW5SdmFRb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXpDaUFnSUNCamIzWmxjaUF6Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WVhKak56VXZZWEpqTnpVdVlXeG5ieTUwY3pveE5EQUtJQ0FnSUM4dklHTnZibk4wSUhCeVpVMUNVaUE5SUVkc2IySmhiQzVqZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpMbTFwYmtKaGJHRnVZMlU3Q2lBZ0lDQm5iRzlpWVd3Z1EzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3dvZ0lDQWdZV05qZEY5d1lYSmhiWE5mWjJWMElFRmpZM1JOYVc1Q1lXeGhibU5sQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiM1psY2lBMENpQWdJQ0JoYzNObGNuUWdMeThnWVdOamIzVnVkQ0JtZFc1a1pXUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWhjbU0zTlM5aGNtTTNOUzVoYkdkdkxuUnpPakUwTWdvZ0lDQWdMeThnWVdOamIzVnVkRG9nYm1WM0lFRmtaSEpsYzNNb1ZIaHVMbk5sYm1SbGNpa3NDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdllYSmpOelV2WVhKak56VXVZV3huYnk1MGN6b3hOREV0TVRRMUNpQWdJQ0F2THlCamIyNXpkQ0IzYUdsMFpXeHBjM1FnUFNCN0NpQWdJQ0F2THlBZ0lHRmpZMjkxYm5RNklHNWxkeUJCWkdSeVpYTnpLRlI0Ymk1elpXNWtaWElwTEFvZ0lDQWdMeThnSUNCaWIzaEpibVJsZURvZ1ltOTRTVzVrWlhnc0NpQWdJQ0F2THlBZ0lHRnlZem9nWVhKakxBb2dJQ0FnTHk4Z2ZUc0tJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1EQXlOQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5aGNtTTNOUzloY21NM05TNWhiR2R2TG5Sek9qRTBOd29nSUNBZ0x5OGdZMjl1YzNRZ2MzQnNhV05sWkNBOUlIUm9hWE11ZDJocGRHVnNhWE4wS0hkb2FYUmxiR2x6ZENrdWRtRnNkV1ZiYVc1a1pYaGRPd29nSUNBZ1pIVndDaUFnSUNCbGVIUnlZV04wSURBZ016SUtJQ0FnSUdScFp5QXhDaUFnSUNCbGVIUnlZV04wSURNeUlESUtJQ0FnSUdScFp5QXlDaUFnSUNCcGJuUmpYeklnTHk4Z016UUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCa2FXY2dNd29nSUNBZ2JHVnVDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURBd01qUUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJQ29LSUNBZ0lIQjFjMmhwYm5RZ01pQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnWW05NFgyVjRkSEpoWTNRS0lDQWdJR0owYjJrS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5aGNtTTNOUzloY21NM05TNWhiR2R2TG5Sek9qRTBPUW9nSUNBZ0x5OGdZMjl1YzNRZ2JtVjNWMmhwZEdWTWFYTjBPaUIxYVc1ME5qUmJYU0E5SUZ0ZE93b2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQXdNQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkZ5WXpjMUwyRnlZemMxTG1Gc1oyOHVkSE02TVRVd0NpQWdJQ0F2THlCbWIzSWdLR3hsZENCcE9pQjFhVzUwTmpRZ1BTQXdPeUJwSUR3Z2RHaHBjeTUzYUdsMFpXeHBjM1FvZDJocGRHVnNhWE4wS1M1MllXeDFaUzVzWlc1bmRHZzdJR2tyS3lrZ2V3b2dJQ0FnYVc1MFkxOHhJQzh2SURBS0NtUmxiR1YwWlVGd2NFWnliMjFYYUdsMFpXeHBjM1JmZDJocGJHVmZkRzl3UURJNkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdllYSmpOelV2WVhKak56VXVZV3huYnk1MGN6b3hOVEFLSUNBZ0lDOHZJR1p2Y2lBb2JHVjBJR2s2SUhWcGJuUTJOQ0E5SURBN0lHa2dQQ0IwYUdsekxuZG9hWFJsYkdsemRDaDNhR2wwWld4cGMzUXBMblpoYkhWbExteGxibWQwYURzZ2FTc3JLU0I3Q2lBZ0lDQmthV2NnTXdvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lIQjFjMmhwYm5RZ01pQXZMeUF5Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQW9nSUNBZ1luUnZhUW9nSUNBZ1pHbG5JREVLSUNBZ0lENEtJQ0FnSUdKNklHUmxiR1YwWlVGd2NFWnliMjFYYUdsMFpXeHBjM1JmWVdaMFpYSmZkMmhwYkdWQU5nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyRnlZemMxTDJGeVl6YzFMbUZzWjI4dWRITTZNVFV4Q2lBZ0lDQXZMeUJwWmlBb2FTQWhQVDBnYVc1a1pYZ3BJSHNLSUNBZ0lHUjFjQW9nSUNBZ1pHbG5JRFlLSUNBZ0lDRTlDaUFnSUNCaWVpQmtaV3hsZEdWQmNIQkdjbTl0VjJocGRHVnNhWE4wWDJGbWRHVnlYMmxtWDJWc2MyVkFOUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkZ5WXpjMUwyRnlZemMxTG1Gc1oyOHVkSE02TVRVeUNpQWdJQ0F2THlCdVpYZFhhR2wwWlV4cGMzUXVjSFZ6YUNoMGFHbHpMbmRvYVhSbGJHbHpkQ2gzYUdsMFpXeHBjM1FwTG5aaGJIVmxXMmxkS1RzS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lDb0tJQ0FnSUhCMWMyaHBiblFnTWlBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ05Bb2dJQ0FnYzNkaGNBb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJR0p2ZUY5bGVIUnlZV04wQ2lBZ0lDQmlkRzlwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmthV2NnTWdvZ0lDQWdaSFZ3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQ0F2THlCdmJpQmxjbkp2Y2pvZ2JXRjRJR0Z5Y21GNUlHeGxibWQwYUNCbGVHTmxaV1JsWkFvZ0lDQWdjM2RoY0FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSEpsY0d4aFkyVXlJREFLSUNBZ0lHSjFjbmtnTWdvS1pHVnNaWFJsUVhCd1JuSnZiVmRvYVhSbGJHbHpkRjloWm5SbGNsOXBabDlsYkhObFFEVTZDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZWEpqTnpVdllYSmpOelV1WVd4bmJ5NTBjem94TlRBS0lDQWdJQzh2SUdadmNpQW9iR1YwSUdrNklIVnBiblEyTkNBOUlEQTdJR2tnUENCMGFHbHpMbmRvYVhSbGJHbHpkQ2gzYUdsMFpXeHBjM1FwTG5aaGJIVmxMbXhsYm1kMGFEc2dhU3NyS1NCN0NpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCaWRYSjVJREVLSUNBZ0lHSWdaR1ZzWlhSbFFYQndSbkp2YlZkb2FYUmxiR2x6ZEY5M2FHbHNaVjkwYjNCQU1nb0taR1ZzWlhSbFFYQndSbkp2YlZkb2FYUmxiR2x6ZEY5aFpuUmxjbDkzYUdsc1pVQTJPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkZ5WXpjMUwyRnlZemMxTG1Gc1oyOHVkSE02TVRVMUNpQWdJQ0F2THlCMGFHbHpMbmRvYVhSbGJHbHpkQ2gzYUdsMFpXeHBjM1FwTG5aaGJIVmxJRDBnWTJ4dmJtVW9ibVYzVjJocGRHVk1hWE4wS1RzS0lDQWdJR1JwWnlBekNpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb2dJQ0FnWkdsbklESUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTloY21NM05TOWhjbU0zTlM1aGJHZHZMblJ6T2pFMU53b2dJQ0FnTHk4Z1lYTnpaWEowS0hOd2JHbGpaV1FnUFQwOUlHRndjRWxFS1RzS0lDQWdJR1JwWnlBeUNpQWdJQ0JrYVdjZ053b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyRnlZemMxTDJGeVl6YzFMbUZzWjI4dWRITTZNVFU1Q2lBZ0lDQXZMeUIwYUdsekxuTmxibVJOUWxKUVlYbHRaVzUwS0hCeVpVMUNVaWs3Q2lBZ0lDQmthV2NnTkFvZ0lDQWdZMkZzYkhOMVlpQnpaVzVrVFVKU1VHRjViV1Z1ZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJGeVl6YzFMMkZ5WXpjMUxtRnNaMjh1ZEhNNk1UTTBMVEV6T1FvZ0lDQWdMeThnWkdWc1pYUmxRWEJ3Um5KdmJWZG9hWFJsYkdsemRDZ0tJQ0FnSUM4dklDQWdZWEpqT2lCemRISnBibWNzQ2lBZ0lDQXZMeUFnSUdKdmVFbHVaR1Y0T2lCVmFXNTBNVFlzQ2lBZ0lDQXZMeUFnSUdGd2NFbEVPaUIxYVc1ME5qUXNDaUFnSUNBdkx5QWdJR2x1WkdWNE9pQjFhVzUwTmpRc0NpQWdJQ0F2THlBcE9pQjJiMmxrSUhzS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJqYjI1MGNtRmpkSE12WVhKak56VXZZWEpqTnpVdVlXeG5ieTUwY3pvNlFWSkROelV1ZG1WeWFXWjVUVUpTVUdGNWJXVnVkQ2h3WVhsdFpXNTBPaUIxYVc1ME5qUXNJSEJ5WlUxQ1Vqb2dkV2x1ZERZMEtTQXRQaUIyYjJsa09ncDJaWEpwWm5sTlFsSlFZWGx0Wlc1ME9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyRnlZemMxTDJGeVl6YzFMbUZzWjI4dWRITTZNamtLSUNBZ0lDOHZJSEJ5YVhaaGRHVWdkbVZ5YVdaNVRVSlNVR0Y1YldWdWRDaHdZWGx0Wlc1ME9pQm5kSGh1TGxCaGVXMWxiblJVZUc0c0lIQnlaVTFDVWpvZ2RXbHVkRFkwS1RvZ2RtOXBaQ0I3Q2lBZ0lDQndjbTkwYnlBeUlEQUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWhjbU0zTlM5aGNtTTNOUzVoYkdkdkxuUnpPak13TFRNekNpQWdJQ0F2THlCaGMzTmxjblJOWVhSamFDaHdZWGx0Wlc1MExDQjdDaUFnSUNBdkx5QWdJSEpsWTJWcGRtVnlPaUJIYkc5aVlXd3VZM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN5d0tJQ0FnSUM4dklDQWdZVzF2ZFc1ME9pQkhiRzlpWVd3dVkzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3k1dGFXNUNZV3hoYm1ObElDMGdjSEpsVFVKU0xBb2dJQ0FnTHk4Z2ZTazdDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdkMGVHNXpJRkpsWTJWcGRtVnlDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZWEpqTnpVdllYSmpOelV1WVd4bmJ5NTBjem96TVFvZ0lDQWdMeThnY21WalpXbDJaWEk2SUVkc2IySmhiQzVqZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpMQW9nSUNBZ1oyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTloY21NM05TOWhjbU0zTlM1aGJHZHZMblJ6T2pNd0xUTXpDaUFnSUNBdkx5QmhjM05sY25STllYUmphQ2h3WVhsdFpXNTBMQ0I3Q2lBZ0lDQXZMeUFnSUhKbFkyVnBkbVZ5T2lCSGJHOWlZV3d1WTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnWVcxdmRXNTBPaUJIYkc5aVlXd3VZM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN5NXRhVzVDWVd4aGJtTmxJQzBnY0hKbFRVSlNMQW9nSUNBZ0x5OGdmU2s3Q2lBZ0lDQTlQUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCbmRIaHVjeUJCYlc5MWJuUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWhjbU0zTlM5aGNtTTNOUzVoYkdkdkxuUnpPak15Q2lBZ0lDQXZMeUJoYlc5MWJuUTZJRWRzYjJKaGJDNWpkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekxtMXBia0poYkdGdVkyVWdMU0J3Y21WTlFsSXNDaUFnSUNCbmJHOWlZV3dnUTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjd29nSUNBZ1lXTmpkRjl3WVhKaGJYTmZaMlYwSUVGalkzUk5hVzVDWVd4aGJtTmxDaUFnSUNCaGMzTmxjblFnTHk4Z1lXTmpiM1Z1ZENCbWRXNWtaV1FLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ0xRb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyRnlZemMxTDJGeVl6YzFMbUZzWjI4dWRITTZNekF0TXpNS0lDQWdJQzh2SUdGemMyVnlkRTFoZEdOb0tIQmhlVzFsYm5Rc0lIc0tJQ0FnSUM4dklDQWdjbVZqWldsMlpYSTZJRWRzYjJKaGJDNWpkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQmhiVzkxYm5RNklFZHNiMkpoYkM1amRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56TG0xcGJrSmhiR0Z1WTJVZ0xTQndjbVZOUWxJc0NpQWdJQ0F2THlCOUtUc0tJQ0FnSUQwOUNpQWdJQ0FtSmdvZ0lDQWdZWE56WlhKMElDOHZJR0Z6YzJWeWRDQjBZWEpuWlhRZ2FYTWdiV0YwWTJnZ1ptOXlJR052Ym1ScGRHbHZibk1LSUNBZ0lISmxkSE4xWWdvS0NpOHZJR052Ym5SeVlXTjBjeTloY21NM05TOWhjbU0zTlM1aGJHZHZMblJ6T2pwQlVrTTNOUzV6Wlc1a1RVSlNVR0Y1YldWdWRDaHdjbVZOUWxJNklIVnBiblEyTkNrZ0xUNGdkbTlwWkRvS2MyVnVaRTFDVWxCaGVXMWxiblE2Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WVhKak56VXZZWEpqTnpVdVlXeG5ieTUwY3pvek5nb2dJQ0FnTHk4Z2NISnBkbUYwWlNCelpXNWtUVUpTVUdGNWJXVnVkQ2h3Y21WTlFsSTZJSFZwYm5RMk5DazZJSFp2YVdRZ2V3b2dJQ0FnY0hKdmRHOGdNU0F3Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WVhKak56VXZZWEpqTnpVdVlXeG5ieTUwY3pvek55MDBNZ29nSUNBZ0x5OGdhWFI0YmdvZ0lDQWdMeThnSUNBdWNHRjViV1Z1ZENoN0NpQWdJQ0F2THlBZ0lDQWdjbVZqWldsMlpYSTZJRlI0Ymk1elpXNWtaWElzQ2lBZ0lDQXZMeUFnSUNBZ1lXMXZkVzUwT2lCd2NtVk5RbElnTFNCSGJHOWlZV3d1WTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjeTV0YVc1Q1lXeGhibU5sTEFvZ0lDQWdMeThnSUNCOUtRb2dJQ0FnTHk4Z0lDQXVjM1ZpYldsMEtDazdDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdllYSmpOelV2WVhKak56VXVZV3huYnk1MGN6b3pPUW9nSUNBZ0x5OGdjbVZqWldsMlpYSTZJRlI0Ymk1elpXNWtaWElzQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZWEpqTnpVdllYSmpOelV1WVd4bmJ5NTBjem8wTUFvZ0lDQWdMeThnWVcxdmRXNTBPaUJ3Y21WTlFsSWdMU0JIYkc5aVlXd3VZM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN5NXRhVzVDWVd4aGJtTmxMQW9nSUNBZ1oyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lHRmpZM1JmY0dGeVlXMXpYMmRsZENCQlkyTjBUV2x1UW1Gc1lXNWpaUW9nSUNBZ1lYTnpaWEowSUM4dklHRmpZMjkxYm5RZ1puVnVaR1ZrQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lITjNZWEFLSUNBZ0lDMEtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FXMXZkVzUwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRkpsWTJWcGRtVnlDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZWEpqTnpVdllYSmpOelV1WVd4bmJ5NTBjem96TnkwME1Rb2dJQ0FnTHk4Z2FYUjRiZ29nSUNBZ0x5OGdJQ0F1Y0dGNWJXVnVkQ2g3Q2lBZ0lDQXZMeUFnSUNBZ2NtVmpaV2wyWlhJNklGUjRiaTV6Wlc1a1pYSXNDaUFnSUNBdkx5QWdJQ0FnWVcxdmRXNTBPaUJ3Y21WTlFsSWdMU0JIYkc5aVlXd3VZM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN5NXRhVzVDWVd4aGJtTmxMQW9nSUNBZ0x5OGdJQ0I5S1FvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyRnlZemMxTDJGeVl6YzFMbUZzWjI4dWRITTZNemN0TkRJS0lDQWdJQzh2SUdsMGVHNEtJQ0FnSUM4dklDQWdMbkJoZVcxbGJuUW9ld29nSUNBZ0x5OGdJQ0FnSUhKbFkyVnBkbVZ5T2lCVWVHNHVjMlZ1WkdWeUxBb2dJQ0FnTHk4Z0lDQWdJR0Z0YjNWdWREb2djSEpsVFVKU0lDMGdSMnh2WW1Gc0xtTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNdWJXbHVRbUZzWVc1alpTd0tJQ0FnSUM4dklDQWdmU2tLSUNBZ0lDOHZJQ0FnTG5OMVltMXBkQ2dwT3dvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lISmxkSE4xWWdvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBRUFRQWlDQ1lCQWdBa01Sa1VSREVZUVFBa2dnUUVSbng4dlFUUm1QeTRCSHd6NkRJRWZoWjByRFlhQUk0RUFCRUFzQUVzQVg4QWdBUzRSSHMyTmhvQWpnRUFBUUFpUXpZYUFWY0NBRFlhQWpZYUF4ZE9BakVXSWdsSlRnUTRFQ0lTUkRJS2N3Rk1UZ1JFTVFCTVVFc0JGUlpYQmdKUEFsQk1LRkJNVUVsWEFDQkxBVmNnQWtzQ0pGbExBeFZQQkU0Q1VsY0NBRTRDVUVzQkZSWlhCZ0pQQWxCTUtGQk1VRWxPQXIxRkFVRUFKVXNCU2I1RVR3SVdTd0ZNVUV3aldTSUlGbGNHQWx3QVN3RzhTTDlMQWtzQ2lBR2dJa01XZ0FJQUFVeFFTd0ZKdkVoTXYwTC81allhQVZjQ0FEWWFBallhQXpJS2N3Rk1TVTRGVGdWRU1RQlBBbEJMQWhVV1Z3WUNUd05RVENoUVRGQkpWd0FnU3dGWElBSkxBaVJaU3dNVlR3Uk9BbEpYQWdCT0FsQkxBUlVXVndZQ1R3SlFUQ2hRVEZCSnZFaEp2RWhNdnpJS2N3RkVEVUVBQllnQlBpSkRNUllpQ1VrNEVDSVNSRXlJQVJSQy8rMDJHZ0ZYQWdBMkdnSXlDbk1CUkRFQVR3SlFTd0lWRmxjR0FrOERVRXdvVUV4UVNWY0FJRXNCVnlBQ1N3SWtXVXNERlU4RVRnSlNWd0lBVGdKUVN3RVZGbGNHQWs4Q1VFd29VRXhRdkVpSUFOb2lRellhQVZjQ0FEWWFBallhQXhkT0FqWWFCQmRKVGdOT0F6SUtjd0ZNVGdSRU1RQk1VRXNCRlJaWEJnSlBBbEJNS0ZCTVVFbFhBQ0JMQVZjZ0Frc0NKRmxMQXhWUEJFNENVbGNDQUU0Q1VFc0JGUlpYQmdKUEFsQk1LRkJNVUVsUEFpVUxnUUlJSmJvWGdBSUFBQ05MQXlPQkFyb1hTd0VOUVFBdlNVc0dFMEVBSUVrbEM0RUNDRXNFVENXNkZ4WkxBa2xQQWxCTUkxa2lDQlpYQmdKY0FFVUNTU0lJUlFGQy84UkxBMG04U0VzQ3Ywc0NTd2NTUkVzRWlBQWNJa09LQWdDTC9qZ0hNZ29TaS80NENESUtjd0ZFaS84SkVoQkVpWW9CQUxFeEFESUtjd0ZFaS85TUNiSUlzZ2Npc2hBanNnR3ppUT09IiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6MCwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
