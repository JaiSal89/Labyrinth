using UnityEngine;

namespace Retro.ThirdPersonCharacter
{
    public class PlayerInput : MonoBehaviour
    {
        private bool _attackInput;
        private bool _specialAttackInput;
        private Vector2 _movementInput;
        private bool _jumpInput;
        private bool _changeCameraModeInput;
        public AudioClip JumpSound = null;
        public AudioClip HitSound = null;
        public AudioClip CoinSound = null;

        private Rigidbody RigidBody = null;
        private AudioSource AudioSource = null;
        private bool FloorTouched = false;

        public bool AttackInput {get => _attackInput;}
        public bool SpecialAttackInput {get => _specialAttackInput;}
        public Vector2 MovementInput {get => _movementInput;}
        public bool JumpInput { get => _jumpInput; }
        public bool ChangeCameraModeInput {get => _changeCameraModeInput;}

        void Start()
        {
            RigidBody = GetComponent<Rigidbody>();
            AudioSource = GetComponent<AudioSource>();
        }

        private void Update()
        {
            _attackInput = Input.GetMouseButtonDown(0);
            _specialAttackInput = Input.GetMouseButtonDown(1);

            _movementInput.Set(Input.GetAxis("Horizontal"),Input.GetAxis("Vertical"));
            _jumpInput = Input.GetButton("Jump");
            _changeCameraModeInput = Input.GetKeyDown(KeyCode.F);
            void OnTriggerEnter(Collider other)
            {
                if (other.gameObject.tag.Equals("Coin"))
                {
                    if (AudioSource != null && CoinSound != null)
                    {
                        AudioSource.PlayOneShot(CoinSound);
                    }
                    Destroy(other.gameObject);
                }
            }
        }
    }
}