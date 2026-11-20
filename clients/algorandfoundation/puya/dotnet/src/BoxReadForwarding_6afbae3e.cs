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

namespace Arc56.Generated.algorandfoundation.puya.BoxReadForwarding_6afbae3e
{


    //
    // 
    //    A value read from a box must not observe later modifications to that box.
    //    Cases restore any box they modify that a later case reads.
    //    Cases are not inlined, so each one is compiled to its own subroutine.
    //    
    //
    public class BoxReadForwardingProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public BoxReadForwardingProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class Inner : AVMObjectType
            {
                public ulong X { get; set; }

                public ulong[] Arr { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vX = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vX.From(X);
                    ret.AddRange(vX.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vArr = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64[]");
                    vArr.From(Arr);
                    ret.AddRange(vArr.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Inner Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Inner();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vX = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vX.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueX = vX.ToValue();
                    if (valueX is ulong vXValue) { ret.X = vXValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vArr = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64[]");
                    count = vArr.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueArr = vArr.ToValue();
                    if (valueArr is ulong[] vArrValue) { ret.Arr = vArrValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Inner);
                }
                public bool Equals(Inner? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Inner left, Inner right)
                {
                    return EqualityComparer<Inner>.Default.Equals(left, right);
                }
                public static bool operator !=(Inner left, Inner right)
                {
                    return !(left == right);
                }

            }

            public class NativeInner : AVMObjectType
            {
                public ulong X { get; set; }

                public ulong[] Arr { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vX = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vX.From(X);
                    ret.AddRange(vX.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vArr = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64[]");
                    vArr.From(Arr);
                    ret.AddRange(vArr.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static NativeInner Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new NativeInner();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vX = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vX.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueX = vX.ToValue();
                    if (valueX is ulong vXValue) { ret.X = vXValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vArr = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64[]");
                    count = vArr.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueArr = vArr.ToValue();
                    if (valueArr is ulong[] vArrValue) { ret.Arr = vArrValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as NativeInner);
                }
                public bool Equals(NativeInner? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(NativeInner left, NativeInner right)
                {
                    return EqualityComparer<NativeInner>.Default.Equals(left, right);
                }
                public static bool operator !=(NativeInner left, NativeInner right)
                {
                    return !(left == right);
                }

            }

            public class NativeOuter : AVMObjectType
            {
                public ulong Y { get; set; }

                public Structs.NativeInner Inner { get; set; } = new Structs.NativeInner();

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vY = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vY.From(Y);
                    ret.AddRange(vY.Encode());
                    stringRef[ret.Count] = Inner.ToByteArray();
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

                public static NativeOuter Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new NativeOuter();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vY = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vY.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueY = vY.ToValue();
                    if (valueY is ulong vYValue) { ret.Y = vYValue; }
                    var indexInner = queue.Dequeue() * 256 + queue.Dequeue();
                    ret.Inner = Structs.NativeInner.Parse(bytes.Skip(indexInner + prefixOffset).ToArray());
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as NativeOuter);
                }
                public bool Equals(NativeOuter? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(NativeOuter left, NativeOuter right)
                {
                    return EqualityComparer<NativeOuter>.Default.Equals(left, right);
                }
                public static bool operator !=(NativeOuter left, NativeOuter right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        public async Task RunAll(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 18, 44, 47, 94 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RunAll_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 18, 44, 47, 94 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Does nothing, used to increase the opcode budget of a group
        ///</summary>
        public async Task Pad(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 254, 132, 130, 254 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Pad_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 254, 132, 130, 254 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQm94UmVhZEZvcndhcmRpbmciLCJkZXNjIjoiXG4gICAgQSB2YWx1ZSByZWFkIGZyb20gYSBib3ggbXVzdCBub3Qgb2JzZXJ2ZSBsYXRlciBtb2RpZmljYXRpb25zIHRvIHRoYXQgYm94LlxuICAgIENhc2VzIHJlc3RvcmUgYW55IGJveCB0aGV5IG1vZGlmeSB0aGF0IGEgbGF0ZXIgY2FzZSByZWFkcy5cbiAgICBDYXNlcyBhcmUgbm90IGlubGluZWQsIHNvIGVhY2ggb25lIGlzIGNvbXBpbGVkIHRvIGl0cyBvd24gc3Vicm91dGluZS5cbiAgICAiLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiSW5uZXIiOlt7Im5hbWUiOiJ4IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImFyciIsInR5cGUiOiJ1aW50NjRbXSJ9XSwiTmF0aXZlSW5uZXIiOlt7Im5hbWUiOiJ4IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImFyciIsInR5cGUiOiJ1aW50NjRbXSJ9XSwiTmF0aXZlT3V0ZXIiOlt7Im5hbWUiOiJ5IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImlubmVyIiwidHlwZSI6Ik5hdGl2ZUlubmVyIn1dfSwiTWV0aG9kcyI6W3sibmFtZSI6InJ1bl9hbGwiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicGFkIiwiZGVzYyI6IkRvZXMgbm90aGluZywgdXNlZCB0byBpbmNyZWFzZSB0aGUgb3Bjb2RlIGJ1ZGdldCBvZiBhIGdyb3VwIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbODIwXSwiZXJyb3JNZXNzYWdlIjoiY2Fubm90IHBvcCBmcm9tIGVtcHR5IGFycmF5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDg4LDUxNiw1NDJdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmEgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzIyLDM0NiwzOTUsNDIyLDQ1M10sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuYiBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2MjBdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODc0XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5uIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzcxMCw3NzRdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLm8gZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjYzXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi50IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY2OF0sImVycm9yTWVzc2FnZSI6ImluZGV4IGFjY2VzcyBpcyBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTI0LDY3NSw3MjAsNzI2LDc1Miw3NTcsNzcwLDgyNSw4MzYsOTE2LDk0MV0sImVycm9yTWVzc2FnZSI6ImluZGV4IG91dCBvZiBib3VuZHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MDIsODAzXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBeUlEZ2dNU0F3Q2lBZ0lDQmllWFJsWTJKc2IyTnJJREI0TmpJZ01IZzJaaUF3ZURZeElEQjROalFnTUhnM05DQXdlRFpsSURCNE5qRTJNall6TmpRZ01IZ3dNREF5TURBd01EQXdNREF3TURBd01EQXdNVEF3TURBd01EQXdNREF3TURBd01ESWdNSGczT0NBd2VEQXdNREF3TURBd01EQXdNREF3TURFd01EQmhNREF3TWpBd01EQXdNREF3TURBd01EQXdNREV3TURBd01EQXdNREF3TURBd01EQXlJREI0TURBd01qQXdNREF3TURBd01EQXdNREF3TURVd01EQXdNREF3TURBd01EQXdNREE1Q2lBZ0lDQXZMeUJ5WldkeVpYTnphVzl1WDNSbGMzUnpMMkp2ZUY5eVpXRmtYMlp2Y25kaGNtUnBibWN1Y0hrNk16SUtJQ0FnSUM4dklHTnNZWE56SUVKdmVGSmxZV1JHYjNKM1lYSmthVzVuS0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNGdUblZ0UVhCd1FYSm5jd29nSUNBZ1lub2diV0ZwYmw5ZlgyRnNaMjl3ZVY5a1pXWmhkV3gwWDJOeVpXRjBaVUF4TVFvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQndkWE5vWW5sMFpYTnpJREI0TVRJeVl6Sm1OV1VnTUhobVpUZzBPREptWlNBdkx5QnRaWFJvYjJRZ0luSjFibDloYkd3b0tYWnZhV1FpTENCdFpYUm9iMlFnSW5CaFpDZ3BkbTlwWkNJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lISjFibDloYkd3Z2JXRnBibDl3WVdSZmNtOTFkR1ZBTndvZ0lDQWdaWEp5Q2dwdFlXbHVYM0JoWkY5eWIzVjBaVUEzT2dvZ0lDQWdMeThnY21WbmNtVnpjMmx2Ymw5MFpYTjBjeTlpYjNoZmNtVmhaRjltYjNKM1lYSmthVzVuTG5CNU9qY3pDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWDE5aGJHZHZjSGxmWkdWbVlYVnNkRjlqY21WaGRHVkFNVEU2Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSVFvZ0lDQWdKaVlLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJRjl3ZFhsaFgyeHBZaTVpYjNoZllYSmpOQzVpYjNoZlpIbHVZVzFwWTE5aGNuSmhlVjlqYjI1allYUmZabWw0WldRb1ltOTRYMnRsZVRvZ1lubDBaWE1zSUdGeWNtRjVYMjltWm5ObGREb2dkV2x1ZERZMExDQnVaWGRmYVhSbGJYTmZZbmwwWlhNNklHSjVkR1Z6TENCdVpYZGZhWFJsYlhOZlkyOTFiblE2SUhWcGJuUTJOQ3dnWm1sNFpXUmZaV3hsYldWdWRGOXphWHBsT2lCMWFXNTBOalFwSUMwK0lIWnZhV1E2Q21KdmVGOWtlVzVoYldsalgyRnljbUY1WDJOdmJtTmhkRjltYVhobFpEb0tJQ0FnSUhCeWIzUnZJRFVnTUFvZ0lDQWdabkpoYldWZlpHbG5JQzAxQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVFFLSUNBZ0lHbHVkR05mTUNBdkx5QXlDaUFnSUNCaWIzaGZaWGgwY21GamRBb2dJQ0FnWW5SdmFRb2dJQ0FnWm5KaGJXVmZaR2xuSUMwMUNpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCd2IzQUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0FxQ2lBZ0lDQXJDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUVUtJQ0FnSUhOM1lYQUtJQ0FnSUdKdmVGOXlaWE5wZW1VS0lDQWdJR1IxY0FvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQXJDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnWm5KaGJXVmZaR2xuSUMwMUNpQWdJQ0JtY21GdFpWOWthV2NnTFRRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1ltOTRYM0psY0d4aFkyVUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE5Bb2dJQ0FnYVc1MFkxOHdJQzh2SURJS0lDQWdJQ3NLSUNBZ0lITjNZWEFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ0tnb2dJQ0FnS3dvZ0lDQWdabkpoYldWZlpHbG5JQzAxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCaWIzaGZjM0JzYVdObENpQWdJQ0J5WlhSemRXSUtDZ292THlCMFpYTjBYMk5oYzJWekxuSmxaM0psYzNOcGIyNWZkR1Z6ZEhNdVltOTRYM0psWVdSZlptOXlkMkZ5WkdsdVp5NUNiM2hTWldGa1JtOXlkMkZ5WkdsdVp5NXlkVzVmWVd4c1czSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjblZ1WDJGc2JEb0tJQ0FnSUM4dklISmxaM0psYzNOcGIyNWZkR1Z6ZEhNdlltOTRYM0psWVdSZlptOXlkMkZ5WkdsdVp5NXdlVG8wT1FvZ0lDQWdMeThnYzJWc1ppNWlMblpoYkhWbElEMGdRbmwwWlhNb1lpSmhZbU5rSWlrS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnMk1nb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjROaklLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdNSGcyTVRZeU5qTTJOQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnY21WbmNtVnpjMmx2Ymw5MFpYTjBjeTlpYjNoZmNtVmhaRjltYjNKM1lYSmthVzVuTG5CNU9qVXdDaUFnSUNBdkx5QnpaV3htTG1FdWRtRnNkV1VnUFNCVlNXNTBOalJCY25KaGVTaGhjbU0wTGxWSmJuUTJOQ2d4S1N3Z1lYSmpOQzVWU1c1ME5qUW9NaWtwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TmpFS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VEWXhDaUFnSUNCaWVYUmxZeUEzSUM4dklEQjRNREF3TWpBd01EQXdNREF3TURBd01EQXdNREV3TURBd01EQXdNREF3TURBd01EQXlDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJ5WldkeVpYTnphVzl1WDNSbGMzUnpMMkp2ZUY5eVpXRmtYMlp2Y25kaGNtUnBibWN1Y0hrNk5URUtJQ0FnSUM4dklITmxiR1l1WkM1MllXeDFaU0E5SUVsdWJtVnlLSGc5WVhKak5DNVZTVzUwTmpRb01Ta3NJR0Z5Y2oxVlNXNTBOalJCY25KaGVTaGhjbU0wTGxWSmJuUTJOQ2d4S1N3Z1lYSmpOQzVWU1c1ME5qUW9NaWtwS1FvZ0lDQWdZbmwwWldOZk15QXZMeUF3ZURZMENpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUdKNWRHVmpYek1nTHk4Z01IZzJOQW9nSUNBZ1lubDBaV01nT1NBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01ERXdNREJoTURBd01qQXdNREF3TURBd01EQXdNREF3TURFd01EQXdNREF3TURBd01EQXdNREF5Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCeVpXZHlaWE56YVc5dVgzUmxjM1J6TDJKdmVGOXlaV0ZrWDJadmNuZGhjbVJwYm1jdWNIazZOVElLSUNBZ0lDOHZJSE5sYkdZdWRDNTJZV3gxWlNBOUlHRnlZelF1UkhsdVlXMXBZMEZ5Y21GNVcxVkpiblEyTkYwb1ZVbHVkRFkwS0RFcExDQlZTVzUwTmpRb01pa3BDaUFnSUNCaWVYUmxZeUEwSUM4dklEQjROelFLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdZbmwwWldNZ05DQXZMeUF3ZURjMENpQWdJQ0JpZVhSbFl5QTNJQzh2SURCNE1EQXdNakF3TURBd01EQXdNREF3TURBd01ERXdNREF3TURBd01EQXdNREF3TURBeUNpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QnlaV2R5WlhOemFXOXVYM1JsYzNSekwySnZlRjl5WldGa1gyWnZjbmRoY21ScGJtY3VjSGs2TlRNS0lDQWdJQzh2SUhObGJHWXViaTUyWVd4MVpTQTlJRTVoZEdsMlpVbHVibVZ5S0hnOVZVbHVkRFkwS0RFcExDQmhjbkk5UVhKeVlYbGJWVWx1ZERZMFhTZ29WVWx1ZERZMEtERXBMQ0JWU1c1ME5qUW9NaWtwS1NrS0lDQWdJR0o1ZEdWaklEVWdMeThnTUhnMlpRb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNCaWVYUmxZeUExSUM4dklEQjRObVVLSUNBZ0lHSjVkR1ZqSURrZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXhNREF3WVRBd01ESXdNREF3TURBd01EQXdNREF3TURBeE1EQXdNREF3TURBd01EQXdNREF3TWdvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z2NtVm5jbVZ6YzJsdmJsOTBaWE4wY3k5aWIzaGZjbVZoWkY5bWIzSjNZWEprYVc1bkxuQjVPalUwQ2lBZ0lDQXZMeUJ6Wld4bUxtOHVkbUZzZFdVZ1BTQk9ZWFJwZG1WUGRYUmxjaWdLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGcyWmdvZ0lDQWdMeThnY21WbmNtVnpjMmx2Ymw5MFpYTjBjeTlpYjNoZmNtVmhaRjltYjNKM1lYSmthVzVuTG5CNU9qVTBMVFUzQ2lBZ0lDQXZMeUJ6Wld4bUxtOHVkbUZzZFdVZ1BTQk9ZWFJwZG1WUGRYUmxjaWdLSUNBZ0lDOHZJQ0FnSUNCNVBWVkpiblEyTkNneEtTd0tJQ0FnSUM4dklDQWdJQ0JwYm01bGNqMU9ZWFJwZG1WSmJtNWxjaWg0UFZWSmJuUTJOQ2d4S1N3Z1lYSnlQVUZ5Y21GNVcxVkpiblEyTkYwb0tGVkpiblEyTkNneEtTd2dWVWx1ZERZMEtESXBLU2twTEFvZ0lDQWdMeThnS1FvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0F2THlCeVpXZHlaWE56YVc5dVgzUmxjM1J6TDJKdmVGOXlaV0ZrWDJadmNuZGhjbVJwYm1jdWNIazZOVFFLSUNBZ0lDOHZJSE5sYkdZdWJ5NTJZV3gxWlNBOUlFNWhkR2wyWlU5MWRHVnlLQW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlRFptQ2lBZ0lDQXZMeUJ5WldkeVpYTnphVzl1WDNSbGMzUnpMMkp2ZUY5eVpXRmtYMlp2Y25kaGNtUnBibWN1Y0hrNk5UUXROVGNLSUNBZ0lDOHZJSE5sYkdZdWJ5NTJZV3gxWlNBOUlFNWhkR2wyWlU5MWRHVnlLQW9nSUNBZ0x5OGdJQ0FnSUhrOVZVbHVkRFkwS0RFcExBb2dJQ0FnTHk4Z0lDQWdJR2x1Ym1WeVBVNWhkR2wyWlVsdWJtVnlLSGc5VlVsdWREWTBLREVwTENCaGNuSTlRWEp5WVhsYlZVbHVkRFkwWFNnb1ZVbHVkRFkwS0RFcExDQlZTVzUwTmpRb01pa3BLU2tzQ2lBZ0lDQXZMeUFwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TURBd01EQXdNREF3TURBd01EQXhNREF3WVRBd01EQXdNREF3TURBd01EQXdNREV3TURCaE1EQXdNakF3TURBd01EQXdNREF3TURBd01ERXdNREF3TURBd01EQXdNREF3TURBeUNpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QnlaV2R5WlhOemFXOXVYM1JsYzNSekwySnZlRjl5WldGa1gyWnZjbmRoY21ScGJtY3VjSGs2TlRrS0lDQWdJQzh2SUhObGJHWXVZbmwwWlhOZmJHVnVYMkZtZEdWeVgzQjFkQ2dwQ2lBZ0lDQmpZV3hzYzNWaUlHSjVkR1Z6WDJ4bGJsOWhablJsY2w5d2RYUUtJQ0FnSUM4dklISmxaM0psYzNOcGIyNWZkR1Z6ZEhNdlltOTRYM0psWVdSZlptOXlkMkZ5WkdsdVp5NXdlVG8yTUFvZ0lDQWdMeThnYzJWc1ppNWllWFJsYzE5bGVIUnlZV04wWDJGbWRHVnlYM053YkdsalpTZ3BDaUFnSUNCallXeHNjM1ZpSUdKNWRHVnpYMlY0ZEhKaFkzUmZZV1owWlhKZmMzQnNhV05sQ2lBZ0lDQXZMeUJ5WldkeVpYTnphVzl1WDNSbGMzUnpMMkp2ZUY5eVpXRmtYMlp2Y25kaGNtUnBibWN1Y0hrNk5qRUtJQ0FnSUM4dklITmxiR1l1WW5sMFpYTmZiR1Z1WDJGbWRHVnlYM04xWW5KdmRYUnBibVZmZDNKcGRHVW9LUW9nSUNBZ1kyRnNiSE4xWWlCaWVYUmxjMTlzWlc1ZllXWjBaWEpmYzNWaWNtOTFkR2x1WlY5M2NtbDBaUW9nSUNBZ0x5OGdjbVZuY21WemMybHZibDkwWlhOMGN5OWliM2hmY21WaFpGOW1iM0ozWVhKa2FXNW5MbkI1T2pZeUNpQWdJQ0F2THlCelpXeG1MbUo1ZEdWelgyeGxibDloWm5SbGNsOWpiMjVrYVhScGIyNWhiRjl3ZFhRb0tRb2dJQ0FnWTJGc2JITjFZaUJpZVhSbGMxOXNaVzVmWVdaMFpYSmZZMjl1WkdsMGFXOXVZV3hmY0hWMENpQWdJQ0F2THlCeVpXZHlaWE56YVc5dVgzUmxjM1J6TDJKdmVGOXlaV0ZrWDJadmNuZGhjbVJwYm1jdWNIazZOak1LSUNBZ0lDOHZJSE5sYkdZdVlubDBaWE5mYkdWdVgybHVYMnh2YjNCZmQybDBhRjl3ZFhRb0tRb2dJQ0FnWTJGc2JITjFZaUJpZVhSbGMxOXNaVzVmYVc1ZmJHOXZjRjkzYVhSb1gzQjFkQW9nSUNBZ0x5OGdjbVZuY21WemMybHZibDkwWlhOMGN5OWliM2hmY21WaFpGOW1iM0ozWVhKa2FXNW5MbkI1T2pZMENpQWdJQ0F2THlCelpXeG1MbUZ5Y21GNVgyeGxibDloWm5SbGNsOWhjSEJsYm1Rb0tRb2dJQ0FnWTJGc2JITjFZaUJoY25KaGVWOXNaVzVmWVdaMFpYSmZZWEJ3Wlc1a0NpQWdJQ0F2THlCeVpXZHlaWE56YVc5dVgzUmxjM1J6TDJKdmVGOXlaV0ZrWDJadmNuZGhjbVJwYm1jdWNIazZOalVLSUNBZ0lDOHZJSE5sYkdZdVlYSnlZWGxmWld4bGJXVnVkRjloWm5SbGNsOXpaWFFvS1FvZ0lDQWdZMkZzYkhOMVlpQmhjbkpoZVY5bGJHVnRaVzUwWDJGbWRHVnlYM05sZEFvZ0lDQWdMeThnY21WbmNtVnpjMmx2Ymw5MFpYTjBjeTlpYjNoZmNtVmhaRjltYjNKM1lYSmthVzVuTG5CNU9qWTJDaUFnSUNBdkx5QnpaV3htTG1GeWNtRjVYMkZ3Y0dWdVpGOTNjbWwwWlY5aVlXTnJYMkZtZEdWeVgzQjFkQ2dwQ2lBZ0lDQmpZV3hzYzNWaUlHRnljbUY1WDJGd2NHVnVaRjkzY21sMFpWOWlZV05yWDJGbWRHVnlYM0IxZEFvZ0lDQWdMeThnY21WbmNtVnpjMmx2Ymw5MFpYTjBjeTlpYjNoZmNtVmhaRjltYjNKM1lYSmthVzVuTG5CNU9qWTNDaUFnSUNBdkx5QnpaV3htTG5OMGNuVmpkRjloY25KaGVWOXlaWEJzWVdObFpGOTNhWFJvWDI5MGFHVnlYMkZ5Y21GNUtDa0tJQ0FnSUdOaGJHeHpkV0lnYzNSeWRXTjBYMkZ5Y21GNVgzSmxjR3hoWTJWa1gzZHBkR2hmYjNSb1pYSmZZWEp5WVhrS0lDQWdJQzh2SUhKbFozSmxjM05wYjI1ZmRHVnpkSE12WW05NFgzSmxZV1JmWm05eWQyRnlaR2x1Wnk1d2VUbzJPQW9nSUNBZ0x5OGdjMlZzWmk1aGNuSmhlVjkwZDI5ZlkyOXdhV1Z6WDNkeWFYUjBaVzVmWW1GamExOXBibDl2Y21SbGNpZ3BDaUFnSUNCallXeHNjM1ZpSUdGeWNtRjVYM1IzYjE5amIzQnBaWE5mZDNKcGRIUmxibDlpWVdOclgybHVYMjl5WkdWeUNpQWdJQ0F2THlCeVpXZHlaWE56YVc5dVgzUmxjM1J6TDJKdmVGOXlaV0ZrWDJadmNuZGhjbVJwYm1jdWNIazZOamtLSUNBZ0lDOHZJSE5sYkdZdWJtVnpkR1ZrWDNOMGNuVmpkRjlqYjNCNVgySmxabTl5WlY5elpYUW9LUW9nSUNBZ1kyRnNiSE4xWWlCdVpYTjBaV1JmYzNSeWRXTjBYMk52Y0hsZlltVm1iM0psWDNObGRBb2dJQ0FnTHk4Z2NtVm5jbVZ6YzJsdmJsOTBaWE4wY3k5aWIzaGZjbVZoWkY5bWIzSjNZWEprYVc1bkxuQjVPamN3Q2lBZ0lDQXZMeUJ6Wld4bUxtNWxjM1JsWkY5emRISjFZM1JmWTI5d2VWOWlaV1p2Y21WZllYQndaVzVrS0NrS0lDQWdJR05oYkd4emRXSWdibVZ6ZEdWa1gzTjBjblZqZEY5amIzQjVYMkpsWm05eVpWOWhjSEJsYm1RS0lDQWdJQzh2SUhKbFozSmxjM05wYjI1ZmRHVnpkSE12WW05NFgzSmxZV1JmWm05eWQyRnlaR2x1Wnk1d2VUbzNNUW9nSUNBZ0x5OGdjMlZzWmk1dVlYUnBkbVZmWm1sbGJHUmZZMjl3ZVY5cGRHVnlZWFJsWkY5M2FHbHNaVjl0YjJScFptbGxaQ2dwQ2lBZ0lDQmpZV3hzYzNWaUlHNWhkR2wyWlY5bWFXVnNaRjlqYjNCNVgybDBaWEpoZEdWa1gzZG9hV3hsWDIxdlpHbG1hV1ZrQ2lBZ0lDQXZMeUJ5WldkeVpYTnphVzl1WDNSbGMzUnpMMkp2ZUY5eVpXRmtYMlp2Y25kaGNtUnBibWN1Y0hrNk5EY0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSZlkyRnpaWE11Y21WbmNtVnpjMmx2Ymw5MFpYTjBjeTVpYjNoZmNtVmhaRjltYjNKM1lYSmthVzVuTGtKdmVGSmxZV1JHYjNKM1lYSmthVzVuTG1KNWRHVnpYMnhsYmw5aFpuUmxjbDl3ZFhRb0tTQXRQaUIyYjJsa09ncGllWFJsYzE5c1pXNWZZV1owWlhKZmNIVjBPZ29nSUNBZ0x5OGdjbVZuY21WemMybHZibDkwWlhOMGN5OWliM2hmY21WaFpGOW1iM0ozWVhKa2FXNW5MbkI1T2pjNUNpQWdJQ0F2THlCdElEMGdjMlZzWmk1aUxuWmhiSFZsQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TmpJS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtSWdaWGhwYzNSekNpQWdJQ0F2THlCeVpXZHlaWE56YVc5dVgzUmxjM1J6TDJKdmVGOXlaV0ZrWDJadmNuZGhjbVJwYm1jdWNIazZPREFLSUNBZ0lDOHZJSE5sYkdZdVlpNTJZV3gxWlNBOUlFSjVkR1Z6S0dJaVhIZ3dOU0lwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TmpJS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEWXlDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dOUW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnY21WbmNtVnpjMmx2Ymw5MFpYTjBjeTlpYjNoZmNtVmhaRjltYjNKM1lYSmthVzVuTG5CNU9qZ3hDaUFnSUNBdkx5QmhjM05sY25RZ2JTNXNaVzVuZEdnZ1BUMGdOQW9nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURRS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUhKbFozSmxjM05wYjI1ZmRHVnpkSE12WW05NFgzSmxZV1JmWm05eWQyRnlaR2x1Wnk1d2VUbzRNZ29nSUNBZ0x5OGdjMlZzWmk1aUxuWmhiSFZsSUQwZ1FubDBaWE1vWWlKaFltTmtJaWtLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGcyTWdvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE5qSUtJQ0FnSUdKNWRHVmpJRFlnTHk4Z01IZzJNVFl5TmpNMk5Bb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdkR1Z6ZEY5allYTmxjeTV5WldkeVpYTnphVzl1WDNSbGMzUnpMbUp2ZUY5eVpXRmtYMlp2Y25kaGNtUnBibWN1UW05NFVtVmhaRVp2Y25kaGNtUnBibWN1WW5sMFpYTmZaWGgwY21GamRGOWhablJsY2w5emNHeHBZMlVvS1NBdFBpQjJiMmxrT2dwaWVYUmxjMTlsZUhSeVlXTjBYMkZtZEdWeVgzTndiR2xqWlRvS0lDQWdJQzh2SUhKbFozSmxjM05wYjI1ZmRHVnpkSE12WW05NFgzSmxZV1JmWm05eWQyRnlaR2x1Wnk1d2VUbzROZ29nSUNBZ0x5OGdiU0E5SUhObGJHWXVZaTUyWVd4MVpRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEWXlDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVpSUdWNGFYTjBjd29nSUNBZ0x5OGdjbVZuY21WemMybHZibDkwWlhOMGN5OWliM2hmY21WaFpGOW1iM0ozWVhKa2FXNW5MbkI1T2pnM0NpQWdJQ0F2THlCelpXeG1MbUl1YzNCc2FXTmxLREFzSURFc0lHSWljWEZ4SWlrS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnMk1nb2dJQ0FnYVc1MFkxOHpJQzh2SURBS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGczTVRjeE56RUtJQ0FnSUdKdmVGOXpjR3hwWTJVS0lDQWdJQzh2SUhKbFozSmxjM05wYjI1ZmRHVnpkSE12WW05NFgzSmxZV1JmWm05eWQyRnlaR2x1Wnk1d2VUbzRPQW9nSUNBZ0x5OGdZWE56WlhKMElHMWJNRG95WFNBOVBTQmlJbUZpSWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QXdDaUFnSUNCa2FXY2dNUW9nSUNBZ1BqMEtJQ0FnSUdsdWRHTmZNeUF2THlBd0NpQWdJQ0JrYVdjZ01nb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpaV3hsWTNRS0lDQWdJR2x1ZEdOZk1DQXZMeUF5Q2lBZ0lDQmthV2NnTWdvZ0lDQWdQajBLSUNBZ0lHbHVkR05mTUNBdkx5QXlDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZzJNVFl5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUJ5WldkeVpYTnphVzl1WDNSbGMzUnpMMkp2ZUY5eVpXRmtYMlp2Y25kaGNtUnBibWN1Y0hrNk9Ea0tJQ0FnSUM4dklITmxiR1l1WWk1MllXeDFaU0E5SUVKNWRHVnpLR0lpWVdKalpDSXBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjROaklLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURZeUNpQWdJQ0JpZVhSbFl5QTJJQzh2SURCNE5qRTJNall6TmpRS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklIUmxjM1JmWTJGelpYTXVjbVZuY21WemMybHZibDkwWlhOMGN5NWliM2hmY21WaFpGOW1iM0ozWVhKa2FXNW5Ma0p2ZUZKbFlXUkdiM0ozWVhKa2FXNW5MbUo1ZEdWelgyeGxibDloWm5SbGNsOXpkV0p5YjNWMGFXNWxYM2R5YVhSbEtDa2dMVDRnZG05cFpEb0tZbmwwWlhOZmJHVnVYMkZtZEdWeVgzTjFZbkp2ZFhScGJtVmZkM0pwZEdVNkNpQWdJQ0F2THlCeVpXZHlaWE56YVc5dVgzUmxjM1J6TDJKdmVGOXlaV0ZrWDJadmNuZGhjbVJwYm1jdWNIazZPVE1LSUNBZ0lDOHZJRzBnUFNCelpXeG1MbUl1ZG1Gc2RXVUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZzJNZ29nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WWlCbGVHbHpkSE1LSUNBZ0lDOHZJSEpsWjNKbGMzTnBiMjVmZEdWemRITXZZbTk0WDNKbFlXUmZabTl5ZDJGeVpHbHVaeTV3ZVRvNU5Bb2dJQ0FnTHk4Z2MyVnNaaTUzY21sMFpWOWlLQ2tLSUNBZ0lHTmhiR3h6ZFdJZ2QzSnBkR1ZmWWdvZ0lDQWdMeThnY21WbmNtVnpjMmx2Ymw5MFpYTjBjeTlpYjNoZmNtVmhaRjltYjNKM1lYSmthVzVuTG5CNU9qazFDaUFnSUNBdkx5QmhjM05sY25RZ2JTNXNaVzVuZEdnZ1BUMGdOQW9nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURRS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUhKbFozSmxjM05wYjI1ZmRHVnpkSE12WW05NFgzSmxZV1JmWm05eWQyRnlaR2x1Wnk1d2VUbzVOZ29nSUNBZ0x5OGdjMlZzWmk1aUxuWmhiSFZsSUQwZ1FubDBaWE1vWWlKaFltTmtJaWtLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGcyTWdvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE5qSUtJQ0FnSUdKNWRHVmpJRFlnTHk4Z01IZzJNVFl5TmpNMk5Bb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdkR1Z6ZEY5allYTmxjeTV5WldkeVpYTnphVzl1WDNSbGMzUnpMbUp2ZUY5eVpXRmtYMlp2Y25kaGNtUnBibWN1UW05NFVtVmhaRVp2Y25kaGNtUnBibWN1ZDNKcGRHVmZZaWdwSUMwK0lIWnZhV1E2Q25keWFYUmxYMkk2Q2lBZ0lDQXZMeUJ5WldkeVpYTnphVzl1WDNSbGMzUnpMMkp2ZUY5eVpXRmtYMlp2Y25kaGNtUnBibWN1Y0hrNk1UQXdDaUFnSUNBdkx5QnpaV3htTG1JdWRtRnNkV1VnUFNCQ2VYUmxjeWhpSW5naUtRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEWXlDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGcyTWdvZ0lDQWdZbmwwWldNZ09DQXZMeUF3ZURjNENpQWdJQ0JpYjNoZmNIVjBDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QjBaWE4wWDJOaGMyVnpMbkpsWjNKbGMzTnBiMjVmZEdWemRITXVZbTk0WDNKbFlXUmZabTl5ZDJGeVpHbHVaeTVDYjNoU1pXRmtSbTl5ZDJGeVpHbHVaeTVpZVhSbGMxOXNaVzVmWVdaMFpYSmZZMjl1WkdsMGFXOXVZV3hmY0hWMEtDa2dMVDRnZG05cFpEb0tZbmwwWlhOZmJHVnVYMkZtZEdWeVgyTnZibVJwZEdsdmJtRnNYM0IxZERvS0lDQWdJQzh2SUhKbFozSmxjM05wYjI1ZmRHVnpkSE12WW05NFgzSmxZV1JmWm05eWQyRnlaR2x1Wnk1d2VUb3hNRFFLSUNBZ0lDOHZJRzBnUFNCelpXeG1MbUl1ZG1Gc2RXVUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZzJNZ29nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WWlCbGVHbHpkSE1LSUNBZ0lDOHZJSEpsWjNKbGMzTnBiMjVmZEdWemRITXZZbTk0WDNKbFlXUmZabTl5ZDJGeVpHbHVaeTV3ZVRveE1EVUtJQ0FnSUM4dklHbG1JRlI0Ymk1dWRXMWZZWEJ3WDJGeVozTTZJQ0FqSUdGc2QyRjVjeUIwY25WbExDQmlkWFFnYm05MElHdHViM2R1SUdGMElHTnZiWEJwYkdVZ2RHbHRaUW9nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lHSjZJR0o1ZEdWelgyeGxibDloWm5SbGNsOWpiMjVrYVhScGIyNWhiRjl3ZFhSZllXWjBaWEpmYVdaZlpXeHpaVUF5Q2lBZ0lDQXZMeUJ5WldkeVpYTnphVzl1WDNSbGMzUnpMMkp2ZUY5eVpXRmtYMlp2Y25kaGNtUnBibWN1Y0hrNk1UQTJDaUFnSUNBdkx5QnpaV3htTG1JdWRtRnNkV1VnUFNCQ2VYUmxjeWhpSW5naUtRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEWXlDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGcyTWdvZ0lDQWdZbmwwWldNZ09DQXZMeUF3ZURjNENpQWdJQ0JpYjNoZmNIVjBDZ3BpZVhSbGMxOXNaVzVmWVdaMFpYSmZZMjl1WkdsMGFXOXVZV3hmY0hWMFgyRm1kR1Z5WDJsbVgyVnNjMlZBTWpvS0lDQWdJQzh2SUhKbFozSmxjM05wYjI1ZmRHVnpkSE12WW05NFgzSmxZV1JmWm05eWQyRnlaR2x1Wnk1d2VUb3hNRGNLSUNBZ0lDOHZJR0Z6YzJWeWRDQnRMbXhsYm1kMGFDQTlQU0EwQ2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ05Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z2NtVm5jbVZ6YzJsdmJsOTBaWE4wY3k5aWIzaGZjbVZoWkY5bWIzSjNZWEprYVc1bkxuQjVPakV3T0FvZ0lDQWdMeThnYzJWc1ppNWlMblpoYkhWbElEMGdRbmwwWlhNb1lpSmhZbU5rSWlrS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnMk1nb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjROaklLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdNSGcyTVRZeU5qTTJOQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnZEdWemRGOWpZWE5sY3k1eVpXZHlaWE56YVc5dVgzUmxjM1J6TG1KdmVGOXlaV0ZrWDJadmNuZGhjbVJwYm1jdVFtOTRVbVZoWkVadmNuZGhjbVJwYm1jdVlubDBaWE5mYkdWdVgybHVYMnh2YjNCZmQybDBhRjl3ZFhRb0tTQXRQaUIyYjJsa09ncGllWFJsYzE5c1pXNWZhVzVmYkc5dmNGOTNhWFJvWDNCMWREb0tJQ0FnSUM4dklISmxaM0psYzNOcGIyNWZkR1Z6ZEhNdlltOTRYM0psWVdSZlptOXlkMkZ5WkdsdVp5NXdlVG94TVRBdE1URXhDaUFnSUNBdkx5QkFjM1ZpY205MWRHbHVaU2hwYm14cGJtVTlSbUZzYzJVcENpQWdJQ0F2THlCa1pXWWdZbmwwWlhOZmJHVnVYMmx1WDJ4dmIzQmZkMmwwYUY5d2RYUW9jMlZzWmlrZ0xUNGdUbTl1WlRvS0lDQWdJSEJ5YjNSdklEQWdNQW9nSUNBZ0x5OGdjbVZuY21WemMybHZibDkwWlhOMGN5OWliM2hmY21WaFpGOW1iM0ozWVhKa2FXNW5MbkI1T2pFeE1nb2dJQ0FnTHk4Z2JTQTlJSE5sYkdZdVlpNTJZV3gxWlFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURZeUNpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNWlJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2NtVm5jbVZ6YzJsdmJsOTBaWE4wY3k5aWIzaGZjbVZoWkY5bWIzSjNZWEprYVc1bkxuQjVPakV4TXdvZ0lDQWdMeThnZEc5MFlXd2dQU0JWU1c1ME5qUW9NQ2tLSUNBZ0lHbHVkR05mTXlBdkx5QXdDaUFnSUNBdkx5QnlaV2R5WlhOemFXOXVYM1JsYzNSekwySnZlRjl5WldGa1gyWnZjbmRoY21ScGJtY3VjSGs2TVRFMENpQWdJQ0F2THlCbWIzSWdYMmtnYVc0Z2RYSmhibWRsS0RJcE9nb2dJQ0FnWkhWd0NncGllWFJsYzE5c1pXNWZhVzVmYkc5dmNGOTNhWFJvWDNCMWRGOW1iM0pmYUdWaFpHVnlRREU2Q2lBZ0lDQXZMeUJ5WldkeVpYTnphVzl1WDNSbGMzUnpMMkp2ZUY5eVpXRmtYMlp2Y25kaGNtUnBibWN1Y0hrNk1URTBDaUFnSUNBdkx5Qm1iM0lnWDJrZ2FXNGdkWEpoYm1kbEtESXBPZ29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01nb2dJQ0FnUEFvZ0lDQWdZbm9nWW5sMFpYTmZiR1Z1WDJsdVgyeHZiM0JmZDJsMGFGOXdkWFJmWVdaMFpYSmZabTl5UURRS0lDQWdJQzh2SUhKbFozSmxjM05wYjI1ZmRHVnpkSE12WW05NFgzSmxZV1JmWm05eWQyRnlaR2x1Wnk1d2VUb3hNVFVLSUNBZ0lDOHZJSFJ2ZEdGc0lDczlJRzB1YkdWdVozUm9DaUFnSUNCa2FXY2dNZ29nSUNBZ2JHVnVDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJQ3NLSUNBZ0lITjNZWEFLSUNBZ0lDOHZJSEpsWjNKbGMzTnBiMjVmZEdWemRITXZZbTk0WDNKbFlXUmZabTl5ZDJGeVpHbHVaeTV3ZVRveE1UWUtJQ0FnSUM4dklITmxiR1l1WWk1MllXeDFaU0E5SUVKNWRHVnpLR0lpZUNJcENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE5qSUtJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlRFl5Q2lBZ0lDQmllWFJsWXlBNElDOHZJREI0TnpnS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklISmxaM0psYzNOcGIyNWZkR1Z6ZEhNdlltOTRYM0psWVdSZlptOXlkMkZ5WkdsdVp5NXdlVG94TVRRS0lDQWdJQzh2SUdadmNpQmZhU0JwYmlCMWNtRnVaMlVvTWlrNkNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdLd29nSUNBZ1lpQmllWFJsYzE5c1pXNWZhVzVmYkc5dmNGOTNhWFJvWDNCMWRGOW1iM0pmYUdWaFpHVnlRREVLQ21KNWRHVnpYMnhsYmw5cGJsOXNiMjl3WDNkcGRHaGZjSFYwWDJGbWRHVnlYMlp2Y2tBME9nb2dJQ0FnY0c5d0NpQWdJQ0F2THlCeVpXZHlaWE56YVc5dVgzUmxjM1J6TDJKdmVGOXlaV0ZrWDJadmNuZGhjbVJwYm1jdWNIazZNVEUzQ2lBZ0lDQXZMeUJoYzNObGNuUWdkRzkwWVd3Z1BUMGdPQW9nSUNBZ2FXNTBZMTh4SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklIUmxjM1JmWTJGelpYTXVjbVZuY21WemMybHZibDkwWlhOMGN5NWliM2hmY21WaFpGOW1iM0ozWVhKa2FXNW5Ma0p2ZUZKbFlXUkdiM0ozWVhKa2FXNW5MbUZ5Y21GNVgyeGxibDloWm5SbGNsOWhjSEJsYm1Rb0tTQXRQaUIyYjJsa09ncGhjbkpoZVY5c1pXNWZZV1owWlhKZllYQndaVzVrT2dvZ0lDQWdMeThnY21WbmNtVnpjMmx2Ymw5MFpYTjBjeTlpYjNoZmNtVmhaRjltYjNKM1lYSmthVzVuTG5CNU9qRXlNUW9nSUNBZ0x5OGdiU0E5SUhObGJHWXVZUzUyWVd4MVpTNWpiM0I1S0NrS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhnMk1Rb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZU0JsZUdsemRITUtJQ0FnSUM4dklISmxaM0psYzNOcGIyNWZkR1Z6ZEhNdlltOTRYM0psWVdSZlptOXlkMkZ5WkdsdVp5NXdlVG94TWpJS0lDQWdJQzh2SUhObGJHWXVZUzUyWVd4MVpTNWhjSEJsYm1Rb1lYSmpOQzVWU1c1ME5qUW9PU2twQ2lBZ0lDQndkWE5vYVc1MElEa0tJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZzJNUW9nSUNBZ2FXNTBZMTh6SUM4dklEQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lHbHVkR05mTVNBdkx5QTRDaUFnSUNCallXeHNjM1ZpSUdKdmVGOWtlVzVoYldsalgyRnljbUY1WDJOdmJtTmhkRjltYVhobFpBb2dJQ0FnTHk4Z2NtVm5jbVZ6YzJsdmJsOTBaWE4wY3k5aWIzaGZjbVZoWkY5bWIzSjNZWEprYVc1bkxuQjVPakV5TXdvZ0lDQWdMeThnWVhOelpYSjBJRzB1YkdWdVozUm9JRDA5SURJS0lDQWdJR2x1ZEdOZk15QXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYekFnTHk4Z01nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z2NtVm5jbVZ6YzJsdmJsOTBaWE4wY3k5aWIzaGZjbVZoWkY5bWIzSjNZWEprYVc1bkxuQjVPakV5TkFvZ0lDQWdMeThnYzJWc1ppNWhMblpoYkhWbElEMGdWVWx1ZERZMFFYSnlZWGtvWVhKak5DNVZTVzUwTmpRb01Ta3NJR0Z5WXpRdVZVbHVkRFkwS0RJcEtRb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VEWXhDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGcyTVFvZ0lDQWdZbmwwWldNZ055QXZMeUF3ZURBd01ESXdNREF3TURBd01EQXdNREF3TURBeE1EQXdNREF3TURBd01EQXdNREF3TWdvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2RHVnpkRjlqWVhObGN5NXlaV2R5WlhOemFXOXVYM1JsYzNSekxtSnZlRjl5WldGa1gyWnZjbmRoY21ScGJtY3VRbTk0VW1WaFpFWnZjbmRoY21ScGJtY3VZWEp5WVhsZlpXeGxiV1Z1ZEY5aFpuUmxjbDl6WlhRb0tTQXRQaUIyYjJsa09ncGhjbkpoZVY5bGJHVnRaVzUwWDJGbWRHVnlYM05sZERvS0lDQWdJQzh2SUhKbFozSmxjM05wYjI1ZmRHVnpkSE12WW05NFgzSmxZV1JmWm05eWQyRnlaR2x1Wnk1d2VUb3hNamdLSUNBZ0lDOHZJRzBnUFNCelpXeG1MbUV1ZG1Gc2RXVXVZMjl3ZVNncENpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE5qRUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbUVnWlhocGMzUnpDaUFnSUNBdkx5QnlaV2R5WlhOemFXOXVYM1JsYzNSekwySnZlRjl5WldGa1gyWnZjbmRoY21ScGJtY3VjSGs2TVRJNUNpQWdJQ0F2THlCelpXeG1MbUV1ZG1Gc2RXVmJNRjBnUFNCaGNtTTBMbFZKYm5RMk5DZzNLUW9nSUNBZ2NIVnphR2x1ZENBM0NpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE5qRUtJQ0FnSUdsdWRHTmZNQ0F2THlBeUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHSnZlRjl5WlhCc1lXTmxJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0J2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0F2THlCeVpXZHlaWE56YVc5dVgzUmxjM1J6TDJKdmVGOXlaV0ZrWDJadmNuZGhjbVJwYm1jdWNIazZNVE13Q2lBZ0lDQXZMeUJoYzNObGNuUWdiVnN3WFNBOVBTQXhDaUFnSUNCbGVIUnlZV04wSURJZ09Bb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJR2wwYjJJS0lDQWdJR0k5UFFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCeVpXZHlaWE56YVc5dVgzUmxjM1J6TDJKdmVGOXlaV0ZrWDJadmNuZGhjbVJwYm1jdWNIazZNVE14Q2lBZ0lDQXZMeUJ6Wld4bUxtRXVkbUZzZFdVZ1BTQlZTVzUwTmpSQmNuSmhlU2hoY21NMExsVkpiblEyTkNneEtTd2dZWEpqTkM1VlNXNTBOalFvTWlrcENpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE5qRUtJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ1lubDBaV05mTWlBdkx5QXdlRFl4Q2lBZ0lDQmllWFJsWXlBM0lDOHZJREI0TURBd01qQXdNREF3TURBd01EQXdNREF3TURFd01EQXdNREF3TURBd01EQXdNREF5Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0J5WlhSemRXSUtDZ292THlCMFpYTjBYMk5oYzJWekxuSmxaM0psYzNOcGIyNWZkR1Z6ZEhNdVltOTRYM0psWVdSZlptOXlkMkZ5WkdsdVp5NUNiM2hTWldGa1JtOXlkMkZ5WkdsdVp5NWhjbkpoZVY5aGNIQmxibVJmZDNKcGRHVmZZbUZqYTE5aFpuUmxjbDl3ZFhRb0tTQXRQaUIyYjJsa09ncGhjbkpoZVY5aGNIQmxibVJmZDNKcGRHVmZZbUZqYTE5aFpuUmxjbDl3ZFhRNkNpQWdJQ0F2THlCeVpXZHlaWE56YVc5dVgzUmxjM1J6TDJKdmVGOXlaV0ZrWDJadmNuZGhjbVJwYm1jdWNIazZNVE0xQ2lBZ0lDQXZMeUJ0SUQwZ2MyVnNaaTVoTG5aaGJIVmxMbU52Y0hrb0tRb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VEWXhDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVoSUdWNGFYTjBjd29nSUNBZ0x5OGdjbVZuY21WemMybHZibDkwWlhOMGN5OWliM2hmY21WaFpGOW1iM0ozWVhKa2FXNW5MbkI1T2pFek5nb2dJQ0FnTHk4Z2MyVnNaaTVoTG5aaGJIVmxJRDBnVlVsdWREWTBRWEp5WVhrb1lYSmpOQzVWU1c1ME5qUW9OeWtwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TmpFS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VEWXhDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNREF4TURBd01EQXdNREF3TURBd01EQXdOd29nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnY21WbmNtVnpjMmx2Ymw5MFpYTjBjeTlpYjNoZmNtVmhaRjltYjNKM1lYSmthVzVuTG5CNU9qRXpOd29nSUNBZ0x5OGdiUzVoY0hCbGJtUW9ZWEpqTkM1VlNXNTBOalFvT1NrcENpQWdJQ0J3ZFhOb2FXNTBJRGtLSUNBZ0lHbDBiMklLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lDOHZJSEpsWjNKbGMzTnBiMjVmZEdWemRITXZZbTk0WDNKbFlXUmZabTl5ZDJGeVpHbHVaeTV3ZVRveE16Y0tJQ0FnSUM4dklHMHVZWEJ3Wlc1a0tHRnlZelF1VlVsdWREWTBLRGtwS1FvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lDc0tJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITjNZWEFLSUNBZ0lISmxjR3hoWTJVeUlEQUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjbVZuY21WemMybHZibDkwWlhOMGN5OWliM2hmY21WaFpGOW1iM0ozWVhKa2FXNW5MbkI1T2pFek9Bb2dJQ0FnTHk4Z2MyVnNaaTVoTG5aaGJIVmxJRDBnYlM1amIzQjVLQ2tLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGcyTVFvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE5qRUtJQ0FnSUdScFp5QXhDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJ5WldkeVpYTnphVzl1WDNSbGMzUnpMMkp2ZUY5eVpXRmtYMlp2Y25kaGNtUnBibWN1Y0hrNk1UTTVDaUFnSUNBdkx5QmhjM05sY25RZ2MyVnNaaTVoTG5aaGJIVmxJRDA5SUZWSmJuUTJORUZ5Y21GNUtHRnlZelF1VlVsdWREWTBLREVwTENCaGNtTTBMbFZKYm5RMk5DZ3lLU3dnWVhKak5DNVZTVzUwTmpRb09Ta3BDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNREF6TURBd01EQXdNREF3TURBd01EQXdNVEF3TURBd01EQXdNREF3TURBd01ESXdNREF3TURBd01EQXdNREF3TURBNUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMENpQWdJQ0J5WlhSemRXSUtDZ292THlCMFpYTjBYMk5oYzJWekxuSmxaM0psYzNOcGIyNWZkR1Z6ZEhNdVltOTRYM0psWVdSZlptOXlkMkZ5WkdsdVp5NUNiM2hTWldGa1JtOXlkMkZ5WkdsdVp5NXpkSEoxWTNSZllYSnlZWGxmY21Wd2JHRmpaV1JmZDJsMGFGOXZkR2hsY2w5aGNuSmhlU2dwSUMwK0lIWnZhV1E2Q25OMGNuVmpkRjloY25KaGVWOXlaWEJzWVdObFpGOTNhWFJvWDI5MGFHVnlYMkZ5Y21GNU9nb2dJQ0FnTHk4Z2NtVm5jbVZ6YzJsdmJsOTBaWE4wY3k5aWIzaGZjbVZoWkY5bWIzSjNZWEprYVc1bkxuQjVPakUwTXdvZ0lDQWdMeThnYlNBOUlITmxiR1l1WkM1MllXeDFaUzVqYjNCNUtDa0tJQ0FnSUdKNWRHVmpYek1nTHk4Z01IZzJOQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WkNCbGVHbHpkSE1LSUNBZ0lDOHZJSEpsWjNKbGMzTnBiMjVmZEdWemRITXZZbTk0WDNKbFlXUmZabTl5ZDJGeVpHbHVaeTV3ZVRveE5EWUtJQ0FnSUM4dklHMHVZWEp5SUQwZ2IzUm9aWEl1WTI5d2VTZ3BDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNU0F2THlBNENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnYVc1MFkxOHpJQzh2SURBS0lDQWdJSE4zWVhBS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCaWVYUmxZeUF4TUNBdkx5QXdlREF3TURJd01EQXdNREF3TURBd01EQXdNREExTURBd01EQXdNREF3TURBd01EQXdPUW9nSUNBZ0x5OGdjbVZuY21WemMybHZibDkwWlhOMGN5OWliM2hmY21WaFpGOW1iM0ozWVhKa2FXNW5MbkI1T2pFME5nb2dJQ0FnTHk4Z2JTNWhjbklnUFNCdmRHaGxjaTVqYjNCNUtDa0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjbVZuY21WemMybHZibDkwWlhOMGN5OWliM2hmY21WaFpGOW1iM0ozWVhKa2FXNW5MbkI1T2pFME53b2dJQ0FnTHk4Z2MyVnNaaTVrTG5aaGJIVmxJRDBnYlM1amIzQjVLQ2tLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdNSGcyTkFvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0JpZVhSbFkxOHpJQzh2SURCNE5qUUtJQ0FnSUhOM1lYQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJSEpsWjNKbGMzTnBiMjVmZEdWemRITXZZbTk0WDNKbFlXUmZabTl5ZDJGeVpHbHVaeTV3ZVRveE5EZ0tJQ0FnSUM4dklHRnpjMlZ5ZENCelpXeG1MbVF1ZG1Gc2RXVXVZWEp5SUQwOUlGVkpiblEyTkVGeWNtRjVLR0Z5WXpRdVZVbHVkRFkwS0RVcExDQmhjbU0wTGxWSmJuUTJOQ2c1S1NrS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhnMk5Bb2dJQ0FnY0hWemFHbHVkQ0F4TUFvZ0lDQWdhVzUwWTE4d0lDOHZJRElLSUNBZ0lHSnZlRjlsZUhSeVlXTjBDaUFnSUNCaWRHOXBDaUFnSUNCcGJuUmpYekVnTHk4Z09Bb2dJQ0FnS2dvZ0lDQWdhVzUwWTE4d0lDOHZJRElLSUNBZ0lDc0tJQ0FnSUdKNWRHVmpYek1nTHk4Z01IZzJOQW9nSUNBZ2NIVnphR2x1ZENBeE1Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQW9nSUNBZ1lubDBaV01nTVRBZ0x5OGdNSGd3TURBeU1EQXdNREF3TURBd01EQXdNREF3TlRBd01EQXdNREF3TURBd01EQXdNRGtLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSFJsYzNSZlkyRnpaWE11Y21WbmNtVnpjMmx2Ymw5MFpYTjBjeTVpYjNoZmNtVmhaRjltYjNKM1lYSmthVzVuTGtKdmVGSmxZV1JHYjNKM1lYSmthVzVuTG1GeWNtRjVYM1IzYjE5amIzQnBaWE5mZDNKcGRIUmxibDlpWVdOclgybHVYMjl5WkdWeUtDa2dMVDRnZG05cFpEb0tZWEp5WVhsZmRIZHZYMk52Y0dsbGMxOTNjbWwwZEdWdVgySmhZMnRmYVc1ZmIzSmtaWEk2Q2lBZ0lDQXZMeUJ5WldkeVpYTnphVzl1WDNSbGMzUnpMMkp2ZUY5eVpXRmtYMlp2Y25kaGNtUnBibWN1Y0hrNk1UVTBDaUFnSUNBdkx5QnRNRnN3WFNBOUlGVkpiblEyTkNneE1qTXBDaUFnSUNCd2RYTm9hVzUwSURFeU13b2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2NtVm5jbVZ6YzJsdmJsOTBaWE4wY3k5aWIzaGZjbVZoWkY5bWIzSjNZWEprYVc1bkxuQjVPakUxTlFvZ0lDQWdMeThnYlRFZ1BTQnpaV3htTG5RdWRtRnNkV1V1WTI5d2VTZ3BDaUFnSUNCaWVYUmxZeUEwSUM4dklEQjROelFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5RZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ5WldkeVpYTnphVzl1WDNSbGMzUnpMMkp2ZUY5eVpXRmtYMlp2Y25kaGNtUnBibWN1Y0hrNk1UVTJDaUFnSUNBdkx5QnRNVnN4WFNBOUlGVkpiblEyTkNnek1qRXBDaUFnSUNCd2RYTm9hVzUwSURNeU1Rb2dJQ0FnYVhSdllnb2dJQ0FnY21Wd2JHRmpaVElnTVRBZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHRmpZMlZ6Y3lCcGN5QnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQXZMeUJ5WldkeVpYTnphVzl1WDNSbGMzUnpMMkp2ZUY5eVpXRmtYMlp2Y25kaGNtUnBibWN1Y0hrNk1UVTNDaUFnSUNBdkx5QnpaV3htTG5RdWRtRnNkV1VnUFNCdE1DNWpiM0I1S0NrS0lDQWdJR0o1ZEdWaklEUWdMeThnTUhnM05Bb2dJQ0FnTHk4Z2NtVm5jbVZ6YzJsdmJsOTBaWE4wY3k5aWIzaGZjbVZoWkY5bWIzSjNZWEprYVc1bkxuQjVPakUxTkFvZ0lDQWdMeThnYlRCYk1GMGdQU0JWU1c1ME5qUW9NVEl6S1FvZ0lDQWdhVzUwWTE4d0lDOHZJRElLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWW05NFgzSmxjR3hoWTJVZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lDOHZJSEpsWjNKbGMzTnBiMjVmZEdWemRITXZZbTk0WDNKbFlXUmZabTl5ZDJGeVpHbHVaeTV3ZVRveE5UZ0tJQ0FnSUM4dklITmxiR1l1ZEM1MllXeDFaU0E5SUcweExtTnZjSGtvS1FvZ0lDQWdZbmwwWldNZ05DQXZMeUF3ZURjMENpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z01IZzNOQW9nSUNBZ1pHbG5JREVLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhKbFozSmxjM05wYjI1ZmRHVnpkSE12WW05NFgzSmxZV1JmWm05eWQyRnlaR2x1Wnk1d2VUb3hOVGtLSUNBZ0lDOHZJR0Z6YzJWeWRDQnpaV3htTG5RdWRtRnNkV1VnUFQwZ1lYSmpOQzVFZVc1aGJXbGpRWEp5WVhsYlZVbHVkRFkwWFNoVlNXNTBOalFvTVNrc0lGVkpiblEyTkNnek1qRXBLUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREF3TWpBd01EQXdNREF3TURBd01EQXdNREV3TURBd01EQXdNREF3TURBd01UUXhDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QjBaWE4wWDJOaGMyVnpMbkpsWjNKbGMzTnBiMjVmZEdWemRITXVZbTk0WDNKbFlXUmZabTl5ZDJGeVpHbHVaeTVDYjNoU1pXRmtSbTl5ZDJGeVpHbHVaeTV1WlhOMFpXUmZjM1J5ZFdOMFgyTnZjSGxmWW1WbWIzSmxYM05sZENncElDMCtJSFp2YVdRNkNtNWxjM1JsWkY5emRISjFZM1JmWTI5d2VWOWlaV1p2Y21WZmMyVjBPZ29nSUNBZ0x5OGdjbVZuY21WemMybHZibDkwWlhOMGN5OWliM2hmY21WaFpGOW1iM0ozWVhKa2FXNW5MbkI1T2pFMk13b2dJQ0FnTHk4Z2JTQTlJSE5sYkdZdWJ5NTJZV3gxWlM1cGJtNWxjaTVqYjNCNUtDa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZzJaZ29nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1YnlCbGVHbHpkSE1LSUNBZ0lDOHZJSEpsWjNKbGMzTnBiMjVmZEdWemRITXZZbTk0WDNKbFlXUmZabTl5ZDJGeVpHbHVaeTV3ZVRveE5qUUtJQ0FnSUM4dklITmxiR1l1Ynk1MllXeDFaUzVwYm01bGNpNWhjbkpiTUYwZ1BTQlZTVzUwTmpRb055a0tJQ0FnSUhCMWMyaHBiblFnTndvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURabUNpQWdJQ0J3ZFhOb2FXNTBJREl3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNZ29nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUdKMGIya0tJQ0FnSUdGemMyVnlkQ0F2THlCcGJtUmxlQ0J2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE5tWUtJQ0FnSUhCMWMyaHBiblFnTWpJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1ltOTRYM0psY0d4aFkyVWdMeThnYjI0Z1pYSnliM0k2SUdsdVpHVjRJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJQzh2SUhKbFozSmxjM05wYjI1ZmRHVnpkSE12WW05NFgzSmxZV1JmWm05eWQyRnlaR2x1Wnk1d2VUb3hOalVLSUNBZ0lDOHZJR0Z6YzJWeWRDQnRMbUZ5Y2xzd1hTQTlQU0F4Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTVNBdkx5QTRDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6RWdMeThnT0FvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lHbHVkR05mTUNBdkx5QXlDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklISmxaM0psYzNOcGIyNWZkR1Z6ZEhNdlltOTRYM0psWVdSZlptOXlkMkZ5WkdsdVp5NXdlVG94TmpZS0lDQWdJQzh2SUdGemMyVnlkQ0J6Wld4bUxtOHVkbUZzZFdVdWFXNXVaWEl1WVhKeVd6QmRJRDA5SURjS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnMlpnb2dJQ0FnY0hWemFHbHVkQ0F5TUFvZ0lDQWdhVzUwWTE4d0lDOHZJRElLSUNBZ0lHSnZlRjlsZUhSeVlXTjBDaUFnSUNCaWRHOXBDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNWtaWGdnYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VEWm1DaUFnSUNCd2RYTm9hVzUwSURJeUNpQWdJQ0JwYm5Salh6RWdMeThnT0FvZ0lDQWdZbTk0WDJWNGRISmhZM1FnTHk4Z2IyNGdaWEp5YjNJNklHbHVaR1Y0SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUdKMGIya0tJQ0FnSUhCMWMyaHBiblFnTndvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnY21WbmNtVnpjMmx2Ymw5MFpYTjBjeTlpYjNoZmNtVmhaRjltYjNKM1lYSmthVzVuTG5CNU9qRTJOd29nSUNBZ0x5OGdjMlZzWmk1dkxuWmhiSFZsTG1sdWJtVnlMbUZ5Y2xzd1hTQTlJRlZKYm5RMk5DZ3hLUW9nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZzJaZ29nSUNBZ2NIVnphR2x1ZENBeU1nb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmliM2hmY21Wd2JHRmpaU0F2THlCdmJpQmxjbkp2Y2pvZ2FXNWtaWGdnYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2RHVnpkRjlqWVhObGN5NXlaV2R5WlhOemFXOXVYM1JsYzNSekxtSnZlRjl5WldGa1gyWnZjbmRoY21ScGJtY3VRbTk0VW1WaFpFWnZjbmRoY21ScGJtY3VibVZ6ZEdWa1gzTjBjblZqZEY5amIzQjVYMkpsWm05eVpWOWhjSEJsYm1Rb0tTQXRQaUIyYjJsa09ncHVaWE4wWldSZmMzUnlkV04wWDJOdmNIbGZZbVZtYjNKbFgyRndjR1Z1WkRvS0lDQWdJQzh2SUhKbFozSmxjM05wYjI1ZmRHVnpkSE12WW05NFgzSmxZV1JmWm05eWQyRnlaR2x1Wnk1d2VUb3hOekVLSUNBZ0lDOHZJRzBnUFNCelpXeG1MbTh1ZG1Gc2RXVXVhVzV1WlhJdVkyOXdlU2dwQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0Tm1ZS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtOGdaWGhwYzNSekNpQWdJQ0F2THlCeVpXZHlaWE56YVc5dVgzUmxjM1J6TDJKdmVGOXlaV0ZrWDJadmNuZGhjbVJwYm1jdWNIazZNVGN5Q2lBZ0lDQXZMeUJ6Wld4bUxtOHVkbUZzZFdVdWFXNXVaWEl1WVhKeUxtRndjR1Z1WkNoVlNXNTBOalFvT1NrcENpQWdJQ0J3ZFhOb2FXNTBJRGtLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGcyWmdvZ0lDQWdjSFZ6YUdsdWRDQXlNQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdhVzUwWTE4eElDOHZJRGdLSUNBZ0lHTmhiR3h6ZFdJZ1ltOTRYMlI1Ym1GdGFXTmZZWEp5WVhsZlkyOXVZMkYwWDJacGVHVmtDaUFnSUNBdkx5QnlaV2R5WlhOemFXOXVYM1JsYzNSekwySnZlRjl5WldGa1gyWnZjbmRoY21ScGJtY3VjSGs2TVRjekNpQWdJQ0F2THlCaGMzTmxjblFnYlM1aGNuSXViR1Z1WjNSb0lEMDlJRElLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh4SUM4dklEZ0tJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1TQXZMeUE0Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ2FXNTBZMTh6SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUJ5WldkeVpYTnphVzl1WDNSbGMzUnpMMkp2ZUY5eVpXRmtYMlp2Y25kaGNtUnBibWN1Y0hrNk1UYzBDaUFnSUNBdkx5QmhjM05sY25RZ2MyVnNaaTV2TG5aaGJIVmxMbWx1Ym1WeUxtRnljaTVzWlc1bmRHZ2dQVDBnTXdvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURabUNpQWdJQ0J3ZFhOb2FXNTBJREl3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNZ29nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUdKMGIya0tJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0F6Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUJ5WldkeVpYTnphVzl1WDNSbGMzUnpMMkp2ZUY5eVpXRmtYMlp2Y25kaGNtUnBibWN1Y0hrNk1UYzFDaUFnSUNBdkx5QmhjM05sY25RZ2MyVnNaaTV2TG5aaGJIVmxMbWx1Ym1WeUxtRnljaTV3YjNBb0tTQTlQU0E1Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNBdElDOHZJRzl1SUdWeWNtOXlPaUJqWVc1dWIzUWdjRzl3SUdaeWIyMGdaVzF3ZEhrZ1lYSnlZWGtLSUNBZ0lHUjFjQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0E4Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzVrWlhnZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekVnTHk4Z09Bb2dJQ0FnS2dvZ0lDQWdjSFZ6YUdsdWRDQXlNZ29nSUNBZ0t3b2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VEWm1DaUFnSUNCa2FXY2dNUW9nSUNBZ2FXNTBZMTh4SUM4dklEZ0tJQ0FnSUdKdmVGOWxlSFJ5WVdOMElDOHZJRzl1SUdWeWNtOXlPaUJwYm1SbGVDQnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQmlkRzlwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0F2THlCeVpXZHlaWE56YVc5dVgzUmxjM1J6TDJKdmVGOXlaV0ZrWDJadmNuZGhjbVJwYm1jdWNIazZNVGMxQ2lBZ0lDQXZMeUJoYzNObGNuUWdjMlZzWmk1dkxuWmhiSFZsTG1sdWJtVnlMbUZ5Y2k1d2IzQW9LU0E5UFNBNUNpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE5tWUtJQ0FnSUhCMWMyaHBiblFnTWpBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1ltOTRYM0psY0d4aFkyVUtJQ0FnSUM4dklISmxaM0psYzNOcGIyNWZkR1Z6ZEhNdlltOTRYM0psWVdSZlptOXlkMkZ5WkdsdVp5NXdlVG94TnpVS0lDQWdJQzh2SUdGemMyVnlkQ0J6Wld4bUxtOHVkbUZzZFdVdWFXNXVaWEl1WVhKeUxuQnZjQ2dwSUQwOUlEa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZzJaZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0F2THlCeVpXZHlaWE56YVc5dVgzUmxjM1J6TDJKdmVGOXlaV0ZrWDJadmNuZGhjbVJwYm1jdWNIazZNVGMxQ2lBZ0lDQXZMeUJoYzNObGNuUWdjMlZzWmk1dkxuWmhiSFZsTG1sdWJtVnlMbUZ5Y2k1d2IzQW9LU0E5UFNBNUNpQWdJQ0JwYm5Salh6RWdMeThnT0FvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0Q2lBZ0lDQmliM2hmYzNCc2FXTmxDaUFnSUNBdkx5QnlaV2R5WlhOemFXOXVYM1JsYzNSekwySnZlRjl5WldGa1gyWnZjbmRoY21ScGJtY3VjSGs2TVRjMUNpQWdJQ0F2THlCaGMzTmxjblFnYzJWc1ppNXZMblpoYkhWbExtbHVibVZ5TG1GeWNpNXdiM0FvS1NBOVBTQTVDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRObVlLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJSEJ2Y0FvZ0lDQWdMeThnY21WbmNtVnpjMmx2Ymw5MFpYTjBjeTlpYjNoZmNtVmhaRjltYjNKM1lYSmthVzVuTG5CNU9qRTNOUW9nSUNBZ0x5OGdZWE56WlhKMElITmxiR1l1Ynk1MllXeDFaUzVwYm01bGNpNWhjbkl1Y0c5d0tDa2dQVDBnT1FvZ0lDQWdhVzUwWTE4eElDOHZJRGdLSUNBZ0lDMEtJQ0FnSUM4dklISmxaM0psYzNOcGIyNWZkR1Z6ZEhNdlltOTRYM0psWVdSZlptOXlkMkZ5WkdsdVp5NXdlVG94TnpVS0lDQWdJQzh2SUdGemMyVnlkQ0J6Wld4bUxtOHVkbUZzZFdVdWFXNXVaWEl1WVhKeUxuQnZjQ2dwSUQwOUlEa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZzJaZ29nSUNBZ2MzZGhjQW9nSUNBZ1ltOTRYM0psYzJsNlpRb2dJQ0FnTHk4Z2NtVm5jbVZ6YzJsdmJsOTBaWE4wY3k5aWIzaGZjbVZoWkY5bWIzSjNZWEprYVc1bkxuQjVPakUzTlFvZ0lDQWdMeThnWVhOelpYSjBJSE5sYkdZdWJ5NTJZV3gxWlM1cGJtNWxjaTVoY25JdWNHOXdLQ2tnUFQwZ09Rb2dJQ0FnY0hWemFHbHVkQ0E1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUIwWlhOMFgyTmhjMlZ6TG5KbFozSmxjM05wYjI1ZmRHVnpkSE11WW05NFgzSmxZV1JmWm05eWQyRnlaR2x1Wnk1Q2IzaFNaV0ZrUm05eWQyRnlaR2x1Wnk1dVlYUnBkbVZmWm1sbGJHUmZZMjl3ZVY5cGRHVnlZWFJsWkY5M2FHbHNaVjl0YjJScFptbGxaQ2dwSUMwK0lIWnZhV1E2Q201aGRHbDJaVjltYVdWc1pGOWpiM0I1WDJsMFpYSmhkR1ZrWDNkb2FXeGxYMjF2WkdsbWFXVmtPZ29nSUNBZ0x5OGdjbVZuY21WemMybHZibDkwWlhOMGN5OWliM2hmY21WaFpGOW1iM0ozWVhKa2FXNW5MbkI1T2pFM09Rb2dJQ0FnTHk4Z2RHOTBZV3dnUFNCVlNXNTBOalFvTUNrS0lDQWdJR2x1ZEdOZk15QXZMeUF3Q2lBZ0lDQXZMeUJ5WldkeVpYTnphVzl1WDNSbGMzUnpMMkp2ZUY5eVpXRmtYMlp2Y25kaGNtUnBibWN1Y0hrNk1UZ3dDaUFnSUNBdkx5Qm1iM0lnYVhSbGJTQnBiaUJ6Wld4bUxtNHVkbUZzZFdVdVlYSnlMbU52Y0hrb0tUb0tJQ0FnSUdKNWRHVmpJRFVnTHk4Z01IZzJaUW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1YmlCbGVHbHpkSE1LSUNBZ0lHSjVkR1ZqSURVZ0x5OGdNSGcyWlFvZ0lDQWdjSFZ6YUdsdWRDQXhNQW9nSUNBZ2FXNTBZMTh3SUM4dklESUtJQ0FnSUdKdmVGOWxlSFJ5WVdOMENpQWdJQ0JpZEc5cENpQWdJQ0JwYm5Salh6TWdMeThnTUFvS2JtRjBhWFpsWDJacFpXeGtYMk52Y0hsZmFYUmxjbUYwWldSZmQyaHBiR1ZmYlc5a2FXWnBaV1JmWm05eVgyaGxZV1JsY2tBeE9nb2dJQ0FnTHk4Z2NtVm5jbVZ6YzJsdmJsOTBaWE4wY3k5aWIzaGZjbVZoWkY5bWIzSjNZWEprYVc1bkxuQjVPakU0TUFvZ0lDQWdMeThnWm05eUlHbDBaVzBnYVc0Z2MyVnNaaTV1TG5aaGJIVmxMbUZ5Y2k1amIzQjVLQ2s2Q2lBZ0lDQmtkWEFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQThDaUFnSUNCaWVpQnVZWFJwZG1WZlptbGxiR1JmWTI5d2VWOXBkR1Z5WVhSbFpGOTNhR2xzWlY5dGIyUnBabWxsWkY5aFpuUmxjbDltYjNKQU5Bb2dJQ0FnWkdsbklESUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHhJQzh2SURnS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0J6ZFdKemRISnBibWN6Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ1pHbG5JREVLSUNBZ0lHbHVkR05mTVNBdkx5QTRDaUFnSUNBcUNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnTHk4Z2NtVm5jbVZ6YzJsdmJsOTBaWE4wY3k5aWIzaGZjbVZoWkY5bWIzSjNZWEprYVc1bkxuQjVPakU0TVFvZ0lDQWdMeThnYzJWc1ppNXVMblpoYkhWbExtRnljbHN4WFNBOUlGVkpiblEyTkNneE1EQXBDaUFnSUNCd2RYTm9hVzUwSURFd01Bb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTWdOU0F2THlBd2VEWmxDaUFnSUNCd2RYTm9hVzUwSURJd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHSnZlRjl5WlhCc1lXTmxJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0J2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0F2THlCeVpXZHlaWE56YVc5dVgzUmxjM1J6TDJKdmVGOXlaV0ZrWDJadmNuZGhjbVJwYm1jdWNIazZNVGd5Q2lBZ0lDQXZMeUIwYjNSaGJDQXJQU0JwZEdWdENpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lDc0tJQ0FnSUdOdmRtVnlJRE1LSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNBckNpQWdJQ0JpSUc1aGRHbDJaVjltYVdWc1pGOWpiM0I1WDJsMFpYSmhkR1ZrWDNkb2FXeGxYMjF2WkdsbWFXVmtYMlp2Y2w5b1pXRmtaWEpBTVFvS2JtRjBhWFpsWDJacFpXeGtYMk52Y0hsZmFYUmxjbUYwWldSZmQyaHBiR1ZmYlc5a2FXWnBaV1JmWVdaMFpYSmZabTl5UURRNkNpQWdJQ0J3YjNCdUlETUtJQ0FnSUM4dklISmxaM0psYzNOcGIyNWZkR1Z6ZEhNdlltOTRYM0psWVdSZlptOXlkMkZ5WkdsdVp5NXdlVG94T0RNS0lDQWdJQzh2SUdGemMyVnlkQ0IwYjNSaGJDQTlQU0F6Q2lBZ0lDQndkWE5vYVc1MElETUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklISmxaM0psYzNOcGIyNWZkR1Z6ZEhNdlltOTRYM0psWVdSZlptOXlkMkZ5WkdsdVp5NXdlVG94T0RRS0lDQWdJQzh2SUhObGJHWXViaTUyWVd4MVpTNWhjbkpiTVYwZ1BTQlZTVzUwTmpRb01pa0tJQ0FnSUdsdWRHTmZNQ0F2THlBeUNpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFl5QTFJQzh2SURCNE5tVUtJQ0FnSUhCMWMyaHBiblFnTWpBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1ltOTRYM0psY0d4aFkyVWdMeThnYjI0Z1pYSnliM0k2SUdsdVpHVjRJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJSEpsZEhOMVlnbz0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFQWdnQkFDWUxBV0lCYndGaEFXUUJkQUZ1QkdGaVkyUVNBQUlBQUFBQUFBQUFBUUFBQUFBQUFBQUNBWGdjQUFBQUFBQUFBQUVBQ2dBQ0FBQUFBQUFBQUFFQUFBQUFBQUFBQWhJQUFnQUFBQUFBQUFBRkFBQUFBQUFBQUFreEcwRUFIekVaRkVReEdFU0NBZ1FTTEM5ZUJQNkVndjQyR2dDT0FnQkRBQUVBSkVNeEdSUXhHQlFRUTRvRkFJdjdpL3dpdWhlTCs3MUlpLzZML3dzSWkvdE0wMG1ML2dnV1Z3WUNpL3VML0U4Q3U0djhJZ2hNaS84TENJdjdUQ1dML2RLSktMeElLQ2NHdnlxOFNDb25CNzhydkVnckp3bS9Kd1M4U0NjRUp3ZS9Kd1c4U0NjRkp3bS9LYnhJS1lBbUFBQUFBQUFBQUFFQUNnQUFBQUFBQUFBQkFBb0FBZ0FBQUFBQUFBQUJBQUFBQUFBQUFBSy9pQUFtaUFBN2lBQnBpQUNCaUFDYWlBQzlpQURXaUFEdGlBRTRpQUZjaUFHTWlBSEppQUlvSkVNb3ZrUW92RWdvZ0FFRnZ4V0JCQkpFS0x4SUtDY0d2NGtvdmtRb0pTU0FBM0Z4Y2RKSkZTVkxBUThsU3dKUEFrMGlTd0lQSWs4RFR3Sk5Vb0FDWVdJU1JDaThTQ2duQnIrSktMNUVpQUFORllFRUVrUW92RWdvSndhL2lTaThTQ2duQ0wrSktMNUVNUnRCQUFjb3ZFZ29Kd2kvRllFRUVrUW92RWdvSndhL2lZb0FBQ2krUkNWSlNTSU1RUUFUU3dJVlR3SUlUQ2k4U0NnbkNMOGtDRUwvNTBnakVrU0pLcjVFZ1FrV0tpVlBBaVFqaVA2V0pWa2lFa1FxdkVncUp3ZS9pU3ErUklFSEZpb2lUd0s3VndJSUpCYW9SQ3E4U0NvbkI3K0pLcjVFS3J4SUtvQUtBQUVBQUFBQUFBQUFCNytCQ1JaTEFTVlpKQWdXVndZQVR3Sk1YQUJNVUNxOFNDcExBYitBR2dBREFBQUFBQUFBQUFFQUFBQUFBQUFBQWdBQUFBQUFBQUFKRWtTSks3NUVTU05aSlV4WUp3cFFLN3hJSzB5L0s0RUtJcm9YSXdzaUNDdUJDazhDdWljS0VrU0pnWHNXSndTK1JJSEJBaFpjQ2ljRUlrOER1eWNFdkVnbkJFc0J2NEFTQUFJQUFBQUFBQUFBQVFBQUFBQUFBQUZCRWtTSktiNUVnUWNXS1lFVUlyb1hSQ21CRms4Q3Uwa2pXVXNCRlZKSkkxbExBUlZTSWxza0VrUXBnUlFpdWhkRUtZRVdJN29YZ1FjU1JDUVdLWUVXVHdLN2lTbStSSUVKRmltQkZFOENKQ09JL1hkSkkxbExBUlZTU1NOWlN3RVZVaVZaSWhKRUtZRVVJcm9YU1lFREVrUkpKQWxKVHdJTVJFa2pDNEVXQ0NsTEFTTzZGMDhDRmxjR0FpbUJGRThDdXlsUEFpT0FBTklwdlVnakNTbE0wNEVKRWtTSkpTY0Z2a1FuQllFS0lyb1hKVWxMQWd4QkFDVkxBa2tqV1VzQkZWSlhBZ0JMQVNNTFc0RmtGaWNGZ1JSUEFydFBCQWhPQXlRSVF2L1VSZ09CQXhKRUloWW5CWUVVVHdLN2lRPT0iLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjk5LCJtaW5vciI6OTksInBhdGNoIjo5OSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
