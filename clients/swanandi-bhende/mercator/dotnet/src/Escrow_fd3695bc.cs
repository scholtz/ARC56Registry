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

namespace Arc56.Generated.swanandi_bhende.mercator.Escrow_fd3695bc
{


    //
    // Escrow settlement tracking for x402 micropayments.
    //    
    //    State:
    //        unlocked_listings: BoxMap(listing_id => UnlockRecord) recording buyer access grants.
    //    
    //    Purpose: Immutable on-chain proof that buyer paid for and accessed specific listing.
    //    
    //
    public class EscrowProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public EscrowProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class UnlockRecord : AVMObjectType
            {
                public Algorand.Address Buyer { get; set; }

                public bool Unlocked { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBuyer = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vBuyer.From(Buyer);
                    ret.AddRange(vBuyer.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUnlocked = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vUnlocked.From(Unlocked);
                    ret.AddRange(vUnlocked.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static UnlockRecord Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new UnlockRecord();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBuyer = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vBuyer.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBuyer = vBuyer.ToValue();
                    if (valueBuyer is Algorand.Address vBuyerValue) { ret.Buyer = vBuyerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUnlocked = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vUnlocked.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueUnlocked = vUnlocked.ToValue();
                    if (valueUnlocked is bool vUnlockedValue) { ret.Unlocked = vUnlockedValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as UnlockRecord);
                }
                public bool Equals(UnlockRecord? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(UnlockRecord left, UnlockRecord right)
                {
                    return EqualityComparer<UnlockRecord>.Default.Equals(left, right);
                }
                public static bool operator !=(UnlockRecord left, UnlockRecord right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Record buyer access after x402 payment confirmed on-chain.
        ///Purpose: Post-payment gate. Called by post_payment_flow after x402 tx confirmed + indexed. Atomically validates that **transaction sender is the buyer** (prevents spoofing).
        ///Actions: 1. Assert op.Txn.sender == buyer.native (confirms caller is buyer's wallet). 2. Store UnlockRecord in boxes: {buyer, unlocked=True}. 3. Return True to signal success.
        ///</summary>
        /// <param name="buyer">Algorand wallet address of the buyer (must match tx sender). </param>
        /// <param name="listing_id">InsightListing ID that buyer paid for. </param>
        public async Task<bool> ReleaseAfterPayment(Algorand.Address buyer, ulong listing_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 162, 99, 19, 83 };
            var buyerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); buyerAbi.From(buyer);
            var listing_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); listing_idAbi.From(listing_id);

            var result = await base.CallApp(new List<object> { abiHandle, buyerAbi, listing_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> ReleaseAfterPayment_Transactions(Algorand.Address buyer, ulong listing_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 162, 99, 19, 83 };
            var buyerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); buyerAbi.From(buyer);
            var listing_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); listing_idAbi.From(listing_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, buyerAbi, listing_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRXNjcm93IiwiZGVzYyI6IkVzY3JvdyBzZXR0bGVtZW50IHRyYWNraW5nIGZvciB4NDAyIG1pY3JvcGF5bWVudHMuXG4gICAgXG4gICAgU3RhdGU6XG4gICAgICAgIHVubG9ja2VkX2xpc3RpbmdzOiBCb3hNYXAobGlzdGluZ19pZCA9PiBVbmxvY2tSZWNvcmQpIHJlY29yZGluZyBidXllciBhY2Nlc3MgZ3JhbnRzLlxuICAgIFxuICAgIFB1cnBvc2U6IEltbXV0YWJsZSBvbi1jaGFpbiBwcm9vZiB0aGF0IGJ1eWVyIHBhaWQgZm9yIGFuZCBhY2Nlc3NlZCBzcGVjaWZpYyBsaXN0aW5nLlxuICAgICIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJVbmxvY2tSZWNvcmQiOlt7Im5hbWUiOiJidXllciIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoidW5sb2NrZWQiLCJ0eXBlIjoiYm9vbCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJyZWxlYXNlX2FmdGVyX3BheW1lbnQiLCJkZXNjIjoiUmVjb3JkIGJ1eWVyIGFjY2VzcyBhZnRlciB4NDAyIHBheW1lbnQgY29uZmlybWVkIG9uLWNoYWluLlxuUHVycG9zZTogUG9zdC1wYXltZW50IGdhdGUuIENhbGxlZCBieSBwb3N0X3BheW1lbnRfZmxvdyBhZnRlciB4NDAyIHR4IGNvbmZpcm1lZCArIGluZGV4ZWQuIEF0b21pY2FsbHkgdmFsaWRhdGVzIHRoYXQgKip0cmFuc2FjdGlvbiBzZW5kZXIgaXMgdGhlIGJ1eWVyKiogKHByZXZlbnRzIHNwb29maW5nKS5cbkFjdGlvbnM6IDEuIEFzc2VydCBvcC5UeG4uc2VuZGVyID09IGJ1eWVyLm5hdGl2ZSAoY29uZmlybXMgY2FsbGVyIGlzIGJ1eWVyJ3Mgd2FsbGV0KS4gMi4gU3RvcmUgVW5sb2NrUmVjb3JkIGluIGJveGVzOiB7YnV5ZXIsIHVubG9ja2VkPVRydWV9LiAzLiBSZXR1cm4gVHJ1ZSB0byBzaWduYWwgc3VjY2Vzcy4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJ1eWVyIiwiZGVzYyI6IkFsZ29yYW5kIHdhbGxldCBhZGRyZXNzIG9mIHRoZSBidXllciAobXVzdCBtYXRjaCB0eCBzZW5kZXIpLiIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibGlzdGluZ19pZCIsImRlc2MiOiJJbnNpZ2h0TGlzdGluZyBJRCB0aGF0IGJ1eWVyIHBhaWQgZm9yLiIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjoiVHJ1ZSBpZiB1bmxvY2sgcmVjb3JkZWQgc3VjY2Vzc2Z1bGx5LiJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbNDZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMzI+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTVdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJQzh2SUdKaFkydGxibVF2WTI5dWRISmhZM1J6TDJWelkzSnZkeTl6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M0wyTnZiblJ5WVdOMExuQjVPak0zQ2lBZ0lDQXZMeUJqYkdGemN5QkZjMk55YjNjb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRiaUJPZFcxQmNIQkJjbWR6Q2lBZ0lDQmllaUJ0WVdsdVgxOWZZV3huYjNCNVgyUmxabUYxYkhSZlkzSmxZWFJsUURjS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZUdFeU5qTXhNelV6SUM4dklHMWxkR2h2WkNBaWNtVnNaV0Z6WlY5aFpuUmxjbDl3WVhsdFpXNTBLR0ZrWkhKbGMzTXNkV2x1ZERZMEtXSnZiMndpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCdFlXbHVYM0psYkdWaGMyVmZZV1owWlhKZmNHRjViV1Z1ZEY5eWIzVjBaVUExQ2lBZ0lDQmxjbklLQ20xaGFXNWZjbVZzWldGelpWOWhablJsY2w5d1lYbHRaVzUwWDNKdmRYUmxRRFU2Q2lBZ0lDQXZMeUJpWVdOclpXNWtMMk52Ym5SeVlXTjBjeTlsYzJOeWIzY3ZjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZHk5amIyNTBjbUZqZEM1d2VUbzBPQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQW1KZ29nSUNBZ1lYTnpaWEowQ2lBZ0lDQmlJSEpsYkdWaGMyVmZZV1owWlhKZmNHRjViV1Z1ZEFvS2JXRnBibDlmWDJGc1oyOXdlVjlrWldaaGRXeDBYMk55WldGMFpVQTNPZ29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJQ0VLSUNBZ0lDWW1DaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVpYTmpjbTkzTG1OdmJuUnlZV04wTGtWelkzSnZkeTV5Wld4bFlYTmxYMkZtZEdWeVgzQmhlVzFsYm5SYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHlaV3hsWVhObFgyRm1kR1Z5WDNCaGVXMWxiblE2Q2lBZ0lDQXZMeUJpWVdOclpXNWtMMk52Ym5SeVlXTjBjeTlsYzJOeWIzY3ZjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZHk5amIyNTBjbUZqZEM1d2VUbzBPQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0F2THlCaVlXTnJaVzVrTDJOdmJuUnlZV04wY3k5bGMyTnliM2N2YzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG8zT1MwNE1Bb2dJQ0FnTHk4Z0l5QlFiM04wTFhCaGVXMWxiblFnY21Wc1pXRnpaU0J3WVhSb09pQmlkWGxsY2lCa2FYSmxZM1JzZVNCallXeHNjeUJsYzJOeWIzY2dZV1owWlhJZ2NHRjViV1Z1ZENCamIyNW1hWEp0WVhScGIyNHVDaUFnSUNBdkx5QmhjM05sY25RZ2IzQXVWSGh1TG5ObGJtUmxjaUE5UFNCaWRYbGxjaTV1WVhScGRtVUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR1JwWnlBeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCaVlXTnJaVzVrTDJOdmJuUnlZV04wY3k5bGMyTnliM2N2YzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG80TWkwNE5Rb2dJQ0FnTHk4Z2MyVnNaaTUxYm14dlkydGxaRjlzYVhOMGFXNW5jMXRzYVhOMGFXNW5YMmxrWFNBOUlGVnViRzlqYTFKbFkyOXlaQ2dLSUNBZ0lDOHZJQ0FnSUNCaWRYbGxjajFpZFhsbGNpd0tJQ0FnSUM4dklDQWdJQ0IxYm14dlkydGxaRDFoY21NMExrSnZiMndvVkhKMVpTa3NDaUFnSUNBdkx5QXBDaUFnSUNCemQyRndDaUFnSUNBdkx5QmlZV05yWlc1a0wyTnZiblJ5WVdOMGN5OWxjMk55YjNjdmMyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkeTlqYjI1MGNtRmpkQzV3ZVRvNE5Bb2dJQ0FnTHk4Z2RXNXNiMk5yWldROVlYSmpOQzVDYjI5c0tGUnlkV1VwTEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0T0RBS0lDQWdJQzh2SUdKaFkydGxibVF2WTI5dWRISmhZM1J6TDJWelkzSnZkeTl6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M0wyTnZiblJ5WVdOMExuQjVPamd5TFRnMUNpQWdJQ0F2THlCelpXeG1MblZ1Ykc5amEyVmtYMnhwYzNScGJtZHpXMnhwYzNScGJtZGZhV1JkSUQwZ1ZXNXNiMk5yVW1WamIzSmtLQW9nSUNBZ0x5OGdJQ0FnSUdKMWVXVnlQV0oxZVdWeUxBb2dJQ0FnTHk4Z0lDQWdJSFZ1Ykc5amEyVmtQV0Z5WXpRdVFtOXZiQ2hVY25WbEtTd0tJQ0FnSUM4dklDa0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdZbUZqYTJWdVpDOWpiMjUwY21GamRITXZaWE5qY205M0wzTnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2N2WTI5dWRISmhZM1F1Y0hrNk9ESUtJQ0FnSUM4dklITmxiR1l1ZFc1c2IyTnJaV1JmYkdsemRHbHVaM05iYkdsemRHbHVaMTlwWkYwZ1BTQlZibXh2WTJ0U1pXTnZjbVFvQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGczTlRabE5tTTJaall6Tm1JS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJpWVdOclpXNWtMMk52Ym5SeVlXTjBjeTlsYzJOeWIzY3ZjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZHk5amIyNTBjbUZqZEM1d2VUbzRNaTA0TlFvZ0lDQWdMeThnYzJWc1ppNTFibXh2WTJ0bFpGOXNhWE4wYVc1bmMxdHNhWE4wYVc1blgybGtYU0E5SUZWdWJHOWphMUpsWTI5eVpDZ0tJQ0FnSUM4dklDQWdJQ0JpZFhsbGNqMWlkWGxsY2l3S0lDQWdJQzh2SUNBZ0lDQjFibXh2WTJ0bFpEMWhjbU0wTGtKdmIyd29WSEoxWlNrc0NpQWdJQ0F2THlBcENpQWdJQ0J6ZDJGd0NpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QmlZV05yWlc1a0wyTnZiblJ5WVdOMGN5OWxjMk55YjNjdmMyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkeTlqYjI1MGNtRmpkQzV3ZVRvME9Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURFMU1XWTNZemMxT0RBS0lDQWdJR3h2WndvZ0lDQWdjSFZ6YUdsdWRDQXhDaUFnSUNCeVpYUjFjbTRLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3pFYlFRQVlnQVNpWXhOVE5ob0FqZ0VBQVFBeEdSUXhHQkJFUWdBSU1Sa1VNUmdVRUVNMkdnRkpGWUVnRWtRMkdnSkpGWUVJRWtReEFFc0NFa1JNZ0FHQVVJQUdkVzVzYjJOclR3SlFUTCtBQlJVZmZIV0FzSUVCUXc9PSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjcsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
