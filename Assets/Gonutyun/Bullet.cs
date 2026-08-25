using UnityEngine;

namespace Gonutyun
{
    public class Bullet : MonoBehaviour
    {
        [SerializeField]
        private Vector3 destination;

        [SerializeField]
        private bool isThrow = false;

        [SerializeField]
        private float speed = 1.0f;

        // 총알이 이동할 방향
        private Vector3 dir;

        void Update()
        {
            // 목표 지점까지 이동
            transform.position += dir.normalized * Time.deltaTime * speed;

            // 목표 지점에 도착하면 이동 중지
            if (Vector3.Distance(transform.position, destination) < 0.1f)
            {
                isThrow = false;
            }
        }

        public void SetBullet(Vector3 _destination)
        {
            destination = _destination;

            // 현재 위치에서 목표 위치까지의 방향 계산
            dir = destination - transform.position;

            isThrow = true;
        }
    }
}