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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.C_e0e82876
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
            public class FReturn : AVMObjectType
            {
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field0 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field1 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field2 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field3 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field4 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field5 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field6 { get; set; }

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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vField2.From(Field2);
                    ret.AddRange(vField2.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vField3.From(Field3);
                    ret.AddRange(vField3.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vField4.From(Field4);
                    ret.AddRange(vField4.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField5 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vField5.From(Field5);
                    ret.AddRange(vField5.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField6 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vField6.From(Field6);
                    ret.AddRange(vField6.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static FReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new FReturn();
                    uint count = 0;
                    var vField0 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field0 = vField0;
                    var vField1 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field1 = vField1;
                    var vField2 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field2 = vField2;
                    var vField3 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vField3.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field3 = vField3;
                    var vField4 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vField4.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field4 = vField4;
                    var vField5 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vField5.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field5 = vField5;
                    var vField6 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vField6.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field6 = vField6;
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as FReturn);
                }
                public bool Equals(FReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(FReturn left, FReturn right)
                {
                    return EqualityComparer<FReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(FReturn left, FReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="__arc4_a"> </param>
        /// <param name="b"> </param>
        /// <param name="c"> </param>
        /// <param name="__arc4_d"> </param>
        public async Task<Structs.FReturn> F(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_a, ushort[][] b, AVM.ClientGenerator.ABI.ARC4.Types.UInt256[][][] c, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_d, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 143, 21, 85, 73 };
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt16>>("uint16[]"); bAbi.From(b);
            var cAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt256>>>(3, "uint256[2][]"); cAbi.From(c);

            var result = await base.SimApp(new List<object> { abiHandle, __arc4_a, bAbi, cAbi, __arc4_d }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.FReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> F_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_a, ushort[][] b, AVM.ClientGenerator.ABI.ARC4.Types.UInt256[][][] c, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_d, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 143, 21, 85, 73 };
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt16>>("uint16[]"); bAbi.From(b);
            var cAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt256>>>(3, "uint256[2][]"); cAbi.From(c);

            return await base.MakeTransactionList(new List<object> { abiHandle, __arc4_a, bAbi, cAbi, __arc4_d }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.FReturn> Test(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 138, 148, 163, 181 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.FReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> Test_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 138, 148, 163, 181 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQyIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJGUmV0dXJuIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6InVpbnQyNTYifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6ImZpZWxkMiIsInR5cGUiOiJ1aW50MjU2In0seyJuYW1lIjoiZmllbGQzIiwidHlwZSI6InVpbnQyNTYifSx7Im5hbWUiOiJmaWVsZDQiLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6ImZpZWxkNSIsInR5cGUiOiJ1aW50MjU2In0seyJuYW1lIjoiZmllbGQ2IiwidHlwZSI6InVpbnQyNTYifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiZiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiX19hcmM0X2EiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQxNltdW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJiIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2WzJdW11bM10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiX19hcmM0X2QiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQyNTYsdWludDI1Nix1aW50MjU2LHVpbnQyNTYsdWludDI1Nix1aW50MjU2LHVpbnQyNTYpIiwic3RydWN0IjoiRlJldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidGVzdCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDI1Nix1aW50MjU2LHVpbnQyNTYsdWludDI1Nix1aW50MjU2LHVpbnQyNTYsdWludDI1NikiLCJzdHJ1Y3QiOiJGUmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzE2OSwxOTcsMjQzLDI3MywzMDMsMzMzLDQ3Myw0NzUsODcwLDg3MiwxNTUyXSwiZXJyb3JNZXNzYWdlIjoiaW5kZXggYWNjZXNzIGlzIG91dCBvZiBib3VuZHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNTAsMTc4LDIyNCwyNTQsMjg0LDMxNCwxNDkxXSwiZXJyb3JNZXNzYWdlIjoiaW5kZXggb3V0IG9mIGJvdW5kcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwNjYsMTEzM10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgZW5jb2RpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDI4LDEwODAsMTE0NywxNDc4LDE1MDksMTU0M10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExMDJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQxNj4+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTE3MF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50MjU2LCAyPj4sIDM+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTAxOSwxMTc4XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDI1NiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwNzRdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIHRhaWwgcG9pbnRlciBmb3IgKGxlbisobGVuK3VpbnQxNltdKVtdKSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExNDFdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIHRhaWwgcG9pbnRlciBmb3IgKGxlbit1aW50MjU2WzJdW10pWzNdIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTE4LDE0NzRdLCJlcnJvck1lc3NhZ2UiOiJub3QgcGF5YWJsZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzkxMiw5MjEsOTMxLDk0Miw5NTMsOTY0LDk3NV0sImVycm9yTWVzc2FnZSI6Im92ZXJmbG93IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZkR1Z6ZEhNdmMyOXNhV1JwZEhrdGMyVnRZVzUwYVdNdGRHVnpkSE12ZEdWemRITXZZV0pwUlc1amIyUmxjbFl5TDJSNWJtRnRhV05mYm1WemRHVmtYMkZ5Y21GNWN5NXpiMnd1UXk1aGNIQnliM1poYkY5d2NtOW5jbUZ0S0NrZ0xUNGdkV2x1ZERZME9ncHRZV2x1T2dvZ0lDQWdhVzUwWTJKc2IyTnJJRElnTUNBeElETXlDaUFnSUNCaWVYUmxZMkpzYjJOcklEQjRJREI0TVRVeFpqZGpOelVLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCa2RYQnVJRE1LSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJaUlLSUNBZ0lHUjFjRzRnTlFvZ0lDQWdjSFZ6YUdsdWRDQTBNRGsyQ2lBZ0lDQmllbVZ5YndvZ0lDQWdaSFZ3Q2lBZ0lDQnpkRzl5WlNBMUNpQWdJQ0J6ZEc5eVpTQXdDaUFnSUNCc2IyRmtJREFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdPREFLSUNBZ0lISmxjR3hoWTJVeUlEWTBDaUFnSUNCemRHOXlaU0F3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWW01NklHMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXlDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWpvS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdjSFZ6YUdKNWRHVnpjeUF3ZURobU1UVTFOVFE1SURCNE9HRTVOR0V6WWpVZ0x5OGdiV1YwYUc5a0lDSm1LSFZwYm5ReU5UWXNkV2x1ZERFMlcxMWJYU3gxYVc1ME1qVTJXekpkVzExYk0xMHNkV2x1ZERJMU5pa29kV2x1ZERJMU5peDFhVzUwTWpVMkxIVnBiblF5TlRZc2RXbHVkREkxTml4MWFXNTBNalUyTEhWcGJuUXlOVFlzZFdsdWRESTFOaWtpTENCdFpYUm9iMlFnSW5SbGMzUW9LU2gxYVc1ME1qVTJMSFZwYm5ReU5UWXNkV2x1ZERJMU5peDFhVzUwTWpVMkxIVnBiblF5TlRZc2RXbHVkREkxTml4MWFXNTBNalUyS1NJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lHMWhhVzVmWmw5eWIzVjBaVUExSUcxaGFXNWZkR1Z6ZEY5eWIzVjBaVUEyQ2lBZ0lDQmxjbklLQ20xaGFXNWZkR1Z6ZEY5eWIzVjBaVUEyT2dvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR0o2SUcxaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeE1nb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0F0Q2lBZ0lDQm5kSGh1Y3lCQmJXOTFiblFLQ20xaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBeE16b0tJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJ1YjNRZ2NHRjVZV0pzWlFvZ0lDQWdjSFZ6YUdKNWRHVnpjeUF3ZURBd01ETXdNREEyTURBd09EQXdNR0V3TURBd01EQXdNREF3TURBZ01IZ3dNREF5TURBd01EQXdNREFLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCallXeHNjM1ZpSUdSNWJtRnRhV05mWVhKeVlYbGZjbVZ3YkdGalpWOWtlVzVoYldsalgyVnNaVzFsYm5RS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQmhjM05sY25RZ0x5OGdhVzVrWlhnZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ1pIVndDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR1IxY0RJS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JwYm5Salh6QWdMeThnTWdvZ0lDQWdLZ29nSUNBZ2FXNTBZMTh3SUM4dklESUtJQ0FnSUNzS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNRFUxQ2lBZ0lDQnlaWEJzWVdObE1pQXlJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0JoWTJObGMzTWdhWE1nYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR05oYkd4emRXSWdaSGx1WVcxcFkxOWhjbkpoZVY5eVpYQnNZV05sWDJSNWJtRnRhV05mWld4bGJXVnVkQW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUdGemMyVnlkQ0F2THlCcGJtUmxlQ0J2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0JrZFhBS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ1pIVndNZ29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lHbHVkR05mTUNBdkx5QXlDaUFnSUNBcUNpQWdJQ0JwYm5Salh6QWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd05UWUtJQ0FnSUhKbGNHeGhZMlV5SURRZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHRmpZMlZ6Y3lCcGN5QnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1kyRnNiSE4xWWlCa2VXNWhiV2xqWDJGeWNtRjVYM0psY0d4aFkyVmZaSGx1WVcxcFkxOWxiR1Z0Wlc1MENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01EQTBNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJR05oYkd4emRXSWdaSGx1WVcxcFkxOWhjbkpoZVY5eVpYQnNZV05sWDJSNWJtRnRhV05mWld4bGJXVnVkQW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0ErQ2lBZ0lDQmhjM05sY25RZ0x5OGdhVzVrWlhnZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ1pIVndDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTWdvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR1IxY0RJS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JwYm5Salh6QWdMeThnTWdvZ0lDQWdLZ29nSUNBZ2FXNTBZMTh3SUM4dklESUtJQ0FnSUNzS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNRFkxQ2lBZ0lDQnlaWEJzWVdObE1pQXlJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0JoWTJObGMzTWdhWE1nYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJR05oYkd4emRXSWdaSGx1WVcxcFkxOWhjbkpoZVY5eVpYQnNZV05sWDJSNWJtRnRhV05mWld4bGJXVnVkQW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0ErQ2lBZ0lDQmhjM05sY25RZ0x5OGdhVzVrWlhnZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ1pIVndDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTWdvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR1IxY0RJS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JwYm5Salh6QWdMeThnTWdvZ0lDQWdLZ29nSUNBZ2FXNTBZMTh3SUM4dklESUtJQ0FnSUNzS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNRFkyQ2lBZ0lDQnlaWEJzWVdObE1pQTBJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0JoWTJObGMzTWdhWE1nYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJR05oYkd4emRXSWdaSGx1WVcxcFkxOWhjbkpoZVY5eVpYQnNZV05sWDJSNWJtRnRhV05mWld4bGJXVnVkQW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0ErQ2lBZ0lDQmhjM05sY25RZ0x5OGdhVzVrWlhnZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ1pIVndDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTWdvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR1IxY0RJS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JwYm5Salh6QWdMeThnTWdvZ0lDQWdLZ29nSUNBZ2FXNTBZMTh3SUM4dklESUtJQ0FnSUNzS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNRFkzQ2lBZ0lDQnlaWEJzWVdObE1pQTJJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0JoWTJObGMzTWdhWE1nYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJR05oYkd4emRXSWdaSGx1WVcxcFkxOWhjbkpoZVY5eVpYQnNZV05sWDJSNWJtRnRhV05mWld4bGJXVnVkQW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0ErQ2lBZ0lDQmhjM05sY25RZ0x5OGdhVzVrWlhnZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ1pIVndDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTWdvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR1IxY0RJS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JwYm5Salh6QWdMeThnTWdvZ0lDQWdLZ29nSUNBZ2FXNTBZMTh3SUM4dklESUtJQ0FnSUNzS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNRFk0Q2lBZ0lDQnlaWEJzWVdObE1pQTRJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0JoWTJObGMzTWdhWE1nYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJR05oYkd4emRXSWdaSGx1WVcxcFkxOWhjbkpoZVY5eVpYQnNZV05sWDJSNWJtRnRhV05mWld4bGJXVnVkQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREF3TVRBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdjSFZ6YUdsdWRDQXpDaUFnSUNCallXeHNjM1ZpSUhOMFlYUnBZMTloY25KaGVWOXlaWEJzWVdObFgyUjVibUZ0YVdOZlpXeGxiV1Z1ZEFvZ0lDQWdhVzUwWTE4eklDOHZJRE15Q2lBZ0lDQmllbVZ5YndvZ0lDQWdaR2xuSURFS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdaR2xuSURJS0lDQWdJR1JwWnlBeENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnY0hWemFHbHVkQ0EyTkFvZ0lDQWdLZ29nSUNBZ2FXNTBZMTh3SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBekNpQWdJQ0JqYjNabGNpQXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaSFZ3Q2lBZ0lDQmxlSFJ5WVdOMElESWdOalFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdOelVLSUNBZ0lISmxjR3hoWTJVeUlETXlJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0JoWTJObGMzTWdhWE1nYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnY21Wd2JHRmpaVElnTWlBdkx5QnZiaUJsY25KdmNqb2dhVzVrWlhnZ1lXTmpaWE56SUdseklHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJSEIxYzJocGJuUWdNd29nSUNBZ1kyRnNiSE4xWWlCemRHRjBhV05mWVhKeVlYbGZjbVZ3YkdGalpWOWtlVzVoYldsalgyVnNaVzFsYm5RS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd01EVXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY0hWemFHbHVkQ0F6Q2lBZ0lDQmpZV3hzYzNWaUlITjBZWFJwWTE5aGNuSmhlVjl5WlhCc1lXTmxYMlI1Ym1GdGFXTmZaV3hsYldWdWRBb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTWdvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR1IxY0RJS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0J3ZFhOb2FXNTBJRFkwQ2lBZ0lDQXFDaUFnSUNCcGJuUmpYekFnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURJS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmtkWEFLSUNBZ0lHVjRkSEpoWTNRZ05qWWdOalFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdPRFVLSUNBZ0lISmxjR3hoWTJVeUlETXlJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0JoWTJObGMzTWdhWE1nYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnY21Wd2JHRmpaVElnTmpZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHRmpZMlZ6Y3lCcGN5QnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NIVnphR2x1ZENBekNpQWdJQ0JqWVd4c2MzVmlJSE4wWVhScFkxOWhjbkpoZVY5eVpYQnNZV05sWDJSNWJtRnRhV05mWld4bGJXVnVkQW9nSUNBZ2NIVnphR2x1ZENBeE1nb2dJQ0FnYVhSdllnb2dJQ0FnY0hWemFHbHVkQ0F4TXdvZ0lDQWdhWFJ2WWdvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyRnNiSE4xWWlCbUNpQWdJQ0J3YjNCdUlESUtJQ0FnSUdOdmRtVnlJRFlLSUNBZ0lHTnZkbVZ5SURVS0lDQWdJR052ZG1WeUlEUUtJQ0FnSUdOdmRtVnlJRE1LSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSE4zWVhBS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNeklLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJR1JwWnlBM0NpQWdJQ0JpZkFvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRE15Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0J6ZDJGd0NpQWdJQ0JrYVdjZ053b2dJQ0FnWW53S0lDQWdJR1JwWnlBeUNpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUF6TWdvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmthV2NnTndvZ0lDQWdZbndLSUNBZ0lHUnBaeUF6Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QXpNZ29nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCa2FXY2dOd29nSUNBZ1lud0tJQ0FnSUdScFp5QTBDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBek1nb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2ZG1WeVpteHZkd29nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JrYVdjZ053b2dJQ0FnWW53S0lDQWdJR1JwWnlBMUNpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUF6TWdvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnZFc1amIzWmxjaUExQ2lBZ0lDQmthV2NnTndvZ0lDQWdZbndLSUNBZ0lHUnBaeUEyQ2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QXpNZ29nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdkVzVqYjNabGNpQTJDaUFnSUNCMWJtTnZkbVZ5SURjS0lDQWdJR0o4Q2lBZ0lDQjFibU52ZG1WeUlEWUtJQ0FnSUhWdVkyOTJaWElnTmdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzUmxjbTVoY25sZlptRnNjMlZBTVRJNkNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZaUJ0WVdsdVgzUmxjbTVoY25sZmJXVnlaMlZBTVRNS0NtMWhhVzVmWmw5eWIzVjBaVUExT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURFd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBNalUyQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHSjFjbmtnT1FvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlEZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBeUNpQWdJQ0FxQ2lBZ0lDQmlkWEo1SURRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQmlkWEo1SURJS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQmlkWEo1SURFd0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZblZ5ZVNBMUNncHRZV2x1WDJadmNsOW9aV0ZrWlhKQU1UWTZDaUFnSUNCa2FXY2dOQW9nSUNBZ1pHbG5JRFlLSUNBZ0lEd0tJQ0FnSUdKNklHMWhhVzVmWVdaMFpYSmZabTl5UURFNENpQWdJQ0JrYVdjZ05Bb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTWdvZ0lDQWdLZ29nSUNBZ1pHbG5JREV4Q2lBZ0lDQmtkWEFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2daVzVqYjJScGJtY0tJQ0FnSUdSMWNBb2dJQ0FnWkdsbklEWUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdOQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUhSaGFXd2djRzlwYm5SbGNpQm1iM0lnS0d4bGJpc29iR1Z1SzNWcGJuUXhObHRkS1Z0ZEtRb2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBeUNpQWdJQ0FxQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnS3dvZ0lDQWdZblZ5ZVNBMENpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdLd29nSUNBZ1luVnllU0ExQ2lBZ0lDQmlJRzFoYVc1ZlptOXlYMmhsWVdSbGNrQXhOZ29LYldGcGJsOWhablJsY2w5bWIzSkFNVGc2Q2lBZ0lDQmthV2NnTWdvZ0lDQWdhVzUwWTE4d0lDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWRERTJQajRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHSjFjbmtnTndvZ0lDQWdjSFZ6YUdsdWRDQTJDaUFnSUNCaWRYSjVJRElLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaWRYSjVJRFFLQ20xaGFXNWZabTl5WDJobFlXUmxja0F4T1RvS0lDQWdJR1JwWnlBekNpQWdJQ0J3ZFhOb2FXNTBJRE1LSUNBZ0lEd0tJQ0FnSUdKNklHMWhhVzVmWVdaMFpYSmZabTl5UURJeENpQWdJQ0JrYVdjZ013b2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTWdvZ0lDQWdLZ29nSUNBZ1pHbG5JRGdLSUNBZ0lHUjFjQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQmxibU52WkdsdVp3b2dJQ0FnWkhWd0NpQWdJQ0JrYVdjZ05Rb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQTBDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnZEdGcGJDQndiMmx1ZEdWeUlHWnZjaUFvYkdWdUszVnBiblF5TlRaYk1sMWJYU2xiTTEwS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0J3ZFhOb2FXNTBJRFkwQ2lBZ0lDQXFDaUFnSUNCcGJuUmpYekFnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdLd29nSUNBZ1luVnllU0F6Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnWW5WeWVTQTBDaUFnSUNCaUlHMWhhVzVmWm05eVgyaGxZV1JsY2tBeE9Rb0tiV0ZwYmw5aFpuUmxjbDltYjNKQU1qRTZDaUFnSUNCa2FXY2dOZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdScFp5QXpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME1qVTJMQ0F5UGo0c0lETStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblF5TlRZS0lDQWdJR1JwWnlBeE1Bb2dJQ0FnWkdsbklERXdDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1kyRnNiSE4xWWlCbUNpQWdJQ0J3YjNCdUlESUtJQ0FnSUdOdmRtVnlJRFlLSUNBZ0lHTnZkbVZ5SURVS0lDQWdJR052ZG1WeUlEUUtJQ0FnSUdOdmRtVnlJRE1LSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCZmNIVjVZVjlzYVdJdVlYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVgzSmxjR3hoWTJWZlpIbHVZVzFwWTE5bGJHVnRaVzUwS0hOdmRYSmpaVG9nWW5sMFpYTXNJRzVsZDE5cGRHVnRPaUJpZVhSbGN5d2dhVzVrWlhnNklIVnBiblEyTkNrZ0xUNGdZbmwwWlhNNkNtUjVibUZ0YVdOZllYSnlZWGxmY21Wd2JHRmpaVjlrZVc1aGJXbGpYMlZzWlcxbGJuUTZDaUFnSUNCd2NtOTBieUF6SURFS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdjM1ZpYzNSeWFXNW5JREFnTWdvZ0lDQWdaSFZ3Q2lBZ0lDQmlkRzlwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUd4bGJnb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHbHVkR05mTUNBdkx5QXlDaUFnSUNBcUNpQWdJQ0JrYVdjZ01nb2dJQ0FnWkdsbklERUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCa2FXY2dOQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNBdENpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1pHbG5JRE1LSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSE5sYkdWamRBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JwYm5Salh6QWdMeThnTWdvZ0lDQWdLZ29nSUNBZ1pHbG5JRFFLSUNBZ0lITjNZWEFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQmtkWEF5Q2lBZ0lDQXRDaUFnSUNCamIzWmxjaUEyQ2lBZ0lDQmthV2NnTkFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lITjFZbk4wY21sdVp6TUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdhVzUwWTE4d0lDOHZJRElLSUNBZ0lDb0tJQ0FnSUhOM1lYQUtDbVI1Ym1GdGFXTmZZWEp5WVhsZmNtVndiR0ZqWlY5a2VXNWhiV2xqWDJWc1pXMWxiblJmWm05eVgyaGxZV1JsY2tBeU9nb2dJQ0FnWm5KaGJXVmZaR2xuSURVS0lDQWdJR1p5WVcxbFgyUnBaeUEwQ2lBZ0lDQThDaUFnSUNCaWVpQmtlVzVoYldsalgyRnljbUY1WDNKbGNHeGhZMlZmWkhsdVlXMXBZMTlsYkdWdFpXNTBYMkZtZEdWeVgyWnZja0ExQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNd29nSUNBZ1pIVndDaUFnSUNCbWNtRnRaVjlrYVdjZ05Rb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXpDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ1puSmhiV1ZmWkdsbklERUtJQ0FnSUNzS0lDQWdJR1p5WVcxbFgyUnBaeUF5Q2lBZ0lDQXRDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01Bb2dJQ0FnWkdsbklESUtJQ0FnSUhOM1lYQUtJQ0FnSUhKbGNHeGhZMlV6Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJRE1LSUNBZ0lHbHVkR05mTUNBdkx5QXlDaUFnSUNBckNpQWdJQ0JtY21GdFpWOWlkWEo1SURVS0lDQWdJR0lnWkhsdVlXMXBZMTloY25KaGVWOXlaWEJzWVdObFgyUjVibUZ0YVdOZlpXeGxiV1Z1ZEY5bWIzSmZhR1ZoWkdWeVFESUtDbVI1Ym1GdGFXTmZZWEp5WVhsZmNtVndiR0ZqWlY5a2VXNWhiV2xqWDJWc1pXMWxiblJmWVdaMFpYSmZabTl5UURVNkNpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdabkpoYldWZlpHbG5JRE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdabkpoYldWZlluVnllU0F3Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJmY0hWNVlWOXNhV0l1WVhKak5DNXpkR0YwYVdOZllYSnlZWGxmY21Wd2JHRmpaVjlrZVc1aGJXbGpYMlZzWlcxbGJuUW9ZWEp5WVhsZmFHVmhaRjloYm1SZmRHRnBiRG9nWW5sMFpYTXNJRzVsZDE5cGRHVnRPaUJpZVhSbGN5d2dhVzVrWlhnNklIVnBiblEyTkN3Z1lYSnlZWGxmYkdWdVozUm9PaUIxYVc1ME5qUXBJQzArSUdKNWRHVnpPZ3B6ZEdGMGFXTmZZWEp5WVhsZmNtVndiR0ZqWlY5a2VXNWhiV2xqWDJWc1pXMWxiblE2Q2lBZ0lDQndjbTkwYnlBMElERUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnYkdWdUNpQWdJQ0JtY21GdFpWOWthV2NnTFRRS0lDQWdJR3hsYmdvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnYVc1MFkxOHdJQzh2SURJS0lDQWdJQ29LSUNBZ0lHWnlZVzFsWDJScFp5QXROQW9nSUNBZ1pHbG5JREVLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ0xRb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJQzBLSUNBZ0lHUnBaeUF6Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0J6Wld4bFkzUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnYVc1MFkxOHdJQzh2SURJS0lDQWdJQ29LSUNBZ0lHWnlZVzFsWDJScFp5QXROQW9nSUNBZ2MzZGhjQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lHUjFjRElLSUNBZ0lDMEtJQ0FnSUdOdmRtVnlJRFFLSUNBZ0lHWnlZVzFsWDJScFp5QXROQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJScFp5QXROQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lITjFZbk4wY21sdVp6TUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCcGJuUmpYekFnTHk4Z01nb2dJQ0FnS2dvZ0lDQWdjM2RoY0FvS2MzUmhkR2xqWDJGeWNtRjVYM0psY0d4aFkyVmZaSGx1WVcxcFkxOWxiR1Z0Wlc1MFgyWnZjbDlvWldGa1pYSkFNVG9LSUNBZ0lHWnlZVzFsWDJScFp5QTBDaUFnSUNCbWNtRnRaVjlrYVdjZ013b2dJQ0FnUEFvZ0lDQWdZbm9nYzNSaGRHbGpYMkZ5Y21GNVgzSmxjR3hoWTJWZlpIbHVZVzFwWTE5bGJHVnRaVzUwWDJGbWRHVnlYMlp2Y2tBMENpQWdJQ0JtY21GdFpWOWthV2NnTWdvZ0lDQWdaSFZ3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dOQW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF6Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdabkpoYldWZlpHbG5JREFLSUNBZ0lDc0tJQ0FnSUdaeVlXMWxYMlJwWnlBeENpQWdJQ0F0Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNQW9nSUNBZ1pHbG5JRElLSUNBZ0lITjNZWEFLSUNBZ0lISmxjR3hoWTJVekNpQWdJQ0JtY21GdFpWOWlkWEo1SURJS0lDQWdJR2x1ZEdOZk1DQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCbWNtRnRaVjlpZFhKNUlEUUtJQ0FnSUdJZ2MzUmhkR2xqWDJGeWNtRjVYM0psY0d4aFkyVmZaSGx1WVcxcFkxOWxiR1Z0Wlc1MFgyWnZjbDlvWldGa1pYSkFNUW9LYzNSaGRHbGpYMkZ5Y21GNVgzSmxjR3hoWTJWZlpIbHVZVzFwWTE5bGJHVnRaVzUwWDJGbWRHVnlYMlp2Y2tBME9nb2dJQ0FnWm5KaGJXVmZaR2xuSURJS0lDQWdJR1p5WVcxbFgySjFjbmtnTUFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMM1JsYzNSekwzTnZiR2xrYVhSNUxYTmxiV0Z1ZEdsakxYUmxjM1J6TDNSbGMzUnpMMkZpYVVWdVkyOWtaWEpXTWk5a2VXNWhiV2xqWDI1bGMzUmxaRjloY25KaGVYTXVjMjlzTGtNdVppaGZYMkZ5WXpSZllUb2dZbmwwWlhNc0lHSTZJR0o1ZEdWekxDQmpPaUJpZVhSbGN5d2dYMTloY21NMFgyUTZJR0o1ZEdWektTQXRQaUJpZVhSbGN5d2dZbmwwWlhNc0lHSjVkR1Z6TENCaWVYUmxjeXdnWW5sMFpYTXNJR0o1ZEdWekxDQmllWFJsY3l3Z1lubDBaWE1zSUdKNWRHVnpPZ3BtT2dvZ0lDQWdjSEp2ZEc4Z05DQTVDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ1lub2dabDkwWlhKdVlYSjVYMlpoYkhObFFESUtJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaM1I0Ym5NZ1FXMXZkVzUwQ2dwbVgzUmxjbTVoY25sZmJXVnlaMlZBTXpvS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QnViM1FnY0dGNVlXSnNaUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdaSFZ3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQnBiblJqWHpNZ0x5OGdNeklLSUNBZ0lHSjZaWEp2Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmthV2NnTVFvZ0lDQWdZbndLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJRHdLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBibVJsZUNCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF5Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdaSFZ3TWdvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR2x1ZEdOZk1DQXZMeUF5Q2lBZ0lDQXFDaUFnSUNCcGJuUmpYekFnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbDBiMklLSUNBZ0lHUnBaeUF6Q2lBZ0lDQmlmQW9nSUNBZ2MzZGhjQW9nSUNBZ2NIVnphR2x1ZENBMENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnYVhSdllnb2dJQ0FnWkdsbklETUtJQ0FnSUdKOENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR2x1ZEdOZk1DQXZMeUF5Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmthV2NnTVFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJSEIxYzJocGJuUWdOalFLSUNBZ0lDb0tJQ0FnSUdsdWRHTmZNQ0F2THlBeUNpQWdJQ0FyQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBkRzlpQ2lBZ0lDQjFibU52ZG1WeUlEVUtJQ0FnSUdKOENpQWdJQ0J6ZDJGd0NpQWdJQ0JsZUhSeVlXTjBJRFkySURZMENpQWdJQ0JsZUhSeVlXTjBJRE15SURNeUlDOHZJRzl1SUdWeWNtOXlPaUJwYm1SbGVDQmhZMk5sYzNNZ2FYTWdiM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdabkpoYldWZlpHbG5JQzAwQ2lBZ0lDQmpiM1psY2lBMUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQnlaWFJ6ZFdJS0NtWmZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeU9nb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0lnWmw5MFpYSnVZWEo1WDIxbGNtZGxRRE1LIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZkR1Z6ZEhNdmMyOXNhV1JwZEhrdGMyVnRZVzUwYVdNdGRHVnpkSE12ZEdWemRITXZZV0pwUlc1amIyUmxjbFl5TDJSNWJtRnRhV05mYm1WemRHVmtYMkZ5Y21GNWN5NXpiMnd1UXk1amJHVmhjbDl6ZEdGMFpWOXdjbTluY21GdEtDa2dMVDRnZFdsdWREWTBPZ3B0WVdsdU9nb2dJQ0FnY0hWemFHbHVkQ0F4Q2lBZ0lDQnlaWFIxY200SyJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQUVBZ0FCSUNZQ0FBUVZIM3gxSTBjREtFY0ZnWUFncjBrMUJUVUFOQUNBSUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQ0FYRUExQURFWVFBQUNKRU14R1JSRU1SaEVnZ0lFanhWVlNRU0tsS08xTmhvQWpnSURpUUFCQURFV1FRTi9NUllrQ1RnSUZFU0NBZzRBQXdBR0FBZ0FDZ0FBQUFBQUFBWUFBZ0FBQUFBamlBUXdTU05aUkVsWEFnQkpJMWxLV1NJTElnaFlnQUlBVlZ3Q0k0Z0VGRWtqV1VSSlZ3SUFTU05aU2xraUN5SUlXSUFDQUZaY0JDT0lBL2lBQ2dBRUFBQUFBQUFBQUFBa2lBUG9TU05aSkExRVNWY0NBRWtpV1VwWklnc2lDRmlBQWdCbFhBSWtpQVBLU1NOWkpBMUVTVmNDQUVraVdVcFpJZ3NpQ0ZpQUFnQm1YQVFraUFPc1NTTlpKQTFFU1ZjQ0FFa2lXVXBaSWdzaUNGaUFBZ0JuWEFZa2lBT09TU05aSkExRVNWY0NBRWtpV1VwWklnc2lDRmlBQWdCb1hBZ2tpQU53S0lCQ0FBRUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFJNEVEaUFPbEphOUxBU05aU3dKTEFWbUJRQXNpQ0VzRFRnSllTVmNDUUlBZ0FBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBSFZjSUZ3Q1R3Sk1JNEVEaUFOZGdNSUNBQVVBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFDU0JBNGdDRWtraVdVcFpnVUFMSWdoTEFrNENXRWxYUWtDQUlBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUNGWENCY1FpU0JBNGdCMDRFTUZvRU5GazhFVHdOUEFvZ0NORVlDVGdaT0JVNEVUZ05PQWt4SkZTVU9SRXNIcTBzQkZTVU9SRXhMQjZ0TEFoVWxEa1JQQWtzSHEwc0RGU1VPUkU4RFN3ZXJTd1FWSlE1RVR3UkxCNnRMQlJVbERrUlBCVXNIcTBzR0ZTVU9SRThHVHdlclR3WlBCbEJQQlZCUEJGQlBBMUJQQWxCTVVDbE1VTEFrUXlOQy9JTTJHZ0ZKUlFvVkpSSkVOaG9DU1VVSlNTTlpTVVVJSWd0RkJFa1ZSUUpYQWdCRkNpTkZCVXNFU3dZTVFRQW5Td1JKSWd0TEMwbFBBbGxKU3daSlRnUVNSRXNCRlZJaldTSUxJZ2dJUlFRa0NFVUZRdi9SU3dJaUNFc0JFa1EyR2dORkI0RUdSUUlqUlFSTEE0RURERUVBS0VzRFNTSUxTd2hKVHdKWlNVc0ZTVTRFRWtSTEFSVlNJMW1CUUFzaUNBaEZBeVFJUlFSQy85QkxCa2tWU3dNU1JEWWFCRWtWSlJKRVN3cExDazhEVHdPSUFRMUdBazRHVGdWT0JFNERUZ0pRVEZCTVVFeFFURkJNVUNsTVVMQWtRNG9EQVl2OVVRQUNTUmVML1ZjQ0FJditGVTRDU1JXTC95UUlJZ3RMQWtzQldVc0VpLzhKSkFsTEEwNENUWXYvSWd0TEJFeFpTZ2xPQmtzRUkwOENVb3YrVUU4RVR3SlBCRkpRVGdKTUlndE1pd1dMQkF4QkFDQ0xBMG1MQlVsT0ExbUxBUWlMQWdrV1Z3WUFTd0pNWFl3RElnaU1CVUwvMklzQWl3TlFqQUNKaWdRQmkvMFZpL3dWaS80a0NDSUxpL3hMQVZtTC80ditDU1FKU3dOT0FrMkwvaUlMaS94TVdVb0pUZ1NML0NOUEFsS0wvVkNML0U4Q1R3UlNVRXlML3lJTFRJc0Vpd01NUVFBZ2l3Skppd1JKVGdOWml3QUlpd0VKRmxjR0FFc0NURjJNQWlJSWpBUkMvOWlMQW93QWlZb0VDVEVXUVFCak1SWWtDVGdJRkVTTC9TTlpTUllscjB4TEFhc2tUd01NUkl2OVZ3SUFTU0paU2xraUN5SUlXRWtqV1JaTEE2dE1nUVJaRmtzRHE0ditJbG1ML2tzQldZRkFDeUlJaS81T0FsaEpJMWtXVHdXclRGZENRRmNnSUl2OFRnV0wvNHY5aS82SkkwTC9udz09IiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OCwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
