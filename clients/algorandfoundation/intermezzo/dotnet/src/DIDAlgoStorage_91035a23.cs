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

namespace Arc56.Generated.algorandfoundation.intermezzo.DIDAlgoStorage_91035a23
{


    public class DIDAlgoStorageProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public DIDAlgoStorageProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
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

                public ulong LastDeleted { get; set; }

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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStatus = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte");
                    vStatus.From(Status);
                    ret.AddRange(vStatus.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEndSize = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vEndSize.From(EndSize);
                    ret.AddRange(vEndSize.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLastDeleted = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vLastDeleted.From(LastDeleted);
                    ret.AddRange(vLastDeleted.Encode());
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStatus = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte");
                    count = vStatus.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueStatus = vStatus.ToValue();
                    if (valueStatus is byte vStatusValue) { ret.Status = vStatusValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEndSize = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vEndSize.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueEndSize = vEndSize.ToValue();
                    if (valueEndSize is ulong vEndSizeValue) { ret.EndSize = vEndSizeValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLastDeleted = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vLastDeleted.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueLastDeleted = vLastDeleted.ToValue();
                    if (valueLastDeleted is ulong vLastDeletedValue) { ret.LastDeleted = vLastDeletedValue; }
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
        ///Allocate boxes to begin data upload process
        ///</summary>
        /// <param name="pubKey">The pubkey of the DID </param>
        /// <param name="numBoxes">The number of boxes that the data will take up </param>
        /// <param name="endBoxSize">The size of the last box </param>
        /// <param name="mbrPayment">Payment from the uploader to cover the box MBR </param>
        public async Task StartUpload(PaymentTransaction mbrPayment, Algorand.Address pubKey, ulong numBoxes, ulong endBoxSize, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrPayment });
            byte[] abiHandle = { 86, 92, 103, 93 };
            var pubKeyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); pubKeyAbi.From(pubKey);
            var numBoxesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); numBoxesAbi.From(numBoxes);
            var endBoxSizeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); endBoxSizeAbi.From(endBoxSize);

