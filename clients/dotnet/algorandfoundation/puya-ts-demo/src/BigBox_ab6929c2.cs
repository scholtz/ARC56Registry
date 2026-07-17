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

namespace Arc56.Generated.algorandfoundation.puya_ts_demo.BigBox_ab6929c2
{


    public class BigBoxProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public BigBoxProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class Metadata : AVMObjectType
            {
                public ulong Start { get; set; }

                public ulong End { get; set; }

                public byte Status { get; set; }

                public ulong EndSize { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStart = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vStart.From(Start);
                    ret.AddRange(vStart.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEnd = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vEnd.From(End);
                    ret.AddRange(vEnd.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStatus = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    vStatus.From(Status);
                    ret.AddRange(vStatus.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEndSize = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vEndSize.From(EndSize);
                    ret.AddRange(vEndSize.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Metadata Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Metadata();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStart = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vStart.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueStart = vStart.ToValue();
                    if (valueStart is ulong vStartValue) { ret.Start = vStartValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEnd = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vEnd.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueEnd = vEnd.ToValue();
                    if (valueEnd is ulong vEndValue) { ret.End = vEndValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStatus = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vStatus.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueStatus = vStatus.ToValue();
                    if (valueStatus is byte vStatusValue) { ret.Status = vStatusValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEndSize = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vEndSize.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueEndSize = vEndSize.ToValue();
                    if (valueEndSize is ulong vEndSizeValue) { ret.EndSize = vEndSizeValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Metadata);
                }
                public bool Equals(Metadata? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Metadata left, Metadata right)
                {
                    return EqualityComparer<Metadata>.Default.Equals(left, right);
                }
                public static bool operator !=(Metadata left, Metadata right)
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
        ///
        ///Allocate boxes to begin data upload process
        ///</summary>
        /// <param name="dataIdentifier">The unique identifier for the data </param>
        /// <param name="numBoxes">The number of boxes that the data will take up </param>
        /// <param name="endBoxSize">The size of the last box </param>
        /// <param name="mbrPayment">Payment from the uploader to cover the box MBR </param>
        public async Task StartUpload(PaymentTransaction mbrPayment, string dataIdentifier, ulong numBoxes, ulong endBoxSize, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrPayment });
            byte[] abiHandle = { 160, 91, 86, 105 };
            var dataIdentifierAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); dataIdentifierAbi.From(dataIdentifier);
            var numBoxesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); numBoxesAbi.From(numBoxes);
            var endBoxSizeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); endBoxSizeAbi.From(endBoxSize);

            var result = await base.CallApp(new List<object> { abiHandle, dataIdentifierAbi, numBoxesAbi, endBoxSizeAbi, mbrPayment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> StartUpload_Transactions(PaymentTransaction mbrPayment, string dataIdentifier, ulong numBoxes, ulong endBoxSize, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrPayment });
            byte[] abiHandle = { 160, 91, 86, 105 };
            var dataIdentifierAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); dataIdentifierAbi.From(dataIdentifier);
            var numBoxesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); numBoxesAbi.From(numBoxes);
            var endBoxSizeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); endBoxSizeAbi.From(endBoxSize);

            return await base.MakeTransactionList(new List<object> { abiHandle, dataIdentifierAbi, numBoxesAbi, endBoxSizeAbi, mbrPayment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///Upload data to a specific offset in a box
        ///</summary>
        /// <param name="dataIdentifier">The unique identifier for the data </param>
        /// <param name="boxIndex">The index of the box to upload the given chunk of data to </param>
        /// <param name="offset">The offset within the box to start writing the data </param>
        /// <param name="data">The data to write </param>
        public async Task Upload(string dataIdentifier, ulong boxIndex, ulong offset, byte[] data, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 27, 125, 250, 53 };
            var dataIdentifierAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); dataIdentifierAbi.From(dataIdentifier);
            var boxIndexAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); boxIndexAbi.From(boxIndex);
            var offsetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); offsetAbi.From(offset);
            var dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dataAbi.From(data);

            var result = await base.CallApp(new List<object> { abiHandle, dataIdentifierAbi, boxIndexAbi, offsetAbi, dataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Upload_Transactions(string dataIdentifier, ulong boxIndex, ulong offset, byte[] data, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 27, 125, 250, 53 };
            var dataIdentifierAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); dataIdentifierAbi.From(dataIdentifier);
            var boxIndexAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); boxIndexAbi.From(boxIndex);
            var offsetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); offsetAbi.From(offset);
            var dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dataAbi.From(data);

            return await base.MakeTransactionList(new List<object> { abiHandle, dataIdentifierAbi, boxIndexAbi, offsetAbi, dataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///Set the status of the data
        ///</summary>
        /// <param name="dataIdentifier">The unique identifier for the data </param>
        /// <param name="status">The new status for the data </param>
        public async Task SetStatus(string dataIdentifier, byte status, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 191, 56, 86, 248 };
            var dataIdentifierAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); dataIdentifierAbi.From(dataIdentifier);
            var statusAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); statusAbi.From(status);

            var result = await base.CallApp(new List<object> { abiHandle, dataIdentifierAbi, statusAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetStatus_Transactions(string dataIdentifier, byte status, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 191, 56, 86, 248 };
            var dataIdentifierAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); dataIdentifierAbi.From(dataIdentifier);
            var statusAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); statusAbi.From(status);

