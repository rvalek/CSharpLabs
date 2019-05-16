using System.Collections.Generic;

namespace cpu_model.core {
    internal class PQHashTable<TEntity> : PriorityQueue<TEntity> {
        private LinkedList<TEntity>[] body;
        private int topPriority = -1;
        private int count = 0;

        public PQHashTable(int lowestPriority, int highestPriority) {
            int size = 1 + highestPriority - lowestPriority;
            body = new LinkedList<TEntity>[size];
        }

        public override void Put(TEntity e) {
            //base.Put(e);

            int index = e.GetHashCode() % body.Length;

            if (body[index] == null) {
                body[index] = new LinkedList<TEntity>();
            }

            body[index].AddFirst(e);

            topPriority = index > topPriority ? index : topPriority;
            count += 1;
        }

        public override TEntity Item() {
            //base.Item();

            return body[topPriority].Last.Value;
        }

        public override void Clear() {
            //base.Clear();

            for (int i = body.Length - 1; i >= 0; i -= 1) {
                body[i] = null;
            }
            topPriority = -1;

            count = 0;
        }

        public override void Remove() {
            //base.Remove();

            if (body[topPriority].Count > 1) {
                body[topPriority].RemoveLast();
            } else {
                body[topPriority] = null;

                topPriority = findCurrentTop();
            }

            count -= 1;
        }

        public override int Count() {
            //base.Count();
            return count;
        }

        private int findCurrentTop() {
            for (int i = body.Length - 1; i >= 0; i -= 1) {
                if (body[i] != null) {
                    return i;
                }
            }

            return -1;
        }

        public new bool Empty() {
            return Count() == 0;
        }

        public override TEntity[] ToArray() {
            TEntity[] asArray = new TEntity[Count()];
            int nextFreeIndex = 0;

            foreach (LinkedList<TEntity> list in body) {
                if (list != null) {
                    foreach (TEntity item in list) {
                        asArray[nextFreeIndex++] = item;
                    }
                }
            }
            return asArray;
        }
    }
}
