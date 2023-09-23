using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class UnlockExtras : MonoBehaviour
{
    public static UnlockExtras instance;
    [SerializeField] private GameObject player;
    [SerializeField] private PlayerExtrasTracker playerExtrasTracker;
    [SerializeField] private bool canDoubleJump, canDash, canEnterBallMode, canDropBombs;
    [SerializeField] private LayerMask DoubleJumpLayerMask;
    [SerializeField] private LayerMask DashLayerMask;
    [SerializeField] private LayerMask BallModeDropBombsLayerMask;
    public ItemController itemController;
    private Collider2D isDoubleJump;
    private Collider2D isDash;
    private Collider2D isBallMode;

    private void Awake()
    {
        instance = this;
        itemController = GetComponent<ItemController>();
    }

    private void Start()
    {
        player = GameObject.Find("Player");
        playerExtrasTracker = player.GetComponent<PlayerExtrasTracker>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SetTracker();
        }
        MoveDestroyItem();
    }

    public void SetTracker()
    {
        isDoubleJump = Physics2D.OverlapCircle(player.transform.position, 0.8f, DoubleJumpLayerMask);
        if (isDoubleJump)
        {
            ItemsManager.instance.AddDoubleJump();
        }
        isDash = Physics2D.OverlapCircle(player.transform.position, 0.8f, DashLayerMask);
        if (isDash)
        {
            ItemsManager.instance.AddDash();
        }
        isBallMode = Physics2D.OverlapCircle(player.transform.position, 0.8f, BallModeDropBombsLayerMask);
        if (isBallMode)
        {
            ItemsManager.instance.AddBallModeDropBombs();
        }
    }

    public void MoveDestroyItem()
    {
        itemController.enabled = true;
    }
}