            return await base.MakeTransactionList(new List<object> { abiHandle, dataIdentifierAbi, statusAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQmlnQm94IiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7Ik1ldGFkYXRhIjpbeyJuYW1lIjoic3RhcnQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZW5kIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InN0YXR1cyIsInR5cGUiOiJ1aW50OCJ9LHsibmFtZSI6ImVuZFNpemUiLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImNyZWF0ZUFwcGxpY2F0aW9uIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InN0YXJ0VXBsb2FkIiwiZGVzYyI6IlxuQWxsb2NhdGUgYm94ZXMgdG8gYmVnaW4gZGF0YSB1cGxvYWQgcHJvY2VzcyIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkYXRhSWRlbnRpZmllciIsImRlc2MiOiJUaGUgdW5pcXVlIGlkZW50aWZpZXIgZm9yIHRoZSBkYXRhIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJudW1Cb3hlcyIsImRlc2MiOiJUaGUgbnVtYmVyIG9mIGJveGVzIHRoYXQgdGhlIGRhdGEgd2lsbCB0YWtlIHVwIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJlbmRCb3hTaXplIiwiZGVzYyI6IlRoZSBzaXplIG9mIHRoZSBsYXN0IGJveCIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibWJyUGF5bWVudCIsImRlc2MiOiJQYXltZW50IGZyb20gdGhlIHVwbG9hZGVyIHRvIGNvdmVyIHRoZSBib3ggTUJSIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InVwbG9hZCIsImRlc2MiOiJcblVwbG9hZCBkYXRhIHRvIGEgc3BlY2lmaWMgb2Zmc2V0IGluIGEgYm94IiwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRhdGFJZGVudGlmaWVyIiwiZGVzYyI6IlRoZSB1bmlxdWUgaWRlbnRpZmllciBmb3IgdGhlIGRhdGEiLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJveEluZGV4IiwiZGVzYyI6IlRoZSBpbmRleCBvZiB0aGUgYm94IHRvIHVwbG9hZCB0aGUgZ2l2ZW4gY2h1bmsgb2YgZGF0YSB0byIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoib2Zmc2V0IiwiZGVzYyI6IlRoZSBvZmZzZXQgd2l0aGluIHRoZSBib3ggdG8gc3RhcnQgd3JpdGluZyB0aGUgZGF0YSIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGF0YSIsImRlc2MiOiJUaGUgZGF0YSB0byB3cml0ZSIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRTdGF0dXMiLCJkZXNjIjoiXG5TZXQgdGhlIHN0YXR1cyBvZiB0aGUgZGF0YSIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkYXRhSWRlbnRpZmllciIsImRlc2MiOiJUaGUgdW5pcXVlIGlkZW50aWZpZXIgZm9yIHRoZSBkYXRhIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50OCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InN0YXR1cyIsImRlc2MiOiJUaGUgbmV3IHN0YXR1cyBmb3IgdGhlIGRhdGEiLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjEsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsyMzIsMzIwXSwiZXJyb3JNZXNzYWdlIjoiQm94IG11c3QgaGF2ZSB2YWx1ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM2XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE5Nl0sImVycm9yTWVzc2FnZSI6ImFzc2VydCB0YXJnZXQgaXMgbWF0Y2ggZm9yIGNvbmRpdGlvbnMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTRdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBHbG9iYWxTdGF0ZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTBdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIHBheSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTVNBd0lEZ0tJQ0FnSUdKNWRHVmpZbXh2WTJzZ0ltTjFjbkpsYm5SSmJtUmxlQ0lnTUhnd01DQXdlREF5Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWW01NklHMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXlDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZbWxuTFdKdmVDOWlhV2N0WW05NExtRnNaMjh1ZEhNNk5EZ0tJQ0FnSUM4dklHTjFjbkpsYm5SSmJtUmxlQ0E5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b2V5QnBibWwwYVdGc1ZtRnNkV1U2SURBZ2ZTazdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmpkWEp5Wlc1MFNXNWtaWGdpQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLQ20xaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeU9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwySnBaeTFpYjNndlltbG5MV0p2ZUM1aGJHZHZMblJ6T2pNNUNpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdRbWxuUW05NElHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnRkWE4wSUdKbElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpZWlCdFlXbHVYMk55WldGMFpWOU9iMDl3UURrS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhoaE1EVmlOVFkyT1NBd2VERmlOMlJtWVRNMUlEQjRZbVl6T0RVMlpqZ2dMeThnYldWMGFHOWtJQ0p6ZEdGeWRGVndiRzloWkNoemRISnBibWNzZFdsdWREWTBMSFZwYm5RMk5DeHdZWGtwZG05cFpDSXNJRzFsZEdodlpDQWlkWEJzYjJGa0tITjBjbWx1Wnl4MWFXNTBOalFzZFdsdWREWTBMR0o1ZEdWYlhTbDJiMmxrSWl3Z2JXVjBhRzlrSUNKelpYUlRkR0YwZFhNb2MzUnlhVzVuTEhWcGJuUTRLWFp2YVdRaUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQnpkR0Z5ZEZWd2JHOWhaQ0IxY0d4dllXUWdjMlYwVTNSaGRIVnpDaUFnSUNCbGNuSUtDbTFoYVc1ZlkzSmxZWFJsWDA1dlQzQkFPVG9LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlpYVdjdFltOTRMMkpwWnkxaWIzZ3VZV3huYnk1MGN6b3pPUW9nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUVKcFowSnZlQ0JsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlR0k0TkRRM1lqTTJJQzh2SUcxbGRHaHZaQ0FpWTNKbFlYUmxRWEJ3YkdsallYUnBiMjRvS1hadmFXUWlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0J0WVdsdVgyTnlaV0YwWlVGd2NHeHBZMkYwYVc5dVgzSnZkWFJsUURFd0NpQWdJQ0JsY25JS0NtMWhhVzVmWTNKbFlYUmxRWEJ3YkdsallYUnBiMjVmY205MWRHVkFNVEE2Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WW1sbkxXSnZlQzlpYVdjdFltOTRMbUZzWjI4dWRITTZOVEFLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCdmJrTnlaV0YwWlRvZ0luSmxjWFZwY21VaUlIMHBDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z1kyOXVkSEpoWTNSekwySnBaeTFpYjNndlltbG5MV0p2ZUM1aGJHZHZMblJ6T2pwQ2FXZENiM2d1YzNSaGNuUlZjR3h2WVdSYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHpkR0Z5ZEZWd2JHOWhaRG9LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlpYVdjdFltOTRMMkpwWnkxaWIzZ3VZV3huYnk1MGN6bzJNaTAyTndvZ0lDQWdMeThnYzNSaGNuUlZjR3h2WVdRb0NpQWdJQ0F2THlBZ0lHUmhkR0ZKWkdWdWRHbG1hV1Z5T2lCemRISnBibWNzQ2lBZ0lDQXZMeUFnSUc1MWJVSnZlR1Z6T2lCMWFXNTBOalFzQ2lBZ0lDQXZMeUFnSUdWdVpFSnZlRk5wZW1VNklIVnBiblEyTkN3S0lDQWdJQzh2SUNBZ2JXSnlVR0Y1YldWdWREb2daM1I0Ymk1UVlYbHRaVzUwVkhodUxBb2dJQ0FnTHk4Z0tUb2dkbTlwWkNCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCa2RYQUtJQ0FnSUdkMGVHNXpJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z2NHRjVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUhSeVlXNXpZV04wYVc5dUlIUjVjR1VnYVhNZ2NHRjVDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZbWxuTFdKdmVDOWlhV2N0WW05NExtRnNaMjh1ZEhNNk5qZ0tJQ0FnSUM4dklHTnZibk4wSUhOMFlYSjBRbTk0SUQwZ2RHaHBjeTVqZFhKeVpXNTBTVzVrWlhndWRtRnNkV1U3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkpwWnkxaWIzZ3ZZbWxuTFdKdmVDNWhiR2R2TG5Sek9qUTRDaUFnSUNBdkx5QmpkWEp5Wlc1MFNXNWtaWGdnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tIc2dhVzVwZEdsaGJGWmhiSFZsT2lBd0lIMHBPd29nSUNBZ1lubDBaV05mTUNBdkx5QWlZM1Z5Y21WdWRFbHVaR1Y0SWdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJKcFp5MWliM2d2WW1sbkxXSnZlQzVoYkdkdkxuUnpPalk0Q2lBZ0lDQXZMeUJqYjI1emRDQnpkR0Z5ZEVKdmVDQTlJSFJvYVhNdVkzVnljbVZ1ZEVsdVpHVjRMblpoYkhWbE93b2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5aWFXY3RZbTk0TDJKcFp5MWliM2d1WVd4bmJ5NTBjem8yT1FvZ0lDQWdMeThnWTI5dWMzUWdaVzVrUW05NE9pQjFhVzUwTmpRZ1BTQnpkR0Z5ZEVKdmVDQXJJRzUxYlVKdmVHVnpJQzBnTVRzS0lDQWdJR1IxY0FvZ0lDQWdaR2xuSURRS0lDQWdJQ3NLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBdENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlltbG5MV0p2ZUM5aWFXY3RZbTk0TG1Gc1oyOHVkSE02TnpFdE56WUtJQ0FnSUM4dklHTnZibk4wSUcxbGRHRmtZWFJoT2lCTlpYUmhaR0YwWVNBOUlIc0tJQ0FnSUM4dklDQWdjM1JoY25RNklITjBZWEowUW05NExBb2dJQ0FnTHk4Z0lDQmxibVE2SUdWdVpFSnZlQ3dLSUNBZ0lDOHZJQ0FnYzNSaGRIVnpPaUJKVGw5UVVrOUhVa1ZUVXl3S0lDQWdJQzh2SUNBZ1pXNWtVMmw2WlRvZ1pXNWtRbTk0VTJsNlpTd0tJQ0FnSUM4dklIMDdDaUFnSUNCemQyRndDaUFnSUNCcGRHOWlDaUFnSUNCa2FXY2dNUW9nSUNBZ2FYUnZZZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WW1sbkxXSnZlQzlpYVdjdFltOTRMbUZzWjI4dWRITTZOelFLSUNBZ0lDOHZJSE4wWVhSMWN6b2dTVTVmVUZKUFIxSkZVMU1zQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TURBS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5aWFXY3RZbTk0TDJKcFp5MWliM2d1WVd4bmJ5NTBjem8zTVMwM05nb2dJQ0FnTHk4Z1kyOXVjM1FnYldWMFlXUmhkR0U2SUUxbGRHRmtZWFJoSUQwZ2V3b2dJQ0FnTHk4Z0lDQnpkR0Z5ZERvZ2MzUmhjblJDYjNnc0NpQWdJQ0F2THlBZ0lHVnVaRG9nWlc1a1FtOTRMQW9nSUNBZ0x5OGdJQ0J6ZEdGMGRYTTZJRWxPWDFCU1QwZFNSVk5UTEFvZ0lDQWdMeThnSUNCbGJtUlRhWHBsT2lCbGJtUkNiM2hUYVhwbExBb2dJQ0FnTHk4Z2ZUc0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JRE1LSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJKcFp5MWliM2d2WW1sbkxXSnZlQzVoYkdkdkxuUnpPamM1Q2lBZ0lDQXZMeUJoYzNObGNuUW9JWFJvYVhNdWJXVjBZV1JoZEdFb1pHRjBZVWxrWlc1MGFXWnBaWEpDZVhSbGN5a3VaWGhwYzNSektUc0tJQ0FnSUdScFp5QTFDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJKcFp5MWliM2d2WW1sbkxXSnZlQzVoYkdkdkxuUnpPamd4Q2lBZ0lDQXZMeUIwYUdsekxtMWxkR0ZrWVhSaEtHUmhkR0ZKWkdWdWRHbG1hV1Z5UW5sMFpYTXBMblpoYkhWbElEMGdZMnh2Ym1Vb2JXVjBZV1JoZEdFcE93b2dJQ0FnZFc1amIzWmxjaUExQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlltbG5MV0p2ZUM5aWFXY3RZbTk0TG1Gc1oyOHVkSE02T0RNS0lDQWdJQzh2SUhSb2FYTXVZM1Z5Y21WdWRFbHVaR1Y0TG5aaGJIVmxJRDBnWlc1a1FtOTRJQ3NnTVRzS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXJDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZbWxuTFdKdmVDOWlhV2N0WW05NExtRnNaMjh1ZEhNNk5EZ0tJQ0FnSUM4dklHTjFjbkpsYm5SSmJtUmxlQ0E5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b2V5QnBibWwwYVdGc1ZtRnNkV1U2SURBZ2ZTazdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmpkWEp5Wlc1MFNXNWtaWGdpQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WW1sbkxXSnZlQzlpYVdjdFltOTRMbUZzWjI4dWRITTZPRE1LSUNBZ0lDOHZJSFJvYVhNdVkzVnljbVZ1ZEVsdVpHVjRMblpoYkhWbElEMGdaVzVrUW05NElDc2dNVHNLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WW1sbkxXSnZlQzlpYVdjdFltOTRMbUZzWjI4dWRITTZPRFlLSUNBZ0lDOHZJRzUxYlVKdmVHVnpJQ29nUTA5VFZGOVFSVkpmUWs5WUlDc2dMeThnWTI5emRDQnZaaUJpYjNobGN3b2dJQ0FnWkdsbklESUtJQ0FnSUhCMWMyaHBiblFnTWpVd01DQXZMeUF5TlRBd0NpQWdJQ0FxQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WW1sbkxXSnZlQzlpYVdjdFltOTRMbUZzWjI4dWRITTZPRGNLSUNBZ0lDOHZJQ2h1ZFcxQ2IzaGxjeUF0SURFcElDb2dUVUZZWDBKUFdGOVRTVnBGSUNvZ1EwOVRWRjlRUlZKZlFsbFVSU0FySUM4dklHTnZjM1FnYjJZZ1pHRjBZUW9nSUNBZ1pHbG5JRE1LSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBdENpQWdJQ0J3ZFhOb2FXNTBJREV6TVRBM01qQXdJQzh2SURFek1UQTNNakF3Q2lBZ0lDQXFDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZbWxuTFdKdmVDOWlhV2N0WW05NExtRnNaMjh1ZEhNNk9EWXRPRGNLSUNBZ0lDOHZJRzUxYlVKdmVHVnpJQ29nUTA5VFZGOVFSVkpmUWs5WUlDc2dMeThnWTI5emRDQnZaaUJpYjNobGN3b2dJQ0FnTHk4Z0tHNTFiVUp2ZUdWeklDMGdNU2tnS2lCTlFWaGZRazlZWDFOSldrVWdLaUJEVDFOVVgxQkZVbDlDV1ZSRklDc2dMeThnWTI5emRDQnZaaUJrWVhSaENpQWdJQ0FyQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WW1sbkxXSnZlQzlpYVdjdFltOTRMbUZzWjI4dWRITTZPRGdLSUNBZ0lDOHZJRzUxYlVKdmVHVnpJQ29nTmpRZ0tpQkRUMU5VWDFCRlVsOUNXVlJGSUNzZ0x5OGdZMjl6ZENCdlppQnJaWGx6Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUhCMWMyaHBiblFnTWpVMk1EQWdMeThnTWpVMk1EQUtJQ0FnSUNvS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5aWFXY3RZbTk0TDJKcFp5MWliM2d1WVd4bmJ5NTBjem80TmkwNE9Bb2dJQ0FnTHk4Z2JuVnRRbTk0WlhNZ0tpQkRUMU5VWDFCRlVsOUNUMWdnS3lBdkx5QmpiM04wSUc5bUlHSnZlR1Z6Q2lBZ0lDQXZMeUFvYm5WdFFtOTRaWE1nTFNBeEtTQXFJRTFCV0Y5Q1QxaGZVMGxhUlNBcUlFTlBVMVJmVUVWU1gwSlpWRVVnS3lBdkx5QmpiM04wSUc5bUlHUmhkR0VLSUNBZ0lDOHZJRzUxYlVKdmVHVnpJQ29nTmpRZ0tpQkRUMU5VWDFCRlVsOUNXVlJGSUNzZ0x5OGdZMjl6ZENCdlppQnJaWGx6Q2lBZ0lDQXJDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZbWxuTFdKdmVDOWlhV2N0WW05NExtRnNaMjh1ZEhNNk9Ea0tJQ0FnSUM4dklHVnVaRUp2ZUZOcGVtVWdLaUJEVDFOVVgxQkZVbDlDV1ZSRk95QXZMeUJqYjNOMElHOW1JR3hoYzNRZ1ltOTRJR1JoZEdFS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2NIVnphR2x1ZENBME1EQWdMeThnTkRBd0NpQWdJQ0FxQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WW1sbkxXSnZlQzlpYVdjdFltOTRMbUZzWjI4dWRITTZPRFl0T0RrS0lDQWdJQzh2SUc1MWJVSnZlR1Z6SUNvZ1EwOVRWRjlRUlZKZlFrOVlJQ3NnTHk4Z1kyOXpkQ0J2WmlCaWIzaGxjd29nSUNBZ0x5OGdLRzUxYlVKdmVHVnpJQzBnTVNrZ0tpQk5RVmhmUWs5WVgxTkpXa1VnS2lCRFQxTlVYMUJGVWw5Q1dWUkZJQ3NnTHk4Z1kyOXpkQ0J2WmlCa1lYUmhDaUFnSUNBdkx5QnVkVzFDYjNobGN5QXFJRFkwSUNvZ1EwOVRWRjlRUlZKZlFsbFVSU0FySUM4dklHTnZjM1FnYjJZZ2EyVjVjd29nSUNBZ0x5OGdaVzVrUW05NFUybDZaU0FxSUVOUFUxUmZVRVZTWDBKWlZFVTdJQzh2SUdOdmMzUWdiMllnYkdGemRDQmliM2dnWkdGMFlRb2dJQ0FnS3dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJKcFp5MWliM2d2WW1sbkxXSnZlQzVoYkdkdkxuUnpPamt4TFRrMENpQWdJQ0F2THlCaGMzTmxjblJOWVhSamFDaHRZbkpRWVhsdFpXNTBMQ0I3Q2lBZ0lDQXZMeUFnSUhKbFkyVnBkbVZ5T2lCSGJHOWlZV3d1WTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnWVcxdmRXNTBPaUIwYjNSaGJFTnZjM1FzQ2lBZ0lDQXZMeUI5S1RzS0lDQWdJR1JwWnlBeENpQWdJQ0JuZEhodWN5QlNaV05sYVhabGNnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwySnBaeTFpYjNndlltbG5MV0p2ZUM1aGJHZHZMblJ6T2preUNpQWdJQ0F2THlCeVpXTmxhWFpsY2pvZ1IyeHZZbUZzTG1OMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01zQ2lBZ0lDQm5iRzlpWVd3Z1EzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJKcFp5MWliM2d2WW1sbkxXSnZlQzVoYkdkdkxuUnpPamt4TFRrMENpQWdJQ0F2THlCaGMzTmxjblJOWVhSamFDaHRZbkpRWVhsdFpXNTBMQ0I3Q2lBZ0lDQXZMeUFnSUhKbFkyVnBkbVZ5T2lCSGJHOWlZV3d1WTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnWVcxdmRXNTBPaUIwYjNSaGJFTnZjM1FzQ2lBZ0lDQXZMeUI5S1RzS0lDQWdJRDA5Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdkMGVHNXpJRUZ0YjNWdWRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQTlQUW9nSUNBZ0ppWUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWlhV2N0WW05NEwySnBaeTFpYjNndVlXeG5ieTUwY3pvMk1pMDJOd29nSUNBZ0x5OGdjM1JoY25SVmNHeHZZV1FvQ2lBZ0lDQXZMeUFnSUdSaGRHRkpaR1Z1ZEdsbWFXVnlPaUJ6ZEhKcGJtY3NDaUFnSUNBdkx5QWdJRzUxYlVKdmVHVnpPaUIxYVc1ME5qUXNDaUFnSUNBdkx5QWdJR1Z1WkVKdmVGTnBlbVU2SUhWcGJuUTJOQ3dLSUNBZ0lDOHZJQ0FnYldKeVVHRjViV1Z1ZERvZ1ozUjRiaTVRWVhsdFpXNTBWSGh1TEFvZ0lDQWdMeThnS1RvZ2RtOXBaQ0I3Q2lBZ0lDQnlaWFIxY200Z0x5OGdiMjRnWlhKeWIzSTZJR0Z6YzJWeWRDQjBZWEpuWlhRZ2FYTWdiV0YwWTJnZ1ptOXlJR052Ym1ScGRHbHZibk1LQ2dvdkx5QmpiMjUwY21GamRITXZZbWxuTFdKdmVDOWlhV2N0WW05NExtRnNaMjh1ZEhNNk9rSnBaMEp2ZUM1MWNHeHZZV1JiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMWNHeHZZV1E2Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkpwWnkxaWIzZ3ZZbWxuTFdKdmVDNWhiR2R2TG5Sek9qRXdOaTB4TVRFS0lDQWdJQzh2SUhWd2JHOWhaQ2dLSUNBZ0lDOHZJQ0FnWkdGMFlVbGtaVzUwYVdacFpYSTZJSE4wY21sdVp5d0tJQ0FnSUM4dklDQWdZbTk0U1c1a1pYZzZJSFZwYm5RMk5Dd0tJQ0FnSUM4dklDQWdiMlptYzJWME9pQjFhVzUwTmpRc0NpQWdJQ0F2THlBZ0lHUmhkR0U2SUdKNWRHVnpMQW9nSUNBZ0x5OGdLVG9nZG05cFpDQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWW5SdmFRb2dJQ0FnWkhWd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHSjBiMmtLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURRS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlltbG5MV0p2ZUM5aWFXY3RZbTk0TG1Gc1oyOHVkSE02TVRFeUNpQWdJQ0F2THlCamIyNXpkQ0J0WlhSaFpHRjBZU0E5SUdOc2IyNWxLSFJvYVhNdWJXVjBZV1JoZEdFb1FubDBaWE1vWkdGMFlVbGtaVzUwYVdacFpYSXBLUzUyWVd4MVpTazdDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR052ZG1WeUlETUtJQ0FnSUdGemMyVnlkQ0F2THlCQ2IzZ2diWFZ6ZENCb1lYWmxJSFpoYkhWbENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlltbG5MV0p2ZUM5aWFXY3RZbTk0TG1Gc1oyOHVkSE02TVRFekNpQWdJQ0F2THlCaGMzTmxjblFvYldWMFlXUmhkR0V1YzNSaGRIVnpJRDA5UFNCSlRsOVFVazlIVWtWVFV5azdDaUFnSUNCa2RYQUtJQ0FnSUdWNGRISmhZM1FnTVRZZ01Rb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VEQXdDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZbWxuTFdKdmVDOWlhV2N0WW05NExtRnNaMjh1ZEhNNk1URTBDaUFnSUNBdkx5QmhjM05sY25Rb2JXVjBZV1JoZEdFdWMzUmhjblFnUEQwZ1ltOTRTVzVrWlhnZ0ppWWdZbTk0U1c1a1pYZ2dQRDBnYldWMFlXUmhkR0V1Wlc1a0tUc0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnUGowS0lDQWdJR0o2SUhWd2JHOWhaRjlpYjI5c1gyWmhiSE5sUURRS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQmthV2NnTkFvZ0lDQWdQajBLSUNBZ0lHSjZJSFZ3Ykc5aFpGOWliMjlzWDJaaGJITmxRRFFLSUNBZ0lHbHVkR05mTUNBdkx5QXhDZ3AxY0d4dllXUmZZbTl2YkY5dFpYSm5aVUExT2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJKcFp5MWliM2d2WW1sbkxXSnZlQzVoYkdkdkxuUnpPakV4TkFvZ0lDQWdMeThnWVhOelpYSjBLRzFsZEdGa1lYUmhMbk4wWVhKMElEdzlJR0p2ZUVsdVpHVjRJQ1ltSUdKdmVFbHVaR1Y0SUR3OUlHMWxkR0ZrWVhSaExtVnVaQ2s3Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5aWFXY3RZbTk0TDJKcFp5MWliM2d1WVd4bmJ5NTBjem94TVRZS0lDQWdJQzh2SUdsbUlDaHZabVp6WlhRZ1BUMDlJREFwSUhzS0lDQWdJR1JwWnlBeUNpQWdJQ0JpYm5vZ2RYQnNiMkZrWDJGbWRHVnlYMmxtWDJWc2MyVkFNVEFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlpYVdjdFltOTRMMkpwWnkxaWIzZ3VZV3huYnk1MGN6b3hNVGNLSUNBZ0lDOHZJSFJvYVhNdVpHRjBZVUp2ZUdWektHSnZlRWx1WkdWNEtTNWpjbVZoZEdVb2V3b2dJQ0FnWkdsbklETUtJQ0FnSUdSMWNBb2dJQ0FnYVhSdllnb2dJQ0FnWW5WeWVTQTJDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZbWxuTFdKdmVDOWlhV2N0WW05NExtRnNaMjh1ZEhNNk1URTRDaUFnSUNBdkx5QnphWHBsT2lCaWIzaEpibVJsZUNBOVBUMGdiV1YwWVdSaGRHRXVaVzVrSUQ4Z2JXVjBZV1JoZEdFdVpXNWtVMmw2WlNBNklFMUJXRjlDVDFoZlUwbGFSU3dLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lEMDlDaUFnSUNCaWVpQjFjR3h2WVdSZmRHVnlibUZ5ZVY5bVlXeHpaVUE0Q2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhwYm5RZ01UY2dMeThnTVRjS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENncDFjR3h2WVdSZmRHVnlibUZ5ZVY5dFpYSm5aVUE1T2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJKcFp5MWliM2d2WW1sbkxXSnZlQzVoYkdkdkxuUnpPakV4TnkweE1Ua0tJQ0FnSUM4dklIUm9hWE11WkdGMFlVSnZlR1Z6S0dKdmVFbHVaR1Y0S1M1amNtVmhkR1VvZXdvZ0lDQWdMeThnSUNCemFYcGxPaUJpYjNoSmJtUmxlQ0E5UFQwZ2JXVjBZV1JoZEdFdVpXNWtJRDhnYldWMFlXUmhkR0V1Wlc1a1UybDZaU0E2SUUxQldGOUNUMWhmVTBsYVJTd0tJQ0FnSUM4dklIMHBPd29nSUNBZ1pHbG5JRFVLSUNBZ0lITjNZWEFLSUNBZ0lHSnZlRjlqY21WaGRHVUtJQ0FnSUhCdmNBb0tkWEJzYjJGa1gyRm1kR1Z5WDJsbVgyVnNjMlZBTVRBNkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlltbG5MV0p2ZUM5aWFXY3RZbTk0TG1Gc1oyOHVkSE02TVRJeUNpQWdJQ0F2THlCMGFHbHpMbVJoZEdGQ2IzaGxjeWhpYjNoSmJtUmxlQ2t1Y21Wd2JHRmpaU2h2Wm1aelpYUXNJR1JoZEdFcE93b2dJQ0FnWkdsbklETUtJQ0FnSUdsMGIySUtJQ0FnSUdScFp5QXpDaUFnSUNCa2FXY2dNd29nSUNBZ1ltOTRYM0psY0d4aFkyVUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWlhV2N0WW05NEwySnBaeTFpYjNndVlXeG5ieTUwY3pveE1EWXRNVEV4Q2lBZ0lDQXZMeUIxY0d4dllXUW9DaUFnSUNBdkx5QWdJR1JoZEdGSlpHVnVkR2xtYVdWeU9pQnpkSEpwYm1jc0NpQWdJQ0F2THlBZ0lHSnZlRWx1WkdWNE9pQjFhVzUwTmpRc0NpQWdJQ0F2THlBZ0lHOW1abk5sZERvZ2RXbHVkRFkwTEFvZ0lDQWdMeThnSUNCa1lYUmhPaUJpZVhSbGN5d0tJQ0FnSUM4dklDazZJSFp2YVdRZ2V3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tkWEJzYjJGa1gzUmxjbTVoY25sZlptRnNjMlZBT0RvS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5aWFXY3RZbTk0TDJKcFp5MWliM2d1WVd4bmJ5NTBjem94TVRnS0lDQWdJQzh2SUhOcGVtVTZJR0p2ZUVsdVpHVjRJRDA5UFNCdFpYUmhaR0YwWVM1bGJtUWdQeUJ0WlhSaFpHRjBZUzVsYm1SVGFYcGxJRG9nVFVGWVgwSlBXRjlUU1ZwRkxBb2dJQ0FnY0hWemFHbHVkQ0F6TWpjMk9DQXZMeUF6TWpjMk9Bb2dJQ0FnWWlCMWNHeHZZV1JmZEdWeWJtRnllVjl0WlhKblpVQTVDZ3AxY0d4dllXUmZZbTl2YkY5bVlXeHpaVUEwT2dvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHSWdkWEJzYjJGa1gySnZiMnhmYldWeVoyVkFOUW9LQ2k4dklHTnZiblJ5WVdOMGN5OWlhV2N0WW05NEwySnBaeTFpYjNndVlXeG5ieTUwY3pvNlFtbG5RbTk0TG5ObGRGTjBZWFIxYzF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuTmxkRk4wWVhSMWN6b0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWlhV2N0WW05NEwySnBaeTFpYjNndVlXeG5ieTUwY3pveE16SUtJQ0FnSUM4dklITmxkRk4wWVhSMWN5aGtZWFJoU1dSbGJuUnBabWxsY2pvZ2MzUnlhVzVuTENCemRHRjBkWE02SUZWcGJuUThPRDRwT2lCMmIybGtJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCa2RYQUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WW1sbkxXSnZlQzlpYVdjdFltOTRMbUZzWjI4dWRITTZNVE0wQ2lBZ0lDQXZMeUJqYjI1emRDQmpkWEp5Wlc1MFUzUmhkSFZ6SUQwZ2RHaHBjeTV0WlhSaFpHRjBZU2hrWVhSaFNXUmxiblJwWm1sbGNrSjVkR1Z6S1M1MllXeDFaUzV6ZEdGMGRYTTdDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmhjM05sY25RZ0x5OGdRbTk0SUcxMWMzUWdhR0YyWlNCMllXeDFaUW9nSUNBZ1pYaDBjbUZqZENBeE5pQXhDaUFnSUNCemQyRndDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZbWxuTFdKdmVDOWlhV2N0WW05NExtRnNaMjh1ZEhNNk1UTTJDaUFnSUNBdkx5QmhjM05sY25Rb2MzUmhkSFZ6SUQwOVBTQlNSVUZFV1NCOGZDQnpkR0YwZFhNZ1BUMDlJRWxOVFZWVVFVSk1SU0I4ZkNCemRHRjBkWE1nUFQwOUlFbE9YMUJTVDBkU1JWTlRLVHNLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF4Q2lBZ0lDQTlQUW9nSUNBZ1ltNTZJSE5sZEZOMFlYUjFjMTlpYjI5c1gzUnlkV1ZBTkFvZ0lDQWdaR2xuSURFS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhnd01nb2dJQ0FnUFQwS0lDQWdJR0p1ZWlCelpYUlRkR0YwZFhOZlltOXZiRjkwY25WbFFEUUtJQ0FnSUdScFp5QXhDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNREFLSUNBZ0lEMDlDaUFnSUNCaWVpQnpaWFJUZEdGMGRYTmZZbTl2YkY5bVlXeHpaVUExQ2dwelpYUlRkR0YwZFhOZlltOXZiRjkwY25WbFFEUTZDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb0tjMlYwVTNSaGRIVnpYMkp2YjJ4ZmJXVnlaMlZBTmpvS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5aWFXY3RZbTk0TDJKcFp5MWliM2d1WVd4bmJ5NTBjem94TXpZS0lDQWdJQzh2SUdGemMyVnlkQ2h6ZEdGMGRYTWdQVDA5SUZKRlFVUlpJSHg4SUhOMFlYUjFjeUE5UFQwZ1NVMU5WVlJCUWt4RklIeDhJSE4wWVhSMWN5QTlQVDBnU1U1ZlVGSlBSMUpGVTFNcE93b2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZbWxuTFdKdmVDOWlhV2N0WW05NExtRnNaMjh1ZEhNNk1UTTNDaUFnSUNBdkx5QmhjM05sY25Rb1kzVnljbVZ1ZEZOMFlYUjFjeUFoUFQwZ1NVMU5WVlJCUWt4RktUc0tJQ0FnSUdSMWNBb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VEQXlDaUFnSUNBaFBRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZbWxuTFdKdmVDOWlhV2N0WW05NExtRnNaMjh1ZEhNNk1UTTVDaUFnSUNBdkx5QjBhR2x6TG0xbGRHRmtZWFJoS0dSaGRHRkpaR1Z1ZEdsbWFXVnlRbmwwWlhNcExuWmhiSFZsTG5OMFlYUjFjeUE5SUhOMFlYUjFjenNLSUNBZ0lHUnBaeUF5Q2lBZ0lDQndkWE5vYVc1MElERTJJQzh2SURFMkNpQWdJQ0JrYVdjZ013b2dJQ0FnWW05NFgzSmxjR3hoWTJVS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5aWFXY3RZbTk0TDJKcFp5MWliM2d1WVd4bmJ5NTBjem94TXpJS0lDQWdJQzh2SUhObGRGTjBZWFIxY3loa1lYUmhTV1JsYm5ScFptbGxjam9nYzNSeWFXNW5MQ0J6ZEdGMGRYTTZJRlZwYm5ROE9ENHBPaUIyYjJsa0lIc0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbk5sZEZOMFlYUjFjMTlpYjI5c1gyWmhiSE5sUURVNkNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZaUJ6WlhSVGRHRjBkWE5mWW05dmJGOXRaWEpuWlVBMkNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQURBUUFJSmdNTVkzVnljbVZ1ZEVsdVpHVjRBUUFCQWpFWVFBQURLQ05uTVJrVVJERVlRUUFkZ2dNRW9GdFdhUVFiZmZvMUJMODRWdmcyR2dDT0F3QVJBSDhBN0FDQUJMaEVlelkyR2dDT0FRQUJBQ0pETmhvQlZ3SUFOaG9DRnpZYUF4Y3hGaUlKU1RnUUloSkVJeWhsUkVsTEJBZ2lDVXdXU3dFV1VDbFFTd01XVUVzRnZVVUJGRVJQQlV5L0lnZ29UR2RMQW9IRUV3dExBeUlKZ1lDQW9BWUxDRThEZ1lESUFRc0lUd0tCa0FNTENFc0JPQWN5Q2hKUEFqZ0lUd0lTRUVNak5ob0JWd0lBTmhvQ0YwbFBBallhQXhkT0FqWWFCRmNDQUU0Q3ZreEpUZ0pPQTBSSlZ4QUJLUkpFSTFzUFFRQTRTU1JiU3dRUFFRQXZJa1JMQWtBQUYwc0RTUlpGQmtzQkpGc1NRUUFUU1lFUlcwc0ZUTGxJU3dNV1N3TkxBN3NpUTRHQWdBSkMvK29qUXYvT05ob0JWd0lBU1RZYUFrbFBBcjVFVnhBQlRJQUJBUkpBQUE1TEFTb1NRQUFIU3dFcEVrRUFEeUpFU1NvVFJFc0NnUkJMQTdzaVF5TkMvKzQ9IiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6MCwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
