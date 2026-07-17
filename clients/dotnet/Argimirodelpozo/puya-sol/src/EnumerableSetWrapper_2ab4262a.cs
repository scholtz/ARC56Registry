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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.EnumerableSetWrapper_2ab4262a
{


    public class EnumerableSetWrapperProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public EnumerableSetWrapperProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class Uint256Set : AVMObjectType
            {
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Spacer { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSpacer = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vSpacer.From(Spacer);
                    ret.AddRange(vSpacer.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Uint256Set Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Uint256Set();
                    uint count = 0;
                    var vSpacer = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vSpacer.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Spacer = vSpacer;
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Uint256Set);
                }
                public bool Equals(Uint256Set? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Uint256Set left, Uint256Set right)
                {
                    return EqualityComparer<Uint256Set>.Default.Equals(left, right);
                }
                public static bool operator !=(Uint256Set left, Uint256Set right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        public async Task<bool> Add(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 115, 147, 209, 129 };

            var result = await base.CallApp(new List<object> { abiHandle, value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Add_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 115, 147, 209, 129 };

            return await base.MakeTransactionList(new List<object> { abiHandle, value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        public async Task<bool> Remove(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 192, 11, 193, 49 };

            var result = await base.CallApp(new List<object> { abiHandle, value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Remove_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 192, 11, 193, 49 };

            return await base.MakeTransactionList(new List<object> { abiHandle, value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        public async Task<bool> Contains(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 14, 173, 149, 51 };

            var result = await base.SimApp(new List<object> { abiHandle, value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Contains_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 14, 173, 149, 51 };

            return await base.MakeTransactionList(new List<object> { abiHandle, value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> Length(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 84, 65, 18, 116 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> Length_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 84, 65, 18, 116 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="index"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> At(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 index, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 55, 222, 155, 43 };

            var result = await base.SimApp(new List<object> { abiHandle, index }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> At_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 index, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 55, 222, 155, 43 };

            return await base.MakeTransactionList(new List<object> { abiHandle, index }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRW51bWVyYWJsZVNldFdyYXBwZXIiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiVWludDI1NlNldCI6W3sibmFtZSI6Il9zcGFjZXIiLCJ0eXBlIjoidWludDI1NiJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJhZGQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbHVlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlbW92ZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY29udGFpbnMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbHVlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibGVuZ3RoIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImluZGV4IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjoxfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlszNzddLCJlcnJvck1lc3NhZ2UiOiJJbmRleE91dE9mQm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDU5LDQ4OCw1MTcsNTM4LDU2OF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNldCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NTUsNDg0LDUxMyw1NjRdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50MjU2IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTQ3LDU3OF0sImVycm9yTWVzc2FnZSI6Im92ZXJmbG93IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQwLDIzMCwyODFdLCJlcnJvck1lc3NhZ2UiOiJyZXZlcnQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmMyOXNZV1I1TDJGMWVDMTNjbUZ3Y0dWeWN5MTBieTFrWlhCc2Iza3ZSVzUxYldWeVlXSnNaVk5sZEZkeVlYQndaWEl1YzI5c0xrVnVkVzFsY21GaWJHVlRaWFJYY21Gd2NHVnlMbUZ3Y0hKdmRtRnNYM0J5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ016SWdNQ0F4Q2lBZ0lDQmllWFJsWTJKc2IyTnJJREI0SUNKelpYUWlJREI0Wm1KaU5qZG1aR0UxTW1RMFltWmlPR0ptSURCNE1UVXhaamRqTnpVZ01IZ3dNQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0p1ZWlCdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1nb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWMyVjBJZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeU9nb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMENpQWdJQ0J3ZFhOb1lubDBaWE56SURCNE56TTVNMlF4T0RFZ01IaGpNREJpWXpFek1TQXdlREJsWVdRNU5UTXpJREI0TlRRME1URXlOelFnTUhnek4yUmxPV0l5WWlBdkx5QnRaWFJvYjJRZ0ltRmtaQ2gxYVc1ME1qVTJLV0p2YjJ3aUxDQnRaWFJvYjJRZ0luSmxiVzkyWlNoMWFXNTBNalUyS1dKdmIyd2lMQ0J0WlhSb2IyUWdJbU52Ym5SaGFXNXpLSFZwYm5ReU5UWXBZbTl2YkNJc0lHMWxkR2h2WkNBaWJHVnVaM1JvS0NsMWFXNTBNalUySWl3Z2JXVjBhRzlrSUNKaGRDaDFhVzUwTWpVMktYVnBiblF5TlRZaUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQmhaR1FnY21WdGIzWmxJR052Ym5SaGFXNXpJR3hsYm1kMGFDQmhkQW9nSUNBZ1pYSnlDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDNOdmJHRmtlUzloZFhndGQzSmhjSEJsY25NdGRHOHRaR1Z3Ykc5NUwwVnVkVzFsY21GaWJHVlRaWFJYY21Gd2NHVnlMbk52YkM1RmJuVnRaWEpoWW14bFUyVjBUR2xpTG14bGJtZDBhQ2d4S1Y4eEtITmxkRG9nWW5sMFpYTXBJQzArSUdKNWRHVnpMQ0JpZVhSbGN6b0tSVzUxYldWeVlXSnNaVk5sZEV4cFlpNXNaVzVuZEdnNkNpQWdJQ0J3Y205MGJ5QXhJRElLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1kyRnNiSE4xWWlCRmJuVnRaWEpoWW14bFUyVjBUR2xpTGw5eWIyOTBVMnh2ZEFvZ0lDQWdabkpoYldWZlluVnllU0F0TVFvZ0lDQWdjRzl3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lISmxkSE4xWWdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OXpiMnhoWkhrdllYVjRMWGR5WVhCd1pYSnpMWFJ2TFdSbGNHeHZlUzlGYm5WdFpYSmhZbXhsVTJWMFYzSmhjSEJsY2k1emIyd3VSVzUxYldWeVlXSnNaVk5sZEV4cFlpNXNaVzVuZEdnb01TbGZNaWh6WlhRNklHSjVkR1Z6S1NBdFBpQmllWFJsY3l3Z1lubDBaWE02Q2k5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTl6YjJ4aFpIa3ZZWFY0TFhkeVlYQndaWEp6TFhSdkxXUmxjR3h2ZVM5RmJuVnRaWEpoWW14bFUyVjBWM0poY0hCbGNpNXpiMnd1Ulc1MWJXVnlZV0pzWlZObGRFeHBZaTVzWlc1bmRHZ29NU2xmTWpvS0lDQWdJSEJ5YjNSdklERWdNZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCallXeHNjM1ZpSUVWdWRXMWxjbUZpYkdWVFpYUk1hV0l1WDNSdlFubDBaWE16TWxObGRBb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBdE1Rb2dJQ0FnWTJGc2JITjFZaUJGYm5WdFpYSmhZbXhsVTJWMFRHbGlMbXhsYm1kMGFBb2dJQ0FnY0c5d0NpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTl6YjJ4aFpIa3ZZWFY0TFhkeVlYQndaWEp6TFhSdkxXUmxjR3h2ZVM5RmJuVnRaWEpoWW14bFUyVjBWM0poY0hCbGNpNXpiMnd1Ulc1MWJXVnlZV0pzWlZObGRFeHBZaTVqYjI1MFlXbHVjeWd5S1Y4eEtITmxkRG9nWW5sMFpYTXNJSFpoYkhWbE9pQmllWFJsY3lrZ0xUNGdkV2x1ZERZMExDQmllWFJsY3pvS1JXNTFiV1Z5WVdKc1pWTmxkRXhwWWk1amIyNTBZV2x1Y3pvS0lDQWdJSEJ5YjNSdklESWdNZ29nSUNBZ1lubDBaV05mTUNBdkx5QWlJZ29nSUNBZ1pIVndDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdOaGJHeHpkV0lnUlc1MWJXVnlZV0pzWlZObGRFeHBZaTVmY205dmRGTnNiM1FLSUNBZ0lHWnlZVzFsWDJKMWNua2dMVElLSUNBZ0lIQnZjQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRabUppTmpkbVpHRTFNbVEwWW1aaU9HSm1DaUFnSUNCaVBUMEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJ5WlhabGNuUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VBb2dJQ0FnWWowOUNpQWdJQ0JpZWlCRmJuVnRaWEpoWW14bFUyVjBUR2xpTG1OdmJuUmhhVzV6WDJGbWRHVnlYMmxtWDJWc2MyVkFOQW9nSUNBZ1lubDBaV05mTWlBdkx5QXdlR1ppWWpZM1ptUmhOVEprTkdKbVlqaGlaZ29nSUNBZ1puSmhiV1ZmWW5WeWVTQXRNUW9LUlc1MWJXVnlZV0pzWlZObGRFeHBZaTVqYjI1MFlXbHVjMTloWm5SbGNsOXBabDlsYkhObFFEUTZDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBd0NpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR0k5UFFvZ0lDQWdaSFZ3Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREVLSUNBZ0lHSnVlaUJGYm5WdFpYSmhZbXhsVTJWMFRHbGlMbU52Ym5SaGFXNXpYMkZtZEdWeVgzZG9hV3hsUURFMUNpQWdJQ0JtY21GdFpWOWthV2NnTVFvZ0lDQWdZbTU2SUVWdWRXMWxjbUZpYkdWVFpYUk1hV0l1WTI5dWRHRnBibk5mWVdaMFpYSmZkMmhwYkdWQU1UVUtJQ0FnSUdaeVlXMWxYMlJwWnlBeENpQWdJQ0JpYm5vZ1JXNTFiV1Z5WVdKc1pWTmxkRXhwWWk1amIyNTBZV2x1YzE5aFpuUmxjbDkzYUdsc1pVQXhOUW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb0tSVzUxYldWeVlXSnNaVk5sZEV4cFlpNWpiMjUwWVdsdWMxOWhablJsY2w5M2FHbHNaVUF4TlRvS0lDQWdJR1p5WVcxbFgyUnBaeUF3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZjMjlzWVdSNUwyRjFlQzEzY21Gd2NHVnljeTEwYnkxa1pYQnNiM2t2Ulc1MWJXVnlZV0pzWlZObGRGZHlZWEJ3WlhJdWMyOXNMa1Z1ZFcxbGNtRmliR1ZUWlhSTWFXSXVZMjl1ZEdGcGJuTW9NaWxmTWloelpYUTZJR0o1ZEdWekxDQjJZV3gxWlRvZ1lubDBaWE1wSUMwK0lIVnBiblEyTkN3Z1lubDBaWE02Q2k5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTl6YjJ4aFpIa3ZZWFY0TFhkeVlYQndaWEp6TFhSdkxXUmxjR3h2ZVM5RmJuVnRaWEpoWW14bFUyVjBWM0poY0hCbGNpNXpiMnd1Ulc1MWJXVnlZV0pzWlZObGRFeHBZaTVqYjI1MFlXbHVjeWd5S1Y4eU9nb2dJQ0FnY0hKdmRHOGdNaUF5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHTmhiR3h6ZFdJZ1JXNTFiV1Z5WVdKc1pWTmxkRXhwWWk1ZmRHOUNlWFJsY3pNeVUyVjBDaUFnSUNCbWNtRnRaVjlpZFhKNUlDMHlDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdKNlpYSnZDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnTFFvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWTJGc2JITjFZaUJGYm5WdFpYSmhZbXhsVTJWMFRHbGlMbU52Ym5SaGFXNXpDaUFnSUNCd2IzQUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDNOdmJHRmtlUzloZFhndGQzSmhjSEJsY25NdGRHOHRaR1Z3Ykc5NUwwVnVkVzFsY21GaWJHVlRaWFJYY21Gd2NHVnlMbk52YkM1RmJuVnRaWEpoWW14bFUyVjBUR2xpTG1Ga1pDZ3lLVjh4S0hObGREb2dZbmwwWlhNc0lIWmhiSFZsT2lCaWVYUmxjeWtnTFQ0Z2RXbHVkRFkwTENCaWVYUmxjem9LUlc1MWJXVnlZV0pzWlZObGRFeHBZaTVoWkdRNkNpQWdJQ0J3Y205MGJ5QXlJRElLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1kyRnNiSE4xWWlCRmJuVnRaWEpoWW14bFUyVjBUR2xpTGw5eWIyOTBVMnh2ZEFvZ0lDQWdabkpoYldWZlluVnllU0F0TWdvZ0lDQWdjRzl3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGhtWW1JMk4yWmtZVFV5WkRSaVptSTRZbVlLSUNBZ0lHSTlQUW9nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUhKbGRtVnlkQW9nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDNOdmJHRmtlUzloZFhndGQzSmhjSEJsY25NdGRHOHRaR1Z3Ykc5NUwwVnVkVzFsY21GaWJHVlRaWFJYY21Gd2NHVnlMbk52YkM1RmJuVnRaWEpoWW14bFUyVjBUR2xpTG1Ga1pDZ3lLVjh5S0hObGREb2dZbmwwWlhNc0lIWmhiSFZsT2lCaWVYUmxjeWtnTFQ0Z2RXbHVkRFkwTENCaWVYUmxjem9LTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMM052YkdGa2VTOWhkWGd0ZDNKaGNIQmxjbk10ZEc4dFpHVndiRzk1TDBWdWRXMWxjbUZpYkdWVFpYUlhjbUZ3Y0dWeUxuTnZiQzVGYm5WdFpYSmhZbXhsVTJWMFRHbGlMbUZrWkNneUtWOHlPZ29nSUNBZ2NISnZkRzhnTWlBeUNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR05oYkd4emRXSWdSVzUxYldWeVlXSnNaVk5sZEV4cFlpNWZkRzlDZVhSbGN6TXlVMlYwQ2lBZ0lDQm1jbUZ0WlY5aWRYSjVJQzB5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHSjZaWEp2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ0xRb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1kyRnNiSE4xWWlCRmJuVnRaWEpoWW14bFUyVjBUR2xpTG1Ga1pBb2dJQ0FnY0c5d0NpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTl6YjJ4aFpIa3ZZWFY0TFhkeVlYQndaWEp6TFhSdkxXUmxjR3h2ZVM5RmJuVnRaWEpoWW14bFUyVjBWM0poY0hCbGNpNXpiMnd1Ulc1MWJXVnlZV0pzWlZObGRFeHBZaTV5WlcxdmRtVW9NaWxmTVNoelpYUTZJR0o1ZEdWekxDQjJZV3gxWlRvZ1lubDBaWE1wSUMwK0lIVnBiblEyTkN3Z1lubDBaWE02Q2tWdWRXMWxjbUZpYkdWVFpYUk1hV0l1Y21WdGIzWmxPZ29nSUNBZ2NISnZkRzhnTWlBeUNpQWdJQ0JpZVhSbFkxOHdJQzh2SUNJaUNpQWdJQ0JrZFhBS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZMkZzYkhOMVlpQkZiblZ0WlhKaFlteGxVMlYwVEdsaUxsOXliMjkwVTJ4dmRBb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBdE1nb2dJQ0FnY0c5d0NpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhobVltSTJOMlprWVRVeVpEUmlabUk0WW1ZS0lDQWdJR0k5UFFvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklISmxkbVZ5ZEFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0Q2lBZ0lDQmlQVDBLSUNBZ0lHSjZJRVZ1ZFcxbGNtRmliR1ZUWlhSTWFXSXVjbVZ0YjNabFgyRm1kR1Z5WDJsbVgyVnNjMlZBTkFvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZUdaaVlqWTNabVJoTlRKa05HSm1ZamhpWmdvZ0lDQWdabkpoYldWZlluVnllU0F0TVFvS1JXNTFiV1Z5WVdKc1pWTmxkRXhwWWk1eVpXMXZkbVZmWVdaMFpYSmZhV1pmWld4elpVQTBPZ29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JpUFQwS0lDQWdJR1IxY0FvZ0lDQWdabkpoYldWZlluVnllU0F4Q2lBZ0lDQmlibm9nUlc1MWJXVnlZV0pzWlZObGRFeHBZaTV5WlcxdmRtVmZZV1owWlhKZmQyaHBiR1ZBTVRrS0lDQWdJR1p5WVcxbFgyUnBaeUF4Q2lBZ0lDQmlibm9nUlc1MWJXVnlZV0pzWlZObGRFeHBZaTV5WlcxdmRtVmZZV1owWlhKZmQyaHBiR1ZBTVRrS0lDQWdJR1p5WVcxbFgyUnBaeUF4Q2lBZ0lDQmlibm9nUlc1MWJXVnlZV0pzWlZObGRFeHBZaTV5WlcxdmRtVmZZV1owWlhKZmQyaHBiR1ZBTVRrS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREFLQ2tWdWRXMWxjbUZpYkdWVFpYUk1hV0l1Y21WdGIzWmxYMkZtZEdWeVgzZG9hV3hsUURFNU9nb2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTl6YjJ4aFpIa3ZZWFY0TFhkeVlYQndaWEp6TFhSdkxXUmxjR3h2ZVM5RmJuVnRaWEpoWW14bFUyVjBWM0poY0hCbGNpNXpiMnd1Ulc1MWJXVnlZV0pzWlZObGRFeHBZaTV5WlcxdmRtVW9NaWxmTWloelpYUTZJR0o1ZEdWekxDQjJZV3gxWlRvZ1lubDBaWE1wSUMwK0lIVnBiblEyTkN3Z1lubDBaWE02Q2k5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTl6YjJ4aFpIa3ZZWFY0TFhkeVlYQndaWEp6TFhSdkxXUmxjR3h2ZVM5RmJuVnRaWEpoWW14bFUyVjBWM0poY0hCbGNpNXpiMnd1Ulc1MWJXVnlZV0pzWlZObGRFeHBZaTV5WlcxdmRtVW9NaWxmTWpvS0lDQWdJSEJ5YjNSdklESWdNZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCallXeHNjM1ZpSUVWdWRXMWxjbUZpYkdWVFpYUk1hV0l1WDNSdlFubDBaWE16TWxObGRBb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBdE1nb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JpZW1WeWJ3b2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJQzBLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR05oYkd4emRXSWdSVzUxYldWeVlXSnNaVk5sZEV4cFlpNXlaVzF2ZG1VS0lDQWdJSEJ2Y0FvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZjMjlzWVdSNUwyRjFlQzEzY21Gd2NHVnljeTEwYnkxa1pYQnNiM2t2Ulc1MWJXVnlZV0pzWlZObGRGZHlZWEJ3WlhJdWMyOXNMa1Z1ZFcxbGNtRmliR1ZUWlhSTWFXSXVZWFFvTWlsZk1TaHpaWFE2SUdKNWRHVnpMQ0JwT2lCaWVYUmxjeWtnTFQ0Z1lubDBaWE1zSUdKNWRHVnpPZ3BGYm5WdFpYSmhZbXhsVTJWMFRHbGlMbUYwT2dvZ0lDQWdjSEp2ZEc4Z01pQXlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdOaGJHeHpkV0lnUlc1MWJXVnlZV0pzWlZObGRFeHBZaTVmY205dmRGTnNiM1FLSUNBZ0lHWnlZVzFsWDJKMWNua2dMVElLSUNBZ0lIQnZjQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCallXeHNjM1ZpSUVWdWRXMWxjbUZpYkdWVFpYUk1hV0l1YkdWdVozUm9DaUFnSUNCbWNtRnRaVjlpZFhKNUlDMHlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdJOFBRb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRWx1WkdWNFQzVjBUMlpDYjNWdVpITUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDNOdmJHRmtlUzloZFhndGQzSmhjSEJsY25NdGRHOHRaR1Z3Ykc5NUwwVnVkVzFsY21GaWJHVlRaWFJYY21Gd2NHVnlMbk52YkM1RmJuVnRaWEpoWW14bFUyVjBUR2xpTG1GMEtESXBYeklvYzJWME9pQmllWFJsY3l3Z2FUb2dZbmwwWlhNcElDMCtJR0o1ZEdWekxDQmllWFJsY3pvS0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDNOdmJHRmtlUzloZFhndGQzSmhjSEJsY25NdGRHOHRaR1Z3Ykc5NUwwVnVkVzFsY21GaWJHVlRaWFJYY21Gd2NHVnlMbk52YkM1RmJuVnRaWEpoWW14bFUyVjBUR2xpTG1GMEtESXBYekk2Q2lBZ0lDQndjbTkwYnlBeUlESUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWTJGc2JITjFZaUJGYm5WdFpYSmhZbXhsVTJWMFRHbGlMbDkwYjBKNWRHVnpNekpUWlhRS0lDQWdJR1p5WVcxbFgySjFjbmtnTFRJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZMkZzYkhOMVlpQkZiblZ0WlhKaFlteGxVMlYwVEdsaUxtRjBDaUFnSUNCd2IzQUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDNOdmJHRmtlUzloZFhndGQzSmhjSEJsY25NdGRHOHRaR1Z3Ykc5NUwwVnVkVzFsY21GaWJHVlRaWFJYY21Gd2NHVnlMbk52YkM1RmJuVnRaWEpoWW14bFUyVjBUR2xpTGw5eWIyOTBVMnh2ZENneEtWOHhLSE02SUdKNWRHVnpLU0F0UGlCaWVYUmxjeXdnWW5sMFpYTTZDa1Z1ZFcxbGNtRmliR1ZUWlhSTWFXSXVYM0p2YjNSVGJHOTBPZ29nSUNBZ2NISnZkRzhnTVNBeUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhneU9UQmtaV05rT1RVME9HSTJNbUU0WkRZd016UTFZVGs0T0RNNE5tWmpPRFJpWVRaaVl6azFORGcwTURBNFpqWXpOakptT1RNeE5qQmxaak5sTlRZekNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTl6YjJ4aFpIa3ZZWFY0TFhkeVlYQndaWEp6TFhSdkxXUmxjR3h2ZVM5RmJuVnRaWEpoWW14bFUyVjBWM0poY0hCbGNpNXpiMnd1Ulc1MWJXVnlZV0pzWlZObGRFeHBZaTVmZEc5Q2VYUmxjek15VTJWMEtERXBYekFvY3pvZ1lubDBaWE1wSUMwK0lHSjVkR1Z6TENCaWVYUmxjem9LUlc1MWJXVnlZV0pzWlZObGRFeHBZaTVmZEc5Q2VYUmxjek15VTJWME9nb2dJQ0FnY0hKdmRHOGdNU0F5Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmMyOXNZV1I1TDJGMWVDMTNjbUZ3Y0dWeWN5MTBieTFrWlhCc2Iza3ZSVzUxYldWeVlXSnNaVk5sZEZkeVlYQndaWEl1YzI5c0xrVnVkVzFsY21GaWJHVlRaWFJYY21Gd2NHVnlMbUZrWkZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtRmtaRG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERJMU5nb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0o1ZEdWalh6RWdMeThnSW5ObGRDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVjBJR1Y0YVhOMGN3b2dJQ0FnYzNkaGNBb2dJQ0FnWTJGc2JITjFZaUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZjMjlzWVdSNUwyRjFlQzEzY21Gd2NHVnljeTEwYnkxa1pYQnNiM2t2Ulc1MWJXVnlZV0pzWlZObGRGZHlZWEJ3WlhJdWMyOXNMa1Z1ZFcxbGNtRmliR1ZUWlhSTWFXSXVZV1JrS0RJcFh6SUtJQ0FnSUhCdmNBb2dJQ0FnWW5sMFpXTWdOQ0F2THlBd2VEQXdDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpaWFJpYVhRS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZjMjlzWVdSNUwyRjFlQzEzY21Gd2NHVnljeTEwYnkxa1pYQnNiM2t2Ulc1MWJXVnlZV0pzWlZObGRGZHlZWEJ3WlhJdWMyOXNMa1Z1ZFcxbGNtRmliR1ZUWlhSWGNtRndjR1Z5TG5KbGJXOTJaVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25KbGJXOTJaVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERJMU5nb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0o1ZEdWalh6RWdMeThnSW5ObGRDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVjBJR1Y0YVhOMGN3b2dJQ0FnYzNkaGNBb2dJQ0FnWTJGc2JITjFZaUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZjMjlzWVdSNUwyRjFlQzEzY21Gd2NHVnljeTEwYnkxa1pYQnNiM2t2Ulc1MWJXVnlZV0pzWlZObGRGZHlZWEJ3WlhJdWMyOXNMa1Z1ZFcxbGNtRmliR1ZUWlhSTWFXSXVjbVZ0YjNabEtESXBYeklLSUNBZ0lIQnZjQW9nSUNBZ1lubDBaV01nTkNBdkx5QXdlREF3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6WlhSaWFYUUtJQ0FnSUdKNWRHVmpYek1nTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12YzI5c1lXUjVMMkYxZUMxM2NtRndjR1Z5Y3kxMGJ5MWtaWEJzYjNrdlJXNTFiV1Z5WVdKc1pWTmxkRmR5WVhCd1pYSXVjMjlzTGtWdWRXMWxjbUZpYkdWVFpYUlhjbUZ3Y0dWeUxtTnZiblJoYVc1elczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZMjl1ZEdGcGJuTTZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblF5TlRZS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0p6WlhRaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGRDQmxlR2x6ZEhNS0lDQWdJSE4zWVhBS0lDQWdJR05oYkd4emRXSWdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzTnZiR0ZrZVM5aGRYZ3RkM0poY0hCbGNuTXRkRzh0WkdWd2JHOTVMMFZ1ZFcxbGNtRmliR1ZUWlhSWGNtRndjR1Z5TG5OdmJDNUZiblZ0WlhKaFlteGxVMlYwVEdsaUxtTnZiblJoYVc1ektESXBYeklLSUNBZ0lIQnZjQW9nSUNBZ1lubDBaV01nTkNBdkx5QXdlREF3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6WlhSaWFYUUtJQ0FnSUdKNWRHVmpYek1nTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12YzI5c1lXUjVMMkYxZUMxM2NtRndjR1Z5Y3kxMGJ5MWtaWEJzYjNrdlJXNTFiV1Z5WVdKc1pWTmxkRmR5WVhCd1pYSXVjMjlzTGtWdWRXMWxjbUZpYkdWVFpYUlhjbUZ3Y0dWeUxteGxibWQwYUZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNteGxibWQwYURvS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0p6WlhRaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGRDQmxlR2x6ZEhNS0lDQWdJR05oYkd4emRXSWdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzTnZiR0ZrZVM5aGRYZ3RkM0poY0hCbGNuTXRkRzh0WkdWd2JHOTVMMFZ1ZFcxbGNtRmliR1ZUWlhSWGNtRndjR1Z5TG5OdmJDNUZiblZ0WlhKaFlteGxVMlYwVEdsaUxteGxibWQwYUNneEtWOHlDaUFnSUNCd2IzQUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWW5wbGNtOEtJQ0FnSUdKOENpQWdJQ0JpZVhSbFkxOHpJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMM052YkdGa2VTOWhkWGd0ZDNKaGNIQmxjbk10ZEc4dFpHVndiRzk1TDBWdWRXMWxjbUZpYkdWVFpYUlhjbUZ3Y0dWeUxuTnZiQzVGYm5WdFpYSmhZbXhsVTJWMFYzSmhjSEJsY2k1aGRGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbUYwT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME1qVTJDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWMyVjBJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaWFFnWlhocGMzUnpDaUFnSUNCemQyRndDaUFnSUNCallXeHNjM1ZpSUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTl6YjJ4aFpIa3ZZWFY0TFhkeVlYQndaWEp6TFhSdkxXUmxjR3h2ZVM5RmJuVnRaWEpoWW14bFUyVjBWM0poY0hCbGNpNXpiMnd1Ulc1MWJXVnlZV0pzWlZObGRFeHBZaTVoZENneUtWOHlDaUFnSUNCd2IzQUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWW5wbGNtOEtJQ0FnSUdKOENpQWdJQ0JpZVhSbFkxOHpJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmMyOXNZV1I1TDJGMWVDMTNjbUZ3Y0dWeWN5MTBieTFrWlhCc2Iza3ZSVzUxYldWeVlXSnNaVk5sZEZkeVlYQndaWEl1YzI5c0xrVnVkVzFsY21GaWJHVlRaWFJYY21Gd2NHVnlMbU5zWldGeVgzTjBZWFJsWDNCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERUtJQ0FnSUhKbGRIVnliZ289In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBRElBQUJKZ1VBQTNObGRBbjd0bi9hVXRTL3VMOEVGUjk4ZFFFQU1SaEFBQVVwS0dja1F6RVpGRVF4R0VTQ0JRUnprOUdCQk1BTHdURUVEcTJWTXdSVVFSSjBCRGZlbXlzMkdnQ09CUUZuQVlRQm9RRytBZFFBaWdFQ2kvK0lBUytNLzBnb2kvK0ppZ0VDaS8rSUFVaU0vNGovNUVpTC80bUtBZ0lvU1l2K2lBRU5qUDVJaS84cXFCUkVpLzhvcUVFQUF5cU0veVNNQUNpTC82aEpqQUZBQUEyTEFVQUFDSXNCUUFBREk0d0Fpd0NML2s4RFR3T0ppZ0lDaS82SUFQZU0vaUt2aS85UVNSVWlDU0pZaVArb1NJditpWW9DQW92K2lBQ3pqUDVJaS84cXFCUkVKSXYraVlvQ0FvditpQURHalA0aXI0di9VRWtWSWdraVdJai8wMGlML29tS0FnSW9TWXYraUFDQWpQNUlpLzhxcUJSRWkvOG9xRUVBQXlxTS95U01BQ2lMLzZoSmpBRkFBQTJMQVVBQUNJc0JRQUFESTR3QWl3Q0wvazhEVHdPSmlnSUNpLzZJQUdxTS9pS3ZpLzlRU1JVaUNTSllpUCtvU0l2K2lZb0NBb3YraUFBbWpQNUlpLzZJL3VlTS9vdi9waFJFS0l2K2lZb0NBb3YraUFBempQNkwvNGovMWtpTC9vbUtBUUtBSUNrTjdObFVpMktvMWdORnFZZzRiOGhMcHJ5VlNFQUk5all2a3hZTzgrVmppLytKaWdFQ0k0di9pVFlhQVVrVkloSkVJeWxsUkV5SS94dElKd1FqVHdKVUsweFFzQ1JETmhvQlNSVWlFa1FqS1dWRVRJai9Xa2duQkNOUEFsUXJURkN3SkVNMkdnRkpGU0lTUkNNcFpVUk1pUDZ3U0NjRUkwOENWQ3RNVUxBa1F5TXBaVVNJL2t0SVNSVWlEa1FpcjZzclRGQ3dKRU0yR2dGSkZTSVNSQ01wWlVSTWlQOUJTRWtWSWc1RUlxK3JLMHhRc0NSRCIsImNsZWFyIjoiQ29FQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjcsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
