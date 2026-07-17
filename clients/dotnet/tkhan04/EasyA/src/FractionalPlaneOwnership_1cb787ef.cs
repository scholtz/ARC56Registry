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

namespace Arc56.Generated.tkhan04.EasyA.FractionalPlaneOwnership_1cb787ef
{


    public class FractionalPlaneOwnershipProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public FractionalPlaneOwnershipProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class AirplainShare : AVMObjectType
            {
                public string Address { get; set; }

                public ulong TotalShares { get; set; }

                public ulong AvailableShares { get; set; }

                public ulong PricePerShare { get; set; }

                public ulong PrivatePlaneId { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vAddress.From(Address);
                    stringRef[ret.Count] = vAddress.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalShares = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTotalShares.From(TotalShares);
                    ret.AddRange(vTotalShares.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAvailableShares = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAvailableShares.From(AvailableShares);
                    ret.AddRange(vAvailableShares.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPricePerShare = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vPricePerShare.From(PricePerShare);
                    ret.AddRange(vPricePerShare.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPrivatePlaneId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vPrivatePlaneId.From(PrivatePlaneId);
                    ret.AddRange(vPrivatePlaneId.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static AirplainShare Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new AirplainShare();
                    uint count = 0;
                    var indexAddress = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vAddress.Decode(bytes.Skip(indexAddress + prefixOffset).ToArray());
                    var valueAddress = vAddress.ToValue();
                    if (valueAddress is string vAddressValue) { ret.Address = vAddressValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalShares = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTotalShares.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalShares = vTotalShares.ToValue();
                    if (valueTotalShares is ulong vTotalSharesValue) { ret.TotalShares = vTotalSharesValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAvailableShares = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAvailableShares.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAvailableShares = vAvailableShares.ToValue();
                    if (valueAvailableShares is ulong vAvailableSharesValue) { ret.AvailableShares = vAvailableSharesValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPricePerShare = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vPricePerShare.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePricePerShare = vPricePerShare.ToValue();
                    if (valuePricePerShare is ulong vPricePerShareValue) { ret.PricePerShare = vPricePerShareValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPrivatePlaneId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vPrivatePlaneId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePrivatePlaneId = vPrivatePlaneId.ToValue();
                    if (valuePrivatePlaneId is ulong vPrivatePlaneIdValue) { ret.PrivatePlaneId = vPrivatePlaneIdValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as AirplainShare);
                }
                public bool Equals(AirplainShare? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(AirplainShare left, AirplainShare right)
                {
                    return EqualityComparer<AirplainShare>.Default.Equals(left, right);
                }
                public static bool operator !=(AirplainShare left, AirplainShare right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="planeAddress"> </param>
        /// <param name="shares"> </param>
        /// <param name="pricePerShare"> </param>
        public async Task<ulong> CreateAirplaneListing(string planeAddress, ulong shares, ulong pricePerShare, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 84, 27, 196, 119 };
            var planeAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); planeAddressAbi.From(planeAddress);
            var sharesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); sharesAbi.From(shares);
            var pricePerShareAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); pricePerShareAbi.From(pricePerShare);

            var result = await base.CallApp(new List<object> { abiHandle, planeAddressAbi, sharesAbi, pricePerShareAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CreateAirplaneListing_Transactions(string planeAddress, ulong shares, ulong pricePerShare, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 84, 27, 196, 119 };
            var planeAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); planeAddressAbi.From(planeAddress);
            var sharesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); sharesAbi.From(shares);
            var pricePerShareAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); pricePerShareAbi.From(pricePerShare);

            return await base.MakeTransactionList(new List<object> { abiHandle, planeAddressAbi, sharesAbi, pricePerShareAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="assetId"> </param>
        public async Task<Structs.AirplainShare> GetListing(ulong assetId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 248, 185, 247, 110 };
            var assetIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetIdAbi.From(assetId);

            var result = await base.SimApp(new List<object> { abiHandle, assetIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.AirplainShare.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetListing_Transactions(ulong assetId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 248, 185, 247, 110 };
            var assetIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetIdAbi.From(assetId);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="user"> </param>
        public async Task<ulong> GetAlgoBalance(Address user, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { user });
            byte userRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 218, 23, 42, 8 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);

            var result = await base.SimApp(new List<object> { abiHandle, userRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetAlgoBalance_Transactions(Address user, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { user });
            byte userRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 218, 23, 42, 8 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);

            return await base.MakeTransactionList(new List<object> { abiHandle, userRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRnJhY3Rpb25hbFBsYW5lT3duZXJzaGlwIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IkFpcnBsYWluU2hhcmUiOlt7Im5hbWUiOiJhZGRyZXNzIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6InRvdGFsU2hhcmVzIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImF2YWlsYWJsZVNoYXJlcyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJwcmljZVBlclNoYXJlIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InByaXZhdGVQbGFuZUlEIiwidHlwZSI6InVpbnQ2NCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGVBaXJwbGFuZUxpc3RpbmciLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoicGxhbmVBZGRyZXNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzaGFyZXMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByaWNlUGVyU2hhcmUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRMaXN0aW5nIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0SWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHN0cmluZyx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiQWlycGxhaW5TaGFyZSIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0QWxnb0JhbGFuY2UiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWNjb3VudCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InVzZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMjcyXSwiZXJyb3JNZXNzYWdlIjoiQm94IG11c3QgaGF2ZSB2YWx1ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYyLDg1LDEwNV0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBpcyBub3QgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI4MV0sImVycm9yTWVzc2FnZSI6ImFjY291bnQgZnVuZGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQxXSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjUsODgsMTA4XSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIG5vdCBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI3MF0sImVycm9yTWVzc2FnZSI6Imxpc3Rpbmcgbm90IGZvdW5kIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNQ0F4SURNeUNpQWdJQ0JpZVhSbFkySnNiMk5ySURCNE1UVXhaamRqTnpVZ0luQnliM0JsY25ScFpYTWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFHVnNiRzlmZDI5eWJHUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBNQW9nSUNBZ0x5OGdaWGh3YjNKMElHUmxabUYxYkhRZ1kyeGhjM01nUm5KaFkzUnBiMjVoYkZCc1lXNWxUM2R1WlhKemFHbHdJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lHSjZJRzFoYVc1ZlltRnlaVjl5YjNWMGFXNW5RRGdLSUNBZ0lIQjFjMmhpZVhSbGMzTWdNSGcxTkRGaVl6UTNOeUF3ZUdZNFlqbG1OelpsSURCNFpHRXhOekpoTURnZ0x5OGdiV1YwYUc5a0lDSmpjbVZoZEdWQmFYSndiR0Z1WlV4cGMzUnBibWNvYzNSeWFXNW5MSFZwYm5RMk5DeDFhVzUwTmpRcGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKblpYUk1hWE4wYVc1bktIVnBiblEyTkNrb2MzUnlhVzVuTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkNraUxDQnRaWFJvYjJRZ0ltZGxkRUZzWjI5Q1lXeGhibU5sS0dGalkyOTFiblFwZFdsdWREWTBJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnYldGcGJsOWpjbVZoZEdWQmFYSndiR0Z1WlV4cGMzUnBibWRmY205MWRHVkFNeUJ0WVdsdVgyZGxkRXhwYzNScGJtZGZjbTkxZEdWQU5DQnRZV2x1WDJkbGRFRnNaMjlDWVd4aGJtTmxYM0p2ZFhSbFFEVUtDbTFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF4TWpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvWld4c2IxOTNiM0pzWkM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRd0NpQWdJQ0F2THlCbGVIQnZjblFnWkdWbVlYVnNkQ0JqYkdGemN5QkdjbUZqZEdsdmJtRnNVR3hoYm1WUGQyNWxjbk5vYVhBZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJkbGRFRnNaMjlDWVd4aGJtTmxYM0p2ZFhSbFFEVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFHVnNiRzlmZDI5eWJHUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzVOd29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUhKbFlXUnZibXg1T2lCMGNuVmxJSDBwQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9aV3hzYjE5M2IzSnNaQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalF3Q2lBZ0lDQXZMeUJsZUhCdmNuUWdaR1ZtWVhWc2RDQmpiR0Z6Y3lCR2NtRmpkR2x2Ym1Gc1VHeGhibVZQZDI1bGNuTm9hWEFnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoY3lCQlkyTnZkVzUwY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmhsYkd4dlgzZHZjbXhrTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T1RjS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2V5QnlaV0ZrYjI1c2VUb2dkSEoxWlNCOUtRb2dJQ0FnWTJGc2JITjFZaUJuWlhSQmJHZHZRbUZzWVc1alpRb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5blpYUk1hWE4wYVc1blgzSnZkWFJsUURRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUdWc2JHOWZkMjl5YkdRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMk5nb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJSEpsWVdSdmJteDVPaUIwY25WbElIMHBDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5b1pXeHNiMTkzYjNKc1pDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUXdDaUFnSUNBdkx5QmxlSEJ2Y25RZ1pHVm1ZWFZzZENCamJHRnpjeUJHY21GamRHbHZibUZzVUd4aGJtVlBkMjVsY25Ob2FYQWdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFHVnNiRzlmZDI5eWJHUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJOZ29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUhKbFlXUnZibXg1T2lCMGNuVmxJSDBwQ2lBZ0lDQmpZV3hzYzNWaUlHZGxkRXhwYzNScGJtY0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZlkzSmxZWFJsUVdseWNHeGhibVZNYVhOMGFXNW5YM0p2ZFhSbFFETTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFHVnNiRzlmZDI5eWJHUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBOZ29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9aV3hzYjE5M2IzSnNaQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalF3Q2lBZ0lDQXZMeUJsZUhCdmNuUWdaR1ZtWVhWc2RDQmpiR0Z6Y3lCR2NtRmpkR2x2Ym1Gc1VHeGhibVZQZDI1bGNuTm9hWEFnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ1luUnZhUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyaGxiR3h2WDNkdmNteGtMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZORFlLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdZMkZzYkhOMVlpQmpjbVZoZEdWQmFYSndiR0Z1WlV4cGMzUnBibWNLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZZbUZ5WlY5eWIzVjBhVzVuUURnNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUdWc2JHOWZkMjl5YkdRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME1Bb2dJQ0FnTHk4Z1pYaHdiM0owSUdSbFptRjFiSFFnWTJ4aGMzTWdSbkpoWTNScGIyNWhiRkJzWVc1bFQzZHVaWEp6YUdsd0lHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ1ltNTZJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF4TWdvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnWTNKbFlYUnBibWNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFHVnNiRzlmZDI5eWJHUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZSbkpoWTNScGIyNWhiRkJzWVc1bFQzZHVaWEp6YUdsd0xtTnlaV0YwWlVGcGNuQnNZVzVsVEdsemRHbHVaeWh3YkdGdVpVRmtaSEpsYzNNNklHSjVkR1Z6TENCemFHRnlaWE02SUhWcGJuUTJOQ3dnY0hKcFkyVlFaWEpUYUdGeVpUb2dkV2x1ZERZMEtTQXRQaUIxYVc1ME5qUTZDbU55WldGMFpVRnBjbkJzWVc1bFRHbHpkR2x1WnpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvWld4c2IxOTNiM0pzWkM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRMkxUUTNDaUFnSUNBdkx5QWdJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdMeThnY0hWaWJHbGpJR055WldGMFpVRnBjbkJzWVc1bFRHbHpkR2x1Wnlod2JHRnVaVUZrWkhKbGMzTTZJSE4wY21sdVp5d2djMmhoY21Wek9pQjFhVzUwTmpRc0lIQnlhV05sVUdWeVUyaGhjbVU2SUhWcGJuUTJOQ2s2SUhWcGJuUTJOQ0I3Q2lBZ0lDQndjbTkwYnlBeklERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5b1pXeHNiMTkzYjNKc1pDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qZ3lMVGt5Q2lBZ0lDQXZMeUJqYjI1emRDQjBlRzVTWlhOMWJIUWdQU0JwZEhodUNpQWdJQ0F2THlBZ0lDNWhjM05sZEVOdmJtWnBaeWg3Q2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJPWVcxbE9pQkNlWFJsY3loaGFYSndiR0Z1WlVGa1pISmxjM01wTG5Oc2FXTmxLREFzSURNeUtTNTBiMU4wY21sdVp5Z3BMQW9nSUNBZ0x5OGdJQ0FnSUhWdWFYUk9ZVzFsT2lBblVFeEJUa1VuTEFvZ0lDQWdMeThnSUNBZ0lIUnZkR0ZzT2lCemFHRnlaWE1zQ2lBZ0lDQXZMeUFnSUNBZ1pHVmphVzFoYkhNNklEQXNDaUFnSUNBdkx5QWdJQ0FnYldGdVlXZGxjam9nUjJ4dlltRnNMbU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJQ0FnY21WelpYSjJaVG9nUjJ4dlltRnNMbU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJQ0FnWm1WbE9pQXdMQW9nSUNBZ0x5OGdJQ0I5S1FvZ0lDQWdMeThnSUNBdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9aV3hzYjE5M2IzSnNaQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamcwQ2lBZ0lDQXZMeUJoYzNObGRFNWhiV1U2SUVKNWRHVnpLR0ZwY25Cc1lXNWxRV1JrY21WemN5a3VjMnhwWTJVb01Dd2dNeklwTG5SdlUzUnlhVzVuS0Nrc0NpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQStQUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdScFp5QXlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sYkdWamRBb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0JrYVdjZ01nb2dJQ0FnUGowS0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdaR2xuSURNS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9aV3hzYjE5M2IzSnNaQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamc0Q2lBZ0lDQXZMeUJ0WVc1aFoyVnlPaUJIYkc5aVlXd3VZM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN5d0tJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFHVnNiRzlmZDI5eWJHUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzRPUW9nSUNBZ0x5OGdjbVZ6WlhKMlpUb2dSMnh2WW1Gc0xtTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNc0NpQWdJQ0JrZFhBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUTI5dVptbG5RWE56WlhSU1pYTmxjblpsQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRU52Ym1acFowRnpjMlYwVFdGdVlXZGxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyaGxiR3h2WDNkdmNteGtMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPRGNLSUNBZ0lDOHZJR1JsWTJsdFlXeHpPaUF3TEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRMjl1Wm1sblFYTnpaWFJFWldOcGJXRnNjd29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCcGRIaHVYMlpwWld4a0lFTnZibVpwWjBGemMyVjBWRzkwWVd3S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvWld4c2IxOTNiM0pzWkM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pnMUNpQWdJQ0F2THlCMWJtbDBUbUZ0WlRvZ0oxQk1RVTVGSnl3S0lDQWdJSEIxYzJoaWVYUmxjeUFpVUV4QlRrVWlDaUFnSUNCcGRIaHVYMlpwWld4a0lFTnZibVpwWjBGemMyVjBWVzVwZEU1aGJXVUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1EyOXVabWxuUVhOelpYUk9ZVzFsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhR1ZzYkc5ZmQyOXliR1F2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem80TWkwNU1Rb2dJQ0FnTHk4Z1kyOXVjM1FnZEhodVVtVnpkV3gwSUQwZ2FYUjRiZ29nSUNBZ0x5OGdJQ0F1WVhOelpYUkRiMjVtYVdjb2V3b2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFRtRnRaVG9nUW5sMFpYTW9ZV2x5Y0d4aGJtVkJaR1J5WlhOektTNXpiR2xqWlNnd0xDQXpNaWt1ZEc5VGRISnBibWNvS1N3S0lDQWdJQzh2SUNBZ0lDQjFibWwwVG1GdFpUb2dKMUJNUVU1Rkp5d0tJQ0FnSUM4dklDQWdJQ0IwYjNSaGJEb2djMmhoY21WekxBb2dJQ0FnTHk4Z0lDQWdJR1JsWTJsdFlXeHpPaUF3TEFvZ0lDQWdMeThnSUNBZ0lHMWhibUZuWlhJNklFZHNiMkpoYkM1amRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56TEFvZ0lDQWdMeThnSUNBZ0lISmxjMlZ5ZG1VNklFZHNiMkpoYkM1amRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56TEFvZ0lDQWdMeThnSUNBZ0lHWmxaVG9nTUN3S0lDQWdJQzh2SUNBZ2ZTa0tJQ0FnSUhCMWMyaHBiblFnTXlBdkx5QXpDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUdWc2JHOWZkMjl5YkdRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNU1Bb2dJQ0FnTHk4Z1ptVmxPaUF3TEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhR1ZzYkc5ZmQyOXliR1F2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem80TWkwNU1nb2dJQ0FnTHk4Z1kyOXVjM1FnZEhodVVtVnpkV3gwSUQwZ2FYUjRiZ29nSUNBZ0x5OGdJQ0F1WVhOelpYUkRiMjVtYVdjb2V3b2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFRtRnRaVG9nUW5sMFpYTW9ZV2x5Y0d4aGJtVkJaR1J5WlhOektTNXpiR2xqWlNnd0xDQXpNaWt1ZEc5VGRISnBibWNvS1N3S0lDQWdJQzh2SUNBZ0lDQjFibWwwVG1GdFpUb2dKMUJNUVU1Rkp5d0tJQ0FnSUM4dklDQWdJQ0IwYjNSaGJEb2djMmhoY21WekxBb2dJQ0FnTHk4Z0lDQWdJR1JsWTJsdFlXeHpPaUF3TEFvZ0lDQWdMeThnSUNBZ0lHMWhibUZuWlhJNklFZHNiMkpoYkM1amRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56TEFvZ0lDQWdMeThnSUNBZ0lISmxjMlZ5ZG1VNklFZHNiMkpoYkM1amRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56TEFvZ0lDQWdMeThnSUNBZ0lHWmxaVG9nTUN3S0lDQWdJQzh2SUNBZ2ZTa0tJQ0FnSUM4dklDQWdMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnYVhSNGJpQkRjbVZoZEdWa1FYTnpaWFJKUkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmhsYkd4dlgzZHZjbXhrTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRNS0lDQWdJQzh2SUdGa1pISmxjM002SUc1bGR5QmhjbU0wTGxOMGNpaHdiR0Z1WlVGa1pISmxjM01wTEFvZ0lDQWdjM2RoY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhR1ZzYkc5ZmQyOXliR1F2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8xTkFvZ0lDQWdMeThnZEc5MFlXeFRhR0Z5WlhNNklHNWxkeUJoY21NMExsVnBiblJPTmpRb2MyaGhjbVZ6S1N3S0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmhsYkd4dlgzZHZjbXhrTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRZS0lDQWdJQzh2SUhCeWFXTmxVR1Z5VTJoaGNtVTZJRzVsZHlCaGNtTTBMbFZwYm5ST05qUW9jSEpwWTJWUVpYSlRhR0Z5WlNrc0NpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2wwYjJJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvWld4c2IxOTNiM0pzWkM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVM0NpQWdJQ0F2THlCd2NtbDJZWFJsVUd4aGJtVkpSRG9nYm1WM0lHRnlZelF1VldsdWRFNDJOQ2hoYzNObGRFbGtLU3dLSUNBZ0lHUnBaeUF6Q2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhR1ZzYkc5ZmQyOXliR1F2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8xTWkwMU9Bb2dJQ0FnTHk4Z1kyOXVjM1FnY0hKdmNHVnlkSGxUZEhKMVkzUWdQU0J1WlhjZ1FXbHljR3hoYVc1VGFHRnlaU2g3Q2lBZ0lDQXZMeUFnSUdGa1pISmxjM002SUc1bGR5QmhjbU0wTGxOMGNpaHdiR0Z1WlVGa1pISmxjM01wTEFvZ0lDQWdMeThnSUNCMGIzUmhiRk5vWVhKbGN6b2dibVYzSUdGeVl6UXVWV2x1ZEU0Mk5DaHphR0Z5WlhNcExBb2dJQ0FnTHk4Z0lDQmhkbUZwYkdGaWJHVlRhR0Z5WlhNNklHNWxkeUJoY21NMExsVnBiblJPTmpRb2MyaGhjbVZ6S1N3S0lDQWdJQzh2SUNBZ2NISnBZMlZRWlhKVGFHRnlaVG9nYm1WM0lHRnlZelF1VldsdWRFNDJOQ2h3Y21salpWQmxjbE5vWVhKbEtTd0tJQ0FnSUM4dklDQWdjSEpwZG1GMFpWQnNZVzVsU1VRNklHNWxkeUJoY21NMExsVnBiblJPTmpRb1lYTnpaWFJKWkNrc0NpQWdJQ0F2THlCOUtRb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQXlNZ29nSUNBZ1pHbG5JRE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2FXY2dNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyaGxiR3h2WDNkdmNteGtMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZORE1LSUNBZ0lDOHZJSEIxWW14cFl5QnNhWE4wWldSUWNtOXdaWEowYVdWeklEMGdRbTk0VFdGd1BIVnBiblEyTkN3Z1FXbHljR3hoYVc1VGFHRnlaVDRvZXlCclpYbFFjbVZtYVhnNklDZHdjbTl3WlhKMGFXVnpKeUI5S1FvZ0lDQWdZbmwwWldOZk1TQXZMeUFpY0hKdmNHVnlkR2xsY3lJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhR1ZzYkc5ZmQyOXliR1F2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yTVFvZ0lDQWdMeThnZEdocGN5NXNhWE4wWldSUWNtOXdaWEowYVdWektHRnpjMlYwU1dRcExuWmhiSFZsSUQwZ2NISnZjR1Z5ZEhsVGRISjFZM1F1WTI5d2VTZ3BDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ2MzZGhjQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmhsYkd4dlgzZHZjbXhrTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmpNS0lDQWdJQzh2SUhKbGRIVnliaUJoYzNObGRFbGtDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFHVnNiRzlmZDI5eWJHUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZSbkpoWTNScGIyNWhiRkJzWVc1bFQzZHVaWEp6YUdsd0xtZGxkRXhwYzNScGJtY29ZWE56WlhSSlpEb2dkV2x1ZERZMEtTQXRQaUJpZVhSbGN6b0taMlYwVEdsemRHbHVaem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9aV3hzYjE5M2IzSnNaQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalkyTFRZM0NpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2djbVZoWkc5dWJIazZJSFJ5ZFdVZ2ZTa0tJQ0FnSUM4dklIQjFZbXhwWXlCblpYUk1hWE4wYVc1bktHRnpjMlYwU1dRNklIVnBiblEyTkNrNklFRnBjbkJzWVdsdVUyaGhjbVVnZXdvZ0lDQWdjSEp2ZEc4Z01TQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFHVnNiRzlmZDI5eWJHUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJPQW9nSUNBZ0x5OGdZWE56WlhKMEtIUm9hWE11YkdsemRHVmtVSEp2Y0dWeWRHbGxjeWhoYzNObGRFbGtLUzVsZUdsemRITXNJQ2RzYVhOMGFXNW5JRzV2ZENCbWIzVnVaQ2NwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHbDBiMklLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9aV3hzYjE5M2IzSnNaQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalF6Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdiR2x6ZEdWa1VISnZjR1Z5ZEdsbGN5QTlJRUp2ZUUxaGNEeDFhVzUwTmpRc0lFRnBjbkJzWVdsdVUyaGhjbVUrS0hzZ2EyVjVVSEpsWm1sNE9pQW5jSEp2Y0dWeWRHbGxjeWNnZlNrS0lDQWdJR0o1ZEdWalh6RWdMeThnSW5CeWIzQmxjblJwWlhNaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5b1pXeHNiMTkzYjNKc1pDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWTRDaUFnSUNBdkx5QmhjM05sY25Rb2RHaHBjeTVzYVhOMFpXUlFjbTl3WlhKMGFXVnpLR0Z6YzJWMFNXUXBMbVY0YVhOMGN5d2dKMnhwYzNScGJtY2dibTkwSUdadmRXNWtKeWtLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JoYzNObGNuUWdMeThnYkdsemRHbHVaeUJ1YjNRZ1ptOTFibVFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9aV3hzYjE5M2IzSnNaQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalk1Q2lBZ0lDQXZMeUJqYjI1emRDQnNhWE4wYVc1bklEMGdkR2hwY3k1c2FYTjBaV1JRY205d1pYSjBhV1Z6S0dGemMyVjBTV1FwTG5aaGJIVmxMbU52Y0hrb0tRb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lYTnpaWEowSUM4dklFSnZlQ0J0ZFhOMElHaGhkbVVnZG1Gc2RXVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5b1pXeHNiMTkzYjNKc1pDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qY3dDaUFnSUNBdkx5QnlaWFIxY200Z2JHbHpkR2x1WndvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmhsYkd4dlgzZHZjbXhrTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2taeVlXTjBhVzl1WVd4UWJHRnVaVTkzYm1WeWMyaHBjQzVuWlhSQmJHZHZRbUZzWVc1alpTaDFjMlZ5T2lCaWVYUmxjeWtnTFQ0Z2RXbHVkRFkwT2dwblpYUkJiR2R2UW1Gc1lXNWpaVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9aV3hzYjE5M2IzSnNaQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamszTFRrNENpQWdJQ0F2THlBZ0lFQmhZbWx0WlhSb2IyUW9leUJ5WldGa2IyNXNlVG9nZEhKMVpTQjlLUW9nSUNBZ0x5OGdjSFZpYkdsaklHZGxkRUZzWjI5Q1lXeGhibU5sS0hWelpYSTZJRUZqWTI5MWJuUXBPaUIxYVc1ME5qUWdld29nSUNBZ2NISnZkRzhnTVNBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUdWc2JHOWZkMjl5YkdRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNU9Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUhWelpYSXVZbUZzWVc1alpRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JoWTJOMFgzQmhjbUZ0YzE5blpYUWdRV05qZEVKaGJHRnVZMlVLSUNBZ0lHRnpjMlZ5ZENBdkx5QmhZMk52ZFc1MElHWjFibVJsWkFvZ0lDQWdjbVYwYzNWaUNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQURBQUVnSmdJRUZSOThkUXB3Y205d1pYSjBhV1Z6TVJ0QkFHaUNBd1JVRzhSM0JQaTU5MjRFMmhjcUNEWWFBSTREQUMwQUdRQUNJa014R1JSRU1SaEVOaG9CRjhBY2lBREhGaWhNVUxBalF6RVpGRVF4R0VRMkdnRVhpQUNoS0V4UXNDTkRNUmtVUkRFWVJEWWFBVmNDQURZYUFoYzJHZ01YaUFBU0ZpaE1VTEFqUXpFWlFQK3ZNUmdVUkNORGlnTUJzWXY5RlNKTEFROGlTd0pQQWswa1N3SVBKRXNEVHdKTmkvMU9BbEl5Q2tteUtySXBJcklqaS82eUlvQUZVRXhCVGtXeUpiSW1nUU95RUNLeUFiTzBQRXdXVndZQ2kvMVFpLzRXaS84V1N3TVdnQUlBSWtzRFVFOERVRThDVUVzQlVFOENVQ2xQQWxCSnZFaE12NG1LQVFHTC94WXBURkJKdlVVQlJMNUVpWW9CQVl2L2N3QkVpUT09IiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo0LCJtaW5vciI6NCwicGF0Y2giOjQsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