            var result = await base.CallApp(new List<object> { abiHandle, pubKeyAbi, numBoxesAbi, endBoxSizeAbi, mbrPayment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> StartUpload_Transactions(PaymentTransaction mbrPayment, Algorand.Address pubKey, ulong numBoxes, ulong endBoxSize, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrPayment });
            byte[] abiHandle = { 86, 92, 103, 93 };
            var pubKeyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); pubKeyAbi.From(pubKey);
            var numBoxesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); numBoxesAbi.From(numBoxes);
            var endBoxSizeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); endBoxSizeAbi.From(endBoxSize);

            return await base.MakeTransactionList(new List<object> { abiHandle, pubKeyAbi, numBoxesAbi, endBoxSizeAbi, mbrPayment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///Upload data to a specific offset in a box
        ///</summary>
        /// <param name="pubKey">The pubkey of the DID </param>
        /// <param name="boxIndex">The index of the box to upload the given chunk of data to </param>
        /// <param name="offset">The offset within the box to start writing the data </param>
        /// <param name="data">The data to write </param>
        public async Task Upload(Algorand.Address pubKey, ulong boxIndex, ulong offset, byte[] data, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 77, 177, 196, 24 };
            var pubKeyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); pubKeyAbi.From(pubKey);
            var boxIndexAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); boxIndexAbi.From(boxIndex);
            var offsetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); offsetAbi.From(offset);
            var dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dataAbi.From(data);

            var result = await base.CallApp(new List<object> { abiHandle, pubKeyAbi, boxIndexAbi, offsetAbi, dataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Upload_Transactions(Algorand.Address pubKey, ulong boxIndex, ulong offset, byte[] data, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 77, 177, 196, 24 };
            var pubKeyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); pubKeyAbi.From(pubKey);
            var boxIndexAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); boxIndexAbi.From(boxIndex);
            var offsetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); offsetAbi.From(offset);
            var dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dataAbi.From(data);

            return await base.MakeTransactionList(new List<object> { abiHandle, pubKeyAbi, boxIndexAbi, offsetAbi, dataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///Mark uploading as false
        ///</summary>
        /// <param name="pubKey">The address of the DID </param>
        public async Task FinishUpload(Algorand.Address pubKey, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 14, 120, 114, 87 };
            var pubKeyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); pubKeyAbi.From(pubKey);

            var result = await base.CallApp(new List<object> { abiHandle, pubKeyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> FinishUpload_Transactions(Algorand.Address pubKey, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 14, 120, 114, 87 };
            var pubKeyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); pubKeyAbi.From(pubKey);

            return await base.MakeTransactionList(new List<object> { abiHandle, pubKeyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Starts the deletion process for the data associated with a DID
        ///</summary>
        /// <param name="pubKey">The address of the DID </param>
        public async Task StartDelete(Algorand.Address pubKey, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 189, 44, 132, 226 };
            var pubKeyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); pubKeyAbi.From(pubKey);

            var result = await base.CallApp(new List<object> { abiHandle, pubKeyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> StartDelete_Transactions(Algorand.Address pubKey, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 189, 44, 132, 226 };
            var pubKeyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); pubKeyAbi.From(pubKey);

            return await base.MakeTransactionList(new List<object> { abiHandle, pubKeyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Deletes a box of data
        ///</summary>
        /// <param name="pubKey">The address of the DID </param>
        /// <param name="boxIndex">The index of the box to delete </param>
        public async Task DeleteData(Algorand.Address pubKey, ulong boxIndex, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 104, 145, 186, 144 };
            var pubKeyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); pubKeyAbi.From(pubKey);
            var boxIndexAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); boxIndexAbi.From(boxIndex);

            var result = await base.CallApp(new List<object> { abiHandle, pubKeyAbi, boxIndexAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DeleteData_Transactions(Algorand.Address pubKey, ulong boxIndex, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 104, 145, 186, 144 };
            var pubKeyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); pubKeyAbi.From(pubKey);
            var boxIndexAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); boxIndexAbi.From(boxIndex);

            return await base.MakeTransactionList(new List<object> { abiHandle, pubKeyAbi, boxIndexAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Allow the contract to be updated by the creator
        ///</summary>
        public async Task UpdateApplication(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 70, 247, 101, 51 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateApplication_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 70, 247, 101, 51 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Dummy function to add extra box references for deleteData.
        ///Boxes are 32k, but a single app call can only inlcude enough references to read/write 8k
        ///at a time. Thus when a box is deleted, we need to add additional dummy calls with box
        ///references to increase the total read/write budget to 32k.
        ///</summary>
        public async Task Dummy(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 163, 12, 231, 255 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Dummy_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 163, 12, 231, 255 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRElEQWxnb1N0b3JhZ2UiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiTWV0YWRhdGEiOlt7Im5hbWUiOiJzdGFydCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJlbmQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoic3RhdHVzIiwidHlwZSI6ImJ5dGUifSx7Im5hbWUiOiJlbmRTaXplIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6Imxhc3REZWxldGVkIiwidHlwZSI6InVpbnQ2NCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJzdGFydFVwbG9hZCIsImRlc2MiOiJcbkFsbG9jYXRlIGJveGVzIHRvIGJlZ2luIGRhdGEgdXBsb2FkIHByb2Nlc3MiLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InB1YktleSIsImRlc2MiOiJUaGUgcHVia2V5IG9mIHRoZSBESUQiLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im51bUJveGVzIiwiZGVzYyI6IlRoZSBudW1iZXIgb2YgYm94ZXMgdGhhdCB0aGUgZGF0YSB3aWxsIHRha2UgdXAiLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImVuZEJveFNpemUiLCJkZXNjIjoiVGhlIHNpemUgb2YgdGhlIGxhc3QgYm94IiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtYnJQYXltZW50IiwiZGVzYyI6IlBheW1lbnQgZnJvbSB0aGUgdXBsb2FkZXIgdG8gY292ZXIgdGhlIGJveCBNQlIiLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidXBsb2FkIiwiZGVzYyI6IlxuVXBsb2FkIGRhdGEgdG8gYSBzcGVjaWZpYyBvZmZzZXQgaW4gYSBib3giLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InB1YktleSIsImRlc2MiOiJUaGUgcHVia2V5IG9mIHRoZSBESUQiLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJveEluZGV4IiwiZGVzYyI6IlRoZSBpbmRleCBvZiB0aGUgYm94IHRvIHVwbG9hZCB0aGUgZ2l2ZW4gY2h1bmsgb2YgZGF0YSB0byIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoib2Zmc2V0IiwiZGVzYyI6IlRoZSBvZmZzZXQgd2l0aGluIHRoZSBib3ggdG8gc3RhcnQgd3JpdGluZyB0aGUgZGF0YSIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGF0YSIsImRlc2MiOiJUaGUgZGF0YSB0byB3cml0ZSIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJmaW5pc2hVcGxvYWQiLCJkZXNjIjoiXG5NYXJrIHVwbG9hZGluZyBhcyBmYWxzZSIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicHViS2V5IiwiZGVzYyI6IlRoZSBhZGRyZXNzIG9mIHRoZSBESUQiLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic3RhcnREZWxldGUiLCJkZXNjIjoiU3RhcnRzIHRoZSBkZWxldGlvbiBwcm9jZXNzIGZvciB0aGUgZGF0YSBhc3NvY2lhdGVkIHdpdGggYSBESUQiLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InB1YktleSIsImRlc2MiOiJUaGUgYWRkcmVzcyBvZiB0aGUgRElEIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImRlbGV0ZURhdGEiLCJkZXNjIjoiRGVsZXRlcyBhIGJveCBvZiBkYXRhIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwdWJLZXkiLCJkZXNjIjoiVGhlIGFkZHJlc3Mgb2YgdGhlIERJRCIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYm94SW5kZXgiLCJkZXNjIjoiVGhlIGluZGV4IG9mIHRoZSBib3ggdG8gZGVsZXRlIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InVwZGF0ZUFwcGxpY2F0aW9uIiwiZGVzYyI6IkFsbG93IHRoZSBjb250cmFjdCB0byBiZSB1cGRhdGVkIGJ5IHRoZSBjcmVhdG9yIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiVXBkYXRlQXBwbGljYXRpb24iXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJkdW1teSIsImRlc2MiOiJEdW1teSBmdW5jdGlvbiB0byBhZGQgZXh0cmEgYm94IHJlZmVyZW5jZXMgZm9yIGRlbGV0ZURhdGEuXG5Cb3hlcyBhcmUgMzJrLCBidXQgYSBzaW5nbGUgYXBwIGNhbGwgY2FuIG9ubHkgaW5sY3VkZSBlbm91Z2ggcmVmZXJlbmNlcyB0byByZWFkL3dyaXRlIDhrXG5hdCBhIHRpbWUuIFRodXMgd2hlbiBhIGJveCBpcyBkZWxldGVkLCB3ZSBuZWVkIHRvIGFkZCBhZGRpdGlvbmFsIGR1bW15IGNhbGxzIHdpdGggYm94XG5yZWZlcmVuY2VzIHRvIGluY3JlYXNlIHRoZSB0b3RhbCByZWFkL3dyaXRlIGJ1ZGdldCB0byAzMmsuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjoxLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMzIzLDQzOSw0OTVdLCJlcnJvck1lc3NhZ2UiOiJCb3ggbXVzdCBoYXZlIHZhbHVlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTddLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gbXVzdCBiZSBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTMyXSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgTm9PcCAmJiBjYW4gb25seSBjYWxsIHdoZW4gY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjFdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gbXVzdCBiZSBVcGRhdGVBcHBsaWNhdGlvbiAmJiBjYW4gb25seSBjYWxsIHdoZW4gbm90IGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTUzLDU4MF0sImVycm9yTWVzc2FnZSI6ImFjY291bnQgZnVuZGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTc3LDMxMiw0MTEsNDM0LDQ4NCw1NDcsNTc3LDYyMF0sImVycm9yTWVzc2FnZSI6ImFwcGxpY2F0aW9uIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE4M10sImVycm9yTWVzc2FnZSI6ImNoZWNrIEdsb2JhbFN0YXRlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI5Ml0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMwMF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNDIsMjYzLDQwNCw0MjcsNDYyXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1MCwxNTksMjcxLDI4Myw0NzNdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNzBdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIHBheSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTVNBd0lEZ2dNeklLSUNBZ0lHSjVkR1ZqWW14dlkyc2dJbU4xY25KbGJuUkpibVJsZUNJZ01IZ3dNQ0F3ZURBeElEQjRNRElLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpYm5vZ2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFESUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWthV1F0WVd4bmJ5MXpkRzl5WVdkbExtRnNaMjh1ZEhNNk5ERUtJQ0FnSUM4dklHTjFjbkpsYm5SSmJtUmxlQ0E5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b2V5QnBibWwwYVdGc1ZtRnNkV1U2SUZWcGJuUTJOQ2d3S1NCOUtUc0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltTjFjbkpsYm5SSmJtUmxlQ0lLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9LYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURJNkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlpHbGtMV0ZzWjI4dGMzUnZjbUZuWlM1aGJHZHZMblJ6T2pNNENpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdSRWxFUVd4bmIxTjBiM0poWjJVZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc0Z1RuVnRRWEJ3UVhKbmN3b2dJQ0FnWW5vZ2JXRnBibDlmWDJGc1oyOTBjMTlmTG1SbFptRjFiSFJEY21WaGRHVkFNVGNLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRFEyWmpjMk5UTXpJQzh2SUcxbGRHaHZaQ0FpZFhCa1lYUmxRWEJ3YkdsallYUnBiMjRvS1hadmFXUWlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0J0WVdsdVgzVndaR0YwWlVGd2NHeHBZMkYwYVc5dVgzSnZkWFJsUURVS0NtMWhhVzVmYzNkcGRHTm9YMk5oYzJWZmJtVjRkRUEyT2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJScFpDMWhiR2R2TFhOMGIzSmhaMlV1WVd4bmJ5NTBjem96T0FvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFUkpSRUZzWjI5VGRHOXlZV2RsSUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCdGRYTjBJR0psSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhnMU5qVmpOamMxWkNBd2VEUmtZakZqTkRFNElEQjRNR1UzT0RjeU5UY2dNSGhpWkRKak9EUmxNaUF3ZURZNE9URmlZVGt3SURCNFlUTXdZMlUzWm1ZZ0x5OGdiV1YwYUc5a0lDSnpkR0Z5ZEZWd2JHOWhaQ2hoWkdSeVpYTnpMSFZwYm5RMk5DeDFhVzUwTmpRc2NHRjVLWFp2YVdRaUxDQnRaWFJvYjJRZ0luVndiRzloWkNoaFpHUnlaWE56TEhWcGJuUTJOQ3gxYVc1ME5qUXNZbmwwWlZ0ZEtYWnZhV1FpTENCdFpYUm9iMlFnSW1acGJtbHphRlZ3Ykc5aFpDaGhaR1J5WlhOektYWnZhV1FpTENCdFpYUm9iMlFnSW5OMFlYSjBSR1ZzWlhSbEtHRmtaSEpsYzNNcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWkdWc1pYUmxSR0YwWVNoaFpHUnlaWE56TEhWcGJuUTJOQ2wyYjJsa0lpd2diV1YwYUc5a0lDSmtkVzF0ZVNncGRtOXBaQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUhOMFlYSjBWWEJzYjJGa0lIVndiRzloWkNCbWFXNXBjMmhWY0d4dllXUWdjM1JoY25SRVpXeGxkR1VnWkdWc1pYUmxSR0YwWVNCdFlXbHVYMlIxYlcxNVgzSnZkWFJsUURFekNpQWdJQ0JsY25JS0NtMWhhVzVmWkhWdGJYbGZjbTkxZEdWQU1UTTZDaUFnSUNBdkx5QmpiMjUwY21GamRITXZaR2xrTFdGc1oyOHRjM1J2Y21GblpTNWhiR2R2TG5Sek9qRTROUW9nSUNBZ0x5OGdaSFZ0Ylhrb0tUb2dkbTlwWkNCN2ZRb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5MWNHUmhkR1ZCY0hCc2FXTmhkR2x2Ymw5eWIzVjBaVUExT2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJScFpDMWhiR2R2TFhOMGIzSmhaMlV1WVd4bmJ5NTBjem94TnpVS0lDQWdJQzh2SUhWd1pHRjBaVUZ3Y0d4cFkyRjBhVzl1S0NrNklIWnZhV1FnZXdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnY0hWemFHbHVkQ0EwSUM4dklGVndaR0YwWlVGd2NHeHBZMkYwYVc5dUNpQWdJQ0E5UFFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUNZbUNpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHMTFjM1FnWW1VZ1ZYQmtZWFJsUVhCd2JHbGpZWFJwYjI0Z0ppWWdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdZaUIxY0dSaGRHVkJjSEJzYVdOaGRHbHZiZ29LYldGcGJsOWZYMkZzWjI5MGMxOWZMbVJsWm1GMWJIUkRjbVZoZEdWQU1UYzZDaUFnSUNBdkx5QmpiMjUwY21GamRITXZaR2xrTFdGc1oyOHRjM1J2Y21GblpTNWhiR2R2TG5Sek9qTTRDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nUkVsRVFXeG5iMU4wYjNKaFoyVWdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdJUW9nSUNBZ0ppWUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdiWFZ6ZENCaVpTQk9iMDl3SUNZbUlHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQmpjbVZoZEdsdVp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUdOdmJuUnlZV04wY3k5a2FXUXRZV3huYnkxemRHOXlZV2RsTG1Gc1oyOHVkSE02T2tSSlJFRnNaMjlUZEc5eVlXZGxMbk4wWVhKMFZYQnNiMkZrVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2MzUmhjblJWY0d4dllXUTZDaUFnSUNBdkx5QmpiMjUwY21GamRITXZaR2xrTFdGc1oyOHRjM1J2Y21GblpTNWhiR2R2TG5Sek9qVXlMVFUzQ2lBZ0lDQXZMeUJ6ZEdGeWRGVndiRzloWkNnS0lDQWdJQzh2SUNBZ2NIVmlTMlY1T2lCQlpHUnlaWE56TEFvZ0lDQWdMeThnSUNCdWRXMUNiM2hsY3pvZ2RXbHVkRFkwTEFvZ0lDQWdMeThnSUNCbGJtUkNiM2hUYVhwbE9pQjFhVzUwTmpRc0NpQWdJQ0F2THlBZ0lHMWljbEJoZVcxbGJuUTZJR2QwZUc0dVVHRjViV1Z1ZEZSNGJpd0tJQ0FnSUM4dklDazZJSFp2YVdRZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDMEtJQ0FnSUdSMWNBb2dJQ0FnWjNSNGJuTWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlCd1lYa0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnZEhKaGJuTmhZM1JwYjI0Z2RIbHdaU0JwY3lCd1lYa0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWthV1F0WVd4bmJ5MXpkRzl5WVdkbExtRnNaMjh1ZEhNNk5UZ0tJQ0FnSUM4dklHRnpjMlZ5ZENoVWVHNHVjMlZ1WkdWeUlEMDlQU0JVZUc0dVlYQndiR2xqWVhScGIyNUpaQzVqY21WaGRHOXlLVHNLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjSEJmY0dGeVlXMXpYMmRsZENCQmNIQkRjbVZoZEc5eUNpQWdJQ0JoYzNObGNuUWdMeThnWVhCd2JHbGpZWFJwYjI0Z1pYaHBjM1J6Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12Wkdsa0xXRnNaMjh0YzNSdmNtRm5aUzVoYkdkdkxuUnpPall3Q2lBZ0lDQXZMeUJqYjI1emRDQnpkR0Z5ZEVKdmVEb2dkV2x1ZERZMElEMGdkR2hwY3k1amRYSnlaVzUwU1c1a1pYZ3VkbUZzZFdVN0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJScFpDMWhiR2R2TFhOMGIzSmhaMlV1WVd4bmJ5NTBjem8wTVFvZ0lDQWdMeThnWTNWeWNtVnVkRWx1WkdWNElEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWg3SUdsdWFYUnBZV3hXWVd4MVpUb2dWV2x1ZERZMEtEQXBJSDBwT3dvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWTNWeWNtVnVkRWx1WkdWNElnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyUnBaQzFoYkdkdkxYTjBiM0poWjJVdVlXeG5ieTUwY3pvMk1Bb2dJQ0FnTHk4Z1kyOXVjM1FnYzNSaGNuUkNiM2c2SUhWcGJuUTJOQ0E5SUhSb2FYTXVZM1Z5Y21WdWRFbHVaR1Y0TG5aaGJIVmxPd29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkhiRzlpWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWthV1F0WVd4bmJ5MXpkRzl5WVdkbExtRnNaMjh1ZEhNNk5qTUtJQ0FnSUM4dklHTnZibk4wSUdWdVpFSnZlRG9nZFdsdWREWTBJRDBnYzNSaGNuUkNiM2dnS3lCdWRXMUNiM2hsY3lBdElFOU9SVHNLSUNBZ0lHUjFjQW9nSUNBZ1pHbG5JRFFLSUNBZ0lDc0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0F0Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12Wkdsa0xXRnNaMjh0YzNSdmNtRm5aUzVoYkdkdkxuUnpPalkxTFRZM0NpQWdJQ0F2THlCamIyNXpkQ0J0WlhSaFpHRjBZVG9nVFdWMFlXUmhkR0VnUFNCN0NpQWdJQ0F2THlBZ0lITjBZWEowT2lCemRHRnlkRUp2ZUN3Z1pXNWtPaUJsYm1SQ2IzZ3NJSE4wWVhSMWN6b2dWVkJNVDBGRVNVNUhMQ0JsYm1SVGFYcGxPaUJsYm1SQ2IzaFRhWHBsTENCc1lYTjBSR1ZzWlhSbFpEb2dNQ3dLSUNBZ0lDOHZJSDA3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmthV2NnTVFvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlpHbGtMV0ZzWjI4dGMzUnZjbUZuWlM1aGJHZHZMblJ6T2pZMkNpQWdJQ0F2THlCemRHRnlkRG9nYzNSaGNuUkNiM2dzSUdWdVpEb2daVzVrUW05NExDQnpkR0YwZFhNNklGVlFURTlCUkVsT1J5d2daVzVrVTJsNlpUb2daVzVrUW05NFUybDZaU3dnYkdGemRFUmxiR1YwWldRNklEQXNDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNREFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlrYVdRdFlXeG5ieTF6ZEc5eVlXZGxMbUZzWjI4dWRITTZOalV0TmpjS0lDQWdJQzh2SUdOdmJuTjBJRzFsZEdGa1lYUmhPaUJOWlhSaFpHRjBZU0E5SUhzS0lDQWdJQzh2SUNBZ2MzUmhjblE2SUhOMFlYSjBRbTk0TENCbGJtUTZJR1Z1WkVKdmVDd2djM1JoZEhWek9pQlZVRXhQUVVSSlRrY3NJR1Z1WkZOcGVtVTZJR1Z1WkVKdmVGTnBlbVVzSUd4aGMzUkVaV3hsZEdWa09pQXdMQW9nSUNBZ0x5OGdmVHNLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURNS0lDQWdJR2wwYjJJS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyUnBaQzFoYkdkdkxYTjBiM0poWjJVdVlXeG5ieTUwY3pvMk5nb2dJQ0FnTHk4Z2MzUmhjblE2SUhOMFlYSjBRbTk0TENCbGJtUTZJR1Z1WkVKdmVDd2djM1JoZEhWek9pQlZVRXhQUVVSSlRrY3NJR1Z1WkZOcGVtVTZJR1Z1WkVKdmVGTnBlbVVzSUd4aGMzUkVaV3hsZEdWa09pQXdMQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWthV1F0WVd4bmJ5MXpkRzl5WVdkbExtRnNaMjh1ZEhNNk5qVXROamNLSUNBZ0lDOHZJR052Ym5OMElHMWxkR0ZrWVhSaE9pQk5aWFJoWkdGMFlTQTlJSHNLSUNBZ0lDOHZJQ0FnYzNSaGNuUTZJSE4wWVhKMFFtOTRMQ0JsYm1RNklHVnVaRUp2ZUN3Z2MzUmhkSFZ6T2lCVlVFeFBRVVJKVGtjc0lHVnVaRk5wZW1VNklHVnVaRUp2ZUZOcGVtVXNJR3hoYzNSRVpXeGxkR1ZrT2lBd0xBb2dJQ0FnTHk4Z2ZUc0tJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMlJwWkMxaGJHZHZMWE4wYjNKaFoyVXVZV3huYnk1MGN6bzNNUW9nSUNBZ0x5OGdkR2hwY3k1dFpYUmhaR0YwWVNod2RXSkxaWGtwTG5aaGJIVmxJRDBnWTJ4dmJtVW9iV1YwWVdSaGRHRXBPd29nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZaR2xrTFdGc1oyOHRjM1J2Y21GblpTNWhiR2R2TG5Sek9qY3pDaUFnSUNBdkx5QjBhR2x6TG1OMWNuSmxiblJKYm1SbGVDNTJZV3gxWlNBOUlHVnVaRUp2ZUNBcklERTdDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJScFpDMWhiR2R2TFhOMGIzSmhaMlV1WVd4bmJ5NTBjem8wTVFvZ0lDQWdMeThnWTNWeWNtVnVkRWx1WkdWNElEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWg3SUdsdWFYUnBZV3hXWVd4MVpUb2dWV2x1ZERZMEtEQXBJSDBwT3dvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWTNWeWNtVnVkRWx1WkdWNElnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyUnBaQzFoYkdkdkxYTjBiM0poWjJVdVlXeG5ieTUwY3pvM013b2dJQ0FnTHk4Z2RHaHBjeTVqZFhKeVpXNTBTVzVrWlhndWRtRnNkV1VnUFNCbGJtUkNiM2dnS3lBeE93b2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWthV1F0WVd4bmJ5MXpkRzl5WVdkbExtRnNaMjh1ZEhNNk56VUtJQ0FnSUM4dklHTnZibk4wSUhSdmRHRnNRMjl6ZERvZ2RXbHVkRFkwSUQwZ2JuVnRRbTk0WlhNZ0tpQkRUMU5VWDFCRlVsOUNUMWdnTHk4Z1kyOXpkQ0J2WmlCa1lYUmhJR0p2ZUdWekNpQWdJQ0JrYVdjZ01nb2dJQ0FnY0hWemFHbHVkQ0F5TlRBd0lDOHZJREkxTURBS0lDQWdJQ29LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlrYVdRdFlXeG5ieTF6ZEc5eVlXZGxMbUZzWjI4dWRITTZOellLSUNBZ0lDOHZJQ3NnS0c1MWJVSnZlR1Z6SUMwZ01Ta2dLaUJOUVZoZlFrOVlYMU5KV2tVZ0tpQkRUMU5VWDFCRlVsOUNXVlJGSUM4dklHTnZjM1FnYjJZZ1pHRjBZUW9nSUNBZ1pHbG5JRE1LSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBdENpQWdJQ0J3ZFhOb2FXNTBJREV6TVRBM01qQXdJQzh2SURFek1UQTNNakF3Q2lBZ0lDQXFDaUFnSUNBdkx5QmpiMjUwY21GamRITXZaR2xrTFdGc1oyOHRjM1J2Y21GblpTNWhiR2R2TG5Sek9qYzFMVGMyQ2lBZ0lDQXZMeUJqYjI1emRDQjBiM1JoYkVOdmMzUTZJSFZwYm5RMk5DQTlJRzUxYlVKdmVHVnpJQ29nUTA5VFZGOVFSVkpmUWs5WUlDOHZJR052YzNRZ2IyWWdaR0YwWVNCaWIzaGxjd29nSUNBZ0x5OGdJQ0FySUNodWRXMUNiM2hsY3lBdElERXBJQ29nVFVGWVgwSlBXRjlUU1ZwRklDb2dRMDlUVkY5UVJWSmZRbGxVUlNBdkx5QmpiM04wSUc5bUlHUmhkR0VLSUNBZ0lDc0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWthV1F0WVd4bmJ5MXpkRzl5WVdkbExtRnNaMjh1ZEhNNk56Y0tJQ0FnSUM4dklDc2diblZ0UW05NFpYTWdLaUE0SUNvZ1EwOVRWRjlRUlZKZlFsbFVSU0F2THlCamIzTjBJRzltSUdSaGRHRWdhMlY1Y3dvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCd2RYTm9hVzUwSURNeU1EQWdMeThnTXpJd01Bb2dJQ0FnS2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJScFpDMWhiR2R2TFhOMGIzSmhaMlV1WVd4bmJ5NTBjem8zTlMwM053b2dJQ0FnTHk4Z1kyOXVjM1FnZEc5MFlXeERiM04wT2lCMWFXNTBOalFnUFNCdWRXMUNiM2hsY3lBcUlFTlBVMVJmVUVWU1gwSlBXQ0F2THlCamIzTjBJRzltSUdSaGRHRWdZbTk0WlhNS0lDQWdJQzh2SUNBZ0t5QW9iblZ0UW05NFpYTWdMU0F4S1NBcUlFMUJXRjlDVDFoZlUwbGFSU0FxSUVOUFUxUmZVRVZTWDBKWlZFVWdMeThnWTI5emRDQnZaaUJrWVhSaENpQWdJQ0F2THlBZ0lDc2diblZ0UW05NFpYTWdLaUE0SUNvZ1EwOVRWRjlRUlZKZlFsbFVSU0F2THlCamIzTjBJRzltSUdSaGRHRWdhMlY1Y3dvZ0lDQWdLd29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMlJwWkMxaGJHZHZMWE4wYjNKaFoyVXVZV3huYnk1MGN6bzNPQW9nSUNBZ0x5OGdLeUJsYm1SQ2IzaFRhWHBsSUNvZ1EwOVRWRjlRUlZKZlFsbFVSU0F2THlCamIzTjBJRzltSUd4aGMzUWdaR0YwWVNCaWIzZ0tJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjSFZ6YUdsdWRDQTBNREFnTHk4Z05EQXdDaUFnSUNBcUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlpHbGtMV0ZzWjI4dGMzUnZjbUZuWlM1aGJHZHZMblJ6T2pjMUxUYzRDaUFnSUNBdkx5QmpiMjV6ZENCMGIzUmhiRU52YzNRNklIVnBiblEyTkNBOUlHNTFiVUp2ZUdWeklDb2dRMDlUVkY5UVJWSmZRazlZSUM4dklHTnZjM1FnYjJZZ1pHRjBZU0JpYjNobGN3b2dJQ0FnTHk4Z0lDQXJJQ2h1ZFcxQ2IzaGxjeUF0SURFcElDb2dUVUZZWDBKUFdGOVRTVnBGSUNvZ1EwOVRWRjlRUlZKZlFsbFVSU0F2THlCamIzTjBJRzltSUdSaGRHRUtJQ0FnSUM4dklDQWdLeUJ1ZFcxQ2IzaGxjeUFxSURnZ0tpQkRUMU5VWDFCRlVsOUNXVlJGSUM4dklHTnZjM1FnYjJZZ1pHRjBZU0JyWlhsekNpQWdJQ0F2THlBZ0lDc2daVzVrUW05NFUybDZaU0FxSUVOUFUxUmZVRVZTWDBKWlZFVWdMeThnWTI5emRDQnZaaUJzWVhOMElHUmhkR0VnWW05NENpQWdJQ0FyQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12Wkdsa0xXRnNaMjh0YzNSdmNtRm5aUzVoYkdkdkxuUnpPamMxTFRjNUNpQWdJQ0F2THlCamIyNXpkQ0IwYjNSaGJFTnZjM1E2SUhWcGJuUTJOQ0E5SUc1MWJVSnZlR1Z6SUNvZ1EwOVRWRjlRUlZKZlFrOVlJQzh2SUdOdmMzUWdiMllnWkdGMFlTQmliM2hsY3dvZ0lDQWdMeThnSUNBcklDaHVkVzFDYjNobGN5QXRJREVwSUNvZ1RVRllYMEpQV0Y5VFNWcEZJQ29nUTA5VFZGOVFSVkpmUWxsVVJTQXZMeUJqYjNOMElHOW1JR1JoZEdFS0lDQWdJQzh2SUNBZ0t5QnVkVzFDYjNobGN5QXFJRGdnS2lCRFQxTlVYMUJGVWw5Q1dWUkZJQzh2SUdOdmMzUWdiMllnWkdGMFlTQnJaWGx6Q2lBZ0lDQXZMeUFnSUNzZ1pXNWtRbTk0VTJsNlpTQXFJRU5QVTFSZlVFVlNYMEpaVkVVZ0x5OGdZMjl6ZENCdlppQnNZWE4wSUdSaGRHRWdZbTk0Q2lBZ0lDQXZMeUFnSUNzZ1EwOVRWRjlRUlZKZlFrOVlJQ3NnS0RnZ0t5QTRJQ3NnTVNBcklEZ2dLeUF6TWlBcklEZ3BJQ29nUTA5VFZGOVFSVkpmUWxsVVJUc2dMeThnWTI5emRDQnZaaUJ0WlhSaFpHRjBZU0JpYjNnS0lDQWdJSEIxYzJocGJuUWdNamcxTURBZ0x5OGdNamcxTURBS0lDQWdJQ3NLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlrYVdRdFlXeG5ieTF6ZEc5eVlXZGxMbUZzWjI4dWRITTZPREVLSUNBZ0lDOHZJR0Z6YzJWeWRDaHRZbkpRWVhsdFpXNTBMbUZ0YjNWdWRDQTlQVDBnZEc5MFlXeERiM04wS1RzS0lDQWdJSE4zWVhBS0lDQWdJR2QwZUc1eklFRnRiM1Z1ZEFvZ0lDQWdQVDBLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlrYVdRdFlXeG5ieTF6ZEc5eVlXZGxMbUZzWjI4dWRITTZOVEl0TlRjS0lDQWdJQzh2SUhOMFlYSjBWWEJzYjJGa0tBb2dJQ0FnTHk4Z0lDQndkV0pMWlhrNklFRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lHNTFiVUp2ZUdWek9pQjFhVzUwTmpRc0NpQWdJQ0F2THlBZ0lHVnVaRUp2ZUZOcGVtVTZJSFZwYm5RMk5Dd0tJQ0FnSUM4dklDQWdiV0p5VUdGNWJXVnVkRG9nWjNSNGJpNVFZWGx0Wlc1MFZIaHVMQW9nSUNBZ0x5OGdLVG9nZG05cFpDQjdDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QmpiMjUwY21GamRITXZaR2xrTFdGc1oyOHRjM1J2Y21GblpTNWhiR2R2TG5Sek9qcEVTVVJCYkdkdlUzUnZjbUZuWlM1MWNHeHZZV1JiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMWNHeHZZV1E2Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMlJwWkMxaGJHZHZMWE4wYjNKaFoyVXVZV3huYnk1MGN6bzVOQW9nSUNBZ0x5OGdkWEJzYjJGa0tIQjFZa3RsZVRvZ1FXUmtjbVZ6Y3l3Z1ltOTRTVzVrWlhnNklIVnBiblEyTkN3Z2IyWm1jMlYwT2lCMWFXNTBOalFzSUdSaGRHRTZJR0o1ZEdWektUb2dkbTlwWkNCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05Bb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2NIVnphR2x1ZENBeUlDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWthV1F0WVd4bmJ5MXpkRzl5WVdkbExtRnNaMjh1ZEhNNk9UVUtJQ0FnSUM4dklHRnpjMlZ5ZENoVWVHNHVjMlZ1WkdWeUlEMDlQU0JVZUc0dVlYQndiR2xqWVhScGIyNUpaQzVqY21WaGRHOXlLVHNLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjSEJmY0dGeVlXMXpYMmRsZENCQmNIQkRjbVZoZEc5eUNpQWdJQ0JoYzNObGNuUWdMeThnWVhCd2JHbGpZWFJwYjI0Z1pYaHBjM1J6Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12Wkdsa0xXRnNaMjh0YzNSdmNtRm5aUzVoYkdkdkxuUnpPamszQ2lBZ0lDQXZMeUJqYjI1emRDQnRaWFJoWkdGMFlTQTlJR05zYjI1bEtIUm9hWE11YldWMFlXUmhkR0VvY0hWaVMyVjVLUzUyWVd4MVpTazdDaUFnSUNCemQyRndDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR052ZG1WeUlETUtJQ0FnSUdGemMyVnlkQ0F2THlCQ2IzZ2diWFZ6ZENCb1lYWmxJSFpoYkhWbENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlpHbGtMV0ZzWjI4dGMzUnZjbUZuWlM1aGJHZHZMblJ6T2prNENpQWdJQ0F2THlCaGMzTmxjblFvYldWMFlXUmhkR0V1YzNSaGRIVnpJRDA5UFNCVlVFeFBRVVJKVGtjcE93b2dJQ0FnWkhWd0NpQWdJQ0JsZUhSeVlXTjBJREUySURFS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnd01Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyUnBaQzFoYkdkdkxYTjBiM0poWjJVdVlXeG5ieTUwY3pveE1EQUtJQ0FnSUM4dklHRnpjMlZ5ZENodFpYUmhaR0YwWVM1emRHRnlkQ0E4UFNCaWIzaEpibVJsZUNBbUppQmliM2hKYm1SbGVDQThQU0J0WlhSaFpHRjBZUzVsYm1RcE93b2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0ErUFFvZ0lDQWdZbm9nZFhCc2IyRmtYMkp2YjJ4ZlptRnNjMlZBTkFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHUnBaeUEwQ2lBZ0lDQStQUW9nSUNBZ1lub2dkWEJzYjJGa1gySnZiMnhmWm1Gc2MyVkFOQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtDblZ3Ykc5aFpGOWliMjlzWDIxbGNtZGxRRFU2Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12Wkdsa0xXRnNaMjh0YzNSdmNtRm5aUzVoYkdkdkxuUnpPakV3TUFvZ0lDQWdMeThnWVhOelpYSjBLRzFsZEdGa1lYUmhMbk4wWVhKMElEdzlJR0p2ZUVsdVpHVjRJQ1ltSUdKdmVFbHVaR1Y0SUR3OUlHMWxkR0ZrWVhSaExtVnVaQ2s3Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5a2FXUXRZV3huYnkxemRHOXlZV2RsTG1Gc1oyOHVkSE02TVRBeUNpQWdJQ0F2THlCcFppQW9iMlptYzJWMElEMDlQU0F3S1NCN0NpQWdJQ0JrYVdjZ01nb2dJQ0FnWW01NklIVndiRzloWkY5aFpuUmxjbDlwWmw5bGJITmxRREV3Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12Wkdsa0xXRnNaMjh0YzNSdmNtRm5aUzVoYkdkdkxuUnpPakV3TXdvZ0lDQWdMeThnZEdocGN5NWtZWFJoUW05NFpYTW9ZbTk0U1c1a1pYZ3BMbU55WldGMFpTaDdDaUFnSUNCa2FXY2dNd29nSUNBZ1pIVndDaUFnSUNCcGRHOWlDaUFnSUNCaWRYSjVJRFlLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlrYVdRdFlXeG5ieTF6ZEc5eVlXZGxMbUZzWjI4dWRITTZNVEEwQ2lBZ0lDQXZMeUJ6YVhwbE9pQmliM2hKYm1SbGVDQTlQVDBnYldWMFlXUmhkR0V1Wlc1a0lEOGdiV1YwWVdSaGRHRXVaVzVrVTJsNlpTQTZJRTFCV0Y5Q1QxaGZVMGxhUlFvZ0lDQWdaR2xuSURFS0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdQVDBLSUNBZ0lHSjZJSFZ3Ykc5aFpGOTBaWEp1WVhKNVgyWmhiSE5sUURnS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQXhOeUF2THlBeE53b2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtDblZ3Ykc5aFpGOTBaWEp1WVhKNVgyMWxjbWRsUURrNkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlpHbGtMV0ZzWjI4dGMzUnZjbUZuWlM1aGJHZHZMblJ6T2pFd015MHhNRFVLSUNBZ0lDOHZJSFJvYVhNdVpHRjBZVUp2ZUdWektHSnZlRWx1WkdWNEtTNWpjbVZoZEdVb2V3b2dJQ0FnTHk4Z0lDQnphWHBsT2lCaWIzaEpibVJsZUNBOVBUMGdiV1YwWVdSaGRHRXVaVzVrSUQ4Z2JXVjBZV1JoZEdFdVpXNWtVMmw2WlNBNklFMUJXRjlDVDFoZlUwbGFSUW9nSUNBZ0x5OGdmU2tLSUNBZ0lHUnBaeUExQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmliM2hmWTNKbFlYUmxDaUFnSUNCd2IzQUtDblZ3Ykc5aFpGOWhablJsY2w5cFpsOWxiSE5sUURFd09nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyUnBaQzFoYkdkdkxYTjBiM0poWjJVdVlXeG5ieTUwY3pveE1Ea0tJQ0FnSUM4dklIUm9hWE11WkdGMFlVSnZlR1Z6S0dKdmVFbHVaR1Y0S1M1eVpYQnNZV05sS0c5bVpuTmxkQ3dnWkdGMFlTazdDaUFnSUNCa2FXY2dNd29nSUNBZ2FYUnZZZ29nSUNBZ1pHbG5JRE1LSUNBZ0lHUnBaeUF6Q2lBZ0lDQmliM2hmY21Wd2JHRmpaUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMlJwWkMxaGJHZHZMWE4wYjNKaFoyVXVZV3huYnk1MGN6bzVOQW9nSUNBZ0x5OGdkWEJzYjJGa0tIQjFZa3RsZVRvZ1FXUmtjbVZ6Y3l3Z1ltOTRTVzVrWlhnNklIVnBiblEyTkN3Z2IyWm1jMlYwT2lCMWFXNTBOalFzSUdSaGRHRTZJR0o1ZEdWektUb2dkbTlwWkNCN0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncDFjR3h2WVdSZmRHVnlibUZ5ZVY5bVlXeHpaVUE0T2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJScFpDMWhiR2R2TFhOMGIzSmhaMlV1WVd4bmJ5NTBjem94TURRS0lDQWdJQzh2SUhOcGVtVTZJR0p2ZUVsdVpHVjRJRDA5UFNCdFpYUmhaR0YwWVM1bGJtUWdQeUJ0WlhSaFpHRjBZUzVsYm1SVGFYcGxJRG9nVFVGWVgwSlBXRjlUU1ZwRkNpQWdJQ0J3ZFhOb2FXNTBJRE15TnpZNElDOHZJRE15TnpZNENpQWdJQ0JpSUhWd2JHOWhaRjkwWlhKdVlYSjVYMjFsY21kbFFEa0tDblZ3Ykc5aFpGOWliMjlzWDJaaGJITmxRRFE2Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1lpQjFjR3h2WVdSZlltOXZiRjl0WlhKblpVQTFDZ29LTHk4Z1kyOXVkSEpoWTNSekwyUnBaQzFoYkdkdkxYTjBiM0poWjJVdVlXeG5ieTUwY3pvNlJFbEVRV3huYjFOMGIzSmhaMlV1Wm1sdWFYTm9WWEJzYjJGa1czSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tabWx1YVhOb1ZYQnNiMkZrT2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJScFpDMWhiR2R2TFhOMGIzSmhaMlV1WVd4bmJ5NTBjem94TVRnS0lDQWdJQzh2SUdacGJtbHphRlZ3Ykc5aFpDaHdkV0pMWlhrNklFRmtaSEpsYzNNcE9pQjJiMmxrSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJScFpDMWhiR2R2TFhOMGIzSmhaMlV1WVd4bmJ5NTBjem94TVRrS0lDQWdJQzh2SUdGemMyVnlkQ2hVZUc0dWMyVnVaR1Z5SUQwOVBTQlVlRzR1WVhCd2JHbGpZWFJwYjI1SlpDNWpjbVZoZEc5eUtUc0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGNIQmZjR0Z5WVcxelgyZGxkQ0JCY0hCRGNtVmhkRzl5Q2lBZ0lDQmhjM05sY25RZ0x5OGdZWEJ3YkdsallYUnBiMjRnWlhocGMzUnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZaR2xrTFdGc1oyOHRjM1J2Y21GblpTNWhiR2R2TG5Sek9qRXlNQW9nSUNBZ0x5OGdkR2hwY3k1dFpYUmhaR0YwWVNod2RXSkxaWGtwTG5aaGJIVmxMbk4wWVhSMWN5QTlJRkpGUVVSWk93b2dJQ0FnY0hWemFHbHVkQ0F4TmlBdkx5QXhOZ29nSUNBZ1lubDBaV05mTWlBdkx5QXdlREF4Q2lBZ0lDQmliM2hmY21Wd2JHRmpaUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMlJwWkMxaGJHZHZMWE4wYjNKaFoyVXVZV3huYnk1MGN6b3hNVGdLSUNBZ0lDOHZJR1pwYm1semFGVndiRzloWkNod2RXSkxaWGs2SUVGa1pISmxjM01wT2lCMmIybGtJSHNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QmpiMjUwY21GamRITXZaR2xrTFdGc1oyOHRjM1J2Y21GblpTNWhiR2R2TG5Sek9qcEVTVVJCYkdkdlUzUnZjbUZuWlM1emRHRnlkRVJsYkdWMFpWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbk4wWVhKMFJHVnNaWFJsT2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJScFpDMWhiR2R2TFhOMGIzSmhaMlV1WVd4bmJ5NTBjem94TWpnS0lDQWdJQzh2SUhOMFlYSjBSR1ZzWlhSbEtIQjFZa3RsZVRvZ1FXUmtjbVZ6Y3lrNklIWnZhV1FnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12Wkdsa0xXRnNaMjh0YzNSdmNtRm5aUzVoYkdkdkxuUnpPakV5T1FvZ0lDQWdMeThnWVhOelpYSjBLRlI0Ymk1elpXNWtaWElnUFQwOUlGUjRiaTVoY0hCc2FXTmhkR2x2Ymtsa0xtTnlaV0YwYjNJcE93b2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGd2NGOXdZWEpoYlhOZloyVjBJRUZ3Y0VOeVpXRjBiM0lLSUNBZ0lHRnpjMlZ5ZENBdkx5QmhjSEJzYVdOaGRHbHZiaUJsZUdsemRITUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWthV1F0WVd4bmJ5MXpkRzl5WVdkbExtRnNaMjh1ZEhNNk1UTXhDaUFnSUNBdkx5QmpiMjV6ZENCdFpYUmhaR0YwWVNBOUlHTnNiMjVsS0hSb2FYTXViV1YwWVdSaGRHRW9jSFZpUzJWNUtTNTJZV3gxWlNrN0NpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdGemMyVnlkQ0F2THlCQ2IzZ2diWFZ6ZENCb1lYWmxJSFpoYkhWbENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlpHbGtMV0ZzWjI4dGMzUnZjbUZuWlM1aGJHZHZMblJ6T2pFek1nb2dJQ0FnTHk4Z1lYTnpaWEowS0cxbGRHRmtZWFJoTG5OMFlYUjFjeUE5UFQwZ1VrVkJSRmtwT3dvZ0lDQWdaWGgwY21GamRDQXhOaUF4Q2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TURFS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5a2FXUXRZV3huYnkxemRHOXlZV2RsTG1Gc1oyOHVkSE02TVRNM0NpQWdJQ0F2THlCMGFHbHpMbTFsZEdGa1lYUmhLSEIxWWt0bGVTa3VkbUZzZFdVZ1BTQmpiRzl1WlNodFpYUmhaR0YwWVNrN0NpQWdJQ0J3ZFhOb2FXNTBJREUySUM4dklERTJDaUFnSUNBdkx5QmpiMjUwY21GamRITXZaR2xrTFdGc1oyOHRjM1J2Y21GblpTNWhiR2R2TG5Sek9qRXpOQW9nSUNBZ0x5OGdiV1YwWVdSaGRHRXVjM1JoZEhWeklEMGdSRVZNUlZSSlRrYzdDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjRNRElLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlrYVdRdFlXeG5ieTF6ZEc5eVlXZGxMbUZzWjI4dWRITTZNVE0zQ2lBZ0lDQXZMeUIwYUdsekxtMWxkR0ZrWVhSaEtIQjFZa3RsZVNrdWRtRnNkV1VnUFNCamJHOXVaU2h0WlhSaFpHRjBZU2s3Q2lBZ0lDQmliM2hmY21Wd2JHRmpaUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMlJwWkMxaGJHZHZMWE4wYjNKaFoyVXVZV3huYnk1MGN6b3hNamdLSUNBZ0lDOHZJSE4wWVhKMFJHVnNaWFJsS0hCMVlrdGxlVG9nUVdSa2NtVnpjeWs2SUhadmFXUWdld29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklHTnZiblJ5WVdOMGN5OWthV1F0WVd4bmJ5MXpkRzl5WVdkbExtRnNaMjh1ZEhNNk9rUkpSRUZzWjI5VGRHOXlZV2RsTG1SbGJHVjBaVVJoZEdGYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGtaV3hsZEdWRVlYUmhPZ29nSUNBZ2NIVnphR0o1ZEdWeklDSWlDaUFnSUNBdkx5QmpiMjUwY21GamRITXZaR2xrTFdGc1oyOHRjM1J2Y21GblpTNWhiR2R2TG5Sek9qRTBOZ29nSUNBZ0x5OGdaR1ZzWlhSbFJHRjBZU2h3ZFdKTFpYazZJRUZrWkhKbGMzTXNJR0p2ZUVsdVpHVjRPaUIxYVc1ME5qUXBPaUIyYjJsa0lIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNHNGdNZ29nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWthV1F0WVd4bmJ5MXpkRzl5WVdkbExtRnNaMjh1ZEhNNk1UUTNDaUFnSUNBdkx5QmhjM05sY25Rb1ZIaHVMbk5sYm1SbGNpQTlQVDBnVkhodUxtRndjR3hwWTJGMGFXOXVTV1F1WTNKbFlYUnZjaWs3Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWEJ3WDNCaGNtRnRjMTluWlhRZ1FYQndRM0psWVhSdmNnb2dJQ0FnWVhOelpYSjBJQzh2SUdGd2NHeHBZMkYwYVc5dUlHVjRhWE4wY3dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJScFpDMWhiR2R2TFhOMGIzSmhaMlV1WVd4bmJ5NTBjem94TkRrS0lDQWdJQzh2SUdOdmJuTjBJRzFsZEdGa1lYUmhJRDBnWTJ4dmJtVW9kR2hwY3k1dFpYUmhaR0YwWVNod2RXSkxaWGtwTG5aaGJIVmxLVHNLSUNBZ0lITjNZWEFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJSE4zWVhBS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWTI5MlpYSWdNd29nSUNBZ1lYTnpaWEowSUM4dklFSnZlQ0J0ZFhOMElHaGhkbVVnZG1Gc2RXVUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWthV1F0WVd4bmJ5MXpkRzl5WVdkbExtRnNaMjh1ZEhNNk1UVXdDaUFnSUNBdkx5QmhjM05sY25Rb2JXVjBZV1JoZEdFdWMzUmhkSFZ6SUQwOVBTQkVSVXhGVkVsT1J5azdDaUFnSUNCa2RYQUtJQ0FnSUdWNGRISmhZM1FnTVRZZ01Rb2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VEQXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZaR2xrTFdGc1oyOHRjM1J2Y21GblpTNWhiR2R2TG5Sek9qRTFNUW9nSUNBZ0x5OGdZWE56WlhKMEtHMWxkR0ZrWVhSaExuTjBZWEowSUR3OUlHSnZlRWx1WkdWNElDWW1JR0p2ZUVsdVpHVjRJRHc5SUcxbGRHRmtZWFJoTG1WdVpDazdDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdSMWNBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQThQUW9nSUNBZ1lub2daR1ZzWlhSbFJHRjBZVjlpYjI5c1gyWmhiSE5sUURRS0lDQWdJR1JwWnlBeENpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR1JwWnlBekNpQWdJQ0ErUFFvZ0lDQWdZbm9nWkdWc1pYUmxSR0YwWVY5aWIyOXNYMlpoYkhObFFEUUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENncGtaV3hsZEdWRVlYUmhYMkp2YjJ4ZmJXVnlaMlZBTlRvS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5a2FXUXRZV3huYnkxemRHOXlZV2RsTG1Gc1oyOHVkSE02TVRVeENpQWdJQ0F2THlCaGMzTmxjblFvYldWMFlXUmhkR0V1YzNSaGNuUWdQRDBnWW05NFNXNWtaWGdnSmlZZ1ltOTRTVzVrWlhnZ1BEMGdiV1YwWVdSaGRHRXVaVzVrS1RzS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyUnBaQzFoYkdkdkxYTjBiM0poWjJVdVlXeG5ieTUwY3pveE5UTUtJQ0FnSUM4dklHbG1JQ2hpYjNoSmJtUmxlQ0FoUFQwZ2JXVjBZV1JoZEdFdWMzUmhjblFwSUdGemMyVnlkQ2h0WlhSaFpHRjBZUzVzWVhOMFJHVnNaWFJsWkNBOVBUMGdZbTk0U1c1a1pYZ2dMU0F4S1RzS0lDQWdJR1JwWnlBeUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnSVQwS0lDQWdJR0o2SUdSbGJHVjBaVVJoZEdGZllXWjBaWEpmYVdaZlpXeHpaVUEzQ2lBZ0lDQmthV2NnTVFvZ0lDQWdjSFZ6YUdsdWRDQXlOU0F2THlBeU5Rb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdScFp5QXpDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZEFvS1pHVnNaWFJsUkdGMFlWOWhablJsY2w5cFpsOWxiSE5sUURjNkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlpHbGtMV0ZzWjI4dGMzUnZjbUZuWlM1aGJHZHZMblJ6T2pFMU5Rb2dJQ0FnTHk4Z1kyOXVjM1FnY0hKbFRVSlNJRDBnVkhodUxtRndjR3hwWTJGMGFXOXVTV1F1WVdSa2NtVnpjeTV0YVc1Q1lXeGhibU5sT3dvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGd2NGOXdZWEpoYlhOZloyVjBJRUZ3Y0VGa1pISmxjM01LSUNBZ0lHRnpjMlZ5ZENBdkx5QmhjSEJzYVdOaGRHbHZiaUJsZUdsemRITUtJQ0FnSUdGalkzUmZjR0Z5WVcxelgyZGxkQ0JCWTJOMFRXbHVRbUZzWVc1alpRb2dJQ0FnYzNkaGNBb2dJQ0FnWW5WeWVTQTNDaUFnSUNCaGMzTmxjblFnTHk4Z1lXTmpiM1Z1ZENCbWRXNWtaV1FLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlrYVdRdFlXeG5ieTF6ZEc5eVlXZGxMbUZzWjI4dWRITTZNVFUzQ2lBZ0lDQXZMeUIwYUdsekxtUmhkR0ZDYjNobGN5aGliM2hKYm1SbGVDa3VaR1ZzWlhSbEtDazdDaUFnSUNCa2FXY2dNZ29nSUNBZ1pIVndDaUFnSUNCcGRHOWlDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlrYVdRdFlXeG5ieTF6ZEc5eVlXZGxMbUZzWjI4dWRITTZNVFU1Q2lBZ0lDQXZMeUJwWmlBb1ltOTRTVzVrWlhnZ1BUMDlJRzFsZEdGa1lYUmhMbVZ1WkNrZ2V3b2dJQ0FnWkdsbklESUtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnUFQwS0lDQWdJR0o2SUdSbGJHVjBaVVJoZEdGZlpXeHpaVjlpYjJSNVFEa0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWthV1F0WVd4bmJ5MXpkRzl5WVdkbExtRnNaMjh1ZEhNNk1UWXdDaUFnSUNBdkx5QjBhR2x6TG0xbGRHRmtZWFJoS0hCMVlrdGxlU2t1WkdWc1pYUmxLQ2s3Q2lBZ0lDQmthV2NnTkFvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NncGtaV3hsZEdWRVlYUmhYMkZtZEdWeVgybG1YMlZzYzJWQU1UQTZDaUFnSUNBdkx5QmpiMjUwY21GamRITXZaR2xrTFdGc1oyOHRjM1J2Y21GblpTNWhiR2R2TG5Sek9qRTJOaTB4TmprS0lDQWdJQzh2SUdsMGVHNHVjR0Y1YldWdWRDaDdDaUFnSUNBdkx5QWdJR0Z0YjNWdWREb2djSEpsVFVKU0lDMGdWSGh1TG1Gd2NHeHBZMkYwYVc5dVNXUXVZV1JrY21WemN5NXRhVzVDWVd4aGJtTmxMQW9nSUNBZ0x5OGdJQ0J5WldObGFYWmxjam9nVkhodUxuTmxibVJsY2l3S0lDQWdJQzh2SUgwcExuTjFZbTFwZENncE93b2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJScFpDMWhiR2R2TFhOMGIzSmhaMlV1WVd4bmJ5NTBjem94TmpjS0lDQWdJQzh2SUdGdGIzVnVkRG9nY0hKbFRVSlNJQzBnVkhodUxtRndjR3hwWTJGMGFXOXVTV1F1WVdSa2NtVnpjeTV0YVc1Q1lXeGhibU5sTEFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGd2NGOXdZWEpoYlhOZloyVjBJRUZ3Y0VGa1pISmxjM01LSUNBZ0lHRnpjMlZ5ZENBdkx5QmhjSEJzYVdOaGRHbHZiaUJsZUdsemRITUtJQ0FnSUdGalkzUmZjR0Z5WVcxelgyZGxkQ0JCWTJOMFRXbHVRbUZzWVc1alpRb2dJQ0FnWVhOelpYSjBJQzh2SUdGalkyOTFiblFnWm5WdVpHVmtDaUFnSUNCa2FXY2dOZ29nSUNBZ2MzZGhjQW9nSUNBZ0xRb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyUnBaQzFoYkdkdkxYTjBiM0poWjJVdVlXeG5ieTUwY3pveE5qZ0tJQ0FnSUM4dklISmxZMlZwZG1WeU9pQlVlRzR1YzJWdVpHVnlMQW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCU1pXTmxhWFpsY2dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYlc5MWJuUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWthV1F0WVd4bmJ5MXpkRzl5WVdkbExtRnNaMjh1ZEhNNk1UWTJMVEUyT1FvZ0lDQWdMeThnYVhSNGJpNXdZWGx0Wlc1MEtIc0tJQ0FnSUM4dklDQWdZVzF2ZFc1ME9pQndjbVZOUWxJZ0xTQlVlRzR1WVhCd2JHbGpZWFJwYjI1SlpDNWhaR1J5WlhOekxtMXBia0poYkdGdVkyVXNDaUFnSUNBdkx5QWdJSEpsWTJWcGRtVnlPaUJVZUc0dWMyVnVaR1Z5TEFvZ0lDQWdMeThnZlNrdWMzVmliV2wwS0NrN0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyUnBaQzFoYkdkdkxYTjBiM0poWjJVdVlXeG5ieTUwY3pveE5EWUtJQ0FnSUM4dklHUmxiR1YwWlVSaGRHRW9jSFZpUzJWNU9pQkJaR1J5WlhOekxDQmliM2hKYm1SbGVEb2dkV2x1ZERZMEtUb2dkbTlwWkNCN0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncGtaV3hsZEdWRVlYUmhYMlZzYzJWZlltOWtlVUE1T2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJScFpDMWhiR2R2TFhOMGIzSmhaMlV1WVd4bmJ5NTBjem94TmpJdE1UWXpDaUFnSUNBdkx5QnRaWFJoWkdGMFlTNXNZWE4wUkdWc1pYUmxaQ0E5SUdKdmVFbHVaR1Y0T3dvZ0lDQWdMeThnZEdocGN5NXRaWFJoWkdGMFlTaHdkV0pMWlhrcExuWmhiSFZsSUQwZ1kyeHZibVVvYldWMFlXUmhkR0VwT3dvZ0lDQWdaR2xuSURRS0lDQWdJSEIxYzJocGJuUWdNalVnTHk4Z01qVUtJQ0FnSUdScFp5QTFDaUFnSUNCaWIzaGZjbVZ3YkdGalpRb2dJQ0FnWWlCa1pXeGxkR1ZFWVhSaFgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRBS0NtUmxiR1YwWlVSaGRHRmZZbTl2YkY5bVlXeHpaVUEwT2dvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHSWdaR1ZzWlhSbFJHRjBZVjlpYjI5c1gyMWxjbWRsUURVS0Nnb3ZMeUJqYjI1MGNtRmpkSE12Wkdsa0xXRnNaMjh0YzNSdmNtRm5aUzVoYkdkdkxuUnpPanBFU1VSQmJHZHZVM1J2Y21GblpTNTFjR1JoZEdWQmNIQnNhV05oZEdsdmJsdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDblZ3WkdGMFpVRndjR3hwWTJGMGFXOXVPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMlJwWkMxaGJHZHZMWE4wYjNKaFoyVXVZV3huYnk1MGN6b3hOellLSUNBZ0lDOHZJR0Z6YzJWeWRDaFVlRzR1YzJWdVpHVnlJRDA5UFNCVWVHNHVZWEJ3YkdsallYUnBiMjVKWkM1amNtVmhkRzl5S1RzS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoY0hCZmNHRnlZVzF6WDJkbGRDQkJjSEJEY21WaGRHOXlDaUFnSUNCaGMzTmxjblFnTHk4Z1lYQndiR2xqWVhScGIyNGdaWGhwYzNSekNpQWdJQ0E5UFFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJScFpDMWhiR2R2TFhOMGIzSmhaMlV1WVd4bmJ5NTBjem94TnpVS0lDQWdJQzh2SUhWd1pHRjBaVUZ3Y0d4cFkyRjBhVzl1S0NrNklIWnZhV1FnZXdvZ0lDQWdjbVYwZFhKdUNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVBUUFJSUNZRURHTjFjbkpsYm5SSmJtUmxlQUVBQVFFQkFqRVlRQUFES0NObk1SdEJBRlNBQkViM1pUTTJHZ0NPQVFBN01Sa1VSREVZUklJR0JGWmNaMTBFVGJIRUdBUU9lSEpYQkwwc2hPSUVhSkc2a0FTakRPZi9OaG9BamdZQUdRQ1JBUjhCTmdGV0FBRUFJa014R1lFRUVqRVlFRVJDQWVreEdSUXhHQlFRUkNKRE5ob0JTUlVsRWtRMkdnSkpGU1FTUkJjMkdnTkpGU1FTUkJjeEZpSUpTVGdRSWhKRU1RQXhHSElIUkJKRUl5aGxSRWxMQkFnaUNVd1dTd0VXVUNsUVN3TVdVQ01XVUU4RlRMOGlDQ2hNWjBzQ2djUVRDMHNESWdtQmdJQ2dCZ3NJVHdPQmdCa0xDRThDZ1pBREN3aUIxTjRCQ0V3NENCSkRJellhQVVrVkpSSkVOaG9DU1JVa0VrUVhTVTRDTmhvRFNSVWtFa1FYVGdJMkdnUkpJMW1CQWdoTEFSVVNSRmNDQUU0Q01RQXhHSElIUkJKRVRMNU1TVTRDVGdORVNWY1FBU2tTUkNOYkQwRUFPRWtrVzBzRUQwRUFMeUpFU3dKQUFCZExBMGtXUlFaTEFTUmJFa0VBRTBtQkVWdExCVXk1U0VzREZrc0RTd083SWtPQmdJQUNRdi9xSTBML3pqWWFBVWtWSlJKRU1RQXhHSElIUkJKRWdSQXF1eUpETmhvQlNSVWxFa1F4QURFWWNnZEVFa1JKdmtSWEVBRXFFa1NCRUN1N0lrT0FBRFlhQVVjQ0ZTVVNSRFlhQWtsT0Fra1ZKQkpFRjBsT0FqRUFNUmh5QjBRU1JFeStURWxPQWs0RFJFbFhFQUVyRWtRalcwbFBBZzVCQUdKTEFTUmJTd01QUVFCWUlrUkxBa3NCRTBFQUMwc0JnUmxiU3dNaUNSSkVNUmh5Q0VSekFVeEZCMFJMQWtrV3ZFaExBaVJiRWtFQUlFc0V2RWl4TVJoeUNFUnpBVVJMQmt3Sk1RQ3lCN0lJSXJJUUk3SUJzeUpEU3dTQkdVc0Z1MEwvMmlOQy82VXhBREVZY2dkRUVrTT0iLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjozLCJwYXRjaCI6MiwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
