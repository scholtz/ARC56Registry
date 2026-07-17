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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.C_ca1c8e2c
{


    public class CProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public CProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class TestViewToDefaultReturn : AVMObjectType
            {
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field0 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field1 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static TestViewToDefaultReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new TestViewToDefaultReturn();
                    uint count = 0;
                    var vField0 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field0 = vField0;
                    var vField1 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field1 = vField1;
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as TestViewToDefaultReturn);
                }
                public bool Equals(TestViewToDefaultReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(TestViewToDefaultReturn left, TestViewToDefaultReturn right)
                {
                    return EqualityComparer<TestViewToDefaultReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(TestViewToDefaultReturn left, TestViewToDefaultReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> ExternalDefault(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 177, 44, 73, 65 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> ExternalDefault_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 177, 44, 73, 65 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> ExternalView(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 108, 114, 226, 62 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> ExternalView_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 108, 114, 226, 62 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> ExternalPure(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 50, 140, 109, 169 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> ExternalPure_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 50, 140, 109, 169 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.TestViewToDefaultReturn> TestViewToDefault(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 255, 69, 208, 189 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.TestViewToDefaultReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> TestViewToDefault_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 255, 69, 208, 189 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.TestViewToDefaultReturn> TestPureToDefault(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 139, 32, 238 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.TestViewToDefaultReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> TestPureToDefault_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 139, 32, 238 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.TestViewToDefaultReturn> TestPureToView(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 178, 15, 247, 111 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.TestViewToDefaultReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> TestPureToView_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 178, 15, 247, 111 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQyIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJUZXN0Vmlld1RvRGVmYXVsdFJldHVybiI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJ1aW50MjU2In0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6InVpbnQyNTYifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiZXh0ZXJuYWxEZWZhdWx0IiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImV4dGVybmFsVmlldyIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImV4dGVybmFsUHVyZSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlc3RWaWV3VG9EZWZhdWx0IiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6Iih1aW50MjU2LHVpbnQyNTYpIiwic3RydWN0IjoiVGVzdFZpZXdUb0RlZmF1bHRSZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0ZXN0UHVyZVRvRGVmYXVsdCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDI1Nix1aW50MjU2KSIsInN0cnVjdCI6IlRlc3RWaWV3VG9EZWZhdWx0UmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidGVzdFB1cmVUb1ZpZXciLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQyNTYsdWludDI1NikiLCJzdHJ1Y3QiOiJUZXN0Vmlld1RvRGVmYXVsdFJldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6Nn0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbNDYwLDQ3Miw1MjQsNjAwLDYxMiw2NjRdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBleHRlcm5hbERlZmF1bHRBcnJheSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMzIsMzQ0LDM5N10sImVycm9yTWVzc2FnZSI6ImNoZWNrIGV4dGVybmFsVmlld0FycmF5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ5OSw2MzldLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBpbnRlcm5hbERlZmF1bHRBcnJheSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNzJdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBpbnRlcm5hbFZpZXdBcnJheSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMzMsMzQ1LDM5OCw0NjEsNDczLDUyNSw2MDEsNjEzLDY2NV0sImVycm9yTWVzc2FnZSI6ImluZGV4IGFjY2VzcyBpcyBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTI0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBmdW5jdGlvbiBwb2ludGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzE4LDQ0Nyw1NzQsNzMyLDc5MCw4NDJdLCJlcnJvck1lc3NhZ2UiOiJub3QgcGF5YWJsZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM2MSwzODIsNDg5LDUwOSw2MjksNjQ5XSwiZXJyb3JNZXNzYWdlIjoib3ZlcmZsb3ciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5NzddLCJlcnJvck1lc3NhZ2UiOiJ1bmtub3duIGZ1bmN0aW9uIHNlbGVjdG9yIGluIHNlbGYtY2FsbCBkaXNwYXRjaCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2ZEdWemRITXZjMjlzYVdScGRIa3RjMlZ0WVc1MGFXTXRkR1Z6ZEhNdmRHVnpkSE12WTI5dWRtVnljMmx2Ym5NdlpuVnVZM1JwYjI1ZmRIbHdaVjloY25KaGVWOTBiMTl6ZEc5eVlXZGxMbk52YkM1RExtRndjSEp2ZG1Gc1gzQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTUNBeElETXlJRFFLSUNBZ0lHSjVkR1ZqWW14dlkyc2dJbVY0ZEdWeWJtRnNSR1ZtWVhWc2RFRnljbUY1SWlBaVpYaDBaWEp1WVd4V2FXVjNRWEp5WVhraUlDSnBiblJsY201aGJFUmxabUYxYkhSQmNuSmhlU0lnTUhneE5URm1OMk0zTlNBd2VEQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUNBd2VEQXdNREF3TURBd01EQXdNREF3TURBZ0ltbHVkR1Z5Ym1Gc1ZtbGxkMEZ5Y21GNUlpQXdlRFpqTnpKbE1qTmxJREI0TXpJNFl6WmtZVGtnTUhnd01EQXdNREF3TURBd01EQXdNREF3TXpJNFl6WmtZVGtLSUNBZ0lIQjFjMmhwYm5RZ05EQTVOZ29nSUNBZ1lucGxjbThLSUNBZ0lHUjFjQW9nSUNBZ2MzUnZjbVVnTlFvZ0lDQWdjM1J2Y21VZ01Bb2dJQ0FnYkc5aFpDQXdDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EZ3dDaUFnSUNCeVpYQnNZV05sTWlBMk5Bb2dJQ0FnYzNSdmNtVWdNQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0p1ZWlCdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1nb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVpYaDBaWEp1WVd4RVpXWmhkV3gwUVhKeVlYa2lDaUFnSUNCaWVYUmxZeUEwSUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVpYaDBaWEp1WVd4V2FXVjNRWEp5WVhraUNpQWdJQ0JpZVhSbFl5QTBJQzh2SURCNE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0psZUhSbGNtNWhiRkIxY21WQmNuSmhlU0lLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCaWVYUmxZMTh5SUM4dklDSnBiblJsY201aGJFUmxabUYxYkhSQmNuSmhlU0lLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ1lubDBaV01nTmlBdkx5QWlhVzUwWlhKdVlXeFdhV1YzUVhKeVlYa2lDaUFnSUNCaWVYUmxZeUExSUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUhCMWMyaGllWFJsY3lBaWFXNTBaWEp1WVd4UWRYSmxRWEp5WVhraUNpQWdJQ0JpZVhSbFl5QTFJQzh2SURCNE1EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXlPZ29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IaGlNVEpqTkRrME1TQXZMeUJ0WlhSb2IyUWdJbVY0ZEdWeWJtRnNSR1ZtWVhWc2RDZ3BkV2x1ZERJMU5pSUtJQ0FnSUdKNWRHVmpJRGNnTHk4Z2JXVjBhRzlrSUNKbGVIUmxjbTVoYkZacFpYY29LWFZwYm5ReU5UWWlDaUFnSUNCaWVYUmxZeUE0SUM4dklHMWxkR2h2WkNBaVpYaDBaWEp1WVd4UWRYSmxLQ2wxYVc1ME1qVTJJZ29nSUNBZ2NIVnphR0o1ZEdWemN5QXdlR1ptTkRWa01HSmtJREI0WWpnNFlqSXdaV1VnTUhoaU1qQm1aamMyWmlBdkx5QnRaWFJvYjJRZ0luUmxjM1JXYVdWM1ZHOUVaV1poZFd4MEtDa29kV2x1ZERJMU5peDFhVzUwTWpVMktTSXNJRzFsZEdodlpDQWlkR1Z6ZEZCMWNtVlViMFJsWm1GMWJIUW9LU2gxYVc1ME1qVTJMSFZwYm5ReU5UWXBJaXdnYldWMGFHOWtJQ0owWlhOMFVIVnlaVlJ2Vm1sbGR5Z3BLSFZwYm5ReU5UWXNkV2x1ZERJMU5pa2lDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0J0WVdsdVgyVjRkR1Z5Ym1Gc1JHVm1ZWFZzZEY5eWIzVjBaVUExSUcxaGFXNWZaWGgwWlhKdVlXeFdhV1YzWDNKdmRYUmxRRFlnYldGcGJsOWxlSFJsY201aGJGQjFjbVZmY205MWRHVkFOeUJ0WVdsdVgzUmxjM1JXYVdWM1ZHOUVaV1poZFd4MFgzSnZkWFJsUURnZ2JXRnBibDkwWlhOMFVIVnlaVlJ2UkdWbVlYVnNkRjl5YjNWMFpVQTVJRzFoYVc1ZmRHVnpkRkIxY21WVWIxWnBaWGRmY205MWRHVkFNVEFLSUNBZ0lHVnljZ29LYldGcGJsOTBaWE4wVUhWeVpWUnZWbWxsZDE5eWIzVjBaVUF4TURvS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JpZWlCdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU1UWUtJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaM1I0Ym5NZ1FXMXZkVzUwQ2dwdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU1UYzZDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnYm05MElIQmhlV0ZpYkdVS0lDQWdJR0o1ZEdWalh6RWdMeThnSW1WNGRHVnlibUZzVm1sbGQwRnljbUY1SWdvZ0lDQWdZbmwwWldNZ09TQXZMeUF3ZURBd01EQXdNREF3TURBd01EQXdNREF6TWpoak5tUmhPUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHbHVkR05mTXlBdkx5QTBDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZeUEySUM4dklDSnBiblJsY201aGJGWnBaWGRCY25KaGVTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVpYaDBaWEp1WVd4V2FXVjNRWEp5WVhraUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUdWNGRHVnlibUZzVm1sbGQwRnljbUY1SUdWNGFYTjBjd29nSUNBZ1pYaDBjbUZqZENBd0lERXlJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0JoWTJObGMzTWdhWE1nYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JpYm5vZ2JXRnBibDlsYkhObFgySnZaSGxBTVRrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0psZUhSbGNtNWhiRlpwWlhkQmNuSmhlU0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2daWGgwWlhKdVlXeFdhV1YzUVhKeVlYa2daWGhwYzNSekNpQWdJQ0JsZUhSeVlXTjBJREFnTVRJZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHRmpZMlZ6Y3lCcGN5QnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQmxlSFJ5WVdOMElEZ2dOQW9nSUNBZ1kyRnNiSE4xWWlCZlgzTmxiRjkwYjE5cFpGOWZYMloxYm1Od2RISmZaR2x6Y0dGMFkyaGZjbVYwWDNVeU5UWUtJQ0FnSUdOaGJHeHpkV0lnWDE5bWRXNWpjSFJ5WDJScGMzQmhkR05vWDNKbGRGOTFNalUyQ2dwdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1qQTZDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUdKNlpYSnZDaUFnSUNCemQyRndDaUFnSUNCa2FXY2dNUW9nSUNBZ1lud0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTJJQzh2SUNKcGJuUmxjbTVoYkZacFpYZEJjbkpoZVNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYVc1MFpYSnVZV3hXYVdWM1FYSnlZWGtnWlhocGMzUnpDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdOaGJHeHpkV0lnWDE5bWRXNWpjSFJ5WDJScGMzQmhkR05vWDNKbGRGOTFNalUyQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdKOENpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYek1nTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZlpXeHpaVjlpYjJSNVFERTVPZ29nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6RWdMeThnSW1WNGRHVnlibUZzVm1sbGQwRnljbUY1SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJsZUhSbGNtNWhiRlpwWlhkQmNuSmhlU0JsZUdsemRITUtJQ0FnSUdWNGRISmhZM1FnTUNBeE1pQXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2dZV05qWlhOeklHbHpJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJR1IxY0FvZ0lDQWdaWGgwY21GamRDQTRJRFFLSUNBZ0lITjNZWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ2NIVnphR2x1ZENBMkNpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQlBia052YlhCc1pYUnBiMjRLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJR2wwZUc0Z1RHRnpkRXh2WndvZ0lDQWdaWGgwY21GamRDQTBJREFLSUNBZ0lHSWdiV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRREl3Q2dwdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU1UWTZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWWlCdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU1UY0tDbTFoYVc1ZmRHVnpkRkIxY21WVWIwUmxabUYxYkhSZmNtOTFkR1ZBT1RvS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JpZWlCdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU1qUUtJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaM1I0Ym5NZ1FXMXZkVzUwQ2dwdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU1qVTZDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnYm05MElIQmhlV0ZpYkdVS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1WNGRHVnlibUZzUkdWbVlYVnNkRUZ5Y21GNUlnb2dJQ0FnWW5sMFpXTWdPU0F2THlBd2VEQXdNREF3TURBd01EQXdNREF3TURBek1qaGpObVJoT1FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR2x1ZEdOZk15QXZMeUEwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0pwYm5SbGNtNWhiRVJsWm1GMWJIUkJjbkpoZVNJS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWlhoMFpYSnVZV3hFWldaaGRXeDBRWEp5WVhraUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUdWNGRHVnlibUZzUkdWbVlYVnNkRUZ5Y21GNUlHVjRhWE4wY3dvZ0lDQWdaWGgwY21GamRDQXdJREV5SUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCaFkyTmxjM01nYVhNZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCaWJub2diV0ZwYmw5bGJITmxYMkp2WkhsQU1qY0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKbGVIUmxjbTVoYkVSbFptRjFiSFJCY25KaGVTSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1pYaDBaWEp1WVd4RVpXWmhkV3gwUVhKeVlYa2daWGhwYzNSekNpQWdJQ0JsZUhSeVlXTjBJREFnTVRJZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHRmpZMlZ6Y3lCcGN5QnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQmxlSFJ5WVdOMElEZ2dOQW9nSUNBZ1kyRnNiSE4xWWlCZlgzTmxiRjkwYjE5cFpGOWZYMloxYm1Od2RISmZaR2x6Y0dGMFkyaGZjbVYwWDNVeU5UWUtJQ0FnSUdOaGJHeHpkV0lnWDE5bWRXNWpjSFJ5WDJScGMzQmhkR05vWDNKbGRGOTFNalUyQ2dwdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1qZzZDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUdKNlpYSnZDaUFnSUNCemQyRndDaUFnSUNCa2FXY2dNUW9nSUNBZ1lud0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKcGJuUmxjbTVoYkVSbFptRjFiSFJCY25KaGVTSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2FXNTBaWEp1WVd4RVpXWmhkV3gwUVhKeVlYa2daWGhwYzNSekNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR05oYkd4emRXSWdYMTltZFc1amNIUnlYMlJwYzNCaGRHTm9YM0psZEY5MU1qVTJDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR0o4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWld4elpWOWliMlI1UURJM09nb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbVY0ZEdWeWJtRnNSR1ZtWVhWc2RFRnljbUY1SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJsZUhSbGNtNWhiRVJsWm1GMWJIUkJjbkpoZVNCbGVHbHpkSE1LSUNBZ0lHVjRkSEpoWTNRZ01DQXhNaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNWtaWGdnWVdOalpYTnpJR2x6SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUdSMWNBb2dJQ0FnWlhoMGNtRmpkQ0E0SURRS0lDQWdJSE4zWVhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdjSFZ6YUdsdWRDQTJDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JQYmtOdmJYQnNaWFJwYjI0S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUdsMGVHNGdUR0Z6ZEV4dlp3b2dJQ0FnWlhoMGNtRmpkQ0EwSURBS0lDQWdJR0lnYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURJNENncHRZV2x1WDNSbGNtNWhjbmxmWm1Gc2MyVkFNalE2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lpQnRZV2x1WDNSbGNtNWhjbmxmYldWeVoyVkFNalVLQ20xaGFXNWZkR1Z6ZEZacFpYZFViMFJsWm1GMWJIUmZjbTkxZEdWQU9Eb0tJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCaWVpQnRZV2x1WDNSbGNtNWhjbmxmWm1Gc2MyVkFNeklLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWjNSNGJuTWdRVzF2ZFc1MENncHRZV2x1WDNSbGNtNWhjbmxmYldWeVoyVkFNek02Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z2JtOTBJSEJoZVdGaWJHVUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltVjRkR1Z5Ym1Gc1JHVm1ZWFZzZEVGeWNtRjVJZ29nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREF3TURBd01EQXdNREF3TURBd01EWmpOekpsTWpObENpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnY0hWemFHbHVkQ0F5Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0pwYm5SbGNtNWhiRVJsWm1GMWJIUkJjbkpoZVNJS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWlhoMFpYSnVZV3hFWldaaGRXeDBRWEp5WVhraUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUdWNGRHVnlibUZzUkdWbVlYVnNkRUZ5Y21GNUlHVjRhWE4wY3dvZ0lDQWdaWGgwY21GamRDQXdJREV5SUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCaFkyTmxjM01nYVhNZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCaWJub2diV0ZwYmw5bGJITmxYMkp2WkhsQU16VUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKbGVIUmxjbTVoYkVSbFptRjFiSFJCY25KaGVTSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1pYaDBaWEp1WVd4RVpXWmhkV3gwUVhKeVlYa2daWGhwYzNSekNpQWdJQ0JsZUhSeVlXTjBJREFnTVRJZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHRmpZMlZ6Y3lCcGN5QnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQmxlSFJ5WVdOMElEZ2dOQW9nSUNBZ1kyRnNiSE4xWWlCZlgzTmxiRjkwYjE5cFpGOWZYMloxYm1Od2RISmZaR2x6Y0dGMFkyaGZjbVYwWDNVeU5UWUtJQ0FnSUdOaGJHeHpkV0lnWDE5bWRXNWpjSFJ5WDJScGMzQmhkR05vWDNKbGRGOTFNalUyQ2dwdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU16WTZDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUdKNlpYSnZDaUFnSUNCemQyRndDaUFnSUNCa2FXY2dNUW9nSUNBZ1lud0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKcGJuUmxjbTVoYkVSbFptRjFiSFJCY25KaGVTSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2FXNTBaWEp1WVd4RVpXWmhkV3gwUVhKeVlYa2daWGhwYzNSekNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR05oYkd4emRXSWdYMTltZFc1amNIUnlYMlJwYzNCaGRHTm9YM0psZEY5MU1qVTJDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR0o4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWld4elpWOWliMlI1UURNMU9nb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbVY0ZEdWeWJtRnNSR1ZtWVhWc2RFRnljbUY1SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJsZUhSbGNtNWhiRVJsWm1GMWJIUkJjbkpoZVNCbGVHbHpkSE1LSUNBZ0lHVjRkSEpoWTNRZ01DQXhNaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNWtaWGdnWVdOalpYTnpJR2x6SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUdSMWNBb2dJQ0FnWlhoMGNtRmpkQ0E0SURRS0lDQWdJSE4zWVhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdjSFZ6YUdsdWRDQTJDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JQYmtOdmJYQnNaWFJwYjI0S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUdsMGVHNGdUR0Z6ZEV4dlp3b2dJQ0FnWlhoMGNtRmpkQ0EwSURBS0lDQWdJR0lnYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURNMkNncHRZV2x1WDNSbGNtNWhjbmxmWm1Gc2MyVkFNekk2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lpQnRZV2x1WDNSbGNtNWhjbmxmYldWeVoyVkFNek1LQ20xaGFXNWZaWGgwWlhKdVlXeFFkWEpsWDNKdmRYUmxRRGM2Q2lBZ0lDQmpZV3hzYzNWaUlHVjRkR1Z5Ym1Gc1VIVnlaUW9nSUNBZ1lubDBaV05mTXlBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWxlSFJsY201aGJGWnBaWGRmY205MWRHVkFOam9LSUNBZ0lHTmhiR3h6ZFdJZ1pYaDBaWEp1WVd4V2FXVjNDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyVjRkR1Z5Ym1Gc1JHVm1ZWFZzZEY5eWIzVjBaVUExT2dvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR0o2SUcxaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBME5Bb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0F0Q2lBZ0lDQm5kSGh1Y3lCQmJXOTFiblFLQ20xaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBME5Ub0tJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJ1YjNRZ2NHRjVZV0pzWlFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TVRVeFpqZGpOelV3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREJpQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBME5Eb0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpSUcxaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBME5Rb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzkwWlhOMGN5OXpiMnhwWkdsMGVTMXpaVzFoYm5ScFl5MTBaWE4wY3k5MFpYTjBjeTlqYjI1MlpYSnphVzl1Y3k5bWRXNWpkR2x2Ymw5MGVYQmxYMkZ5Y21GNVgzUnZYM04wYjNKaFoyVXVjMjlzTGtNdVpYaDBaWEp1WVd4V2FXVjNLQ2tnTFQ0Z1lubDBaWE02Q21WNGRHVnlibUZzVm1sbGR6b0tJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCaWVpQmxlSFJsY201aGJGWnBaWGRmZEdWeWJtRnllVjltWVd4elpVQXlDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUMwS0lDQWdJR2QwZUc1eklFRnRiM1Z1ZEFvS1pYaDBaWEp1WVd4V2FXVjNYM1JsY201aGNubGZiV1Z5WjJWQU16b0tJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJ1YjNRZ2NHRjVZV0pzWlFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3WXdvZ0lDQWdjbVYwYzNWaUNncGxlSFJsY201aGJGWnBaWGRmZEdWeWJtRnllVjltWVd4elpVQXlPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdJZ1pYaDBaWEp1WVd4V2FXVjNYM1JsY201aGNubGZiV1Z5WjJWQU13b0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzkwWlhOMGN5OXpiMnhwWkdsMGVTMXpaVzFoYm5ScFl5MTBaWE4wY3k5MFpYTjBjeTlqYjI1MlpYSnphVzl1Y3k5bWRXNWpkR2x2Ymw5MGVYQmxYMkZ5Y21GNVgzUnZYM04wYjNKaFoyVXVjMjlzTGtNdVpYaDBaWEp1WVd4UWRYSmxLQ2tnTFQ0Z1lubDBaWE02Q21WNGRHVnlibUZzVUhWeVpUb0tJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCaWVpQmxlSFJsY201aGJGQjFjbVZmZEdWeWJtRnllVjltWVd4elpVQXlDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUMwS0lDQWdJR2QwZUc1eklFRnRiM1Z1ZEFvS1pYaDBaWEp1WVd4UWRYSmxYM1JsY201aGNubGZiV1Z5WjJWQU16b0tJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJ1YjNRZ2NHRjVZV0pzWlFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3WkFvZ0lDQWdjbVYwYzNWaUNncGxlSFJsY201aGJGQjFjbVZmZEdWeWJtRnllVjltWVd4elpVQXlPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdJZ1pYaDBaWEp1WVd4UWRYSmxYM1JsY201aGNubGZiV1Z5WjJWQU13b0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzkwWlhOMGN5OXpiMnhwWkdsMGVTMXpaVzFoYm5ScFl5MTBaWE4wY3k5MFpYTjBjeTlqYjI1MlpYSnphVzl1Y3k5bWRXNWpkR2x2Ymw5MGVYQmxYMkZ5Y21GNVgzUnZYM04wYjNKaFoyVXVjMjlzTGtNdVgxOW1kVzVqY0hSeVgyUnBjM0JoZEdOb1gzSmxkRjkxTWpVMktGOWZablZ1WTNCMGNsOXBaRG9nZFdsdWREWTBLU0F0UGlCaWVYUmxjem9LWDE5bWRXNWpjSFJ5WDJScGMzQmhkR05vWDNKbGRGOTFNalUyT2dvZ0lDQWdjSEp2ZEc4Z01TQXhDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdsdWRHTmZNeUF2THlBMENpQWdJQ0E5UFFvZ0lDQWdZbm9nWDE5bWRXNWpjSFJ5WDJScGMzQmhkR05vWDNKbGRGOTFNalUyWDJWc2MyVmZZbTlrZVVBeUNpQWdJQ0J3ZFhOb2FXNTBJREl6Q2lBZ0lDQnBkRzlpQ2lBZ0lDQnlaWFJ6ZFdJS0NsOWZablZ1WTNCMGNsOWthWE53WVhSamFGOXlaWFJmZFRJMU5sOWxiSE5sWDJKdlpIbEFNam9LSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2NIVnphR2x1ZENBeUNpQWdJQ0E5UFFvZ0lDQWdZbm9nWDE5bWRXNWpjSFJ5WDJScGMzQmhkR05vWDNKbGRGOTFNalUyWDJWc2MyVmZZbTlrZVVBMENpQWdJQ0J3ZFhOb2FXNTBJREl5Q2lBZ0lDQnBkRzlpQ2lBZ0lDQnlaWFJ6ZFdJS0NsOWZablZ1WTNCMGNsOWthWE53WVhSamFGOXlaWFJmZFRJMU5sOWxiSE5sWDJKdlpIbEFORG9LSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2NIVnphR2x1ZENBekNpQWdJQ0E5UFFvZ0lDQWdZbm9nWDE5bWRXNWpjSFJ5WDJScGMzQmhkR05vWDNKbGRGOTFNalUyWDJWc2MyVmZZbTlrZVVBMkNpQWdJQ0JqWVd4c2MzVmlJR1Y0ZEdWeWJtRnNVSFZ5WlFvZ0lDQWdjbVYwYzNWaUNncGZYMloxYm1Od2RISmZaR2x6Y0dGMFkyaGZjbVYwWDNVeU5UWmZaV3h6WlY5aWIyUjVRRFk2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnWm5WdVkzUnBiMjRnY0c5cGJuUmxjZ29nSUNBZ1kyRnNiSE4xWWlCbGVIUmxjbTVoYkZacFpYY0tJQ0FnSUhKbGRITjFZZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5MFpYTjBjeTl6YjJ4cFpHbDBlUzF6WlcxaGJuUnBZeTEwWlhOMGN5OTBaWE4wY3k5amIyNTJaWEp6YVc5dWN5OW1kVzVqZEdsdmJsOTBlWEJsWDJGeWNtRjVYM1J2WDNOMGIzSmhaMlV1YzI5c0xrTXVYMTl6Wld4ZmRHOWZhV1JmWDE5bWRXNWpjSFJ5WDJScGMzQmhkR05vWDNKbGRGOTFNalUyS0Y5ZmMyVnNPaUJpZVhSbGN5a2dMVDRnZFdsdWREWTBPZ3BmWDNObGJGOTBiMTlwWkY5ZlgyWjFibU53ZEhKZlpHbHpjR0YwWTJoZmNtVjBYM1V5TlRZNkNpQWdJQ0J3Y205MGJ5QXhJREVLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRZV05rTUdKaVptUWdMeThnYldWMGFHOWtJQ0pwYm5SbGNtNWhiRkIxY21Vb0tYVnBiblF5TlRZaUNpQWdJQ0E5UFFvZ0lDQWdZbm9nWDE5elpXeGZkRzlmYVdSZlgxOW1kVzVqY0hSeVgyUnBjM0JoZEdOb1gzSmxkRjkxTWpVMlgyVnNjMlZmWW05a2VVQXlDaUFnSUNCcGJuUmpYek1nTHk4Z05Bb2dJQ0FnY21WMGMzVmlDZ3BmWDNObGJGOTBiMTlwWkY5ZlgyWjFibU53ZEhKZlpHbHpjR0YwWTJoZmNtVjBYM1V5TlRaZlpXeHpaVjlpYjJSNVFESTZDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VHRTBaV05sWWpneElDOHZJRzFsZEdodlpDQWlhVzUwWlhKdVlXeFdhV1YzS0NsMWFXNTBNalUySWdvZ0lDQWdQVDBLSUNBZ0lHSjZJRjlmYzJWc1gzUnZYMmxrWDE5ZlpuVnVZM0IwY2w5a2FYTndZWFJqYUY5eVpYUmZkVEkxTmw5bGJITmxYMkp2WkhsQU5Bb2dJQ0FnY0hWemFHbHVkQ0F5Q2lBZ0lDQnlaWFJ6ZFdJS0NsOWZjMlZzWDNSdlgybGtYMTlmWm5WdVkzQjBjbDlrYVhOd1lYUmphRjl5WlhSZmRUSTFObDlsYkhObFgySnZaSGxBTkRvS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZbmwwWldNZ09DQXZMeUJ0WlhSb2IyUWdJbVY0ZEdWeWJtRnNVSFZ5WlNncGRXbHVkREkxTmlJS0lDQWdJRDA5Q2lBZ0lDQmllaUJmWDNObGJGOTBiMTlwWkY5ZlgyWjFibU53ZEhKZlpHbHpjR0YwWTJoZmNtVjBYM1V5TlRaZlpXeHpaVjlpYjJSNVFEWUtJQ0FnSUhCMWMyaHBiblFnTXdvZ0lDQWdjbVYwYzNWaUNncGZYM05sYkY5MGIxOXBaRjlmWDJaMWJtTndkSEpmWkdsemNHRjBZMmhmY21WMFgzVXlOVFpmWld4elpWOWliMlI1UURZNkNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR0o1ZEdWaklEY2dMeThnYldWMGFHOWtJQ0psZUhSbGNtNWhiRlpwWlhjb0tYVnBiblF5TlRZaUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJSFZ1YTI1dmQyNGdablZ1WTNScGIyNGdjMlZzWldOMGIzSWdhVzRnYzJWc1ppMWpZV3hzSUdScGMzQmhkR05vQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBjM1ZpQ2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2ZEdWemRITXZjMjlzYVdScGRIa3RjMlZ0WVc1MGFXTXRkR1Z6ZEhNdmRHVnpkSE12WTI5dWRtVnljMmx2Ym5NdlpuVnVZM1JwYjI1ZmRIbHdaVjloY25KaGVWOTBiMTl6ZEc5eVlXZGxMbk52YkM1RExtTnNaV0Z5WDNOMFlYUmxYM0J5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFS0lDQWdJSEpsZEhWeWJnbz0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFFQUFFZ0JDWUtGR1Y0ZEdWeWJtRnNSR1ZtWVhWc2RFRnljbUY1RVdWNGRHVnlibUZzVm1sbGQwRnljbUY1RkdsdWRHVnlibUZzUkdWbVlYVnNkRUZ5Y21GNUJCVWZmSFVNQUFBQUFBQUFBQUFBQUFBQUNBQUFBQUFBQUFBQUVXbHVkR1Z5Ym1Gc1ZtbGxkMEZ5Y21GNUJHeHk0ajRFTW94dHFRd0FBQUFBQUFBQUFES01iYW1CZ0NDdlNUVUZOUUEwQUlBZ0FBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBSUJjUURVQU1SaEFBRDhvSndSbktTY0VaNEFSWlhoMFpYSnVZV3hRZFhKbFFYSnlZWGtuQkdjcUp3Vm5Kd1luQldlQUVXbHVkR1Z5Ym1Gc1VIVnlaVUZ5Y21GNUp3Vm5JME14R1JSRU1SaEVnQVN4TEVsQkp3Y25DSUlEQlA5RjBMMEV1SXNnN2dTeUQvZHZOaG9BamdZQm53R1dBWTBCQVFDQ0FBRUFNUlpCQUhneEZpTUpPQWdVUkNrbkNXY2xGaWNHVEdjaUtXVkVWd0FNSWx0QUFEUWlLV1ZFVndBTVZ3Z0VpQUkvaUFJTlNSVWtEa1FrcjB4TEFhc2lKd1psUkNKYmlBSDRTUlVrRGtSUEFxdFFLMHhRc0NORHNTSXBaVVJYQUF4SlZ3Z0VUQ0piZ1FheUVDS3lHU0t5QWJJWXNocXp0RDVYQkFCQy83WWlRditLTVJaQkFIWXhGaU1KT0FnVVJDZ25DV2NsRmlwTVp5SW9aVVJYQUF3aVcwQUFNeUlvWlVSWEFBeFhDQVNJQWIrSUFZMUpGU1FPUkNTdlRFc0JxeUlxWlVRaVc0Z0JlVWtWSkE1RVR3S3JVQ3RNVUxBalE3RWlLR1ZFVndBTVNWY0lCRXdpVzRFR3NoQWlzaGtpc2dHeUdMSWFzN1ErVndRQVF2KzNJa0wvakRFV1FRQ0RNUllqQ1RnSUZFUW9nQXdBQUFBQUFBQUFBR3h5NGo1bmdRSVdLa3huSWlobFJGY0FEQ0piUUFBeklpaGxSRmNBREZjSUJJZ0JNNGdCQVVrVkpBNUVKSzlNU3dHcklpcGxSQ0piaUFEdFNSVWtEa1JQQXF0UUsweFFzQ05Ec1NJb1pVUlhBQXhKVndnRVRDSmJnUWF5RUNLeUdTS3lBYklZc2hxenRENVhCQUJDLzdjaVF2OS9pQUI5SzB4UXNDTkRpQUJBSzB4UXNDTkRNUlpCQURFeEZpTUpPQWdVUklBa0ZSOThkUUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBTHNDTkRJa0wvMFRFV1FRQXJNUllqQ1RnSUZFU0FJQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBTWlTSkMvOWN4RmtFQUt6RVdJd2s0Q0JSRWdDQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBRFlraVF2L1hpZ0VCaS84bEVrRUFCSUVYRm9tTC80RUNFa0VBQklFV0ZvbUwvNEVERWtFQUJJai9wNG1ML3lNU1JJai9hb21LQVFHTC80QUVyTkM3L1JKQkFBSWxpWXYvZ0FTazdPdUJFa0VBQTRFQ2lZdi9Kd2dTUVFBRGdRT0ppLzhuQnhKRUk0az0iLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo4LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
